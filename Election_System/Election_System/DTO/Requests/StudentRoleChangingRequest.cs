using Election_System.Enumerations;

namespace Election_System.DTO.Requests
{
    public class StudentRoleChangingRequest
    {
        public int StudentId { get; set; }
        public Role Role { get; set; }

    }

}
