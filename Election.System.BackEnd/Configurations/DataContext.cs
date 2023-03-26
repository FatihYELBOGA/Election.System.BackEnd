using Election.System.BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace Election.System.BackEnd.Configurations
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        DbSet<Administration> administrations { get; set; }
        DbSet<Candidate> candidates { get; set; }
        DbSet<Department> departments { get; set; }
        DbSet<Document> documents { get; set; }
        DbSet<Faculty> faculties { get; set; }
        DbSet<ElectionResult> electionResults { get; set; }   
        DbSet<Role> roles { get; set; }
        DbSet<Student> students { get; set; }
        DbSet<AttendantStudent> attendantStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        } 

    }
}
