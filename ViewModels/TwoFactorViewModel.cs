using System.ComponentModel.DataAnnotations;

namespace GiftOfTheGivers.ViewModels
{
    public class TwoFactorViewModel
    {
        [Required]
        [Display(Name = "Security Code")]
        public string Code { get; set; }

        [Display(Name = "Remember this device?")]
        public bool RememberClient { get; set; }
    }
}
