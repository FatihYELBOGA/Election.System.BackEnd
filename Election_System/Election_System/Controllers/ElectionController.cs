using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ElectionController : ControllerBase
    {
        private IElectionService _electionService;
        public ElectionController(IElectionService electionService)
        {
            _electionService = electionService;
        }

        [HttpPost("/elections/vote-for-department-representative")]
        public StudentResponse AddVoteForDepartmentRepresentative([FromBody] VoteOfDepartmentRepresentativeRequest vote)
        {
            return _electionService.AddVoteForDepartmentRepresentative(vote);
        }

        [HttpGet("/elections/results/{departmentId}")]
        public List<ElectionResultResponse> GetElectionResultsForDepartmentRepresentative(int departmentId)
        {
            return _electionService.GetElectionResultsForDepartmentRepresentative(departmentId);
        }

        [HttpGet("/elections/{voterId}")]
        public StudentResponse GetCandidateForDepartmentRepresentative(int voterId)
        {
            return _electionService.GetCandidateForDepartmentRepresentative(voterId);
        }

        [HttpDelete("/elections")]
        public int RemoveAll()
        {
            return _electionService.RemoveAll();
        }

    }

}
