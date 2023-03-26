using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttendantStudentController: ControllerBase
    {

        [HttpGet("all-department-representatives")]
        public List<Student> GetAllDepartmentRepresentatives()
        {
            return null;
        }

        [HttpGet("all-faculty-representatives")]
        public List<Student> GetAllFacultyRepresentatives()
        {
            return null;
        }

        [HttpPost("add-department-representative")]
        public Student CreateDepartmentRepresentative([FromQuery] int studentId)
        {
            return null;
        }

        [HttpPost("add-faculty-representative")]
        public Student CreateFacultyRepresentative([FromQuery] int studentId)
        {
            return null;
        }

        [HttpDelete("remove-department-representative/{id}")]
        public bool DeleteDepartmentRepresentativeById(int id)
        {
            return false;
        }

        [HttpDelete("remove-faculty-representative/{id}")]
        public bool DeleteFacultyRepresentativeById(int id)
        {
            return false;
        }

    }
}
