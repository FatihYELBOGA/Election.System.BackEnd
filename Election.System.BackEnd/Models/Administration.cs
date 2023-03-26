namespace Election.System.BackEnd.Models
{
    public class Administration
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Born { get; set; }
        public string Gender { get; set; }
        public int RoleId { get; set; }
        public Role role { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
