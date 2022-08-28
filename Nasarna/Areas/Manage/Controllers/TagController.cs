using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using System;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TagController : Controller
    {
        private readonly NasarnaDbContext _context;

        public TagController(NasarnaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Tags.Count() / 10d);

            if (page < 1 || page > (int)Math.Ceiling(_context.Tags.Count() / 10d))
                return RedirectToAction("error", "home");

            var tags = _context.Tags.Include(x => x.BlogTags).Skip((page - 1) * 10).Take(10).ToList();
            return View(tags);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            if(!ModelState.IsValid)
                return View();

            _context.Tags.Add(tag);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Tag tag = _context.Tags.FirstOrDefault(x => x.Id == id);
            if (tag == null)
                return RedirectToAction("error", "dashboard");

            return View(tag);
        }

        [HttpPost]
        public IActionResult Edit(Tag tag)
        {
            var existTag = _context.Tags.FirstOrDefault(x => x.Id == tag.Id);

            if (existTag == null)
                return RedirectToAction("error", "dashboard");

            existTag.Name = tag.Name;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Tag tag = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (tag == null)
                return NotFound();

            _context.Tags.Remove(tag);
            _context.SaveChanges();
            return Ok();
        }
    }
}
