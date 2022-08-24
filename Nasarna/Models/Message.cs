using System;

namespace Nasarna.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public AppUser FromUser { get; set; }
        public AppUser ToUser { get; set; }
    }
}
