namespace JobBoard.API.Models
{
    /*
     * Reference class representing people who would vouch for you to recruiter
     */
    public class Reference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string? Institution { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RelationshipToApplicant { get; set; }

        public Reference(int id, string name, string jobTitle, string? institution, string phoneNumber,
            string email, string relationshipToApplicant)
        {
            Id = id;
            Name = name;
            JobTitle = jobTitle;
            Institution = institution;
            PhoneNumber = phoneNumber;
            Email = email;
            RelationshipToApplicant = relationshipToApplicant;
        }
    }
}