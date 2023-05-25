using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : Controller
    {
        private readonly IProcessService _processService;

        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }

        [HttpGet("/processes")]
        public List<ProcessResponse> GetAllProcesses() 
        { 
            return _processService.GetAllProcesses();
        }

        [HttpPost("/processes")]
        public ProcessResponse Add([FromForm] ProcessRequest processRequest)
        {
            return _processService.Add(processRequest);
        }

        [HttpPut("/processes/{id}")]
        public ProcessResponse Update(int id, [FromForm] ProcessRequest processRequest)
        {
            return _processService.Update(id, processRequest);
        }

        [HttpDelete("/processes/{id}")]
        public bool Remove(int id)
        {
            return _processService.Remove(id);
        }
    }
}
