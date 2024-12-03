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
        public enum FactType //todo adva: fix this maybe another class?
        {
            Friends,
            Posts,
            Age,
            RelationshipStatus,
            Hometown,
            Gender,
            Birthday
        }

        private List<FactType> m_Facts;//todo adva
        private int m_FactIndex = 0; //todo adva

        private FacebookWrapper.LoginResult m_LoginResult;
        private readonly User r_LoggedInUser = null;
        public bool LogoutButtonClicked { get; private set; }

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            LogoutButtonClicked = false;
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            r_LoggedInUser = i_LoggedInUser;

            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            this.labelUsername.Text = $"Logged in as {r_LoggedInUser.Name}";

            //todo adva: move to a class
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked = true;
            FacebookService.LogoutWithUI();
            this.Close();
        }

        private void buttonGenerateFact_Click(object sender, EventArgs e)
        {
            executeGenerte();
        }

        private void executeGenerte()
        {
            if (r_LoggedInUser != null)
            {
                string randomFact = generateNextFact();
                MessageBox.Show(randomFact, "Your Random Fact!");
            }
            else
            {
                MessageBox.Show("Please log in first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string generateNextFact() //todo: adva - move to a class
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
                    fact = string.Format("You have {0} friends!", r_LoggedInUser.Friends.Count);
                    break;
                case FactType.Posts:
                    fact = string.Format("You've made {0} posts so far!", r_LoggedInUser.Posts.Count);
                    break;
                case FactType.Age:
                    if (DateTime.TryParse(r_LoggedInUser.Birthday, out DateTime birthday))
                    {
                        int age = DateTime.Now.Year - birthday.Year;
                        if (birthday.Date > DateTime.Now.AddYears(-age)) age--;
                        fact = string.Format("You are {0} years old!", age);
                    }
                    break;
                case FactType.RelationshipStatus:
                    fact = string.Format("Your relationship status is: {0}.", r_LoggedInUser.RelationshipStatus);
                    break;
                case FactType.Hometown:
                    fact = string.Format("You live in {0}!", r_LoggedInUser.Hometown?.Name);
                    break;
                case FactType.Gender:
                    fact = string.Format("Your gender is: {0}.", r_LoggedInUser.Gender);
                    break;
                case FactType.Birthday:
                    fact = string.Format("You were born on {0}!", r_LoggedInUser.Birthday);
                    break;
            }

            m_FactIndex++; 

            return fact;
        }
    }
}
