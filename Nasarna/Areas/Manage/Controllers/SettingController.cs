using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nasarna.DAL;
using Nasarna.Models;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles ="SuperAdmin")]
    public class SettingController : Controller
    {
        private NasarnaDbContext _context;

        public SettingController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var settings = _context.Settings.ToDictionary(x => x.Key, y => y.Value);
            return View(settings);
        }


        public IActionResult Edit(string id)
        {
            var existSetting = _context.Settings.FirstOrDefault(x => x.Key == id);

            if (existSetting == null)
                return RedirectToAction("error", "dashboard");

            return View(existSetting);
        }

        [HttpPost]
        public IActionResult Edit(Setting setting)
        {
            var existSetting = _context.Settings.FirstOrDefault(x => x.Key == setting.Key);

            if (existSetting == null)
                return RedirectToAction("error", "dashboard");

            existSetting.Value = setting.Value;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
