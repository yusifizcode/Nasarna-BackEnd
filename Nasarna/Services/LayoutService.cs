using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nasarna.DAL;
using Nasarna.Models;
using System.Collections.Generic;
using System.Linq;

namespace Nasarna.Services
{
    public class LayoutService
    {
        private readonly NasarnaDbContext _context;

        public LayoutService(NasarnaDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(x => x.Key, y => y.Value);
        }

        public List<Blog> GetBlogs()
        {
            return _context.Blogs.Include(x => x.BlogTags).ThenInclude(e => e.Tag)
                                      .Include(x => x.BlogImages)
                                      .Include(x => x.AppUser).OrderByDescending(x=>x.CreatedAt).Take(2)
                                      .ToList();
        }
    }
}
