using Election_System.Enumerations;

namespace Election_System.Models
{
    public class AttendantStudent
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public ProcessType ProcessType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }

}
