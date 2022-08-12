using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using Pustok.Helpers;
using System.Linq;

namespace Nasarna.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly NasarnaDbContext _context;

        public BlogController(NasarnaDbContext context, IWebHostEnvironment env)
        {
            
            _env = env;
            _context = context;
        }

        public IActionResult Index()
        {
/*            var blogs = _context.Blogs.Include(x=>x.Author).ToList();
*/            var blogs = _context.Blogs.Include(x=>x.BlogTags).ThenInclude(e=>e.Tag).Include(x=>x.BlogImages).ToList();
            return View(blogs);
        }

        public IActionResult Create()
        {
/*            ViewBag.Authors = _context.Authors.ToList();
*/            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
/*            if (!_context.Authors.Any(x => x.Id == blog.Id))
                ModelState.AddModelError("AuthorId", "Author not found!");
*/

            if (blog.ImageFiles != null)
            {
                foreach (var file in blog.ImageFiles)
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
            else
            {
                ModelState.AddModelError("ImageFiles", "ImageFile is required!");
            }

            if (blog.TagIds != null)
            {
                foreach (var tagId in blog.TagIds)
                {
                    if (!_context.Tags.Any(x => x.Id == tagId))
                    {
                        ModelState.AddModelError("TagIds", "Tag id not found");
                    }
                }
            }

            if (!ModelState.IsValid)
            {
/*                ViewBag.Authors = _context.Authors.ToList();
*/                ViewBag.Tags = _context.Tags.ToList();


                return View();
            }


            if (blog.ImageFiles != null)
            {
                foreach (var file in blog.ImageFiles)
                {
                    BlogImage blogImage = new BlogImage
                    {
                        Name = FileManager.Save(_env.WebRootPath, "uploads/blogs", file),
                    };

                    blog.BlogImages.Add(blogImage);
                }
            }


            if (blog.TagIds != null)
            {
                foreach (var tagId in blog.TagIds)
                {
                    BlogTag bookTag = new BlogTag
                    {
                        TagId = tagId
                    };

                    blog.BlogTags.Add(bookTag);
                }
            }

            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return RedirectToAction("index");

        }

        public IActionResult Edit(int id)
        {
            Blog blog = _context.Blogs.Include(x => x.BlogTags).ThenInclude(t => t.Tag).Include(x => x.BlogImages).FirstOrDefault(x => x.Id == id);

            if (blog == null)
                return RedirectToAction("error", "dashboard");

            ViewBag.Tags = _context.Tags.ToList();

            blog.TagIds = blog.BlogTags.Select(x => x.TagId).ToList();

            return View(blog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            Blog existBlog = _context.Blogs.Include(x => x.BlogTags).ThenInclude(t => t.Tag).Include(x => x.BlogImages).FirstOrDefault(x => x.Id == blog.Id);

            if (existBlog == null)
                return RedirectToAction("error", "dashboard");

            if (blog.ImageFiles != null)
            {
                foreach (var file in blog.ImageFiles)
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

            if (blog.TagIds != null)
            {
                foreach (var tagId in blog.TagIds)
                {
                    if (!_context.Tags.Any(x => x.Id == tagId))
                    {
                        ModelState.AddModelError("TagIds", "Tag id not found");
                    }
                }
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Tags = _context.Tags.ToList();
                return View();
            }

            existBlog.BlogTags.RemoveAll(bt=> !blog.TagIds.Contains(bt.Id));

            foreach (var tagId in blog.TagIds.Where(x => !existBlog.BlogTags.Any(bt => bt.TagId == x)))
            {
                BlogTag blogTag = new BlogTag
                {
                    TagId = tagId
                };
                existBlog.BlogTags.Add(blogTag);
            }

            

            if (blog.ImageFiles != null)
            {
                if (existBlog.BlogImages != null)
                {
                    foreach (var file in existBlog.BlogImages)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/blogs", file.Name);
                        _context.BlogImages.Remove(file);
                    }
                }

                foreach (var file in blog.ImageFiles)
                {
                    BlogImage blogImage = new BlogImage
                    {
                        Name = FileManager.Save(_env.WebRootPath, "uploads/blogs", file),
                    };

                    existBlog.BlogImages.Add(blogImage);
                }
            }

            existBlog.Title = blog.Title;
            existBlog.Desc = blog.Desc;
            
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Blog blog = _context.Blogs.Include(x => x.BlogTags).ThenInclude(t => t.Tag).Include(x => x.BlogImages).FirstOrDefault(x => x.Id == id);

            if(blog == null)
                return NotFound();

            foreach (var file in blog.BlogImages)
            {
                FileManager.Delete(_env.WebRootPath, "uploads/blogs", file.Name);
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();

            return Ok();
        }
    }
}
