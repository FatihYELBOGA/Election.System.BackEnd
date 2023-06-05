using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public interface IProcessService
    {
        public List<ProcessResponse> GetAll();
        public List<ProcessResponse> GetActives();
        ProcessResponse GetStartedProcess(ProcessType process);
        ProcessResponse GetStartingProcess(ProcessType process);
        ProcessResponse GetWillStartProcess(ProcessType process);
        public ProcessResponse Add(ProcessRequest processRequest);
        public ProcessResponse Update(int id, ProcessRequest processRequest);
        public bool Remove(int id);

    }

}
