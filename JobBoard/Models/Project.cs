namespace JobBoard.API.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<String> ProjectBulletPoints { get; set; }

        public Project(int id, string ProjectName, string? ProjectDescription, DateTime? startDate, DateTime? EndDate, List<string>? projectBulletPoints)
        {
            Id = id;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            StartDate = startDate;
            EndDate = endDate;
            ProjectBulletPoints = projectBulletPoints;
        }
    }
}
