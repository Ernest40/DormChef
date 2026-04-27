using DormChef.ViewModels;

namespace DormChef.Views
{
    public partial class HomePage : ContentPage
    {
        private readonly HomeViewModel _viewModel;

        public HomePage(HomeViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private async void OnBreakfastClicked(object sender, EventArgs e)
        {
            var page = App.Services!.GetRequiredService<CategoryPage>();
            page.LoadCategory("Breakfast");
            await Navigation.PushAsync(page);
        }

        private async void OnLunchClicked(object sender, EventArgs e)
        {
            var page = App.Services!.GetRequiredService<CategoryPage>();
            page.LoadCategory("Lunch");
            await Navigation.PushAsync(page);
        }

        private async void OnDinnerClicked(object sender, EventArgs e)
        {
            var page = App.Services!.GetRequiredService<CategoryPage>();
            page.LoadCategory("Dinner");
            await Navigation.PushAsync(page);
        }

        private async void OnSnacksClicked(object sender, EventArgs e)
        {
            var page = App.Services!.GetRequiredService<CategoryPage>();
            page.LoadCategory("Snacks");
            await Navigation.PushAsync(page);
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