using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AdministrationController: ControllerBase
    {

        [HttpGet("administration-by-id/{id}")]
        public Administration GetById(int id)
        {
            return null;
        }

    }
}
