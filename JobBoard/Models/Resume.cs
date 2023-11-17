namespace JobBoard.API.Models
{
    public class Resume
    {
        public int Id { get; private set; }

        public int UserId { get; set; }
        public User User { get; set; }

        // Paragraph explaining an applicant's goal.
        public string Objective { get; set; }

        // Represent the various education and work experience an applicant has.
        public IList<Milestone> Milestones { get; set; }

        // Represents projects an applicant has done outside of formal (salaried) work or education
        public IList<Project> Projects { get; set; }

        public IList<Skill> Skills { get; set; }

        // Represents individuals or companies that can speak on the applicant's character
        public IList<Reference> References { get; set; }

        public Resume(int id, int userId, User user, string objective, IList<Milestone> milestones,
            IList<Project> projects, IList<Skill> skills, IList<Reference> references)
        {
            Id = id;
            UserId = userId;
            User = user;
            Objective = objective;
            Milestones = milestones;
            Projects = projects;
            Skills = skills;
            References = references;
        }
    }
}