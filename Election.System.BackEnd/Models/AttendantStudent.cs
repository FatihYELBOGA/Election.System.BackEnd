namespace Election.System.BackEnd.Models
{
    public class AttendantStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
