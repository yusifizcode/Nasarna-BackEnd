using System;
using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public AppUser AppUser { get; set; }
    }
}
