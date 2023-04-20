using System.ComponentModel.DataAnnotations;
using Instagames.Entities;

namespace Instagames.WebApp.Models.HomeViewModel
{
    public class PricingPlanViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        public Plan? SubscribePlan { get; set; }
    }
}