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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public enum FactType //todo: fix this maybe another class?
        {
            Friends,
            Posts,
            Age,
            RelationshipStatus,
            Hometown,
            Gender,
            Birthday
        }

        private List<FactType> m_Facts;
        private int m_FactIndex = 0;
        private FacebookWrapper.LoginResult m_LoginResult;
        private User m_LoggedInUser;
        public string AccessToken { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_Facts = new List<FactType>
            {
                FactType.Friends,
                FactType.Posts,
                FactType.Age,
                FactType.RelationshipStatus,
                FactType.Hometown,
                FactType.Gender,
                FactType.Birthday
            };
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null|| string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                login();
            }    
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
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

            if (m_LoginResult != null && !string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            if (m_LoginResult != null && !string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }
        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            this.Text = $"Logged in as {m_LoggedInUser.Name}";
            //if (m_LoggedInUser.Posts.Count > 0)
            //{
            //    textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            //}
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI(); 
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            m_LoggedInUser = null;
            pictureBoxProfile.ImageLocation = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerateFact_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                string randomFact = generateNextFact();
                MessageBox.Show(randomFact, "Your Random Fact!");
            }
            else
            {
                MessageBox.Show("Please log in first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string generateNextFact()
        {
            if (m_FactIndex >= m_Facts.Count)
            {
                m_FactIndex = 0; 
            }

            FactType currentFact = m_Facts[m_FactIndex];
            string fact = string.Empty;

            
            switch (currentFact)
            {
                case FactType.Friends:
                    fact = string.Format("You have {0} friends!", m_LoggedInUser.Friends.Count);
                    break;
                case FactType.Posts:
                    fact = string.Format("You've made {0} posts so far!", m_LoggedInUser.Posts.Count);
                    break;
                case FactType.Age:
                    if (DateTime.TryParse(m_LoggedInUser.Birthday, out DateTime birthday))
                    {
                        int age = DateTime.Now.Year - birthday.Year;
                        if (birthday.Date > DateTime.Now.AddYears(-age)) age--;
                        fact = string.Format("You are {0} years old!", age);
                    }
                    break;
                case FactType.RelationshipStatus:
                    fact = string.Format("Your relationship status is: {0}.", m_LoggedInUser.RelationshipStatus);
                    break;
                case FactType.Hometown:
                    fact = string.Format("You live in {0}!", m_LoggedInUser.Hometown?.Name);
                    break;
                case FactType.Gender:
                    fact = string.Format("Your gender is: {0}.", m_LoggedInUser.Gender);
                    break;
                case FactType.Birthday:
                    fact = string.Format("You were born on {0}!", m_LoggedInUser.Birthday);
                    break;
            }

            m_FactIndex++; 

            return fact;
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FacebookWrapper.FacebookService.Logout();

            m_LoginResult = null;
            m_LoggedInUser = null;
            pictureBoxProfile.ImageLocation = null;
        }
    }
}
