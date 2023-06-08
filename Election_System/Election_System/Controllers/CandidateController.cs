using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;
using Election_System.Models;
using Election_System.Enumerations;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet("/candidates")]
        public List<StudentResponse> GetAll(ProcessType process)
        {
            return _candidateService.GetAll(process);
        }

        [HttpPost("/candidates/{id}")]
        public StudentResponse Add(int id, ProcessType process)
        {
            return _candidateService.Add(id, process);
        }

        [HttpDelete("/candidates/{id}")]
        public bool Remove(int id)
        {
            return _candidateService.Remove(id);
        }

        [HttpDelete("/candidates")]
        public int RemoveAll()
        {
            return _candidateService.RemoveAll();
        }

    }
}
