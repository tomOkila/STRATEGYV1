namespace STRATEGY.CLIENT.DTOs
{
    public record UserClaimsDTO(string Fullname = null!, string UserName = null!, string Email = null!, string Role = null!, string RoleName = null!, string PermissionData = null!, int userId = 0);
}
