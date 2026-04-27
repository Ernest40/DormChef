using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DormChef.Models;
using DormChef.Services;

namespace DormChef.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseService _databaseService;
        private readonly AppStateService _appStateService;

        private bool _isGuest;
        public bool IsGuest
        {
            get => _isGuest;
            set
            {
                _isGuest = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsLoggedIn));
            }
        }

        public bool IsLoggedIn => !IsGuest;

        private UserProfile? _currentProfile;
        public UserProfile? CurrentProfile
        {
            get => _currentProfile;
            set
            {
                _currentProfile = value;
                OnPropertyChanged();
            }
        }

        public ICommand ContinueAsGuestCommand { get; }

        public ProfileViewModel(DatabaseService databaseService, AppStateService appStateService)
        {
            _databaseService = databaseService;
            _appStateService = appStateService;

            ContinueAsGuestCommand = new Command(SetGuestMode);
        }

        public async Task LoadProfileAsync()
        {
            int currentUserId = _appStateService.GetCurrentUserId();

            IsGuest = _appStateService.IsGuestUser() || currentUserId == 0;

            if (IsGuest)
            {
                CurrentProfile = null;
                return;
            }

            CurrentProfile = await _databaseService.GetUserProfileByIdAsync(currentUserId);
        }

        private void SetGuestMode()
        {
            _appStateService.ClearUserSession();
            IsGuest = true;
            CurrentProfile = null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}