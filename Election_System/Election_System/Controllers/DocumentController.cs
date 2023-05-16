using Election_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Election_System.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class DocumentController : Controller
    {
        private IDocumentSerivce _documentSerivce;

        public DocumentController(IDocumentSerivce documentSerivce) { 
            _documentSerivce = documentSerivce;
         }
    }
}
