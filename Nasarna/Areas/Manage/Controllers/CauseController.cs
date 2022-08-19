using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CauseController : Controller
    {
        private readonly NasarnaDbContext _context;

        public CauseController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                       .Include(x => x.Category)
                                       .Include(x => x.CauseImages)
                                       .Include(x => x.AppUser)
                                       .ToList();

            return View(causes);
        }

        public IActionResult Detail(int id)
        {
            Cause cause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                         .Include(x => x.Category)
                                         .Include(x => x.CauseImages)
                                         .Include(x => x.CauseComments)
                                         .Include(x => x.Payments).ThenInclude(u => u.AppUser)
                                         .Include(x => x.AppUser)
                                         .FirstOrDefault(x => x.Id == id);

            if (cause == null)
                return RedirectToAction("error", "dashboard");

            return View(cause);
        }

        public IActionResult ActivateCause(int id,bool isActive)
        {

            Cause cause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                         .Include(x => x.Category)
                                         .Include(x => x.CauseImages)
                                         .Include(x => x.CauseComments)
                                         .Include(x => x.Payments).ThenInclude(u => u.AppUser)
                                         .Include(x => x.AppUser)
                                         .FirstOrDefault(x => x.Id == id);


            if (cause == null)
                return RedirectToAction("error", "dashboard");

            cause.IsActive = isActive;

            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
