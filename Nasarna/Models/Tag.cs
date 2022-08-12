using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public List<BlogTag> BlogTags { get; set; }
        public List<CauseTag> CauseTags { get; set; }
    }
}
