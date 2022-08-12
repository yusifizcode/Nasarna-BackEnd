using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.Models;
using Nasarna.ViewModels;
using System.Threading.Tasks;

namespace Nasarna.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
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
          

            AppUser user = new AppUser
            {
                FullName = member.FullName,
                Email = member.Email,
                UserName = member.UserName,
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

            await _roleManager.CreateAsync(new IdentityRole("Member"));

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
