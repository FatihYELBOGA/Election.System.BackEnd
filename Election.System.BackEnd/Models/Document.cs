using Election.System.BackEnd.Enumerations;

namespace Election.System.BackEnd.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public byte[] DocumentBytes { get; set; }
        public string Document_Type { get; set; }
        public DateTime Upload_Time { get; set; }
        public DocumentReason DocumentReason { get; set; }
        public ControlStatus ControlStatus { get; set; }

    }
}
