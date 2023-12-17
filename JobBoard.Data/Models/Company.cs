namespace JobBoard.Data.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CityBased {  get; set; } = null!;
        public CompanySize CompanySize { get; set; }

        public Company()
        {
            
        }

        public Company(int id, string name, string description, string cityBased, CompanySize companySize)
        {
            Id = id;
            Name = name;
            Description = description;
            CityBased = cityBased;
            CompanySize = companySize;
        }
    }
}

namespace JobBoard.Data.Models
{
    public enum CompanySize
    {
        Small, // 1 - 99 employees
        Meduim, // 100 - 499 employees
        Large, // 500 - 999 employees
        Enterprise // 1000+ employees
    }
}