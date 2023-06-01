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
        public List<ProcessResponse> GetAll() 
        { 
            return _processService.GetAll();
        }

        [HttpGet("/processes/active")]
        public List<ProcessResponse> GetActives()
        {
            return _processService.GetActives();
        }

        [HttpGet("/processes/started-department-candidacy")]
        public ProcessResponse GetStartedDepartmentCandidacy()
        {
            return _processService.GetStartedDepartmentCandidacy();
        }

        [HttpGet("/processes/will-start-department-candidacy")]
        public ProcessResponse GetWillStartDepartmentCandidacy()
        {
            return _processService.GetWillStartDepartmentCandidacy();
        }

        [HttpPost("/processes")]
        public ProcessResponse Add([FromBody] ProcessRequest processRequest)
        {
            return _processService.Add(processRequest);
        }

        [HttpPut("/processes/{id}")]
        public ProcessResponse Update(int id, [FromBody] ProcessRequest processRequest)
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
