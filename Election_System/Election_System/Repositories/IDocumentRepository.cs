using Election_System.DTO.Responses;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface IDocumentRepository : IGenericRepository<Document>
    {
        Document GetDeparmentCandidacyDocumentByStudentId(int studentId);
        Document GetQualificationControlDocumentByStudentId(int studentId);
        List<Document> GetDepartmentCandidacyDocuments();
        List<Document> GetQualificationControlDocuments();

    }

}
