using Election_System.Enumerations;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Configurations
{
    public static class SeedDatabase
    {
        public static void Seed(DataContext dataContext)
        {
            if (dataContext.Database.GetPendingMigrations().Count() == 0)
            {
                dataContext.faculties.AddRange(faculties);
                dataContext.departments.AddRange(departments);
                dataContext.administrations.AddRange(administrations);
                dataContext.students.AddRange(students);
                dataContext.candidates.AddRange(candidates);
                dataContext.attendantStudents.AddRange(attendantStudents);
                dataContext.announcements.AddRange(announcements);  
                dataContext.feedbacks.AddRange(feedbacks);  
                dataContext.feedbackStudents.AddRange(feedbackStudents);
                dataContext.processes.AddRange(processes);
                dataContext.electionResults.AddRange(electionResults);  
                dataContext.documents.AddRange(documents);

                dataContext.SaveChanges();
            }
        }

        private static Faculty[] faculties = new Faculty[]
        {
            new Faculty()
            {
                Name = "Engineering Faculty"
            }
        };

        private static Department[] departments = new Department[]
        {
            new Department()
            {
                Name = "Computer Engineering",
                Faculty = faculties[0]
            },
            new Department()
            {
                Name = "Electric-Electronic Engineering",
                Faculty = faculties[0]
            }
        };

        private static Administration[] administrations = new Administration[]
        {
            new Administration()
            {
                Username = "fatihyelboga@std.iyte.edu.tr",
                Password = "fatih123",
                FirstName = "Fatih",
                LastName = "YELBOGA",
                Gender = Gender.MALE,
                Role = Role.SYSTEM_ADMIN
            },
            new Administration()
            {
                Username = "enesdemirel@std.iyte.edu.tr",
                Password = "enes123",
                FirstName = "Enes",
                LastName = "DEMIREL",
                Gender = Gender.MALE,
                Role = Role.STUDENT_AFFAIR
            },
            new Administration()
            {
                Username = "emreyelboga@std.iyte.edu.tr",
                Password = "emre123",
                FirstName = "Emre",
                LastName = "YELBOGA",
                Gender = Gender.MALE,
                Role = Role.ADMINISTRATIVE
            },
            new Administration()
            {
                Username = "berkaybayrak@std.iyte.edu.tr",
                Password = "berkay123",
                FirstName = "Berkay",
                LastName = "BAYRAK",
                Gender = Gender.MALE,
                Role = Role.ADMINISTRATIVE
            }
        };

        private static Student[] students = new Student[]
        {
            new Student()
            {
                Username = "osmanaltunay@std.iyte.edu.tr",
                Password = "osman123",
                FirstName = "Osman",
                LastName = "ALTUNAY",
                Gender = Gender.MALE,
                Role = Role.FACULTY_REPRESENTATIVE,
                Department = departments[0],
                GPA = 3.1f
            },
            new Student()
            {
                Username = "mervenurozan@std.iyte.edu.tr",
                Password = "merve123",
                FirstName = "Merve",
                MiddleName = "Nur",
                LastName = "OZAN",
                Gender = Gender.FEMALE,
                Role = Role.DEPARTMENT_REPRESENTATIVE,
                Department = departments[1],
                GPA = 3.2f
            },
            new Student()
            {
                Username = "halilbugday@std.iyte.edu.tr",
                Password = "halil123",
                FirstName = "Halil",
                LastName = "BUGDAY",
                Gender = Gender.MALE,
                Role = Role.STUDENT,
                Department = departments[0],
                GPA = 3.3f
            },
            new Student()
            {
                Username = "gokaygulsoy@std.iyte.edu.tr",
                Password = "gokay123",
                FirstName = "Gokay",
                LastName = "GULSOY",
                Gender = Gender.MALE,
                Role = Role.STUDENT,
                Department = departments[1],
                GPA = 3.4f
            }
        };
        private static Candidate[] candidates = new Candidate[]
        {
            new Candidate()
            {
                CandidateStudent = students[0],
                CandidacyDate = new DateTime(2022, 10, 01),
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE
            },
            new Candidate()
            {
                CandidateStudent = students[1],
                CandidacyDate = new DateTime(2022, 10, 10),
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE
            },
            new Candidate()
            {
                CandidateStudent = students[0],
                CandidacyDate = new DateTime(2022, 10, 20),
                ProcessType = ProcessType.FACULTY_REPRESENTATIVE
            }
        };

        private static AttendantStudent[] attendantStudents = new AttendantStudent[]
        {
            new AttendantStudent()
            {
                Student = students[0],
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                StartDate= new DateTime(2022, 10, 15),
                EndDate= new DateTime(2023, 10, 15)
            },
            new AttendantStudent()
            {
                Student = students[1],
                ProcessType = ProcessType.FACULTY_REPRESENTATIVE,
                StartDate= new DateTime(2022, 11, 01),
                EndDate= new DateTime(2023, 11, 01)
            }
        };

        private static Announcement[] announcements = new Announcement[]
        {
            new Announcement()
            {
                Title = "DEPARTMAN ADAYLIGI SURECI BASLADI",
                Description = 
                "Departman adayligi icin basvuracak ogrenciler 2022-10-01'den 2022-10-15'e kadar gerekli basvuru dokumanlarini sistem uzerinden gondermelidir.\n" +
                "Ogrenci Isleri - Enes DEMIREL",
                StartDate = new DateTime(2022, 10, 01),
                EndDate = new DateTime(2022, 10, 15),
                Administration = administrations[1]
            }
        };

        private static Feedback[] feedbacks = new Feedback[]
        {
            new Feedback()
            {
                Title = "DEPARTMAN ADAYLIGI BASVURUSU",
                Description = "Department temsilciligi icin gondermis oldugunuz evraklar eksiktir, lutfen kontrollerinizi saglayiniz.",
                Administration = administrations[1],
                PostTime = new DateTime(2022, 10, 10)
            }
        };

        private static FeedbackStudent[] feedbackStudents = new FeedbackStudent[]
        {
            new FeedbackStudent()
            {
                Feedback = feedbacks[0],
                Student = students[0]
            },
            new FeedbackStudent()
            {
                Feedback = feedbacks[0],
                Student = students[1]
            }
        };

        private static Process[] processes = new Process[]
        {
            new Process()
            {
                ProcessType = ProcessType.DEPARTMENT_CANDIDACY,
                StartDate= new DateTime(2022, 10, 01),
                EndDate = new DateTime(2022, 10, 15),
                administration = administrations[2]
            },
            new Process()
            {
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                StartDate= new DateTime(2022, 10, 15),
                EndDate = new DateTime(2022, 10, 16),
                administration = administrations[2]
            },
            new Process()
            {
                ProcessType = ProcessType.FACULTY_CANDIDACY,
                StartDate= new DateTime(2022, 10, 16),
                EndDate = new DateTime(2022, 10, 30),
                administration = administrations[2]
            },
            new Process()
            {
                ProcessType = ProcessType.FACULTY_REPRESENTATIVE,
                StartDate= new DateTime(2022, 11, 01),
                EndDate = new DateTime(2022, 11, 01),
                administration = administrations[2]
            }
        };

        private static ElectionResult[] electionResults = new ElectionResult[]
        {
            new ElectionResult()
            {
                VoterStudent = students[0],
                CandidateStudent = students[0],
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                VoteDate = new DateTime(2022, 10, 15)
            },
            new ElectionResult()
            {
                VoterStudent = students[2],
                CandidateStudent = students[0],
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                VoteDate = new DateTime(2022, 10, 15)
            },
            new ElectionResult()
            {
                VoterStudent = students[1],
                CandidateStudent = students[1],
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                VoteDate = new DateTime(2022, 10, 15)
            },
            new ElectionResult()
            {
                VoterStudent = students[3],
                CandidateStudent = students[1],
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                VoteDate = new DateTime(2022, 10, 15)
            }
        };

        private static Document[] documents = new Document[]
        {
            new Document()
            {
                Student = students[0],
                UploadingTime = new DateTime(2022, 10, 12),
                ControlStatus = ControlStatus.APPROVED,
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE
            },
            new Document()
            {
                Student = students[1],
                UploadingTime = new DateTime(2022, 10, 14),
                ControlStatus = ControlStatus.APPROVED,
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE
            }
        };

    }

}
