using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        private readonly DataContext _dataContext;
        public CandidateRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Candidate> GetAllCandidates()
        {
            return _dataContext.candidates.
                Include(s => s.CandidateStudent).
                    ThenInclude(d => d.Department).ToList();
        }


        //Doğru sonuç vermiyor
        public List<Candidate> GetCandidatesByDepartmentId(int id)
        {
            return _dataContext.candidates.
                Include(s => s.CandidateStudent).
                    ThenInclude(d => d.Department).Where(d => d.CandidateStudent.Department.Id == id).ToList();
        }
    }
}
