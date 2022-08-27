using System.ComponentModel.DataAnnotations;

namespace Nasarna.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }

    }
}
