using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using Nasarna.ViewModels;
using System.Linq;

namespace Nasarna.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public VolunteerController(NasarnaDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            VolunteerViewModel volunteerVM = new VolunteerViewModel
            {
                VolunteerUsers = _context.Volunteers.Include(x=>x.AppUser).Take(3).ToList(),
            };
            return View(volunteerVM);
        }

        [HttpPost]
        [Authorize(Roles = "Member")]

        public IActionResult Create(Volunteer volunteer)
        {
            AppUser loggedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                loggedUser = _userManager.Users.FirstOrDefault(x => !x.IsAdmin && x.IsStatus && x.UserName == User.Identity.Name);
                volunteer.AppUserId = loggedUser.Id;
            }
            if (!ModelState.IsValid)
                return View();

            _context.Volunteers.Add(volunteer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
