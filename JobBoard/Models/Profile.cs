namespace JobBoard.API.Models
{
    public class Profile
    {
        public int Id { get; private set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string? Description { get; set; }

        public IList<Milestone>? Education { get; set; }

        public IList<Milestone>? WorkExperience { get; set; }

        // Represents projects an applicant has done outside of formal (salaried) work or education
        public IList<Project>? Projects { get; set; }

        public IList<Skill>? Skills { get; set; }


        public Profile(int id, int userId, User user, string? description, IList<Milestone>? education,
            IList<Milestone>? workExperience, IList<Project>? projects, IList<Skill>? skills)
        {
            Id = id;
            UserId = userId;
            User = user;
            Description = description;
            Education = education;
            WorkExperience = WorkExperience;
            Projects = projects;
            Skills = skills;
        }
    }
}
