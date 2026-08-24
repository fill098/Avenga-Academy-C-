using System.ComponentModel.DataAnnotations;

namespace RentWaveApp.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Please enter your card number.")]
        public string CardNumber { get; set; }
    }
}
