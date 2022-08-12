using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nasarna.Models
{
    public class Blog
    {
        public int Id { get; set; }
/*        public int AuthorId { get; set; }
*/
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public string Desc { get; set; }
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();
        public List<BlogImage> BlogImages { get; set; } = new List<BlogImage>();

/*        public Author Author { get; set; }
*/
        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }
        [NotMapped]
        public List<int> ImageIds { get; set; } = new List<int>();
        [NotMapped]
        public List<int> TagIds { get; set; } = new List<int>();

    }
}
