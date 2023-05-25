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

        [HttpGet("/announcements/")]
        public List<AnnouncementResponse> GetAll()
        {
            return _announcementService.GetAll();
        }

        [HttpGet("/announcements/active")]
        public List<AnnouncementResponse> GetActives()
        {
            return _announcementService.GetActives();
        }

        [HttpGet("/announcements/{id}")]
        public AnnouncementResponse GetById(int id)
        {
            return _announcementService.GetById(id);
        }

        [HttpPost("/announcements")]
        public AnnouncementResponse Add([FromBody] AnnouncementRequest announcementRequest)
        {
            return _announcementService.Add(announcementRequest);
        }

        [HttpPut("/announcements/{id}")]
        public AnnouncementResponse Update(int id, [FromBody] AnnouncementRequest announcementRequest)
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
