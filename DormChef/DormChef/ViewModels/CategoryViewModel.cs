using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DormChef.Models;
using DormChef.Services;

namespace DormChef.ViewModels
{
    public class CategoryViewModel : INotifyPropertyChanged
    {
        private readonly MealDataService _mealDataService;

        private string _categoryName = string.Empty;
        public string CategoryName
        {
            get => _categoryName;
            set
            {
                _categoryName = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Meal> Meals { get; set; } = new();

        public CategoryViewModel(MealDataService mealDataService)
        {
            _mealDataService = mealDataService;
        }

        public void LoadCategory(string category)
        {
            CategoryName = category;
            Meals.Clear();

            var meals = _mealDataService.GetMealsByCategory(category);

            foreach (var meal in meals)
                Meals.Add(meal);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}