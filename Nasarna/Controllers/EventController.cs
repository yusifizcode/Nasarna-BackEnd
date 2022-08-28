using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.ViewModels;
using System;
using System.Linq;

namespace Nasarna.Controllers
{
    public class EventController : Controller
    {
        private readonly NasarnaDbContext _context;

        public EventController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string title, int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Events.Count() / 6d);

            var events = _context.Events.ToList();

            if(events.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Events.Count() / 6d))
                    return RedirectToAction("error", "home");
            }

            if(title != null)
                events = events.Where(x => x.Title.Contains(title)).Skip((page - 1) * 6).Take(6).ToList();

            return View(events.Skip((page - 1) * 6).Take(6).ToList()) ;
        }

        public IActionResult Detail(int id,string title)
        {
            var @event = _context.Events.FirstOrDefault(x=>x.Id == id);
            var events = _context.Events.ToList();
            
            if (title != null)
            {
                events = events.Where(x => x.Title.Contains(title)).ToList();
                return RedirectToAction("index",new {title = title});
            }

            if (@event == null)
                return RedirectToAction("error", "dashboard");

            EventViewModel eventVM = new EventViewModel
            {
                Event = @event,
                RecentlyEvents = _context.Events.OrderByDescending(x => x.Id).Take(3).ToList()
            };

            return View(eventVM);
        }
    }
}
