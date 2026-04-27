using DormChef.Models;
using SQLite;

namespace DormChef.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _database;

        public async Task InitAsync()
        {
            if (_database != null)
                return;

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "dormchef.db3");
            _database = new SQLiteAsyncConnection(dbPath);

            await _database.CreateTableAsync<UserProfile>();
            await _database.CreateTableAsync<Favorite>();
        }

        // This is how the user Profile works

        public async Task<int> SaveUserProfileAsync(UserProfile profile)
        {
            await InitAsync();

            if (profile.Id != 0)
                return await _database.UpdateAsync(profile);

            return await _database.InsertAsync(profile);
        }

        public async Task<UserProfile?> GetUserProfileByIdAsync(int id)
        {
            await InitAsync();
            return await _database.Table<UserProfile>()
                                  .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserProfile?> GetUserProfileByEmailAsync(string email)
        {
            await InitAsync();
            return await _database.Table<UserProfile>()
                                  .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<List<UserProfile>> GetAllProfilesAsync()
        {
            await InitAsync();
            return await _database.Table<UserProfile>().ToListAsync();
        }

        // This is how the favorites works

        public async Task<int> AddFavoriteAsync(Favorite favorite)
        {
            await InitAsync();

            var existingFavorite = await _database.Table<Favorite>()
                .FirstOrDefaultAsync(f => f.MealId == favorite.MealId && f.UserProfileId == favorite.UserProfileId);

            if (existingFavorite != null)
                return 0;

            return await _database.InsertAsync(favorite);
        }

        public async Task<int> RemoveFavoriteAsync(int mealId, int userProfileId)
        {
            await InitAsync();

            var favorite = await _database.Table<Favorite>()
                .FirstOrDefaultAsync(f => f.MealId == mealId && f.UserProfileId == userProfileId);

            if (favorite == null)
                return 0;

            return await _database.DeleteAsync(favorite);
        }

        public async Task<List<Favorite>> GetFavoritesAsync(int userProfileId)
        {
            await InitAsync();

            return await _database.Table<Favorite>()
                                  .Where(f => f.UserProfileId == userProfileId)
                                  .ToListAsync();
        }

        public async Task<bool> IsFavoriteAsync(int mealId, int userProfileId)
        {
            await InitAsync();

            var favorite = await _database.Table<Favorite>()
                .FirstOrDefaultAsync(f => f.MealId == mealId && f.UserProfileId == userProfileId);

            return favorite != null;
        }
    }
}