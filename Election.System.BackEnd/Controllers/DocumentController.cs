using Election.System.BackEnd.Enumerations;
using Election.System.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Election.System.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController: ControllerBase
    {
        [HttpGet("document-by-id/{id}")]
        public Document GetDocumentById(int id)
        {
            return null;
        }

        [HttpGet("all-control-status")]
        public List<ControlStatus> GetAllControlStatus()
        {
            return null;
        }

        [HttpGet("pending-documents")]
        public List<Document> GetAllPendingDocuments()
        {
            return null;
        }

        [HttpPost("upload-document")]
        public bool UploadDocument([FromForm] Document document)
        {
            return false;
        }

        [HttpPut("change-document-status")]
        public Document ChangeDocumentStatus([FromQuery] ControlStatus controlStatus)
        {
            return null;
        }

        [HttpDelete("remove-document-by-id/{id}")]
        public bool DeleteDocumentById(int id)
        {
            return false;
        }

    }
}
