using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nasarna.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
