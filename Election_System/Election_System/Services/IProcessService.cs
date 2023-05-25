using Election_System.DTO.Requests;
using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IProcessService
    {
        public List<ProcessResponse> GetAll();
        public List<ProcessResponse> GetActives();
        public ProcessResponse Add(ProcessRequest processRequest);
        public ProcessResponse Update(int id, ProcessRequest processRequest);
        public bool Remove(int id);

    }

}
