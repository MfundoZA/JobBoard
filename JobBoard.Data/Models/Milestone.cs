namespace JobBoard.Data.Models
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

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }


        public Milestone()
        {

        }

        public Milestone(int id, string milestoneType, string? companyName, string title,
            string description, DateTime? startDate, DateTime? endDate)
        {
            Id = id;
            MilestoneType = milestoneType;
            CompanyName = companyName;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
