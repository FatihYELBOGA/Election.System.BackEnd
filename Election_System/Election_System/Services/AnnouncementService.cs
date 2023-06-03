using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Repositories;
using Election_System.Models;

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
            List<AnnouncementResponse> announcementResponses = new List<AnnouncementResponse>();
            foreach (var announcement in _announcementRepository.GetAll())
            {
                announcementResponses.Add(new AnnouncementResponse(announcement));
            }

            return announcementResponses;
        }

        public List<AnnouncementResponse> GetActives()
        {
            List<AnnouncementResponse> announcementResponses = new List<AnnouncementResponse>();
            foreach (var announcement in _announcementRepository.GetActives())
            {
                announcementResponses.Add(new AnnouncementResponse(announcement));
            }

            return announcementResponses;
        }
        public AnnouncementResponse GetById(int id)
        {
            return new AnnouncementResponse(_announcementRepository.GetById(id));
        }

        public AnnouncementResponse Add(AnnouncementRequest announcementRequest)
        {
            string[] startDate = announcementRequest.StartDate.Split('-');
            string[] endDate = announcementRequest.EndDate.Split('-');

            Announcement addedAnnouncement = _announcementRepository.Add(new Announcement()
            {
                Title = announcementRequest.Title,
                Description = announcementRequest.Description,
                StartDate = new DateTime((int)Int64.Parse(startDate[0]), (int)Int64.Parse(startDate[1]), (int)Int64.Parse(startDate[2]), (int)Int64.Parse(startDate[3]), (int)Int64.Parse(startDate[4]), (int)Int64.Parse(startDate[5])),
                EndDate = new DateTime((int)Int64.Parse(endDate[0]), (int)Int64.Parse(endDate[1]), (int)Int64.Parse(endDate[2]), (int)Int64.Parse(endDate[3]), (int)Int64.Parse(endDate[4]), (int)Int64.Parse(endDate[5])),
                AdministrationId = announcementRequest.AdministrationId
            });

            return new AnnouncementResponse(addedAnnouncement);
        }

        public AnnouncementResponse Update(int id, AnnouncementRequest announcementRequest)
        {
            string[] startDate = announcementRequest.StartDate.Split('-');
            string[] endDate = announcementRequest.EndDate.Split('-');

            Announcement updatedAnnouncement = new Announcement()
            {
                Id = id,
                Title = announcementRequest.Title,
                Description = announcementRequest.Description,
                StartDate = new DateTime((int)Int64.Parse(startDate[0]), (int)Int64.Parse(startDate[1]), (int)Int64.Parse(startDate[2]), (int)Int64.Parse(startDate[3]), (int)Int64.Parse(startDate[4]), (int)Int64.Parse(startDate[5])),
                EndDate = new DateTime((int)Int64.Parse(endDate[0]), (int)Int64.Parse(endDate[1]), (int)Int64.Parse(endDate[2]), (int)Int64.Parse(endDate[3]), (int)Int64.Parse(endDate[4]), (int)Int64.Parse(endDate[5])),
                AdministrationId = announcementRequest.AdministrationId
            };

            return new AnnouncementResponse(_announcementRepository.Update(updatedAnnouncement));
        }

        public bool Remove(int id)
        {
            try
            {
                _announcementRepository.DeleteById(id);
                return true;
            } 
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
