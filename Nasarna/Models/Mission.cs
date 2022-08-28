using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nasarna.Models
{
    public class Mission
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(25)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Desc { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
