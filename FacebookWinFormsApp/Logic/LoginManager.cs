using FacebookWrapper;
using System;

namespace BasicFacebookFeatures.Logic
{
    public class LoginManager 
    {
        public LoginResult LoginResult { get; private set; }
        public bool IsAccessTokenValid { get; set; }

        public AppSettings AppSettings { get; set; }

        public LoginManager()
        {
            LoginResult = null;
            AppSettings = null;
            IsAccessTokenValid = false;
        }

        public bool LoginToFacebook()
        {
            FacebookService.Logout();
            return IsAccessTokenValid ? loginWithExistingToken() : loginWithNewToken();
        }

        private bool loginWithExistingToken()
        {
            if (LoginResult.AccessToken != null)
            {
                LoginResult = FacebookService.Connect(LoginResult.AccessToken);
                if (string.IsNullOrEmpty(LoginResult.AccessToken))
                {
                    return loginWithNewToken();
                }
                return true; 
            }
            else
            {
                return loginWithNewToken();
            }
        }

        public void SetLoginResult(LoginResult loginResult)
        {
            LoginResult = loginResult;
        }

        public bool loginWithNewToken()
        {
            LoginResult = FacebookService.Login(
                "3934700983518444",  // app's ID
                "email",
                "public_profile",
                "user_friends",
                "user_birthday",
                "user_posts",
                "user_location",
                "user_hometown",
                "user_events",
                "user_photos",
                "user_gender",
                "user_likes"
            );
            // removed user_groups

            return !string.IsNullOrEmpty(LoginResult.AccessToken);
        }

        public void SaveAppSettings(bool i_IsRememberMeChecked)
        {
            AppSettings.RememberUser = i_IsRememberMeChecked;
            AppSettings.LastAccessToken = i_IsRememberMeChecked ? LoginResult.AccessToken : null;

            if (i_IsRememberMeChecked && !string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                AppSettings.LastLoginTime = DateTime.Now;
            }

            try
            {
                AppSettings.SaveToFile();
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public bool LoadAppSettingsIfExists()
        {
            AppSettings = AppSettings.LoadFromFile();
            if (AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken))
            {
                LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
                IsAccessTokenValid = !string.IsNullOrEmpty(LoginResult.AccessToken);
            }
            return IsAccessTokenValid;
        }
    }
}
