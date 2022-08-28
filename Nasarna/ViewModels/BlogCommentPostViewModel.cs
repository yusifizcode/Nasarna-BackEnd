using System.ComponentModel.DataAnnotations;

namespace Nasarna.ViewModels
{
    public class BlogCommentPostViewModel
    {
        public int BlogId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Text { get; set; }

    }
}
