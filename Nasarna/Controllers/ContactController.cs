using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nasarna.DAL;
using Nasarna.Models;
using System.Linq;

namespace Nasarna.Controllers
{
    public class ContactController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly NasarnaDbContext _context;

        public ContactController(UserManager<AppUser> userManager, NasarnaDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Member")]
        public IActionResult Create(Contact contact)
        {
            AppUser loggedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                loggedUser = _userManager.Users.FirstOrDefault(x => !x.IsAdmin && x.IsStatus && x.UserName == User.Identity.Name);
                contact.AppUserId = loggedUser.Id;
            }
            if (!ModelState.IsValid)
                return View();


            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
