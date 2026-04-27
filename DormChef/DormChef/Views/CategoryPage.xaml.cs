using DormChef.Models;
using DormChef.ViewModels;

namespace DormChef.Views
{
    public partial class CategoryPage : ContentPage
    {
        private readonly CategoryViewModel _viewModel;

        public CategoryPage(CategoryViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        public void LoadCategory(string category)
        {
            _viewModel.LoadCategory(category);
        }

        private async void OnMealTapped(object sender, EventArgs e)
        {
            if (sender is BindableObject bindable && bindable.BindingContext is Meal meal)
            {
                var page = App.Services!.GetRequiredService<MealDetailPage>();
                page.LoadMeal(meal.Id);
                await Navigation.PushAsync(page);
            }
        }

        private async void OnHomeNavClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void OnFavoritesNavClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Services!.GetRequiredService<FavoritesPage>());
        }

        private async void OnProfileNavClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Services!.GetRequiredService<ProfilePage>());
        }
    }
}