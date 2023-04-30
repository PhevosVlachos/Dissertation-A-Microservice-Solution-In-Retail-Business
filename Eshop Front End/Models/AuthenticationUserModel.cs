using System.ComponentModel.DataAnnotations;

namespace Eshop_Front_End.Models
{
    public class AuthenticationUserModel
    {

        [Required(ErrorMessage = "Email Address is required.")]
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
