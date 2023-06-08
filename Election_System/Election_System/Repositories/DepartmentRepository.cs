using Election_System.Configurations;
using Election_System.DTO.Responses;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DataContext dataContext) : base(dataContext)
        {

        }

        List<DepartmentResponse> IDepartmentRepository.GetAll()
        {
            var query = GetDataContext().departments.
                GroupBy(d => new { d.Id, d.Name }).
                Select(g => new { id = g.Key.Id , departmentName = g.Key.Name });

            List<DepartmentResponse> departments = new List<DepartmentResponse>();
            foreach (var q in query)
            {
                departments.Add(new DepartmentResponse()
                {
                    Id = q.id,
                    Name = q.departmentName
                });
            }

            return departments;
        }
    }
}
