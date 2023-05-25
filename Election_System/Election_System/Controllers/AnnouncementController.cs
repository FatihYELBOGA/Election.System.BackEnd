using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet("/announcements")]
        public List<AnnouncementResponse> GetAll()
        {
            return _announcementService.GetAll();
        }

        [HttpPost("/announcements")]
        public AnnouncementResponse Add([FromForm] AnnouncementRequest announcementRequest)
        {
            return _announcementService.Add(announcementRequest);
        }

        [HttpPut("/announcements/{id}")]
        public AnnouncementResponse Update(int id, [FromForm] AnnouncementRequest announcementRequest)
        {
            return _announcementService.Update(id, announcementRequest);
        }

        [HttpDelete("/announcements/{id}")]
        public bool Remove(int id)
        {
            return _announcementService.Remove(id);
        }
    }
}
