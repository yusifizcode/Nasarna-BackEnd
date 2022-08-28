using Nasarna.Models;
using System.Collections.Generic;

namespace Nasarna.ViewModels
{
    public class BlogDetailViewModel
    {
        public Blog Blog { get; set; }
        public List<Blog> RecentlyBlogs { get; set; }
        public BlogCommentPostViewModel BlogComment { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
