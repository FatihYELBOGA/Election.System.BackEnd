using Election_System.Repositories;

namespace Election_System.Services
{
    public class DocumentService : IDocumentSerivce
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
    }
}
