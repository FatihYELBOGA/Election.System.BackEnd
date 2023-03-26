using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class StudentController: ControllerBase
    {
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return null;
        }

        [HttpGet("student-by-id/{id}")]
        public Student GetById(int id)
        {
            return null;
        }

        [HttpGet("your-voter")]
        public Student GetVoter()
        {
            return null;
        } 

        [HttpPost("vote")]
        public bool Vote([FromQuery] int candidateStudentId)
        {
            return false;
        }

        [HttpPut("change-student-role")]
        public Student ChangeStudentRole([FromBody] Student student)
        {
            return null;
        }

    }

}
