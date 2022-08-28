using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using System;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles ="SuperAdmin")]
    public class CategoryController : Controller
    {
        private readonly NasarnaDbContext _context;

        public CategoryController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Categories.Count() / 10d);

            var categories = _context.Categories.Include(x=>x.Causes).ToList();

            if(categories.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Categories.Count() / 10d))
                    return RedirectToAction("error", "dashboard");
            }

            return View(categories.Skip((page - 1) * 10).Take(10).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
                return View();

            if(_context.Categories.Any(x=>x.Name == category.Name))
            {
                ModelState.AddModelError("Name", "This category is already exist!");
                return View();
            }

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var cat = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (cat == null)
                return RedirectToAction("error", "dashboard");

            return View(cat);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var existCategory = _context.Categories.FirstOrDefault(x => x.Id == category.Id);

            if (existCategory == null)
                return RedirectToAction("error", "dashboard");

            if(_context.Categories.Any(x=>x.Id != existCategory.Id && x.Name == existCategory.Name))
            {
                ModelState.AddModelError("Name", "This category is already exist!");
                return View();
            }

            existCategory.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var cat = _context.Categories.FirstOrDefault(x=>x.Id == id);

            if(cat == null)
                return NotFound();

            _context.Categories.Remove(cat);
            _context.SaveChanges();
            return Ok();
        }
    }
}
