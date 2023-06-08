using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class DepartmentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FacultyResponse Faculty { get; set; }

        public DepartmentResponse() { }

        public DepartmentResponse(Department department)
        {
            Id = department.Id;
            Name = department.Name;

            if(department.Faculty != null)
            {
                Faculty = new FacultyResponse(department.Faculty);
            }
        }

    }

}
