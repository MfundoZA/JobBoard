namespace JobBoard.API.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Project()
        {

        }

        public Project(int id, string projectName, string? projectDescription, DateTime? startDate, DateTime? endDate)
        {
            Id = id;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
