using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms.VisualStyles;
using System.Net.NetworkInformation;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly RandomFactGenerator r_FactGenerator;

        private readonly User r_LoggedInUser = null;
        public bool LogoutButtonClicked { get; private set; }

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            LogoutButtonClicked = false;
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            r_LoggedInUser = i_LoggedInUser;
            r_FactGenerator = new RandomFactGenerator(i_LoggedInUser);
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            this.labelUsername.Text = $"Logged in as {r_LoggedInUser.Name}";

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked = true;
            FacebookService.LogoutWithUI();
            this.Close();
        }

        private void buttonGenerateFact_Click(object sender, EventArgs e)
        {
            executeGenertor();
        }

       private void executeGenertor()
        {
            if (r_LoggedInUser != null)
            {
                string randomFact = r_FactGenerator.GenerateNextFact();
                MessageBox.Show(randomFact, "Your Random Fact!");
            }
            else
            {
                MessageBox.Show("Please log in first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
