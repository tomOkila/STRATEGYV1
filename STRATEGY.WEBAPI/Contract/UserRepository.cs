using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using STRATEGY.CLIENT.DTOs;
using STRATEGY.WEBAPI.Data;
using STRATEGY.CLIENT.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace STRATEGY.WEBAPI.Contract
{
    public class UserRepository(AppDbContext _appDbContext, IConfiguration _config) : IUser
    {
        public async Task<GeneralResponse> CreateRoleAsync(AppRoles model)
        {
            var response = await FindRoleByNameAsync(model.RoleName);
            if (response != null)
            {
                return new GeneralResponse(false, "Role already exists");
            }
            _appDbContext.Roles.Add(new AppRoles()
            {
                RoleName = model.RoleName,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Role Added Successfully");
        }

        public async  Task<GeneralResponse> DeleteRoleAsync(AppRoles model)
        {
            var role = await _appDbContext.Roles.FindAsync(model.Id);
            if (role == null)
                return new GeneralResponse(false, "Role not found");
            _appDbContext.Roles.Remove(role);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Deleted");
        }

        public async Task<GeneralResponse> DeleteUserAsync(AppUsers model)
        {
            var user = await _appDbContext.Users.FindAsync(model.UserId);
            if (user == null)
                return new GeneralResponse(false, "User not found");
            var resultuser = _appDbContext.Users.Remove(user);
            if (resultuser != null)
            {
                await DeleteUserRoleAsync(model.UserId);
            }
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Deleted");
        }

        public async Task<List<AppRoles>> GetRolesAsync() =>
    await _appDbContext.Roles.ToListAsync();

        public async Task<List<GetUserDTO>> GetUsersAsync()
        {
            var result = (from a in _appDbContext.Users
                          join c in _appDbContext.UserRoles on a.UserId equals c.UserId
                          join d in _appDbContext.Roles on c.RoleId equals d.Id
                          join e in _appDbContext.Departments on a.DepartmentId equals e.DepartmentId

                          select new { Users = a, UserRoles = c, Roles = d, Departments = e });

            List<GetUserDTO> response1 = new List<GetUserDTO>();
            foreach (var user in result)
            {
                GetUserDTO response = new GetUserDTO();
                response.Id = user.Users.UserId;
                response.Name = user.Users.Name;
                response.Email = user.Users.Email;
                response.RoleId = user.UserRoles.RoleId;
                response.RoleName = user.Roles.RoleName;
                response.PermissionId = user.UserRoles.PermissionId;
                response.DepartmentId = user.Departments.DepartmentId;
                response.ProfileImage = user.Users.ProfileImage;
                response1.Add(response);
            }

            return response1.ToList();
        }

        public async Task<LoginResponse> LoginUserAsync(LoginDTO loginDTO)
        {
            AppUsers getUser = new AppUsers();
            getUser = await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email == loginDTO.Email);
            if (getUser == null) return new LoginResponse(false, "User not found,Sorry");

            bool checkPassword = BCrypt.Net.BCrypt.Verify(loginDTO.Password, getUser.Password);
            if (checkPassword)
            {
                //get user role
                var getUserRole = await FindUserRole(getUser.UserId);
                if (getUserRole is null) return new LoginResponse(false, "user role not found");

                //get role name
                var getRoleName = await FindRoleName(getUserRole.RoleId);
                if (getRoleName is null) return new LoginResponse(false, "user role name not found");

                string refreshToken = GenerateRefreshToken();
                var resultToken = await GenerateJWTToken(getUser);

                //clear refresh tokens
                _appDbContext.RefreshTokens.RemoveRange(_appDbContext.RefreshTokens.Where(x => x.UserID == getUser.UserId.ToString()));
                _appDbContext.SaveChanges();

                //log refresh token
                await AddToDatabase(new RefreshToken() { UserID = getUser.UserId.ToString(), Token = refreshToken, CreateDate = DateTime.Now });

                return new LoginResponse(true, "Login successful", resultToken, refreshToken);
            }
            else
            {
                return new LoginResponse(false, "Invalid Credentials");
            }
            

        }

        public async Task<TokenResponse> RefreshTokenAsync(PostToken model)
        {
            var token = await _appDbContext.RefreshTokens.FirstOrDefaultAsync(t => t.Token == model.RefreshToken);
            if (token == null)
            {
                var token1 = await _appDbContext.RefreshTokens.FirstOrDefaultAsync(t => t.UserID == model.SessionUserId.ToString());
                token = token1;
                //return new TokenResponse();
            }
            var user = await _appDbContext.Users.FindAsync(Convert.ToInt32(token.UserID));
            string newToken = await GenerateJWTToken(user!);
            string newRefreshToken = GenerateRefreshToken();
            var saveResult = await SaveRefreshToken(user!.UserId.ToString(), newRefreshToken);
            if (saveResult.Flag) return new TokenResponse("Refresh Token", newToken, newRefreshToken);
            else
                return new TokenResponse();
        }

        public async Task<GeneralResponse> RegisterUserAsync(RegisterUserDTO model)
        {
            var getUser = await FinduserByEmailAsync(model.Email);
            if (getUser != null)
            {
                return new GeneralResponse(false, "User already exists");
            }

            var getDepartment = await FindDepartmentByID(model.DepartmentId);
            if (getDepartment == null)
            {
                return new GeneralResponse(false, "Department selected doesn't exist");
            }

            var getRole= await FindRoleName(model.RoleId);
            if (getRole == null)
            {
                return new GeneralResponse(false, "Role selected doesn't exist");
            }

            //foreach (var item in model.PermissionId)
            //{
            //    var getPermission = await FindPermissionByID(item);
            //    if (getPermission == null)
            //    {
            //        return new GeneralResponse(false, "Permission selected doesn't exist");
            //    }
            //}

            var getPermission = await FindPermissionByID(model.PermissionId);
            if (getPermission == null)
            {
                return new GeneralResponse(false, "Permission selected doesn't exist");
            }


            if (!string.IsNullOrEmpty(model.ProfileImageName))
            {
                Byte[] bytes = Convert.FromBase64String(model.ProfileImage);
                File.WriteAllBytes(_config.GetConnectionString("PROFILEPIC_UPLOADFILE_PATH") + model.ProfileImageName, bytes);
                //assign photo details
                model.ProfileImage = _config.GetConnectionString("PROFILEPIC_UPLOADFILE_DBPATH") + model.ProfileImageName;
            }


            _appDbContext.Users.Add(new AppUsers()
            {
                Name = model.Name,
                Email = model.Email,
                DepartmentId = model.DepartmentId,
                ProfileImage=model.ProfileImage,
                Password = BCrypt.Net.BCrypt.HashPassword(model.Password),
                CreateDate = DateTime.Now
            });

            var response = await _appDbContext.SaveChangesAsync();
            if (response > 0)
            {
                //check that the permision exist
                //foreach (var userPermissionId in model.PermissionId)
                //{
                //    var userPermission = await _appDbContext.Permissions.FirstOrDefaultAsync(u => u.PermissionId == userPermissionId);
                //    if (userPermission == null)
                //    {
                //        return new GeneralResponse(false, "Unable to complete registration at the moment. Please confirm the permission");
                //    }
                //}

                var userPermission = await _appDbContext.Permissions.FirstOrDefaultAsync(u => u.PermissionId == model.PermissionId);
                if (userPermission == null)
                {
                    return new GeneralResponse(false, "Unable to complete registration at the moment. Please confirm the permission");
                }

                var userrole = await _appDbContext.Roles.FirstOrDefaultAsync(u => u.Id == model.RoleId);
                if (userrole == null) return new GeneralResponse(false, "Unable to complete registration at the moment. Please confirm the roles");
                await AssignUserToRole(new AppUsers() { Name = model.Name, Email = model.Email }, new AppRoles() { RoleName = userrole.RoleName }, model.PermissionId);
                return new GeneralResponse(true, "Registration completed");
            }
            else
            {
                return new GeneralResponse(false, "Unable to complete registration at this time");
            }
          
        }

        public async Task<GeneralResponse> UpdateUserAsync(RegisterUserDTO model)
        {
            var getUser = await FinduserByEmailandIFAsync(model.Email, model.Id);
            if (getUser == null)
            {
                return new GeneralResponse(false, "User doesn't exists. Kindly recheck and try again!");
            }


            if (!string.IsNullOrEmpty(model.ProfileImageName))
            {
                Byte[] bytes = Convert.FromBase64String(model.ProfileImage);
                File.WriteAllBytes(_config.GetConnectionString("PROFILEPIC_UPLOADFILE_PATH") + model.ProfileImageName, bytes);
                //assign photo details
                model.ProfileImage = _config.GetConnectionString("PROFILEPIC_UPLOADFILE_DBPATH") + model.ProfileImageName;
            }

            //update users
            AppUsers appuseredit = new AppUsers();
            appuseredit.Name = model.Name;
            appuseredit.Email = model.Email;
            appuseredit.UserId = model.Id;
            appuseredit.DepartmentId = model.DepartmentId;
            appuseredit.ProfileImage = model.ProfileImage;
            appuseredit.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
            appuseredit.CreateDate = getUser.CreateDate;
            appuseredit.UpdatedDate = DateTime.Now;

            //check that the permision exist
            //foreach (var userPermissionId in model.PermissionId)
            //{
            //    var userPermission = await _appDbContext.Permissions.FirstOrDefaultAsync(u => u.PermissionId == userPermissionId);
            //    if (userPermission == null)
            //    {
            //        return new GeneralResponse(false, "Unable to complete update at the moment. Please confirm the permission");
            //    }
            //}

            var userPermission = await _appDbContext.Permissions.FirstOrDefaultAsync(u => u.PermissionId == model.PermissionId);
            if (userPermission == null)
            {
                return new GeneralResponse(false, "Unable to complete update at the moment. Please confirm the permission");
            }

            //check the role
            var responserole = await _appDbContext.Roles.FirstOrDefaultAsync(u => u.Id == model.RoleId);
            if (responserole == null) return new GeneralResponse(false, "Unable to complete update at the moment. Please confirm the roles");


            _appDbContext.ChangeTracker.Clear();
            //update roles
            var userrole = await _appDbContext.UserRoles.FirstOrDefaultAsync(u => u.UserId == model.Id);
            if (userrole!.UserId > 0)
                _appDbContext.UserRoles.Remove(userrole);
                await _appDbContext.SaveChangesAsync();

            UserRoles userRoleEdit = new UserRoles();
            userRoleEdit.UserId = model.Id;
            userRoleEdit.RoleId = model.RoleId;
            userRoleEdit.PermissionId = model.PermissionId;
            userRoleEdit.CreateDate = userrole.CreateDate; 
            userRoleEdit.UpdatedDate = DateTime.Now;
            _appDbContext.UserRoles.Add(userRoleEdit);

            //update users
            _appDbContext.Users.Update(appuseredit);


            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Updated");
        }

        public async Task<GeneralResponse> UpdateUserRoleAsync(AppRoles approles)
        {
            _appDbContext.Roles.Update(approles);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Updated");
        }


        public async Task<GeneralResponse> CreatePermissionsAsync(Permissions model)
        {
            var response = await FindPermissionByNameAsync(model.PermissionName);
            if (response != null)
            {
                return new GeneralResponse(false, "Permission already exists");
            }
            _appDbContext.Permissions.Add(new Permissions()
            {
                PermissionName = model.PermissionName,
                CreateDate = DateTime.Now
            });
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Permission Added Successfully");
        }

        public async Task<List<Permissions>> GetPermissionsAsync() =>
    await _appDbContext.Permissions.ToListAsync();

        public async Task<GeneralResponse> UpdatePermissionsAsync(Permissions approles)
        {

            _appDbContext.Permissions.Update(approles);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Updated");
        }

        public async Task<GeneralResponse> DeletePermissionsAsync(Permissions model)
        {
            var role = await _appDbContext.Permissions.FindAsync(model.PermissionId);
            if (role == null)
                return new GeneralResponse(false, "Permission not found");
            _appDbContext.Permissions.Remove(role);
            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, "Deleted");
        }


        private async Task<AppRoles> FindRoleByNameAsync(string roleName)
 => await _appDbContext.Roles.FirstOrDefaultAsync(u => u.RoleName == roleName);

        private async Task<Permissions> FindPermissionByNameAsync(string permissionName)
=> await _appDbContext.Permissions.FirstOrDefaultAsync(u => u.PermissionName == permissionName);

        public async Task<GeneralResponse> DeleteUserRoleAsync(int id)
    {
        var userrole = await _appDbContext.UserRoles.FirstOrDefaultAsync(u => u.UserId == id);
        if (userrole == null)
            return new GeneralResponse(false, "UserRole not found");
        _appDbContext.UserRoles.Remove(userrole);
        await _appDbContext.SaveChangesAsync();
        return new GeneralResponse(true, "Deleted");
    }
    private async Task<string> GenerateJWTToken(AppUsers user)
    {
        try
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSection:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var userPermission = await FindUserPermissionByID(user.UserId);
            var roleID = FindUserRole(user.UserId).Result.RoleId;
            var roleName = FindRoleName(roleID).Result.RoleName;
            var sysPermission = await FindPermissionByID(userPermission.PermissionId);

           var userClaims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
            new Claim(ClaimTypes.Name,user.Name),
            new Claim(ClaimTypes.Email,user.Email),
            new Claim(ClaimTypes.Role,roleID.ToString().Trim()),
            new Claim(ClaimTypes.Thumbprint,user.ProfileImage.ToString().Trim()),
            new Claim(ClaimTypes.StreetAddress,roleName.ToString().Trim()),
            new Claim(ClaimTypes.Surname,user.DepartmentId.ToString().Trim()),
            new Claim(ClaimTypes.Country,sysPermission.Create.ToString().Trim()),
            new Claim(ClaimTypes.Locality,sysPermission.Update.ToString().Trim()),
            new Claim(ClaimTypes.StateOrProvince,sysPermission.Delete.ToString().Trim()),
            };

            var token = new JwtSecurityToken(
                issuer: _config["JwtSection:Issuer"],
                audience: _config["JwtSection:Audience"],
                claims: userClaims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        catch { return null!; }
    }

    public static string GenerateRefreshToken() =>
    Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

    private async Task<GeneralResponse> SaveRefreshToken(string userId, string token)
    {
        try
        {
            var user = await _appDbContext.RefreshTokens.FirstOrDefaultAsync(t => t.UserID == userId);
            if (user == null)
                _appDbContext.RefreshTokens.Add(new RefreshToken() { UserID = userId, Token = token });
            else
                user.Token = token;

            await _appDbContext.SaveChangesAsync();
            return new GeneralResponse(true, null!);
        }
        catch (Exception ex)
        {
            return new GeneralResponse(false, ex.Message);
        }
    }


        private async Task<UserRoles> FindUserRole(int userId) =>
        await _appDbContext.UserRoles.FirstOrDefaultAsync(_ => _.UserId == userId);

    private async Task<AppRoles> FindRoleName(int roleId) =>
        await _appDbContext.Roles.FirstOrDefaultAsync(_ => _.Id == roleId);

    private async Task<AppUsers> FinduserByEmailAsync(string email)
     => await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
    private async Task<Department> FindDepartmentByID(int DepartmentID)
         => await _appDbContext.Departments.FirstOrDefaultAsync(u => u.DepartmentId == DepartmentID);

    private async Task<Permissions> FindPermissionByID(int PermissionID)
     => await _appDbContext.Permissions.FirstOrDefaultAsync(u => u.PermissionId == PermissionID);

        private async Task<UserRoles> FindUserPermissionByID(int UserID)
     => await _appDbContext.UserRoles.FirstOrDefaultAsync(u => u.UserId == UserID);


        private async Task<AppUsers> FinduserByEmailandIFAsync(string email, int Id)
     => await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email == email && u.UserId == Id);

        private async Task<T> AddToDatabase<T>(T model)
    {
        var result = _appDbContext.Add(model);
        await _appDbContext.SaveChangesAsync();
        return (T)result.Entity;
    }


    public async Task<GeneralResponse> AssignUserToRole(AppUsers user, AppRoles role, int  PermissionId)
    {

        //get the related IDs for role and user
        var userIDDetails = await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
        var userRoleDetails = await _appDbContext.Roles.FirstOrDefaultAsync(u => u.RoleName == role.RoleName);

        var userResult = await _appDbContext.UserRoles.FindAsync(userIDDetails!.UserId);
        if (userResult != null)
            return new GeneralResponse(false, "Role already assigned to the user");

        UserRoles userRole = new();
        userRole.UserId = Convert.ToInt32(userIDDetails.UserId);
        userRole.RoleId = Convert.ToInt32(userRoleDetails.Id);
        userRole.PermissionId = PermissionId;
        userRole.CreateDate = DateTime.Now;
        _appDbContext.UserRoles.Add(userRole);
        await _appDbContext.SaveChangesAsync();
        return new GeneralResponse(true, "Saved Successfully");
    }

     
    }

}
