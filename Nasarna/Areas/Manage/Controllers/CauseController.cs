﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Hubs;
using Nasarna.Models;
using System;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles ="SuperAdmin")]
    public class CauseController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly IHubContext<NasarnaHub> _hubContext;
        private readonly UserManager<AppUser> _userManager;

        public CauseController(NasarnaDbContext context, IHubContext<NasarnaHub> hubContext,UserManager<AppUser> userManager)
        {
            _context = context;
            _hubContext = hubContext;
            _userManager = userManager;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Causes.Count() / 10d);

            var causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                       .Include(x => x.Category)
                                       .Include(x => x.CauseImages)
                                       .Include(x => x.AppUser)
                                       .ToList();

            if(causes.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Causes.Count() / 10d))
                    return RedirectToAction("error", "dashboard");
            }

            return View(causes.Skip((page - 1) * 10).Take(10).ToList());
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

            if(cause.AppUserId != null)
            {
                AppUser user = _userManager.FindByIdAsync(cause.AppUserId).Result;

                if (user.ConnectionId != null)
                {
                    if(cause.IsActive == true)
                    {
                        _hubContext.Clients.Client(user.ConnectionId).SendAsync("causeAccepted");
                    }
                    else if(cause.IsActive == false)
                    {
                        _hubContext.Clients.Client(user.ConnectionId).SendAsync("causeRejected");
                    }
                }
            }


            return RedirectToAction("index");
        }
    }
}
