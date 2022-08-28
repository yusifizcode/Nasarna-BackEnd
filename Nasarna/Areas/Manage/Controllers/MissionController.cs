using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nasarna.DAL;
using Nasarna.Models;
using Pustok.Helpers;
using System;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    [Area("manage")]

    public class MissionController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly IWebHostEnvironment _env;

        public MissionController(NasarnaDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Missions.Count() / 10d);

            var missions = _context.Missions.ToList();

            if(missions.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Missions.Count() / 10d))
                    return RedirectToAction("error", "dashboard");
            }

            return View(missions);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mission mission)
        {
            if(mission.ImageFile != null)
            {
                if (mission.ImageFile.ContentType != "image/png" && mission.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Image content type must be png, jpg or jpeg!");
                }

                if (mission.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size must be less than 2MB!");
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Image file is required!");
            }

            mission.Image = FileManager.Save(_env.WebRootPath, "uploads/missions", mission.ImageFile);

            _context.Missions.Add(mission);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var mission = _context.Missions.FirstOrDefault(x=>x.Id == id);
            if (mission == null)
                return RedirectToAction("error", "dashboard");

            return View(mission);
        }

        [HttpPost]
        public IActionResult Edit(Mission mission)
        {
            var existMission = _context.Missions.FirstOrDefault(x => x.Id == mission.Id);

            if (existMission == null)
                return RedirectToAction("error", "dashboard");

            if (mission.ImageFile != null)
            {
                if (mission.ImageFile.ContentType != "image/png" && mission.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Image content type must be png, jpg or jpeg!");
                }

                if (mission.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size must be less than 2MB!");
                }

                if (!ModelState.IsValid)
                    return View();

                string newFileName = FileManager.Save(_env.WebRootPath,"uploads/missions",mission.ImageFile);

                FileManager.Delete(_env.WebRootPath, "uploads/missions", existMission.Image);

                existMission.Image = newFileName;
            }

            existMission.Title = mission.Title;
            existMission.Desc = mission.Desc;

            _context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            Mission mission = _context.Missions.FirstOrDefault(m => m.Id == id);

            if (mission == null)
                return NotFound();

            FileManager.Delete(_env.WebRootPath, "uploads/events", mission.Image);

            _context.Missions.Remove(mission);
            _context.SaveChanges();

            return Ok();
        }
    }
}
