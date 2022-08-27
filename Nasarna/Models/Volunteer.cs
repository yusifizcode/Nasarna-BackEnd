using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        [MaxLength (50)]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(100)]
        public string FacebookUrl { get; set; }
        [MaxLength(100)]
        public string InstagramUrl { get; set; }
        [MaxLength(100)]
        public string TwitterUrl { get; set; }
        public AppUser AppUser { get; set; }
    }
}
