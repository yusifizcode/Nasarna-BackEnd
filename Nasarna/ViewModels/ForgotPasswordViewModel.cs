using System.ComponentModel.DataAnnotations;

namespace Nasarna.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
