using System;
using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string AppUserId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } =  DateTime.Now;
        public AppUser AppUser { get; set; }
        public Blog Blog { get; set; }
    }
}
