using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface IProcessRepository : IGenericRepository<Process>
    {
        public List<Process> GetActives();
        public Process GetStartedDepartmentCandidacy();
        public Process GetWillStartDepartmentCandidacy();

    }

}
