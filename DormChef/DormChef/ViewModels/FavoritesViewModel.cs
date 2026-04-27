using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DormChef.Models;
using DormChef.Services;

namespace DormChef.ViewModels
{
    public class FavoritesViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseService _databaseService;
        private readonly MealDataService _mealDataService;
        private readonly AppStateService _appStateService;

        public ObservableCollection<Meal> FavoriteMeals { get; set; } = new();

        public FavoritesViewModel(
            DatabaseService databaseService,
            MealDataService mealDataService,
            AppStateService appStateService)
        {
            _databaseService = databaseService;
            _mealDataService = mealDataService;
            _appStateService = appStateService;
        }

        public async Task LoadFavoritesAsync()
        {
            FavoriteMeals.Clear();

            int currentUserId = _appStateService.GetCurrentUserId();
            var favorites = await _databaseService.GetFavoritesAsync(currentUserId);

            foreach (var favorite in favorites)
            {
                var meal = _mealDataService.GetMealById(favorite.MealId);
                if (meal != null)
                    FavoriteMeals.Add(meal);
            }

            OnPropertyChanged(nameof(FavoriteMeals));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}