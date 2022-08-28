using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Helpers;
using Nasarna.Models;
using Nasarna.ViewModels;
using Pustok.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Nasarna.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly NasarnaDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager,NasarnaDbContext context,IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
            _env = env;
        }
        public IActionResult Index(string id,int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Causes.Where(x => x.AppUserId == id).Count() / 6d);
            ViewBag.Messages = _context.Messages.Include(x => x.FromUser).Include(x => x.ToUser).ToList();


            if (page < 1 || page > (int)Math.Ceiling(_context.Causes.Where(x => x.AppUserId == id).Count() / 6d))
                return RedirectToAction("error", "home");

            AccountViewModel accountVM = new AccountViewModel
            {
                Causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).Include(x => x.AppUser).Where(x => x.AppUserId == id).Skip((page - 1) * 6).Take(6).ToList(),
                User = _context.Users.FirstOrDefault(x => x.Id == id),
            };

            foreach (var cause in accountVM.Causes)
            {
                if (cause.NeedAmount > 0)
                {
                    cause.AmountPercent = (cause.CurrentAmount / cause.NeedAmount) * 100;
                }
            }
            return View(accountVM);
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(MemberLoginViewModel member)
        {

            AppUser user = await _userManager.Users.FirstOrDefaultAsync(x => !x.IsAdmin && x.UserName == member.UserName);


            if (user == null)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }

            if (user.IsStatus == false)
            {
                ModelState.AddModelError("", "Your account has been blocked!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, member.Password, member.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }

            if (!ModelState.IsValid)
                return View();

            return RedirectToAction("index","home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterViewModel member)
        {

            if (member == null)
                return RedirectToAction("error", "dashboard");

            if(member.ImageFile != null)
            {
                if (member.ImageFile.ContentType != "image/png" && member.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File format must be image/png or image/jpeg");
                }

                if (member.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size must be less than 2MB");
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Profile image is required!");
            }

            if (!ModelState.IsValid)
                return View();

            var newFileName = FileManager.Save(_env.WebRootPath, "uploads/users", member.ImageFile);

            AppUser user = new AppUser
            {
                FullName = member.FullName,
                Email = member.Email,
                UserName = member.UserName,
                ProfileImg = newFileName,
                ImageFile = member.ImageFile,
                IsAdmin = false,
                IsStatus = true,
            };

            var result = await _userManager.CreateAsync(user, member.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            if (!ModelState.IsValid)
                return View();

/*
            await _roleManager.CreateAsync(new IdentityRole("Member"));
*/
            await _userManager.AddToRoleAsync(user, "Member");


            return RedirectToAction("login","account");
            
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if(string.IsNullOrEmpty(email))
                return BadRequest();

            var dbUser = await _userManager.FindByEmailAsync(email);

            if(dbUser == null)
                return RedirectToAction("error","home");

            if (!dbUser.IsStatus)
            {
                ModelState.AddModelError("", "Your account has been blocked!");
                return View();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(dbUser);

            var link = Url.Action("ResetPassword", "Account", new { dbUser.Id,token },protocol:HttpContext.Request.Scheme);

            var message = $"<a href='{link}'>reset password</a>";

            await EmailManager.SendEmailAsync(email, "Reset Password", message);

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> ResetPassword(string id, string token)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(token))
                return BadRequest();

            var dbUser = await _userManager.FindByIdAsync(id);

            if (dbUser == null)
                return RedirectToAction("error", "home");

            ResetPasswordViewModel resetVM = new ResetPasswordViewModel
            {
                Token = token,
            };

            return View(resetVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> ResetPassword(string id, ResetPasswordViewModel resetPasswordVM)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(resetPasswordVM.Token))
                return BadRequest();

            if (!ModelState.IsValid)
                return View();

            var dbUser = await _userManager.FindByIdAsync(id);
            if (dbUser == null)
                return RedirectToAction("error", "home");

            if (!dbUser.IsStatus)
            {
                ModelState.AddModelError("", "Your account has been blocked!");
                return View();
            }

            var result = await _userManager.ResetPasswordAsync(dbUser,resetPasswordVM.Token,resetPasswordVM.NewPassword);


            if(result.Errors == null)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

    }
}
