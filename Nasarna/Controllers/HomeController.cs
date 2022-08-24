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
        };
            return View(homeVM);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Volunteer()
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


        public async Task<IActionResult> CreateMessage(Message message)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return Ok(message);
        }
    }
}
