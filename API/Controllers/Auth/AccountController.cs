using API.DomainModel;
using API.DTO;
using API.RequestModel;
using API.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Auth
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SignInManager<User> _signManger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signManger, RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager, IConfiguration config)
        {
            _signManger = signManger;
            _roleManager = roleManager;
            _userManager = userManager;
            _config = config;
        }

        [HttpPost]
        [Route("user-login")]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
            {
            var user = await _userManager.Users.Where(x=>x.UserName == login.Username).FirstOrDefaultAsync();

            if (user == null || !await _userManager.CheckPasswordAsync(user, login.Password))
            {
                return Unauthorized();
            }
            var token = Services.GenerateToken(user, _config);
            return Ok(new { tokens = token, login =true, user = new { Id = user.Id,user.Email,user.UserName } });
        }
       
        [HttpPost]
        [Route("UserRegister")]
        public async Task<IActionResult> Register([FromBody]UserRequestModel user)
        {
            var checkUser = await _userManager.FindByEmailAsync(user.Email);
            if (checkUser != null)
            {
                return BadRequest(new { message = "Account is already created by this mail" });
            }
            var userdetails = new User
            {
                UserName = user.UserName,
                Email = user.Email,
                EmailConfirmed = false,
                PhoneNumber =user.Phone
            };
            var result = await _userManager.CreateAsync(userdetails,user.Password);
            if (result.Succeeded)
            {
                return Ok(new { username = user.UserName, status = true, statusCode = StatusCodes.Status201Created });
            }
            return Ok(new {username = user.UserName, status = false, statusCode = StatusCodes.Status400BadRequest});
        }
    }
}
