using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.CLIENT.Services
{
    public interface IUserService
    {
        Task<GeneralResponse> RegisterUserAsync(RegisterUserDTO model);
        Task<LoginResponse> LoginUserAsync(LoginDTO loginDTO);
        Task<LoginResponse> RefreshTokenAsync(PostToken model);
        Task<List<GetUserDTO>> GetUsersAsync(int SessionUserId);
        Task<GeneralResponse> UpdateUserAsync(RegisterUserDTO model, int SessionUserId);
        Task<GeneralResponse> DeleteUserAsync(AppUsers model);
        Task<GeneralResponse> CreateRoleAsync(AppRoles model);
        Task<List<AppRoles>> GetRolesAsync(int SessionUserId);
        Task<GeneralResponse> UpdateUserRoleAsync(AppRoles model);
        Task<GeneralResponse> DeleteRoleAsync(AppRoles model);
        Task<GeneralResponse> CreatePermissionsAsync(Permissions model);
        Task<List<Permissions>> GetPermissionsAsync(int SessionUserId);
        Task<GeneralResponse> UpdatePermissionsAsync(Permissions model);
        Task<GeneralResponse> DeletePermissionsAsync(Permissions model);
    }
}
