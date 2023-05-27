using Election_System.Enumerations;

namespace Election_System.Controllers
{
    public class DocumentRequest
    {
        public int StudentId { get; set; }
        public IFormFile File { get; set; }

    }

}
