using Election_System.DTO.Requests;
using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IDocumentService
    {
        public DocumentResponse GetById(int id);
        List<DocumentResponse> GetDepartmentCandidacyDocuments();
        List<DocumentResponse> GetQualificationControlDocuments();
        DocumentResponse GetDeparmentCandidacyDocumentByStudentId(int studentId);
        DocumentResponse GetQualificationControlDocumentByStudentId(int studentId);
        public DocumentResponse Add(DocumentRequest documentRequest);
        bool Remove(int id);

    }

}
