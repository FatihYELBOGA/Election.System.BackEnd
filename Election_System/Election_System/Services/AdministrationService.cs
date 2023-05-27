using Election_System.DTO;
using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Models;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class AdministrationService : IAdministrationService
    {
        private readonly IAdministrationRepository _administrationRepository;
        private readonly IStudentRepository _studentRepository;
        public AdministrationService(IAdministrationRepository administrationRepository, IStudentRepository studentRepository)
        {
            _administrationRepository = administrationRepository;
            _studentRepository = studentRepository;
        }

        public List<AdministrationResponse> GetAll()
        {
            List<AdministrationResponse> administrationResponses = new List<AdministrationResponse>();   
            foreach (var admin in _administrationRepository.GetAll())
            {
                administrationResponses.Add(new AdministrationResponse(admin));
            }

            return administrationResponses;
        }

        public AdministrationResponse GetById(int id)
        {
            return new AdministrationResponse(_administrationRepository.GetById(id));
        }

        public StudentResponse UpdateStudentRole(StudentRoleChangingRequest changingRequest)
        {
            Student student = _studentRepository.GetById(changingRequest.StudentId);
            student.Role = changingRequest.Role;
            return new StudentResponse(_studentRepository.Update(student));
        }
    }

}
