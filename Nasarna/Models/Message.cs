﻿namespace Nasarna.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public string Text { get; set; }
        public AppUser AppUser { get; set; }
    }
}
