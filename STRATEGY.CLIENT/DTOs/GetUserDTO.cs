using System.ComponentModel.DataAnnotations;

namespace STRATEGY.CLIENT.DTOs
{
    public class GetUserDTO
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
        public string RoleName { get; set; } = string.Empty;
        public IList<int> PermissionId { get; set; }
        public int DepartmentId { get; set; }
    }
}
