using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RoleController: ControllerBase
    {

        [HttpGet]
        public List<Role> GetAllRoles()
        {
            return null;
        }

    }
}

