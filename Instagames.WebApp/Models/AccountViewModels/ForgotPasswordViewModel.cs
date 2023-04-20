using System.ComponentModel.DataAnnotations;

namespace Instagames.WebApp.Models.AccountViewModels
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
