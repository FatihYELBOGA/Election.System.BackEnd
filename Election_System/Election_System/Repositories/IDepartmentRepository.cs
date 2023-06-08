using Election_System.DTO.Responses;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        public List<DepartmentResponse> GetAll();

    }

}
