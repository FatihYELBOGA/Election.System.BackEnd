namespace Election.System.BackEnd.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdministrationId { get; set; }
        public Administration Administration { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

    }
}
