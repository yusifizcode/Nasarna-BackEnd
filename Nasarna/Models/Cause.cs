using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nasarna.Models
{
    public class Cause
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [Required]
        public string Desc { get; set; }    
        public string SubDesc { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }

        [Column(TypeName = "decimal(18, 6)")]
        public decimal NeedAmount { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CurrentAmount { get; set; } = 0;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AmountPercent { get; set; } = 0;
        public List<CauseImage> CauseImages { get; set; } = new List<CauseImage>();
        public List<CauseTag> CauseTags { get; set; } = new List<CauseTag>();
        public List<Donation> Donations { get; set; } = new List<Donation>();
        public Category Category { get; set; }
        public AppUser AppUser { get; set; }
        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }
        [NotMapped]
        public List<int> TagIds { get; set; } = new List<int>();
    }
}
