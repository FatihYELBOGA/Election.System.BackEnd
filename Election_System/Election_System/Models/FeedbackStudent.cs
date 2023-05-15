namespace Election_System.Models
{
    public class FeedbackStudent
    {
        public int Id { get; set; }
        public int? FeedbackId { get; set; }
        public Feedback? Feedback { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }

    }

}
