using SQLite;

namespace DormChef.Models
{
    public class Favorite
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int MealId { get; set; }

        // 0 is for guest users or people who dont want to create a profile
        public int UserProfileId { get; set; }
    }
}