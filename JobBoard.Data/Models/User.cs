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
        public Profile Profile { get; set; }
        public string CityBased { get; set; }
        
        public User(int id, string firstName, string lastName, string email, string password,
            string phoneNumber, Profile profile, string cityBased)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Profile = profile;
            CityBased = cityBased;
        }
    }
}
