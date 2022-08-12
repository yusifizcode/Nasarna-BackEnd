using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using Nasarna.ViewModels;
using Pustok.Helpers;
using System.Linq;

namespace Nasarna.Controllers
{
    public class CauseController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CauseController(NasarnaDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            var causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).ToList() ;
            return View(causes);
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Categories = _context.Categories.Where(x=>x.Causes.Any());
            ViewBag.Tags = _context.Tags.Where(x => x.CauseTags.Any());

            CauseDetailViewModel detailVM = new CauseDetailViewModel
            {
                Cause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).Include(x=>x.Donations).FirstOrDefault(x => x.Id == id),
                Donation = _context.Donations.Include(x=>x.Cause).FirstOrDefault(x=>x.CauseId == id),
            }; 
            return View(detailVM);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cause cause)
        {
            if (!_context.Categories.Any(x => x.Id == cause.CategoryId))
                ModelState.AddModelError("CategoryId", "Category not found!");

            if (cause.ImageFiles != null)
            {
                foreach (var file in cause.ImageFiles)
                {
                    if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("ImageFiles", "File format must be image/png or image/jpeg");
                    }

                    if (file.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFiles", "File size must be less than 2MB");
                    }
                }
            }

            if (cause.TagIds != null)
            {
                foreach (var tagId in cause.TagIds)
                {
                    if (!_context.Tags.Any(x => x.Id == tagId))
                    {
                        ModelState.AddModelError("TagIds", "Tag id not found");
                    }
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Tags = _context.Tags.ToList();

                return View();
            }

            if (cause.ImageFiles != null)
            {
                foreach (var file in cause.ImageFiles)
                {
                    CauseImage causeImage = new CauseImage
                    {
                        Name = FileManager.Save(_env.WebRootPath, "uploads/causes", file),
                    };

                    cause.CauseImages.Add(causeImage);
                }
            }

            if (cause.TagIds != null)
            {
                foreach (var tagId in cause.TagIds)
                {
                    CauseTag causeTag = new CauseTag
                    {
                        TagId = tagId
                    };

                    cause.CauseTags.Add(causeTag);
                }
            }

            _context.Causes.Add(cause);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Donate(CauseDetailViewModel detailVM)
        {
            var donatedCause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).Include(x => x.Donations).FirstOrDefault(x=>x.Id == detailVM.Cause.Id);

            if (donatedCause == null)
                return RedirectToAction("error", "home");

            detailVM.Donation.CauseId = donatedCause.Id;

            if(detailVM.Donation.Amount > detailVM.Cause.NeedAmount)
            {
                ModelState.AddModelError("Amount", "Your amount more than need amount!");
                return RedirectToAction("detail", new { detailVM.Cause.Id });
            }
            else
            {
                donatedCause.CurrentAmount += detailVM.Donation.Amount;
            }

            if (!ModelState.IsValid)
                return RedirectToAction("detail", new { detailVM.Cause.Id });

            _context.Donations.Add(detailVM.Donation);
            _context.SaveChanges();
            return RedirectToAction("index","home");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
