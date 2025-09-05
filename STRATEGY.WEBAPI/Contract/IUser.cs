using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.WEBAPI.Contract
{
    public interface IUser
    {
        Task<GeneralResponse> RegisterUserAsync(RegisterUserDTO model);
        Task<LoginResponse> LoginUserAsync(LoginDTO loginDTO);
        Task<TokenResponse> RefreshTokenAsync(PostToken model);
        Task<List<GetUserDTO>> GetUsersAsync();
        Task<GeneralResponse> UpdateUserAsync(RegisterUserDTO model);
        Task<GeneralResponse> DeleteUserAsync(AppUsers model);
        Task<GeneralResponse> CreateRoleAsync(AppRoles model);
        Task<List<AppRoles>> GetRolesAsync();
        Task<GeneralResponse> UpdateUserRoleAsync(AppRoles approles);
        Task<GeneralResponse> DeleteRoleAsync(AppRoles model);
        Task<GeneralResponse> CreatePermissionsAsync(Permissions model);
        Task<List<Permissions>> GetPermissionsAsync();
        Task<GeneralResponse> UpdatePermissionsAsync(Permissions approles);
        Task<GeneralResponse> DeletePermissionsAsync(Permissions model);
    }
}
