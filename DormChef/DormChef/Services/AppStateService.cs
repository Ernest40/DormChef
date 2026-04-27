namespace DormChef.Services
{
    public class AppStateService
    {
        private const string HasSeenSignupKey = "HasSeenSignup";
        private const string IsGuestKey = "IsGuestUser";
        private const string CurrentUserIdKey = "CurrentUserId";

        public bool HasSeenSignup()
        {
            return Preferences.Get(HasSeenSignupKey, false);
        }

        public void SetHasSeenSignup(bool value)
        {
            Preferences.Set(HasSeenSignupKey, value);
        }

        public bool IsGuestUser()
        {
            return Preferences.Get(IsGuestKey, true);
        }

        public void SetGuestUser(bool value)
        {
            Preferences.Set(IsGuestKey, value);
        }

        public int GetCurrentUserId()
        {
            return Preferences.Get(CurrentUserIdKey, 0);
        }

        public void SetCurrentUserId(int userId)
        {
            Preferences.Set(CurrentUserIdKey, userId);
        }

        public void ClearUserSession()
        {
            Preferences.Set(IsGuestKey, true);
            Preferences.Set(CurrentUserIdKey, 0);
        }
    }
}