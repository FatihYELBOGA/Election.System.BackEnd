using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Enumerations;
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

        public List<ProcessResponse> GetAll()
        {
            List<ProcessResponse> processResponses = new List<ProcessResponse>();
            foreach (var process in _processRepository.GetAll())
            {
                processResponses.Add(new ProcessResponse(process));
            }

            return processResponses;
        }

        public List<ProcessResponse> GetActives()
        {
            List<ProcessResponse> processResponses = new List<ProcessResponse>();
            foreach (var process in _processRepository.GetActives())
            {
                processResponses.Add(new ProcessResponse(process));
            }

            return processResponses;
        }
        public ProcessResponse GetStartedProcess(ProcessType process)
        {
            Process proc = _processRepository.GetStartedDepartmentCandidacy(process);
            if (proc != null)
            {
                return new ProcessResponse(proc);
            }

            return null;
        }

        public ProcessResponse GetStartingProcess(ProcessType process)
        {
            Process proc = _processRepository.GetStartingDepartmentCandidacy(process);
            if (proc != null)
            {
                return new ProcessResponse(proc);
            }

            return null;
        }

        public ProcessResponse GetWillStartProcess(ProcessType process)
        {
            Process proc = _processRepository.GetWillStartDepartmentCandidacy(process);
            if (proc != null)
            {
                return new ProcessResponse(proc);
            }

            return null;
        }

        public ProcessResponse Add(ProcessRequest processRequest)
        {
            ProcessType process = processRequest.ProcessType;
            foreach (var p in _processRepository.GetAll())
            {
                if(p.ProcessType == process)
                {
                    return null;
                }
            }

            string[] startDate = processRequest.StartDate.Split('-');
            string[] endDate = processRequest.EndDate.Split('-');

            Process addedProcess = _processRepository.Add(new Process()
            {
                ProcessType = process,
                StartDate = new DateTime((int)Int64.Parse(startDate[0]), (int)Int64.Parse(startDate[1]), (int)Int64.Parse(startDate[2]), (int)Int64.Parse(startDate[3]), (int)Int64.Parse(startDate[4]), (int)Int64.Parse(startDate[5])),
                EndDate = new DateTime((int)Int64.Parse(endDate[0]), (int)Int64.Parse(endDate[1]), (int)Int64.Parse(endDate[2]), (int)Int64.Parse(endDate[3]), (int)Int64.Parse(endDate[4]), (int)Int64.Parse(endDate[5])),
                AdministrationId = processRequest.AdministratonId
            });

            return new ProcessResponse(addedProcess);
        }

        public ProcessResponse Update(int id, ProcessRequest processRequest)
        {
            string[] startDate = processRequest.StartDate.Split('-');
            string[] endDate = processRequest.EndDate.Split('-');

            Process updatedProcess = new Process()
            {
                Id = id,
                ProcessType = processRequest.ProcessType,
                StartDate = new DateTime((int)Int64.Parse(startDate[0]), (int)Int64.Parse(startDate[1]), (int)Int64.Parse(startDate[2]), (int)Int64.Parse(startDate[3]), (int)Int64.Parse(startDate[4]), (int)Int64.Parse(startDate[5])),
                EndDate = new DateTime((int)Int64.Parse(endDate[0]), (int)Int64.Parse(endDate[1]), (int)Int64.Parse(endDate[2]), (int)Int64.Parse(endDate[3]), (int)Int64.Parse(endDate[4]), (int)Int64.Parse(endDate[5])),
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
