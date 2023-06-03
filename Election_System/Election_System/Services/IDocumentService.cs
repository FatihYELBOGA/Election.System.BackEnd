using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public interface IDocumentService
    {
        public DocumentResponse GetById(int id);
        List<StudentResponse> GetStudentsHaveDepartmentCandidacyDocuments();
        List<DocumentResponse> GetDeparmentCandidacyDocumentsByStudentId(int studentId);
        List<DocumentResponse> GetQualificationControlDocumentsByStudentId(int studentId);
        public DocumentResponse Add(DocumentRequest documentRequest);
        DocumentResponse UpdateControlStatus(int id, ControlStatus controlStatus);
        DocumentResponse Update(int id, IFormFile file);
        bool Remove(int id);

    }

}
