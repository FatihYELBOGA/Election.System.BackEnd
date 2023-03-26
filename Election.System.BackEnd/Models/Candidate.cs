using Election.System.BackEnd.Enumerations;

namespace Election.System.BackEnd.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public int CandidateStudentId { get; set; }
        public Student CandidateStudent { get; set; }
        public DateTime CandidacyDate { get; set; }
        public ElectionType ElectionType { get; set; }

    }
}
