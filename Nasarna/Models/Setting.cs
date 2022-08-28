using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Key { get; set; }
        [MaxLength(250)]
        public string Value { get; set; }
    }
}
