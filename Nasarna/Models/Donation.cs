using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nasarna.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int CauseId { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Amount { get; set; }
        [Required]
        public string Card { get; set; }
        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        public string CardNumber { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(3)]
        public string CVV { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        public string ExpireDate { get; set; }
        public AppUser AppUser { get; set; }
        public Cause Cause { get; set; }
    }
}
