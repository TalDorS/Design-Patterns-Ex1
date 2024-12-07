using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UserInterface
{
    public partial class FormFactsGenerator : Form
    {

        private readonly User r_LoggedInUser;
        private FactGenerator m_FactGenerator;
        private readonly Random m_Random;

        public FormFactsGenerator(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            m_FactGenerator = new FactGenerator(r_LoggedInUser);
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

        private void buttonNextFact_Click(object sender, EventArgs e)
        {
            DisplayNextFact();
        }

        private void applyRandomFontAndSize()
        {
            string[] fontFamilies = { "Arial", "Comic Sans MS", "Verdana", "Tahoma", "Times New Roman" };
            int fontSize = m_Random.Next(13, 29); // Random font size between 13 and 28
            string fontFamily = fontFamilies[m_Random.Next(fontFamilies.Length)];

            lblFact.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
            lblFact.Width = this.ClientSize.Width - 40; 
            lblFact.MaximumSize = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100);
            lblFact.AutoSize = false;
            lblFact.TextAlign = ContentAlignment.TopCenter;
        }
        private void setImageForFact(FactGenerator.FactType factType)
        {
            switch (factType)
            {
                case FactGenerator.FactType.Friends:
                    pictureBoxFacts.Image = Properties.Resources.FriendsImage; 
                    break;
                case FactGenerator.FactType.Posts:
                    pictureBoxFacts.Image = Properties.Resources.PostsImage; 
                    break;
                case FactGenerator.FactType.Age:
                    pictureBoxFacts.Image = Properties.Resources.AgeImage; 
                    break;
                case FactGenerator.FactType.RelationshipStatus:
                    pictureBoxFacts.Image = Properties.Resources.RelationshipImage; 
                    break;
                case FactGenerator.FactType.Hometown:
                    pictureBoxFacts.Image = Properties.Resources.HometownImage;
                    break;
                case FactGenerator.FactType.Gender:
                    pictureBoxFacts.Image = Properties.Resources.GenderImage; 
                    break;
                case FactGenerator.FactType.Birthday:
                    pictureBoxFacts.Image = Properties.Resources.BirthdayImage; 
                    break;
                case FactGenerator.FactType.ProfilePicture:
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
                case FactGenerator.FactType.LikedPages:
                    pictureBoxFacts.Image = Properties.Resources.LikedPagesImage; 
                    break;
                case FactGenerator.FactType.Groups: 
                    pictureBoxFacts.Image = Properties.Resources.GroupsImage; 
                    break;
                case FactGenerator.FactType.ZodiacSign: 
                    pictureBoxFacts.Image = Properties.Resources.ZodiacImage;
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
                Color.Orange,
                Color.Brown,
                Color.Black,
                Color.Yellow,
                Color.Pink
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

        private void buttonShareFact_Click(object sender, EventArgs e)
        {
            executeShareFact();
        }

        private void executeShareFact()
        {
            string factToShare = lblFact.Text;
            Clipboard.SetText(factToShare); 
            MessageBox.Show("Fact copied to clipboard! Share it with your friends!");
        }
    }
}
