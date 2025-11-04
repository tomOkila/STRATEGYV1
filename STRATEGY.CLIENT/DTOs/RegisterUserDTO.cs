using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.DTOs
{
    public class RegisterUserDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required, Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
        public int RoleId { get; set; }
        //public IList<int> PermissionId { get; set; }
        public int PermissionId { get; set; }
        public int DepartmentId { get; set; }

        public string ProfileImage { get; set; } = string.Empty;
        public string ProfileImageName { get; set; } = string.Empty;
    }
}
