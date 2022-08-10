using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nasarna.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public DateTime CreatedAt = DateTime.Now;
        [Required]
        public string Desc { get; set; }
        [Required]
        public string Schedule { get; set; }
        [Required]
        public string Location { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
