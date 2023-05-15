using Election_System.Enumerations;

namespace Election_System.DTO.Responses
{
    public class StudentResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public Gender? Gender { get; set; }
        public float GPA { get; set; }

    }

}
