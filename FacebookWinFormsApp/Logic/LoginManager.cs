using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic
{
    public class LoginManager //todo- need to handle saved user
    {
        public LoginResult LoginResult { get; private set; }

        public AppSettings AppSettings { get; set; }

        public LoginManager()
        {
            LoginResult = null;
            AppSettings = null;
        }

        public bool LoginToFacebook()
        {
            return login();
        }
        public bool login()
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
                "user_photos",
                "user_gender"
            );

            return !string.IsNullOrEmpty(LoginResult.AccessToken);
        }

    }
}
