using System.ComponentModel.DataAnnotations;

namespace Instagames.WebApi.Models.AccountViewModels
{
    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "External access token")]
        public string ExternalAccessToken { get; set; }
    }
}