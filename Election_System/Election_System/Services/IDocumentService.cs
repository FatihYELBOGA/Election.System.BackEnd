using Election_System.Controllers;
using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IDocumentService
    {
        public DocumentResponse AddDocumentForDepartmentRepresentative(DocumentRequest documentRequest);

    }

}
