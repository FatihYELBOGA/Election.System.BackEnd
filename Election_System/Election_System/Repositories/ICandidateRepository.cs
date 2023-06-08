using Election_System.Enumerations;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        public List<Candidate> GetAll(ProcessType process);
        public int RemoveAll();

    }

}
