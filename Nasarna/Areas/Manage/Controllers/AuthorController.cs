using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    public class AuthorController : Controller
    {
        private readonly NasarnaDbContext _context;

        public AuthorController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var authors = _context.Authors.Include(x=>x.Blogs).ToList();
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if(!ModelState.IsValid)
                return View();

            _context.Authors.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var author = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
                return RedirectToAction("error", "dashboard");

            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            var existAuthor = _context.Authors.FirstOrDefault(x => x.Id == author.Id);

            if (existAuthor == null)
                return RedirectToAction("error", "dashboard");

            if (!ModelState.IsValid)
                return View();

            existAuthor.FullName = author.FullName;
            existAuthor.BirthDate = author.BirthDate;
            
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var author = _context.Authors.FirstOrDefault(x => x.Id == id);

            if(author == null)
                return NotFound();

            _context.Authors.Remove(author);
            _context.SaveChanges();

            return Ok();
        }
    }
}
