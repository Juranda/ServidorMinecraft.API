using Microsoft.AspNetCore.Mvc;
using ServidorMinecraft.API.Models.DTO.Authentication;
using ServidorMinecraft.API.Repositories;

namespace ServidorMinecraft.API.Controllers
{
    [ApiController]
    [Route("login")]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly ITokenHandler tokenHandler;

        public AuthController(IUserRepository userRepository, ITokenHandler tokenHandler)
        {
            this.userRepository = userRepository;
            this.tokenHandler = tokenHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequest userLoginRequest)
        {
            var user = await userRepository.AuthenticateUserAsync(userLoginRequest.Username, userLoginRequest.Password);

            if (user is null) return BadRequest("Username or Password incorrect");

            var token = await tokenHandler.CreateTokenAsync(user);

            return Ok(token);
        }
    }
}
