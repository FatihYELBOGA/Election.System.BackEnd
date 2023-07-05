using Election_System.DTO.Responses;
using Election_System.Models;
using Election_System.Repositories;
using Election_System.Enumerations;
using Election_System.DTO.Requests;

namespace Election_System.Services
{
    public class DocumentService : IDocumentService
    {
        private IDocumentRepository _documentRepository;
        private IFileRepository _fileRepository;
        public DocumentService(IDocumentRepository documentRepository, IFileRepository fileRepository) 
        {
            _documentRepository = documentRepository;
            _fileRepository = fileRepository;
        }

        public DocumentResponse GetById(int id)
        {
            return new DocumentResponse(_documentRepository.GetById(id));
        }

        public List<StudentResponse> GetStudentsHaveDepartmentCandidacyDocuments()
        {
            return _documentRepository.GetStudentsHaveDepartmentCandidacyDocuments();
        }

        public List<DocumentResponse> GetDeparmentCandidacyDocumentsByStudentId(int studentId)
        {
            List<DocumentResponse> documentResponses = new List<DocumentResponse>();
            foreach (var doc in _documentRepository.GetDeparmentCandidacyDocumentsByStudentId(studentId))
            {
                documentResponses.Add(new DocumentResponse(doc));
            }

            return documentResponses;
        }

        public List<DocumentResponse> GetQualificationControlDocumentsByStudentId(int studentId)
        {
            List<DocumentResponse> documentResponses = new List<DocumentResponse>();
            foreach (var doc in _documentRepository.GetQualificationControlDocumentsByStudentId(studentId))
            {
                documentResponses.Add(new DocumentResponse(doc));
            }

            return documentResponses;
        }

        public DocumentResponse Add(DocumentRequest documentRequest)
        {
            Models.File newFile = null;
            long fileSize = documentRequest.File.Length;
            if (fileSize > 0)
            {
                using (var stream = new MemoryStream())
                {
                    documentRequest.File.CopyTo(stream);
                    var bytes = stream.ToArray();

                    newFile = new Models.File()
                    {
                        Name = documentRequest.File.FileName,
                        Type = documentRequest.File.ContentType,
                        Content = bytes
                    };
                }
            }

            Document newDocument = new Document()
            {
                File = newFile,
                StudentId = documentRequest.StudentId,
                ControlStatus = ControlStatus.WAITING,
                ProcessType = documentRequest.Process,
                DocumentType = documentRequest.Document
            };

            Document document = _documentRepository.Add(newDocument);
            Models.File file = _fileRepository.GetById((int)document.FileId);
            file.DocumentId = document.Id;
            _fileRepository.Update(file);

            return new DocumentResponse(_documentRepository.GetById(document.Id));
        }

        public DocumentResponse UpdateControlStatus(int id, ControlStatus controlStatus)
        {
            Document document = _documentRepository.GetById(id);
            document.ControlStatus = controlStatus;
            return new DocumentResponse(_documentRepository.Update(document));
        }

        public DocumentResponse Update(int id, IFormFile file)
        {
            Document document = _documentRepository.GetById(id); 

            long fileSize = file.Length;
            if (fileSize > 0)
            {
                using (var stream = new MemoryStream())
                {
                    file.CopyTo(stream);
                    var bytes = stream.ToArray();
                    document.File.Name = file.FileName;
                    document.File.Type = file.ContentType;
                    document.File.Content = bytes;
                }
            }
            document.ControlStatus = ControlStatus.WAITING;

            return new DocumentResponse(_documentRepository.Update(document));
        }

        public bool Remove(int id)
        {
            try
            {
                _fileRepository.DeleteById(_documentRepository.GetById(id).File.Id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int RemoveAll()
        {
            try
            {
                return _documentRepository.RemoveAll();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }

}
