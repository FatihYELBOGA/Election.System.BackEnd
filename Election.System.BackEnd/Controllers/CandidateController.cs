using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CandidateController: ControllerBase
    {

        [HttpGet("department-representative-candidates/{id}")]
        public List<Student> GetAllDepartmentRepresentativeCandidates()
        {
            return null;
        }

        [HttpGet("faculty-representative-candidates/{id}")]
        public List<Student> GetAllFacultyRepresentativeCandidates()
        {
            return null;
        }

        [HttpPost("add-department-representative-candidate")]
        public Student CreateDepartmentRepresentativeCandidate([FromQuery] int studentId)
        {
            return null;
        }

        [HttpPost("add-faculty-representative-candidate")]
        public Student CreateFacultyRepresentativeCandidate([FromQuery] int studentId)
        {
            return null;
        }

        [HttpDelete("remove-department-representative-candidate/{id}")]
        public bool DeleteDepartmentRepresentativeCandidateById(int id)
        {
            return false;
        }

        [HttpDelete("remove-faculty-representative-candidate/{id}")]
        public bool DeleteFacultyRepresentativeCandidateById(int id)
        {
            return false;
        }

    }
}
