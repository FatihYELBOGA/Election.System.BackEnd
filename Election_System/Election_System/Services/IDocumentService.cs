using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public interface IDocumentService
    {
        public DocumentResponse GetById(int id);
        public List<StudentResponse> GetStudentsHaveDepartmentCandidacyDocuments();
        public List<DocumentResponse> GetDeparmentCandidacyDocumentsByStudentId(int studentId);
        public List<DocumentResponse> GetQualificationControlDocumentsByStudentId(int studentId);
        public DocumentResponse Add(DocumentRequest documentRequest);
        public DocumentResponse UpdateControlStatus(int id, ControlStatus controlStatus);
        public DocumentResponse Update(int id, IFormFile file);
        public bool Remove(int id);
        public int RemoveAll();

    }

}
