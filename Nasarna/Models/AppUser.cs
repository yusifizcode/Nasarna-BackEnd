using Microsoft.AspNetCore.Identity;

namespace Nasarna.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsStatus { get; set; }
    }
}
