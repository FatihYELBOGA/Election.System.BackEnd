using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Configurations
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Faculty> faculties { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Administration> administrations { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Candidate> candidates { get; set; }
        public DbSet<AttendantStudent> attendantStudents { get; set; }
        public DbSet<Announcement> announcements { get; set; }
        public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<FeedbackStudent> feedbackStudents { get; set; }
        public DbSet<Process> processes { get; set; }
        public DbSet<ElectionResult> electionResults { get; set; }
        public DbSet<Document> documents { get; set; }
        public DbSet<Models.File> files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().
                HasOne(d => d.Faculty).
                WithMany(f => f.Departments).
                HasForeignKey(d => d.FacultyId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>().
                HasOne(s => s.Department).
                WithMany(d => d.Students).
                HasForeignKey(s => s.DepartmentId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Announcement>().
                HasOne(ann => ann.Administration).
                WithMany(a => a.Announcements).
                HasForeignKey(ann => ann.AdministrationId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Feedback>().
                HasOne(f => f.Administration).
                WithMany(a => a.Feedbacks).
                HasForeignKey(f => f.AdministrationId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FeedbackStudent>().
                HasOne(fs => fs.Feedback).
                WithMany(f => f.FeedbackStudents).
                HasForeignKey(fs => fs.FeedbackId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FeedbackStudent>().
                HasOne(fs => fs.Student).
                WithMany(s => s.Feedbacks).
                HasForeignKey(fs => fs.StudentId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AttendantStudent>().
                HasOne(a => a.Student).
                WithMany(s => s.Attendants).
                HasForeignKey(a => a.StudentId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Document>().
                HasOne(d => d.Student).
                WithMany(s => s.Documents).
                HasForeignKey(d => d.StudentId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Candidate>().
                HasOne(c => c.CandidateStudent).
                WithMany(s => s.Candidacies).
                HasForeignKey(c => c.CandidateStudentId).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Process>().
                HasOne(p => p.administration).
                WithMany(a => a.Processes).
                HasForeignKey(p => p.AdministratonId).
                OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ElectionResult>().
                HasOne(er => er.VoterStudent).
                WithMany(s => s.FirstStudents).
                HasForeignKey(c => c.VoterStudentId).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ElectionResult>().
                HasOne(er => er.CandidateStudent).
                WithMany(s => s.SecondStudents).
                HasForeignKey(c => c.CandidateStudentId).
                OnDelete(DeleteBehavior.ClientSetNull);

        }

    }

}
