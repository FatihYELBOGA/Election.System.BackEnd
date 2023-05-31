using Election_System.DTO.Requests;
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

        [HttpGet("/documents/{id}")]
        public DocumentResponse GetById(int id)
        {
            return _documentService.GetById(id);
        }

        [HttpGet("/documents/department-candidacy/{studentId}")]
        public DocumentResponse GetDeparmentCandidacyDocumentByStudentId(int studentId)
        {
            return _documentService.GetDeparmentCandidacyDocumentByStudentId(studentId);
        }

        [HttpGet("/documents/qualification-control/{studentId}")]
        public DocumentResponse GetQualificationControlDocumentByStudentId(int studentId)
        {
            return _documentService.GetQualificationControlDocumentByStudentId(studentId);
        }

        [HttpGet("/documents/department-candidacies")]
        public List<DocumentResponse> GetDeparmentCandidacyDocuments()
        {
            return _documentService.GetDepartmentCandidacyDocuments();
        }

        [HttpGet("/documents/qualification-controls")]
        public List<DocumentResponse> GetQualificationControlDocuments()
        {
            return _documentService.GetQualificationControlDocuments();
        }

        [HttpPost("/documents")]
        public DocumentResponse Add([FromForm] DocumentRequest documentRequest)
        {
            return _documentService.Add(documentRequest);
        }

        [HttpDelete("/documents/{id}")]
        public bool Remove(int id)
        {
            return _documentService.Remove(id);
        }

    }

}
