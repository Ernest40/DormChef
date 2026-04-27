using DormChef.ViewModels;

namespace DormChef.Views
{
    public partial class ProfilePage : ContentPage
    {
        private readonly ProfileViewModel _viewModel;

        public ProfilePage(ProfileViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadProfileAsync();
        }

        private async void OnCreateProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Services!.GetRequiredService<SignUpPage>());
        }

        private async void OnHomeNavClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void OnFavoritesNavClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(App.Services!.GetRequiredService<FavoritesPage>());
        }
    }
}