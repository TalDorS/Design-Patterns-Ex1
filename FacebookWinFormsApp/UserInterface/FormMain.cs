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
using BasicFacebookFeatures.UserInterface;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FactsGeneratorForm m_FactGenerator;
        private readonly User r_LoggedInUser = null;
        private FormYearSummarization m_formYearSummarization;

        public bool LogoutButtonClicked { get; private set; }

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            LogoutButtonClicked = false;
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            r_LoggedInUser = i_LoggedInUser;
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            this.labelUsername.Text = $"Logged in as {r_LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked = true;
            FacebookService.Logout();
            this.Close();
        }

        private void buttonGenerateFact_Click(object sender, EventArgs e)
        {
            if(m_FactGenerator == null)
            {
                m_FactGenerator = new FactsGeneratorForm(r_LoggedInUser);
            }

            m_FactGenerator.ShowDialog();
        }

        private void buttonYearSummary_Click(object sender, EventArgs e)
        {
            if(m_formYearSummarization == null)
            {
                m_formYearSummarization = new FormYearSummarization(r_LoggedInUser);
            }

            m_formYearSummarization.ShowDialog();
        }
    }
}
