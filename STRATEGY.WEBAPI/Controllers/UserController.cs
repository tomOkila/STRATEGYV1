using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using STRATEGY.CLIENT.DTOs;
using STRATEGY.WEBAPI.Contract;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsApi")]
    public class UserController(IUser user) : ControllerBase
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponse>> LogUserIn(LoginDTO loginDTO)
        {
            var result = await user.LoginUserAsync(loginDTO);
            return Ok(result);
        }


        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<RegisterUserDTO>> RegisterUser(RegisterUserDTO registerUserDTO)
        {
            var result = await user.RegisterUserAsync(registerUserDTO);
            return Ok(result);
        }


        [HttpGet("userlist")]
        public async Task<ActionResult<List<RegisterUserDTO>>> GetUsers()
        {
            var result = await user.GetUsersAsync();
            return Ok(result);
        }

        [HttpPut("updateuser")]
        public async Task<IActionResult> UpdateUserRoleAsync([FromBody] RegisterUserDTO applicationUsers)
        {
            var result = await user.UpdateUserAsync(applicationUsers);
            return Ok(result);
        }

        [HttpPost("deleteUser")]
        public async Task<IActionResult> DeleteUserAsync(AppUsers model)
        {
            var result = await user.DeleteUserAsync(model);
            return Ok(result);
        }

        [HttpPost("createRole")]
        public async Task<ActionResult<RegisterUserDTO>> CreateRoleAsync(AppRoles model)
        {
            var result = await user.CreateRoleAsync(model);
            return Ok(result);
        }

        [HttpGet("rolelist")]
        public async Task<ActionResult<List<AppRoles>>> GetRolesAsync()
=> Ok(await user.GetRolesAsync());

        [HttpPut("updaterole")]
        public async Task<IActionResult> UpdateUserRoleAsync([FromBody] AppRoles applicationUsers)
        {
            var result = await user.UpdateUserRoleAsync(applicationUsers);
            return Ok(result);
        }

        [HttpPost("deleteRole")]
        public async Task<IActionResult> DeleteRoleAsync(AppRoles model)
        {
            var result = await user.DeleteRoleAsync(model);
            return Ok(result);
        }

        [HttpPost("createPermission")]
        public async Task<ActionResult<Permissions>> CreatePermissionsAsync(Permissions model)
        {
            var result = await user.CreatePermissionsAsync(model);
            return Ok(result);
        }

        [HttpGet("permissionslist")]
        public async Task<ActionResult<List<Permissions>>> GetPermissionsAsync()
=> Ok(await user.GetPermissionsAsync());

        [HttpPut("updatePermission")]
        public async Task<IActionResult> UpdatePermissionsAsync([FromBody] Permissions model)
        {
            var result = await user.UpdatePermissionsAsync(model);
            return Ok(result);
        }

        [HttpPost("deletePermission")]
        public async Task<IActionResult> DeletePermissionsAsync(Permissions model)
        {
            var result = await user.DeletePermissionsAsync(model);
            return Ok(result);
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<GeneralResponse>> RefreshToken(PostToken model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model cannot be null");

            return Ok(await user.RefreshTokenAsync(model));
        }
    }
}
