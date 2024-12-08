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
    }
}
