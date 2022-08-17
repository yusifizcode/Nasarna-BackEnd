using System.ComponentModel.DataAnnotations;

namespace Nasarna.ViewModels
{
    public class CauseCommentPostViewModel
    {
        public int CauseId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Text { get; set; }
    }
}
