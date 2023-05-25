using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class AnnouncementResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public AnnouncementResponse(Announcement announcement) 
        {
            Id = announcement.Id;
            Title = announcement.Title;
            Description = announcement.Description;
            StartDate = announcement.StartDate;
            EndDate = announcement.EndDate;
        }

    }
}
