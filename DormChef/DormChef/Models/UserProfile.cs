using SQLite;

namespace DormChef.Models
{
    public class UserProfile
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique]
        public string Email { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}