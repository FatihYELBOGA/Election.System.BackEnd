using Election_System.DTO;
using Election_System.DTO.Responses;
using Election_System.Enumerations;
using Election_System.Models;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class CandidateService : ICandidateService
    {   
        private readonly ICandidateRepository _candidateRepository;
        private readonly IStudentRepository _studentRepository;
        public CandidateService(ICandidateRepository candidateRepository, IStudentRepository studentRepository)
        {
            _candidateRepository = candidateRepository;
            _studentRepository = studentRepository; 
        }


        public List<StudentResponse> GetAll(ProcessType process)
        {
            List<StudentResponse> studentResponses = new List<StudentResponse>();
            foreach (var s in _candidateRepository.GetAll(process))
            {
                studentResponses.Add(new StudentResponse(s.CandidateStudent));
            }

            return studentResponses;
        }

        public StudentResponse Add(int id, ProcessType process)
        {
            Candidate addedCandidate = _candidateRepository.Add(new Candidate()
            {
                CandidateStudentId = id,
                ProcessType = process
            });

            return new StudentResponse(_studentRepository.GetById((int) addedCandidate.CandidateStudentId));
        }

        public bool Remove(int id)
        {
            try
            {
                _candidateRepository.DeleteById(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }

}
