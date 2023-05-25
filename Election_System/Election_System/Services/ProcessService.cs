using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Models;
using Election_System.Repositories;

namespace Election_System.Services
{
    public class ProcessService : IProcessService
    {
        private readonly IProcessRepository _processRepository;

        public ProcessService(IProcessRepository processRepository)
        {
            _processRepository = processRepository;
        }

        public List<ProcessResponse> GetAllProcesses()
        {
            List<ProcessResponse> processResponses = new List<ProcessResponse>();
            foreach(var process in _processRepository.GetAll())
            {
                processResponses.Add(new ProcessResponse(process));
            }

            return processResponses;
        }

        public ProcessResponse Add(ProcessRequest processRequest)
        {
            string[] startDate = processRequest.StartDate.Split(',');
            string[] endDate = processRequest.EndDate.Split(',');

            Process addedProcess = _processRepository.Add(new Process()
            {
                ProcessType = processRequest.ProcessType,
                StartDate = new DateTime((int)Int64.Parse(startDate[0]), (int)Int64.Parse(startDate[1]), (int)Int64.Parse(startDate[2])),
                EndDate = new DateTime((int)Int64.Parse(endDate[0]), (int)Int64.Parse(endDate[1]), (int)Int64.Parse(endDate[2])),
                AdministrationId = processRequest.AdministratonId
            });

            return new ProcessResponse(addedProcess);
        }

        public ProcessResponse Update(int id, ProcessRequest processRequest)
        {
            string[] startDate = processRequest.StartDate.Split(',');
            string[] endDate = processRequest.EndDate.Split(',');

            Process updatedProcess = new Process()
            {
                Id = id,
                ProcessType = processRequest.ProcessType,
                StartDate = new DateTime((int)Int64.Parse(startDate[0]), (int)Int64.Parse(startDate[1]), (int)Int64.Parse(startDate[2])),
                EndDate = new DateTime((int)Int64.Parse(endDate[0]), (int)Int64.Parse(endDate[1]), (int)Int64.Parse(endDate[2])),
                AdministrationId = processRequest.AdministratonId
            };

            return new ProcessResponse(_processRepository.Update(updatedProcess));
        }

        public bool Remove(int id)
        {
            try
            {
                _processRepository.DeleteById(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
