using Election_System.DTO;
using Election_System.DTO.Responses;
using Election_System.Repositories;
using Microsoft.Identity.Client;

namespace Election_System.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementRepository _announcementRepository;
        public  AnnouncementService(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }
        public List<AnnouncementResponse> GetAll()
        {   
            List<AnnouncementResponse> responses = new List<AnnouncementResponse>();
            foreach (var announcement in _announcementRepository.GetAnnouncements())
            {
                responses.Add(ConvertToDto.ToAnnouncementResponse(announcement));

            }
           return responses;
        }
    }
}
