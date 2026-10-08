using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Dtos.Auth
{
    public class LoginRequestDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
