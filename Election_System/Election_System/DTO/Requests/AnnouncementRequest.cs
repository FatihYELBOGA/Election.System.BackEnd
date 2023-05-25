namespace Election_System.DTO.Requests
{
    public class AnnouncementRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? AdministrationId { get; set; }

    }

}
