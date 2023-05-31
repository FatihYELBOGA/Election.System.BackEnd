using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;
using Election_System.Enumerations;

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
                Include(d => d.Student).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                FirstOrDefault();
        }
        public List<Document> GetDepartmentCandidacyDocuments()
        {
            return GetDataContext().documents.
                Where(d => d.ProcessType == ProcessType.DEPARTMENT_REPRESENTATIVE).
                Include(d => d.File).
                Include(d => d.Student).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                ToList();
        }

        public List<Document> GetQualificationControlDocuments()
        {
            return GetDataContext().documents.
                Where(d => d.ProcessType == ProcessType.QUALIFICATION_CONTROL).
                Include(d => d.File).
                Include(d => d.Student).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                ToList();
        }

        public Document GetDeparmentCandidacyDocumentByStudentId(int studentId)
        {
            return GetDataContext().documents.
                Where(d => d.StudentId == studentId && d.ProcessType == ProcessType.DEPARTMENT_REPRESENTATIVE).
                Include(d => d.File).
                Include(d => d.Student).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                FirstOrDefault();
        }

        public Document GetQualificationControlDocumentByStudentId(int studentId)
        {
            return GetDataContext().documents.
                Where(d => d.StudentId == studentId && d.ProcessType == ProcessType.QUALIFICATION_CONTROL).
                Include(d => d.File).
                Include(d => d.Student).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                FirstOrDefault();
        }

    }

}
