using Election_System.DTO;
using Election_System.DTO.Responses;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class AdministrationService : IAdministrationService
    {
        private readonly IAdministrationRepository _administrationRepository;
        public AdministrationService(IAdministrationRepository administrationRepository)
        {
            _administrationRepository = administrationRepository;
        }

        public List<AdministrationResponse> GetAll()
        {
            List<AdministrationResponse> administrationResponses = new List<AdministrationResponse>();   
            foreach (var admin in _administrationRepository.GetAll())
            {
                administrationResponses.Add(ConvertToDto.ToAdministrationResponse(admin));
            }

            return administrationResponses;
        }

        public AdministrationResponse GetById(int id)
        {
            return ConvertToDto.ToAdministrationResponse(_administrationRepository.GetById(id));
        }
    }

}
