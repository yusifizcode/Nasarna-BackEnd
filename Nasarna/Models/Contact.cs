using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        [Required,MaxLength(50)]
        public string Subject { get; set; }
        [Required,MaxLength (150)]
        public string Desciption { get; set; }
        public AppUser AppUser { get; set; }
    }
}
