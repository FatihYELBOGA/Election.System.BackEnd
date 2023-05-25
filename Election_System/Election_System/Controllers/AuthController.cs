using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("/login")]
        public LoginResponse Login([FromBody] LoginRequest loginRequest)
        {
            return _authService.Login(loginRequest);
        }

    }
}
