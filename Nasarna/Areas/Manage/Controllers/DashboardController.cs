using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using System;
using System.Collections.Generic;
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


            var volunteers = _context.Volunteers.Include(x => x.AppUser).ToList();

            if (volunteers.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Volunteers.Count() / 10d))
                    return RedirectToAction("error", "dashboard");
            }

            return View(volunteers.Skip((page - 1) * 10).Take(10).ToList());
        }

        public IActionResult Contact(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Contacts.Count() / 10d);

            var contacts = _context.Contacts.Include(x => x.AppUser).ToList(); 
            
            if(contacts.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Contacts.Count() / 10d))
                    return RedirectToAction("error", "dashboard");
            }

            return View(contacts.Skip((page - 1) * 10).Take(10).ToList());
        }

        public IActionResult Subscribes(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Subscribes.Count() / 10d);

            var subscribes = _context.Subscribes.Include(x => x.AppUser).ToList();

            if(subscribes.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Subscribes.Count() / 10d))
                    return RedirectToAction("error", "dashboard");
            }

            return View(subscribes.Skip((page - 1) * 10).Take(10).ToList());
        }

        public List<object> GetCauses()
        {
            var data = new List<object>();

            List<string> labels = _context.Causes.Select(x=>x.Title).ToList();

            data.Add(labels);

            List<double> donateAmount = _context.Causes.Select(x=>x.AmountPercent).ToList();

            data.Add(donateAmount);

            List<string> labels1 = _context.Users.Select(x =>x.UserName).Where(x=>x != "SuperAdmin").ToList();

            data.Add(labels1);

            List<int> totalAmounts = new List<int>();
            foreach (var item in labels1)
            {
                var totalAmount = 0;

                List<int> amount = _context.Payments.Where(x=>x.AppUser.UserName == item).Select(x => x.Value).ToList();
                foreach (var i in amount)
                {
                    totalAmount += i;
                }
                totalAmounts.Add(totalAmount);
            }
            data.Add(totalAmounts);

            return data;
        }
    }
}
