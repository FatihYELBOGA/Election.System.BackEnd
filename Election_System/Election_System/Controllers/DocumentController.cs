using Election_System.DTO.Responses;
using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpPost("/documents")]
        public DocumentResponse AddDocumentForDepartmentRepresentative([FromBody] DocumentRequest documentRequest)
        {
            return _documentService.AddDocumentForDepartmentRepresentative(documentRequest);
        }

    }

}
