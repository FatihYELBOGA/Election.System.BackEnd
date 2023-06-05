using Election_System.Generics;
using Election_System.Models;
using Election_System.Enumerations;

namespace Election_System.Repositories
{
    public interface IProcessRepository : IGenericRepository<Process>
    {
        public List<Process> GetActives();
        public Process GetStartedDepartmentCandidacy(ProcessType process);
        public Process GetStartingDepartmentCandidacy(ProcessType process);
        public Process GetWillStartDepartmentCandidacy(ProcessType process);

    }

}
