namespace JobBoard.Data.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public Profile Profile { get; set; } = null!;
        public string? CityBased { get; set; }

        public User() { }

        public User(int id, string firstName, string? lastName, string email, string password,
            string phoneNumber, Profile profile, string? cityBased)
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
