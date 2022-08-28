using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nasarna.DAL;
using Nasarna.Models;
using Pustok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    public class EventController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly IWebHostEnvironment _env;

        public EventController(NasarnaDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Events.Count() / 10d);

            if (page < 1 || page > (int)Math.Ceiling(_context.Events.Count() / 10d))
                return RedirectToAction("error", "home");

            List<Event> events = _context.Events.Skip((page - 1) * 10).Take(10).ToList();
            return View(events);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Event ev)
        {
            if(ev.ImageFile != null)
            {
                if(ev.ImageFile.ContentType != "image/png" && ev.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File format must be image/png or image/jpeg");
                }

                if(ev.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size must be less than 2MB");
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile", "ImageFile is required!");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }


            ev.Image = FileManager.Save(_env.WebRootPath,"uploads/events",ev.ImageFile);

            _context.Add(ev);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            Event ev = _context.Events.FirstOrDefault(e => e.Id == id);

            if (ev == null)
            {
                return RedirectToAction("error","dashboard");
            }

            return View(ev);
        }

        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            Event existEvent = _context.Events.FirstOrDefault(e => e.Id == ev.Id);

            if (existEvent == null)
                return RedirectToAction("error", "dashboard");

            if (ev.ImageFile != null)
            {
                if (ev.ImageFile.ContentType != "image/png" && ev.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File format must be image/png or image/jpeg");
                }

                if (ev.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size must be less than 2MB");
                }

                if (!ModelState.IsValid)
                    return View();

                string newFileName = FileManager.Save(_env.WebRootPath, "uploads/events", ev.ImageFile);

                FileManager.Delete(_env.WebRootPath, "uploads/events", existEvent.Image);

                existEvent.Image = newFileName;
            }

            if (!ModelState.IsValid)
                return View();

            existEvent.Title = ev.Title;
            existEvent.Schedule = ev.Schedule;
            existEvent.Desc = ev.Desc;
            existEvent.Date = ev.Date;
            existEvent.Location = ev.Location;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Event @event = _context.Events.FirstOrDefault(e => e.Id == id);

            if (@event == null)
                return NotFound();

            FileManager.Delete(_env.WebRootPath,"uploads/events",@event.Image);

            _context.Events.Remove(@event);
            _context.SaveChanges();

            return Ok();
        }
    }
}
