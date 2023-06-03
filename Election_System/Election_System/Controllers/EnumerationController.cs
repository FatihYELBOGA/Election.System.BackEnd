using Election_System.DTO.Responses;
using Election_System.Enumerations;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnumerationController : ControllerBase
    {

        [HttpGet("/control-status")]
        public ControlStatus[] GetControlStatus()
        {
            return (ControlStatus[]) Enum.GetValues(typeof(ControlStatus));
        }

        [HttpGet("/genders")]
        public Gender[] GetGenders()
        {
            return (Gender[])Enum.GetValues(typeof(Gender));
        }

        [HttpGet("/process-types")]
        public ProcessType[] GetProcessTypes()
        {
            return (ProcessType[])Enum.GetValues(typeof(ProcessType));
        }

        [HttpGet("/roles")]
        public Role[] GetRoles()
        {
            return (Role[])Enum.GetValues(typeof(Role));
        }

        [HttpGet("/document-types")]
        public DocumentType[] GetDocumentTypes()
        {
            return (DocumentType[])Enum.GetValues(typeof(DocumentType));
        }

    }
}
