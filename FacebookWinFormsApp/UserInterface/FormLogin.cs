using BasicFacebookFeatures.Logic;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    public partial class FormLogin : Form
    {
        private const bool k_NewLoginToken = true;
        private const string k_LoginAsUserPlaceholder = "Continue as {0}";

        public bool RememberUser { get; private set; }

        public FormMain FormMain { get; private set; }

        public LoginManager LoginManager { get; private set; }

        public AppSettings AppSettings { get; set; }

        private bool ExitMainWithLogout { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            LoginManager = new LoginManager();
            RememberUser = false;
            ExitMainWithLogout = true;
            updateLoginButtonState();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            checkBoxRememberMe.Checked = LoginManager.LoadAppSettingsIfExists();
            RememberUser = checkBoxRememberMe.Checked;

            if (RememberUser)
            {
                updateUIWithExistingUser();
            }
            updateLoginButtonState();
            checkBoxRememberMe.Checked = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {
                LoginManager.SaveAppSettings(checkBoxRememberMe.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoginAsNewUser_Click(object sender, EventArgs e)
        {
            FacebookService.Logout();
            LoginManager.SetLoginResult(null); 
            buttonLoginAsNewUser.Enabled = false;
            LoginManager.IsAccessTokenValid = false;
            executeLogin();
            buttonLoginAsNewUser.Enabled = true;
        }

        private void switchForms()
        {
            this.Visible = false;
            FormMain.ShowDialog();
            FormMain.Dispose();
            this.Visible = true;
        }

        private void FormLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                doWhenFormIsVisible();
                updateLoginButtonState();
            }
            else
            {
                RememberUser = checkBoxRememberMe.Checked;
            }
        }

        private void doWhenFormIsVisible()
        {
            if (RememberUser || !ExitMainWithLogout)
            {
                updateUIWithExistingUser();
            }
            else
            {
                initializeUIToInitialState();
            }
        }

        private void initializeUIToInitialState()
        {
            checkBoxRememberMe.Checked = false;
            changingButtonVisibility(k_NewLoginToken);
        }
        private void changingButtonVisibility(bool i_NewLoginToken)
        {
            LoginManager.IsAccessTokenValid = !i_NewLoginToken;
            buttonLoginAs.Visible = i_NewLoginToken;
            buttonLoginAsNewUser.Visible = !i_NewLoginToken;
        }

        private void buttonLoginAs_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void executeLogin()
        {
            RememberUser = checkBoxRememberMe.Checked;
            bool isSuccessfulLogin = LoginManager.LoginToFacebook();
            
            if (isSuccessfulLogin && RememberUser)
            {

               updateUIWithExistingUser();
 
            }
            else if (isSuccessfulLogin)
            {
                initiateFacebookFormAfterLogin();
            }
            else
            {
                MessageBox.Show(LoginManager.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void initiateFacebookFormAfterLogin()
        {
            FormMain = new FormMain(LoginManager.LoginResult.LoggedInUser);
            switchForms();
        }

        private void updateUIWithExistingUser()
        {
            try
            {
                if (LoginManager.LoginResult.AccessToken != null && RememberUser)
                {
                    FormMain = new FormMain(LoginManager.LoginResult.LoggedInUser);
                    buttonLoginAs.Text = string.Format(k_LoginAsUserPlaceholder, LoginManager.LoginResult.LoggedInUser.Name);
                    buttonLoginAs.Enabled = true;
                    buttonLoginAsNewUser.Enabled = true;
                    RememberUser = false;
                    LoginManager.IsAccessTokenValid = true;
                    checkBoxRememberMe.Checked = false;
                    switchForms();
                }
                else
                {
                    MessageBox.Show("The saved access token is invalid. Please log in again.", "Login Required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the UI: {ex.Message}", "Error");
            }
        }

        private void updateLoginButtonState()
        {
            if (!LoginManager.IsAccessTokenValid)
            {
                buttonLoginAs.Enabled = false;
            }
            else
            {
                buttonLoginAs.Enabled = true;
            }
        }   
    }
}
