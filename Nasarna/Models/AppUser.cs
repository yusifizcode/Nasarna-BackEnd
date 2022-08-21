﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Nasarna.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsStatus { get; set; }
        public string ProfileImg { get; set; }
        public string ConnectionId { get; set; }
        public DateTime ConnectedAt { get; set; }
        public List<Message> Messages { get; set; }
    }
}
