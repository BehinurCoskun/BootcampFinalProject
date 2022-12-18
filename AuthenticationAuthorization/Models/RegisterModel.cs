using System.ComponentModel.DataAnnotations;

namespace AuthenticationAuthorization.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        public string? PhoneNumber { get; set; }

        public string? TC { get; set; } 

        public string? Plate { get; set; }

    }
}
