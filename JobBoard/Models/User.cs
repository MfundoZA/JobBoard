namespace JobBoard.API.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public IList<Profile>? Resumes { get; set; }
        public string CityBased { get; set; }
        public IList<string>? ProfileLinks { get; set; }

        public User(int id, string firstName, string lastName, string email, string password,
            string phoneNumber, IList<Profile>? resumes, string cityBased, IList<string>? profileLinks)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Resumes = resumes;
            CityBased = cityBased;
            ProfileLinks = profileLinks;
        }
    }
}
