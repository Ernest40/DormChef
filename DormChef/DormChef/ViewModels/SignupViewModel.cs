using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DormChef.Models;
using DormChef.Services;
using DormChef.Views;

namespace DormChef.ViewModels
{
    public class SignupViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseService _databaseService;
        private readonly AppStateService _appStateService;

        private string _email = string.Empty;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _profileName = string.Empty;
        private string _password = string.Empty;

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropertyChanged(); }
        }

        public string LastName
        {
            get => _lastName;
            set { _lastName = value; OnPropertyChanged(); }
        }

        public string ProfileName
        {
            get => _profileName;
            set { _profileName = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand SignUpCommand { get; }
        public ICommand SkipLoginCommand { get; }

        public SignupViewModel(DatabaseService databaseService, AppStateService appStateService)
        {
            _databaseService = databaseService;
            _appStateService = appStateService;

            SignUpCommand = new Command(async () => await SignUpAsync());
            SkipLoginCommand = new Command(async () => await SkipLoginAsync());
        }

        private async Task SignUpAsync()
        {
            if (string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(LastName) ||
                string.IsNullOrWhiteSpace(ProfileName) ||
                string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current!.MainPage!.DisplayAlert(
                    "Missing Info",
                    "Please fill in all fields.",
                    "OK");

                return;
            }

            var existingUser = await _databaseService.GetUserProfileByEmailAsync(Email);

            if (existingUser != null)
            {
                await Application.Current!.MainPage!.DisplayAlert(
                    "Account Exists",
                    "A profile with this email already exists.",
                    "OK");

                return;
            }

            var profile = new UserProfile
            {
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                ProfileName = ProfileName,
                Password = Password
            };

            await _databaseService.SaveUserProfileAsync(profile);

            var savedUser = await _databaseService.GetUserProfileByEmailAsync(Email);

            _appStateService.SetHasSeenSignup(true);
            _appStateService.SetGuestUser(false);
            _appStateService.SetCurrentUserId(savedUser?.Id ?? 0);

            GoToHome();
        }

        private async Task SkipLoginAsync()
        {
            _appStateService.SetHasSeenSignup(true);
            _appStateService.SetGuestUser(true);
            _appStateService.SetCurrentUserId(0);

            await Task.Delay(100);

            GoToHome();
        }

        private void GoToHome()
        {
            Application.Current!.MainPage =
                new NavigationPage(App.Services!.GetRequiredService<HomePage>());
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}