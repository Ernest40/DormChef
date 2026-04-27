using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DormChef.Models;
using DormChef.Services;

namespace DormChef.ViewModels
{
    public class MealDetailViewModel : INotifyPropertyChanged
    {
        private readonly MealDataService _mealDataService;
        private readonly DatabaseService _databaseService;
        private readonly AppStateService _appStateService;

        private Meal? _selectedMeal;
        public Meal? SelectedMeal
        {
            get => _selectedMeal;
            set
            {
                _selectedMeal = value;
                OnPropertyChanged();
            }
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set
            {
                _isFavorite = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FavoriteButtonText));
            }
        }

        public string FavoriteButtonText => IsFavorite ? "Remove from Favorites" : "Add to Favorites";

        public ObservableCollection<string> Ingredients { get; set; } = new();
        public ObservableCollection<string> Steps { get; set; } = new();

        public ICommand ToggleFavoriteCommand { get; }

        public MealDetailViewModel(
            MealDataService mealDataService,
            DatabaseService databaseService,
            AppStateService appStateService)
        {
            _mealDataService = mealDataService;
            _databaseService = databaseService;
            _appStateService = appStateService;

            ToggleFavoriteCommand = new Command(async () => await ToggleFavoriteAsync());
        }

        public async void LoadMealById(int mealId)
        {
            SelectedMeal = _mealDataService.GetMealById(mealId);

            Ingredients.Clear();
            Steps.Clear();

            if (SelectedMeal != null)
            {
                foreach (var ingredient in SelectedMeal.Ingredients)
                    Ingredients.Add(ingredient);

                foreach (var step in SelectedMeal.Steps)
                    Steps.Add(step);
            }

            int currentUserId = _appStateService.GetCurrentUserId();
            IsFavorite = await _databaseService.IsFavoriteAsync(mealId, currentUserId);
        }

        private async Task ToggleFavoriteAsync()
        {
            if (SelectedMeal == null)
                return;

            int currentUserId = _appStateService.GetCurrentUserId();

            if (IsFavorite)
            {
                await _databaseService.RemoveFavoriteAsync(SelectedMeal.Id, currentUserId);
                IsFavorite = false;
            }
            else
            {
                await _databaseService.AddFavoriteAsync(new Favorite
                {
                    MealId = SelectedMeal.Id,
                    UserProfileId = currentUserId
                });

                IsFavorite = true;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}