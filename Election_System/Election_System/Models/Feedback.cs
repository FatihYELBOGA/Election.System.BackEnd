namespace Election_System.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostTime { get; set; }
        public int? AdministrationId { get; set; }
        public Administration? Administration { get; set; }
        public List<FeedbackStudent> FeedbackStudents { get; set; }

    }

}
