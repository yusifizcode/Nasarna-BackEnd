using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using Nasarna.ViewModels;
using Pustok.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace Nasarna.Controllers
{
    public class CauseController : Controller
    {
        private readonly NasarnaDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;

        public CauseController(NasarnaDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var causes = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                        .Include(x => x.Category)
                                        .Include(x => x.CauseImages)
                                        .Include(x=>x.AppUser)
                                        .ToList() ;


            return View(causes);
        }

        public IActionResult Detail(int id)
        
        {
            ViewBag.Categories = _context.Categories.Where(x=>x.Causes.Any());
            ViewBag.Tags = _context.Tags.Where(x => x.CauseTags.Any());

            CauseDetailViewModel detailVM = GetCauseDetailVM(id);

            if (detailVM == null)
                return RedirectToAction("error", "home");

            if(TempData["Error"] != null)
                return View(detailVM);


            return View(detailVM);
        }


        private CauseDetailViewModel GetCauseDetailVM(int id)
        {
            Cause cause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag)
                                         .Include(x => x.Category)
                                         .Include(x => x.CauseImages)
                                         .Include(x => x.CauseComments)
                                         .Include(x=>x.AppUser)
                                         .FirstOrDefault(x => x.Id == id);

            if (cause == null)
                return null;

            CauseDetailViewModel causeVM = new CauseDetailViewModel
            {
                Cause = cause,
                RecentlyCauses = _context.Causes.Include(x => x.CauseImages).OrderByDescending(x=>x.Id).Take(3).ToList(),
                CauseComment = new CauseCommentPostViewModel { CauseId = id },
                Payment = _context.Payments.Include(x => x.Cause).FirstOrDefault(x => x.CauseId == id),
            };

            return causeVM;
        }


        [HttpPost]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Comment(CauseCommentPostViewModel commentVM)
        {
            if (!ModelState.IsValid)
            {
                var model = GetCauseDetailVM(commentVM.CauseId);

                if (model == null) return RedirectToAction("error", "home");
                else
                {
                    model.CauseComment = commentVM;
                    return View("Detail",model);
                }
            }

            Cause cause = _context.Causes.Include(x=>x.CauseComments).FirstOrDefault(x=>x.Id == commentVM.CauseId);

            if (cause == null)
                return RedirectToAction("error", "home");

            AppUser user = await _context.Users.FirstOrDefaultAsync(x => !x.IsAdmin && x.NormalizedUserName == User.Identity.Name.ToUpper());

            CauseComment comment = new CauseComment
            {
                CauseId = commentVM.CauseId,
                AppUserId = user.Id,
                CreatedAt = DateTime.UtcNow.AddHours(4),
                Text = commentVM.Text,
            };

            cause.CauseComments.Add(comment);

            await _context.SaveChangesAsync();


            return RedirectToAction("detail", new { id = commentVM.CauseId });
        }


        [Authorize(Roles = "Member")]

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }

        [Authorize(Roles = "Member")]

        [HttpPost]
        public IActionResult Create(Cause cause)
        {


            AppUser loggedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                loggedUser = _userManager.Users.FirstOrDefault(x => !x.IsAdmin && x.UserName == User.Identity.Name);
                cause.AppUserId = loggedUser.Id;
            }

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

        [Authorize(Roles = "Member")]

        public IActionResult Edit(int id)
        
       {
            var cause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).FirstOrDefault(x => x.Id == id);

            AppUser loggedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                loggedUser = _userManager.Users.FirstOrDefault(x => !x.IsAdmin && x.UserName == User.Identity.Name);
            }

            if (cause == null || (cause.AmountPercent != 100 && cause.AmountPercent != 0) || cause?.AppUserId != loggedUser.Id)
                return RedirectToAction("error", "home");

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();

            cause.TagIds = cause.CauseTags.Select(x => x.TagId).ToList();
            return View(cause);
        }
        [Authorize(Roles = "Member")]


        [HttpPost]
        public IActionResult Edit(Cause cause)
        {
            var existCause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).FirstOrDefault(x=>x.Id == cause.Id);

            AppUser loggedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                loggedUser = _userManager.Users.FirstOrDefault(x => !x.IsAdmin && x.UserName == User.Identity.Name);
            }

            if (existCause == null || (existCause.AmountPercent != 100 && existCause.AmountPercent != 0) || existCause?.AppUserId != loggedUser.Id)
                return RedirectToAction("error", "home");


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

            existCause.CauseTags.RemoveAll(bt => !existCause.TagIds.Contains(bt.Id));

            foreach (var tagId in cause.TagIds.Where(x => !existCause.CauseTags.Any(bt => bt.TagId == x)))
            {
                CauseTag causeTag = new CauseTag
                {
                    TagId = tagId
                };
                existCause.CauseTags.Add(causeTag);
            }

            if (cause.ImageFiles != null)
            {
                if (existCause.CauseImages != null)
                {
                    foreach (var file in existCause.CauseImages)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/causes", file.Name);
                        _context.CauseImages.Remove(file);
                    }
                }

                foreach (var file in cause.ImageFiles)
                {
                    CauseImage causeImage = new CauseImage
                    {
                        Name = FileManager.Save(_env.WebRootPath, "uploads/causes", file),
                    };

                    existCause.CauseImages.Add(causeImage);
                }
            }


            existCause.Address = cause.Address;
            existCause.Desc = cause.Desc;
            existCause.SubDesc = cause.SubDesc;
            existCause.Title = cause.Title;
            existCause.SubTitle = cause.SubTitle;
            existCause.CategoryId = cause.CategoryId;
            existCause.NeedAmount = cause.NeedAmount;

            _context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            var cause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).FirstOrDefault(x => x.Id == id);

            AppUser loggedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                loggedUser = _userManager.Users.FirstOrDefault(x => !x.IsAdmin && x.UserName == User.Identity.Name);
            }

            if (cause == null || (cause.AmountPercent != 100 && cause.AmountPercent != 0) || cause?.AppUserId != loggedUser.Id)
                   return NotFound();

            foreach (var file in cause.CauseImages)
            {
                FileManager.Delete(_env.WebRootPath, "uploads/causes", file.Name);
            }

            _context.Causes.Remove(cause);
            _context.SaveChanges();
            return Ok();
        }


        /*
                [HttpPost]
                public IActionResult Donate(CauseDetailViewModel detailVM)
                {
                    var donatedCause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).Include(x => x.Donations).FirstOrDefault(x=>x.Id == detailVM.Cause.Id);

                    if (donatedCause == null)
                        return RedirectToAction("error", "home");

                    detailVM.Donation.CauseId = donatedCause.Id;

                    if((detailVM.Donation.Amount > detailVM.Cause.NeedAmount) || (detailVM.Cause.CurrentAmount >= detailVM.Cause.NeedAmount))
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
                    return RedirectToAction("detail", new { detailVM.Cause.Id });
                }

        */

        public async Task<IActionResult> Payment(Payment payment)
        {

            var donatedCause = _context.Causes.Include(x => x.CauseTags).ThenInclude(t => t.Tag).Include(x => x.Category).Include(x => x.CauseImages).Include(x => x.Payments).FirstOrDefault(x => x.Id == payment.CauseId);


            if (payment == null || donatedCause == null)
                return RedirectToAction("error", "home");


            var result = await MakePayment.PayAsync(payment.CardNumber, payment.Month, payment.Year, payment.Cvc, payment.Value);

            if (result == "Success")
            {
                if ((payment.Value > donatedCause.NeedAmount) || (donatedCause.CurrentAmount >= donatedCause.NeedAmount))
                {
                    /*ModelState.AddModelError("", "Your amount more than need amount!");
                    return RedirectToAction("detail", new { donatedCause.Id });*/

                    return RedirectToAction("error", "home");
                }
                else
                {
                    donatedCause.CurrentAmount += payment.Value;

                    if (donatedCause.NeedAmount > 0)
                    {
                        donatedCause.AmountPercent = (int)((donatedCause.CurrentAmount / donatedCause.NeedAmount) * 100);
                    }
                }



                payment.CauseId = donatedCause.Id;

                _context.Payments.Add(payment);
                _context.SaveChanges();

                return RedirectToAction("detail", new { id = payment.CauseId });
            }
            else
            {
                TempData["Error"] = result;
                return RedirectToAction("detail", new { id = donatedCause.Id }) ;
            }
        }

/*        [Route("pay")]
        public async Task<dynamic> Pay(Models.Payment pm)
        {
            var result = await MakePayment.PayAsync(pm.CardNumber, pm.Month, pm.Year, pm.Cvc, pm.Value);

            if (result == "Success")
            {
                return RedirectToAction("detail", new { id = pm.CauseId });
            }
            else
            {
                return RedirectToAction("error", "home");
            }

            *//*            return await MakePayment.PayAsync(pm.CardNumber, pm.Month, pm.Year, pm.Cvc, pm.Value);
            *//*
        }*/
    }
}
