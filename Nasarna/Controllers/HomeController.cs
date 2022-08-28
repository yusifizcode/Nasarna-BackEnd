using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nasarna.DAL;
using Nasarna.Models;
using Nasarna.ViewModels;
/*using Nasarna.Models;
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nasarna.Controllers
{
    public class HomeController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(NasarnaDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                Causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                        .Include(x => x.Category)
                                        .Include(x => x.CauseImages)
                                        .Include(x => x.AppUser)
                                        .Where(x => x.IsActive == true).Take(5)
                                        .ToList(),
                Payments = _context.Payments.ToList(),
                Volunteers = _context.Volunteers.Include(x=>x.AppUser).Take(3).ToList(),
                Events = _context.Events.Take(3).ToList(),
                Blogs = _context.Blogs.Include(x=>x.BlogImages).OrderByDescending(x=>x.CreatedAt).Take(3).ToList(),
                Missions = _context.Missions.Take(4).ToList()
        };
            return View(homeVM);
        }

        public IActionResult About()
        {
            AboutViewModel aboutVM = new AboutViewModel
            {
                Causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                        .Include(x => x.Category)
                                        .Include(x => x.CauseImages)
                                        .Include(x => x.AppUser)
                                        .Where(x => x.IsActive == true).Take(5)
                                        .ToList(),
                Volunteers = _context.Volunteers.Include(x => x.AppUser).Take(3).ToList(),
                Events = _context.Events.ToList(),
                Payments = _context.Payments.ToList(),
                Missions = _context.Missions.Take(4).ToList()

            };
            return View(aboutVM);
        }

        public IActionResult Error()
        {
            return View();
        }

        /*
                public async Task<IActionResult> Chat()
                {
                    var currentUser = await _userManager.GetUserAsync(User);
                    if (User.Identity.IsAuthenticated)
                    {
                        ViewBag.CurrentUserName = currentUser.UserName;
                    }
                    var messages = await _context.Messages.ToListAsync();
                    return View(messages);
                }

                public async Task<IActionResult> CreateMessage(Message message)
                {
                    if(!ModelState.IsValid)
                        return NotFound();

                    message.UserName = User.Identity.Name;
                    var sender = await _userManager.GetUserAsync(User);
                    message.AppUserId = sender.Id;
                    await _context.Messages.AddAsync(message);
                    await _context.SaveChangesAsync();
                    return Ok();
                }*/


        public async Task<IActionResult> CreateMessage([FromBody] Message message)
        {
            if (!ModelState.IsValid)
                return NotFound();

            var fromUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            message.FromUserId = fromUser.Id;

            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Authorize(Roles ="Member")]
        public IActionResult Subscribe(Subscribe subscribe)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Subscribes.Add(subscribe);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
