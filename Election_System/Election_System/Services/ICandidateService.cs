using Election_System.DTO.Responses;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public interface ICandidateService
    {
        List<StudentResponse> GetAll(ProcessType process);
        StudentResponse Add(int id, ProcessType process);
        bool Remove(int id);

    }
}
