using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

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
        public List<CandidateResponse> GetAll()
        {
            return _candidateService.GetAll();
        }
        [HttpGet("/candidates/{id}")]
        public List<CandidateResponse> GetCandidatesByDepartmentId(int id)
        {
            return _candidateService.GetCandidatesByDepartmentId(id);
        }

    }
}
