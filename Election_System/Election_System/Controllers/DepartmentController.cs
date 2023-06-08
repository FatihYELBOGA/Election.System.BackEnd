using Election_System.DTO.Responses;
using Election_System.Repositories;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService) 
        {
            _departmentService = departmentService;
        }

        [HttpGet("/departments")]
        public List<DepartmentResponse> GetAll()
        {
            return _departmentService.GetAll();
        }

    }

}
