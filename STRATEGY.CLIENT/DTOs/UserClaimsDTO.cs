namespace STRATEGY.CLIENT.DTOs
{
    public record UserClaimsDTO(string Fullname = null!, string UserName = null!, string Email = null!, string Role = null!, string RoleName = null!, string PermissionCreate = null!, string PermissionUpdate = null!, string PermissionDelete = null!, string DepartmentID = null!, int userId = 0);
}
