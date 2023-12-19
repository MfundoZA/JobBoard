using JobBoard.Data.Models;

namespace JobBoard.Data.Models
{
    public class Profile
    {
        public int Id { get; private set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public string? Description { get; set; }

        public IList<Milestone>? Milestones { get; set; }

        public IList<Project>? Projects { get; set; }

        public IList<Skill>? Skills { get; set; }

        public IList<Certification>? Certifications { get; set; }

        public IList<Opening>? Openings { get; set; }

        public Profile()
        {

        }

        public Profile(int id, int userId, User user, string? description, IList<Milestone>? milestones,
            IList<Project>? projects, IList<Skill>? skills, IList<Certification>? certifications, IList<Opening>? openings)
        {
            Id = id;
            UserId = userId;
            User = user;
            Description = description;
            Milestones = milestones;
            Projects = projects;
            Skills = skills;
            Certifications = certifications;
            Openings = openings;
        }
    }
}
