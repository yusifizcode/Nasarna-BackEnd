using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> RecentlyBlogs { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
