using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
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

        public IActionResult Volunteer()
        {
            var volunteers = _context.Volunteers.Include(x => x.AppUser).ToList();
            return View(volunteers);
        }

        public IActionResult Contact()
        {
            var contacts = _context.Contacts.Include(x => x.AppUser).ToList();  
            return View(contacts);
        }
    }
}
