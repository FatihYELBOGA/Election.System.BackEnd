using Election_System.Enumerations;
using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class CandidateResponse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        public string? DepartmentName { get; set; }
        public DateTime CandidacyDate { get; set; }
        public ProcessType ProcessType { get; set; }
        

    }
}
