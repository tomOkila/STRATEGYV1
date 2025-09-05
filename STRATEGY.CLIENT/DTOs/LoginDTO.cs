using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.DTOs
{
    public class LoginDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
