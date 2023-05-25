using Election_System.Enumerations;

namespace Election_System.DTO.Requests
{
    public class ProcessRequest
    {
        public ProcessType ProcessType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? AdministratonId { get; set; }

    }

}
