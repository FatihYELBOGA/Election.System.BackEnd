namespace Election.System.BackEnd.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdministrationId { get; set;  }
        public Administration Administration { get; set; }

    }
}
