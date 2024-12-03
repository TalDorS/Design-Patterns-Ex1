using BasicFacebookFeatures.Logic;
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
        public FormMain FormMain { get; private set; }
        public LoginManager LoginManager { get; private set; }

        private const bool k_NewLoginToken = true;
        public bool RememberUser { get; private set; }


        public FormLogin()
        {
            InitializeComponent();
            LoginManager = new LoginManager();
            RememberUser = false;
        }

        private void buttonLoginAsDifferentUser_Click(object sender, EventArgs e)
        {

        }

        private void switchForms()
        {
            this.Visible = false;
            FormMain.ShowDialog();
            FormMain.Dispose();
            this.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void executeLogin()
        {
            bool isSuccessfulLogin = LoginManager.LoginToFacebook();

            if (isSuccessfulLogin)
            {
                FormMain = new FormMain(LoginManager.LoginResult.LoggedInUser);
                switchForms();
            }
            else
            {
                MessageBox.Show(LoginManager.LoginResult.ErrorMessage, "Login Failed");
            }
        }
    }

}
