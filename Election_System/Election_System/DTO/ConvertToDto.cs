using Election_System.DTO.Responses;
using Election_System.Models;

namespace Election_System.DTO
{
    public static class ConvertToDto
    {
        public static AdministrationResponse ToAdministrationResponse(Administration administration)
        {
            return new AdministrationResponse()
            {
                Id = administration.Id,
                Username = administration.Username,
                Role= administration.Role,
                FirstName = administration.FirstName,
                MiddleName = administration.MiddleName,
                LastName = administration.LastName,
                BornDate = administration.BornDate,
                Gender = administration.Gender
            };

        }
        public static StudentResponse ToStudentResponse(Student student)
        {
            return new StudentResponse()
            {
                Id = student.Id,
                Username = student.Username,
                Role = student.Role,
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                BornDate = student.BornDate,
                Gender = student.Gender
            };

        }
        public static CandidateResponse ToCandidateResponse(Candidate candidate)
        {
            return new CandidateResponse()
            {
                Id = candidate.Id,
                FirstName = candidate.CandidateStudent.FirstName,
                Lastname = candidate.CandidateStudent.LastName,
                DepartmentName = candidate.CandidateStudent.Department.Name,
                CandidacyDate = candidate.CandidacyDate,
                ProcessType = candidate.ProcessType
            };
        }

        public static AnnouncementResponse ToAnnouncementResponse(Announcement announcement)
        {
            return new AnnouncementResponse()
            {
                Id = announcement.Id,
                Title = announcement.Title,
                Description = announcement.Description

            };
        }

    }

}
