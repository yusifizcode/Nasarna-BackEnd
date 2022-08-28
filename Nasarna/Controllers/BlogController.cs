using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using Nasarna.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nasarna.Controllers
{
    public class BlogController : Controller
    {
        private readonly NasarnaDbContext _context;

        public BlogController(NasarnaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? tagId, string title, int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling(_context.Blogs.Count() / 6d);

            var blogs = _context.Blogs.Include(x => x.BlogTags).ThenInclude(e => e.Tag)
                                      .Include(x => x.BlogImages)
                                      .Include(x => x.AppUser)
                                      .ToList();

            /*            var causeCategories = _context.Categories.Where(x => x.Causes.Any()).ToList();
                        if (categoryId != null)
                            causeCategories = causeCategories.Where(x=>x.Id == categoryId).ToList();*/

            if(blogs.Count > 0)
            {
                if (page < 1 || page > (int)Math.Ceiling(_context.Blogs.Count() / 6d))
                    return RedirectToAction("error", "home");
            }

            var blogTags = _context.Tags.Where(x => x.BlogTags.Any()).ToList();

            if(tagId != null)
                blogs = blogs.Where(x=>x.BlogTags.Any(bt=>bt.TagId == tagId)).ToList();

            if(title != null)
                blogs = blogs.Where(x=>x.Title.Contains(title)).ToList();

            BlogViewModel blogVM = new BlogViewModel
            {
                Tags = blogTags,
                RecentlyBlogs = _context.Blogs.Include(x => x.BlogImages).OrderByDescending(x => x.Id).Take(3).ToList(),
                Blogs = blogs.Skip((page - 1) * 6).Take(6).ToList(),
            };
            return View(blogVM);
        }


        public IActionResult Detail(int id,int? tagId, string title)
        {
            BlogDetailViewModel detailVM = GetBlogDetailVM(id,tagId,title);

            if (tagId != null)
                return RedirectToAction("index", new { tagId = tagId });

            if (title != null)
                return RedirectToAction("index", new { title = title });

            if (detailVM == null)
                return RedirectToAction("error", "home");

            return View(detailVM);
        }

        private BlogDetailViewModel GetBlogDetailVM(int id, int? tagId,string title)
        {
            var blogs = _context.Blogs.Include(x => x.BlogTags).ThenInclude(e => e.Tag)
                                      .Include(x => x.BlogImages)
                                      .Include(x => x.AppUser)
                                      .ToList();

            var blog = _context.Blogs.Include(x => x.BlogTags).ThenInclude(e => e.Tag)
                                      .Include(x => x.BlogImages)
                                      .Include(x=>x.BlogComments).ThenInclude(x=>x.AppUser)
                                      .Include(x => x.AppUser)
                                      .FirstOrDefault(x => x.Id == id);

            var blogTags = _context.Tags.Where(x => x.BlogTags.Any()).ToList();

            if (tagId != null)
                blogs = blogs.Where(x => x.BlogTags.Any(bt => bt.Id == tagId)).ToList();

            if (title != null)
                blogs = blogs.Where(x => x.Title.Contains(title)).ToList();

            if (blog == null)
                return null;

            BlogDetailViewModel blogDetailVM = new BlogDetailViewModel
            {
                Blog = blog,
                Tags = blogTags,
                RecentlyBlogs = _context.Blogs.Include(x => x.BlogImages).OrderByDescending(x => x.Id).Take(3).ToList(),
                BlogComment = new BlogCommentPostViewModel { BlogId = id },
            };

            return blogDetailVM;
        }


        [HttpPost]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Comment(BlogCommentPostViewModel commentVM,int? tagId,string title)
        {
            if (!ModelState.IsValid)
            {
                var model = GetBlogDetailVM(commentVM.BlogId,tagId,title);

                if (model == null) return RedirectToAction("error", "home");
                else
                {
                    model.BlogComment = commentVM;
                    return View("Detail", model);
                }
            }

            Blog blog = _context.Blogs.Include(x => x.BlogComments).FirstOrDefault(x => x.Id == commentVM.BlogId);

            if (blog == null)
                return RedirectToAction("error", "home");

            AppUser user = await _context.Users.FirstOrDefaultAsync(x => !x.IsAdmin && x.IsStatus && x.NormalizedUserName == User.Identity.Name.ToUpper());

            if (user == null)
                return RedirectToAction("error", "home");

            BlogComment comment = new BlogComment
            {
                BlogId = commentVM.BlogId,
                AppUserId = user.Id,
                AppUser = user,
                CreatedAt = DateTime.UtcNow.AddHours(4),
                Text = commentVM.Text,
            };

            blog.BlogComments.Add(comment);

            await _context.SaveChangesAsync();


            return RedirectToAction("detail", new { id = commentVM.BlogId });
        }
    }
}
