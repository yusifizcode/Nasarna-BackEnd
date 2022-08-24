using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using Nasarna.ViewModels;
using Pustok.Helpers;
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
        public IActionResult Index(string id)
        {

            AccountViewModel accountVM = new AccountViewModel
            {
                Causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).Include(x => x.AppUser).Where(x => x.AppUserId == id).ToList(),
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

        public IActionResult CreatePost()
        {
            return View();
        }

        public IActionResult EditPost(int id)
        {
            return View();
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

            var result = await _signInManager.PasswordSignInAsync(user, member.Password, false, false);

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
                    ModelState.AddModelError("ImageFiles", "File format must be image/png or image/jpeg");
                }

                if (member.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFiles", "File size must be less than 2MB");
                }
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
                IsAdmin = false
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
                        string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var url = Url.Action("ConfirmEmail", "Account", new { email = user.Email, token = token }, Request.Scheme);*/

            /*            await _roleManager.CreateAsync(new IdentityRole("Member"));*/

            await _userManager.AddToRoleAsync(user, "Member");

/*            return Ok(new { URL = url });
*/            return RedirectToAction("login","account");
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

    }
}
