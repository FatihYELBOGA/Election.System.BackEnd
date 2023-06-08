using Election_System.DTO.Responses;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public List<DepartmentResponse> GetAll()
        {
            return _departmentRepository.GetAll();
        }

    }

}
