using Election_System.DTO.Responses;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface IDocumentRepository : IGenericRepository<Document>
    {
        List<StudentResponse> GetStudentsHaveDepartmentCandidacyDocuments();
        List<Document> GetDeparmentCandidacyDocumentsByStudentId(int studentId);
        List<Document> GetQualificationControlDocumentsByStudentId(int studentId);
        public int RemoveAll();

    }

}
