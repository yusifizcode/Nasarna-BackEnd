using System.ComponentModel.DataAnnotations;

namespace Nasarna.ViewModels
{
    public class MemberLoginViewModel
    {
        [Required]
        [MaxLength(25)]
        [MinLength(6)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
