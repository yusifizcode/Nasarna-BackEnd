using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using System;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin")]
    public class DashboardController : Controller
    {
        public NasarnaDbContext _context { get; }

        public DashboardController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Volunteer(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Volunteers.Count() / 10d);

            if (page < 1 || page > (int)Math.Ceiling(_context.Volunteers.Count() / 10d))
                return RedirectToAction("error", "home");

            var volunteers = _context.Volunteers.Include(x => x.AppUser).Skip((page - 1) * 10).Take(10).ToList();
            return View(volunteers);
        }

        public IActionResult Contact(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Contacts.Count() / 10d);

            if (page < 1 || page > (int)Math.Ceiling(_context.Contacts.Count() / 10d))
                return RedirectToAction("error", "home");

            var contacts = _context.Contacts.Include(x => x.AppUser).Skip((page - 1) * 10).Take(10).ToList();  
            return View(contacts);
        }
    }
}
