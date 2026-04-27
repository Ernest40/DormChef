using DormChef.ViewModels;

namespace DormChef.Views
{
    public partial class MealDetailPage : ContentPage
    {
        private readonly MealDetailViewModel _viewModel;

        public MealDetailPage(MealDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        public void LoadMeal(int mealId)
        {
            _viewModel.LoadMealById(mealId);
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