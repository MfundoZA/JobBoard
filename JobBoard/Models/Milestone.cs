namespace JobBoard.API.Models
{
    public class Milestone
    {
        public int Id { get; private set; }

        // Refers to the type of milestone i.e Education, Work Experience or Achievement
        public string MilestoneType { get; set; }

        // Refers to the name of the organization the user was in when the milestone was achieved.
        // It can be null if the achievement was is not associated with any organization.
        public string? CompanyName { get; set; }

        // Refers to the title of the position related to the milestone i.e Software Engineer.
        public string Title { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<string>? MilestoneBulletPoints { get; set; }

        public Milestone(int id, string milestoneType, string? companyName, string title, DateTime? startDate, DateTime? endDate, List<string>? milestoneBulletPoints)
        {
            Id = id;
            MilestoneType = milestoneType;
            CompanyName = companyName;
            Title = title;
            StartDate = startDate;
            EndDate = endDate;
            MilestoneBulletPoints = milestoneBulletPoints;
        }
    }
}
