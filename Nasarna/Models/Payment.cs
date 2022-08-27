using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int CauseId { get; set; }
        public string AppUserId { get; set; }
        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        public string CardNumber { get; set; }
        [Required]
        public int Month { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(3)]
        public string Cvc { get; set; }
        [Required]
        public int Value { get; set; }
        public Cause Cause { get; set; }
        public AppUser AppUser { get; set; }
    }
}
