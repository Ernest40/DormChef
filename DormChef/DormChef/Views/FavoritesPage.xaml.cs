using DormChef.Models;
using DormChef.ViewModels;

namespace DormChef.Views
{
    public partial class FavoritesPage : ContentPage
    {
        private readonly FavoritesViewModel _viewModel;

        public FavoritesPage(FavoritesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadFavoritesAsync();
        }

        private async void OnFavoriteMealTapped(object sender, EventArgs e)
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

        private void OnFavoritesNavClicked(object sender, EventArgs e)
        {
            // Already on Favorites
        }

        private async void OnProfileNavClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Services!.GetRequiredService<ProfilePage>());
        }
    }
}