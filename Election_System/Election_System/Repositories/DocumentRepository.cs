using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;
using Election_System.Enumerations;
using Election_System.DTO.Responses;

namespace Election_System.Repositories
{
    public class DocumentRepository : GenericRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DataContext dataContext) : base(dataContext) 
        {

        }

        public override Document GetById(int id)
        {
            return GetDataContext().documents.
                Where(d => d.Id == id).
                Include(d => d.File).
                FirstOrDefault();
        }

        public List<StudentResponse> GetStudentsHaveDepartmentCandidacyDocuments()
        {
            var query = GetDataContext().documents.
                GroupBy(d => d.StudentId).
                Select(g => new { StudentId = g.Key }).
                Join(GetDataContext().students, d => d.StudentId, s => s.Id, (d, s) => new
                {
                    Id = s.Id,
                    Username = s.Username,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName,
                });

            List<StudentResponse> studentResponses = new List<StudentResponse>();
            foreach (var q in query)
            {
                studentResponses.Add(new StudentResponse()
                {
                    Id = q.Id,
                    Username = q.Username,
                    FirstName = q.FirstName,
                    MiddleName = q.MiddleName,
                    LastName = q.LastName,
                });
            }
            return studentResponses;
        }

        public List<Document> GetDeparmentCandidacyDocumentsByStudentId(int studentId)
        {
            return GetDataContext().documents.
                Where(d => d.StudentId == studentId && d.ProcessType == ProcessType.DEPARTMENT_REPRESENTATIVE).
                Include(d => d.File).
                ToList();
        }

        public List<Document> GetQualificationControlDocumentsByStudentId(int studentId)
        {
            return GetDataContext().documents.
                Where(d => d.StudentId == studentId && d.ProcessType == ProcessType.QUALIFICATION_CONTROL).
                Include(d => d.File).
                ToList();
        }

    }

}
