using Election_System.Configurations;
using Election_System.Enumerations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public List<Candidate> GetAll(ProcessType process)
        {
            return GetDataContext().candidates.
                Where(p => p.ProcessType == process).
                Include(p => p.CandidateStudent).
                    ThenInclude(s => s.Department).
                    ThenInclude(d => d.Faculty).
                ToList();
        }

        public override void DeleteById(int id)
        {
            Candidate candidate = GetDataContext().candidates.
                Where(c => c.CandidateStudentId == id).
                FirstOrDefault();

            DeleteByEntity(candidate);
        }

        public int RemoveAll()
        {
            return GetDataContext().Database.ExecuteSql($"DELETE FROM candidates");
        }
    }
}
