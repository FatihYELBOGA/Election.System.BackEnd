using Election_System.DTO.Responses;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public interface ICandidateService
    {
        public List<StudentResponse> GetAll(ProcessType process);
        public StudentResponse Add(int id, ProcessType process);
        public bool Remove(int id);
        public int RemoveAll();

    }

}
