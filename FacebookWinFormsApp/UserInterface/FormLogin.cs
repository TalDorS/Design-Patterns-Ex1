using BasicFacebookFeatures.Logic;
using FacebookWrapper;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UserInterface
{
    public partial class FormLogin : Form
    {
        public bool RememberUser { get; private set; }

        public FormMain FormMain { get; private set; }

        public LoginManager LoginManager { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
            LoginManager = new LoginManager();
            RememberUser = false;
            checkBoxRememberMe.Checked = false;
            updateLoginButtonState();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bool isRemembered = LoginManager.LoadAppSettingsIfExists();

            if (!isRemembered)
            {
                LoginManager.AppSettings.LastAccessToken = null;
                LoginManager.SaveAppSettings(false);
            }

            updateLoginButtonState();
        }

        private void buttonLoginAsNewUser_Click(object sender, EventArgs e)
        {
            loginAsNewUser();
        }

        private void loginAsNewUser()
        {
            FacebookService.Logout();
            LoginManager.SetLoginResult(null);
            LoginManager.IsAccessTokenValid = false;
            if (LoginManager.LoginWithNewToken())
            {
                RememberUser = checkBoxRememberMe.Checked;
                if (!RememberUser)
                {
                    LoginManager.AppSettings.LastAccessToken = null;
                }

                LoginManager.SaveAppSettings(RememberUser);
                initiateFacebookFormAfterLogin();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.", "Error");
            }
        }

        private void switchForms()
        {
            this.Visible = false;
            FormMain.ShowDialog();
            FormMain.Dispose();
        }

        private void buttonLoginAsExisting_Click(object sender, EventArgs e)
        {
            loginAsRememberedUser();
        }

        private void loginAsRememberedUser()
        {
            if (LoginManager.IsAccessTokenValid)
            {
                initiateFacebookFormAfterLogin();
                this.Close();
            }
            else
            {
                MessageBox.Show("No valid remembered session. Please log in as a new user.", "Login Required");
            }
        }

        private void initiateFacebookFormAfterLogin()
        {
            FormMain = new FormMain(LoginManager.LoginResult.LoggedInUser);
            switchForms();
        }

        private void updateLoginButtonState()
        {
            buttonLoginAsExisting.Enabled = LoginManager.IsAccessTokenValid;
        }


        //private void FormLogin_VisibleChanged(object sender, EventArgs e)
        //{
        //    if (this.Visible)
        //    {
        //        if (LoginManager.IsAccessTokenValid)
        //        {
        //            updateUIWithExistingUser();
        //        }
        //        else
        //        {
        //            initializeUIToInitialState();
        //        }
        //    }
        //}

        //private void initializeUIToInitialState()
        //{
        //    checkBoxRememberMe.Checked = false;
        //    changingButtonVisibility(k_NewLoginToken);
        //}

        //private void changingButtonVisibility(bool i_NewLoginToken)
        //{
        //    LoginManager.IsAccessTokenValid = !i_NewLoginToken;
        //    buttonLoginAs.Visible = i_NewLoginToken;
        //    buttonLoginAsNewUser.Visible = !i_NewLoginToken;
        //}

        //private void executeLogin()
        //{
        //    RememberUser = checkBoxRememberMe.Checked;
        //    bool isSuccessfulLogin = LoginManager.LoginToFacebook();

        //    if (isSuccessfulLogin && RememberUser)
        //    {

        //        updateUIWithExistingUser();

        //    }
        //    else if (isSuccessfulLogin)
        //    {
        //        initiateFacebookFormAfterLogin();
        //    }
        //    else
        //    {
        //        MessageBox.Show(LoginManager.LoginResult.ErrorMessage, "Login Failed");
        //    }
        //}

        //private void updateUIWithExistingUser()
        //{
        //    try
        //    {
        //        if (LoginManager.LoginResult.AccessToken != null && RememberUser)
        //        {
        //            FormMain = new FormMain(LoginManager.LoginResult.LoggedInUser);
        //            buttonLoginAs.Text = string.Format(k_LoginAsUserPlaceholder, LoginManager.LoginResult.LoggedInUser.Name);
        //            buttonLoginAs.Enabled = true;
        //            buttonLoginAsNewUser.Enabled = true;
        //            RememberUser = false;
        //            LoginManager.IsAccessTokenValid = true;
        //            checkBoxRememberMe.Checked = false;
        //            switchForms();
        //        }
        //        else
        //        {
        //            MessageBox.Show("The saved access token is invalid. Please log in again.", "Login Required");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while updating the UI: {ex.Message}", "Error");
        //    }
        //}
    }
}
