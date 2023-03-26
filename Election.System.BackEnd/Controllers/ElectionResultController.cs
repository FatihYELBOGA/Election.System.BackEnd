using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ElectionResultController: ControllerBase
    {

        [HttpGet("election-result")]
        public List<ElectionResult> GetElectionResult()
        {
            return null;
        }

    }
}
