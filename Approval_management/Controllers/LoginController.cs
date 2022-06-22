using Approval_management.DataModel.Entities;
using Approval_management.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Approval_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController: ControllerBase
    {
        readonly IUserInfoService _userService;
        private readonly IConfiguration _config;
        readonly ITokenService _tokenService;
        public LoginController(IConfiguration config, IUserInfoService userService, ITokenService tokenService)
        {
            _config = config;
            _userService = userService;
            _tokenService = tokenService;
        }
        [HttpPost]
        public IActionResult Login([FromBody] UserInfo login)
        {
            IActionResult response = Unauthorized();
            UserInfo user = _userService.AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = _tokenService.CreateToken(user);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }

            return response;
        }
    }
    
}
