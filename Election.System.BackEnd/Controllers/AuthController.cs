using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{
    public class AuthController
    {

        [HttpPost("login")]
        public void LogIn([FromBody] string username, [FromBody] string password)
        {

        }

    }
}
