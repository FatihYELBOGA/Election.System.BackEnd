using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IDepartmentService
    {
        public List<DepartmentResponse> GetAll();

    }

}
