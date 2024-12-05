using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UserInterface
{
    public partial class FactsGeneratorForm : Form
    {

        private readonly User r_LoggedInUser;
        private RandomFactGenerator m_FactGenerator;
        private readonly Random m_Random;

        public FactsGeneratorForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            m_FactGenerator = new RandomFactGenerator(r_LoggedInUser);
            m_Random = new Random();
            DisplayNextFact();
        }

        private void DisplayNextFact()
        {
            buttonNextFact.Enabled = false;
            string fact = m_FactGenerator.GenerateNextFact();
            lblFact.Text = fact;

            setImageForFact(m_FactGenerator.CurrentFact);
            applyRandomFontAndSize();
            applyRandomColor();
            centerLabel();
            this.Invalidate();

            Task.Delay(300).ContinueWith(t =>
            {
                buttonNextFact.Invoke((MethodInvoker)(() => buttonNextFact.Enabled = true));
            });
        }

        private void btnNextFact_Click(object sender, EventArgs e)
        {
            DisplayNextFact();
        }

        private void buttonNextFact_Click(object sender, EventArgs e)
        {
            DisplayNextFact();
        }

        private void applyRandomFontAndSize()
        {
            string[] fontFamilies = { "Arial", "Comic Sans MS", "Verdana", "Tahoma", "Times New Roman" };
            int fontSize = m_Random.Next(10, 29); // Random font size between 10 and 28
            string fontFamily = fontFamilies[m_Random.Next(fontFamilies.Length)];

            lblFact.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
            lblFact.Width = this.ClientSize.Width - 40; 
            lblFact.MaximumSize = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100);
            lblFact.AutoSize = false;
            lblFact.TextAlign = ContentAlignment.TopCenter;
        }
        private void setImageForFact(RandomFactGenerator.FactType factType)
        {
            switch (factType)
            {
                case RandomFactGenerator.FactType.Friends:
                    pictureBoxFacts.Image = Properties.Resources.FriendsImage; 
                    break;
                case RandomFactGenerator.FactType.Posts:
                    pictureBoxFacts.Image = Properties.Resources.PostsImage; 
                    break;
                case RandomFactGenerator.FactType.Age:
                    pictureBoxFacts.Image = Properties.Resources.AgeImage; 
                    break;
                case RandomFactGenerator.FactType.RelationshipStatus:
                    pictureBoxFacts.Image = Properties.Resources.RelationshipImage; 
                    break;
                case RandomFactGenerator.FactType.Hometown:
                    pictureBoxFacts.Image = Properties.Resources.HometownImage;
                    break;
                case RandomFactGenerator.FactType.Gender:
                    pictureBoxFacts.Image = Properties.Resources.GenderImage; 
                    break;
                case RandomFactGenerator.FactType.Birthday:
                    pictureBoxFacts.Image = Properties.Resources.BirthdayImage; 
                    break;
                case RandomFactGenerator.FactType.ProfilePicture:
                    if (Uri.IsWellFormedUriString(r_LoggedInUser.PictureNormalURL, UriKind.Absolute))
                    {
                        try
                        {
                            pictureBoxFacts.Load(r_LoggedInUser.PictureNormalURL); 
                        }
                        catch (Exception)
                        {
                            pictureBoxFacts.Image = Properties.Resources.DefaultProfileImage; 
                        }
                    }
                    else
                    {
                        pictureBoxFacts.Image = Properties.Resources.DefaultProfileImage; 
                    }
                    break;
                case RandomFactGenerator.FactType.LikedPages: // New Fact
                    pictureBoxFacts.Image = Properties.Resources.LikedPagesImage; 
                    break;
                case RandomFactGenerator.FactType.Groups: // New Fact
                    pictureBoxFacts.Image = Properties.Resources.GroupsImage; 
                    break;
                default:
                    pictureBoxFacts.Image = null;
                    break;
            }

            pictureBoxFacts.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void applyRandomColor()
        {
            Color[] colors =
            {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Purple,
                Color.Orange
            };

            lblFact.ForeColor = colors[m_Random.Next(colors.Length)];
        }
        private void centerLabel()
        {
            int verticalOffset = 90;

            lblFact.AutoSize = true;
            lblFact.Left = (this.ClientSize.Width - lblFact.Width) / 2;
            lblFact.Top = (this.ClientSize.Height - lblFact.Height) / 2 - verticalOffset;
        }
    }
}
