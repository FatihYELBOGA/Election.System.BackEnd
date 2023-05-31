using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public class FileRepository : GenericRepository<Models.File>, IFileRepository
    {
        public FileRepository(DataContext dataContext) : base(dataContext)
        {
           
        }

    }
}
