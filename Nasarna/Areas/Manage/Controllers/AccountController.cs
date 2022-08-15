using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.Areas.Manage.ViewModels;
using Nasarna.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
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
            var users = _userManager.Users.ToList();
            return View(users);
        }

        /*        CREATE DEFAULT SUPER ADMIN
        */
/*        public async Task<IActionResult> CreateAdmin()
        {
            AppUser admin = new AppUser
            {
                FullName = "Super Admin",
                UserName = "SuperAdmin",
                IsAdmin = true,
                IsStatus = true,
            };

            var result = await _userManager.CreateAsync(admin, "Admin123");

            if (!result.Succeeded)
                return Ok(result.Errors);

            var roleResult = await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));

            if (!roleResult.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("Name", item.Description);
                }
            }

            await _userManager.AddToRoleAsync(admin, "SuperAdmin");

            return View();
        }
*/


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel admin)
        {

            AppUser user = await _userManager.Users.FirstOrDefaultAsync(x => x.IsAdmin && x.UserName == admin.UserName);


            if (user == null)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, admin.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }

            if (!ModelState.IsValid)
                return View();

            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "account");
        }

    }
}
