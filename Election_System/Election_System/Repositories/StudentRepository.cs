using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(DataContext dataContext) : base(dataContext)
        {

        }

    }

}
