using Election_System.DTO;
using Election_System.DTO.Responses;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class CandidateService : ICandidateService
    {   
        private readonly ICandidateRepository _candidateRepository;
        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }
        public List<CandidateResponse> GetAll()
        {
            List<CandidateResponse> results = new List<CandidateResponse>();
            foreach (var candidate in _candidateRepository.GetAllCandidates())

            {
                results.Add(ConvertToDto.ToCandidateResponse(candidate));
            }
            return results;
        }

        public List<CandidateResponse> GetCandidatesByDepartmentId(int id)
        {
            List<CandidateResponse> results = new List<CandidateResponse>();
            foreach (var candidate in _candidateRepository.GetCandidatesByDepartmentId(id))

            {
                results.Add(ConvertToDto.ToCandidateResponse(candidate));
            }
            return results;
        }
    }
}
