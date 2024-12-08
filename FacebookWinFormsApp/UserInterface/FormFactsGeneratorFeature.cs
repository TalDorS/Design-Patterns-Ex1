using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Enums;

namespace BasicFacebookFeatures.UserInterface
{
    public partial class FormFactsGeneratorFeature : Form
    {
        private const int MinFontSize = 13;
        private const int MaxFontSize = 29;
        private readonly User r_LoggedInUser;
        private FactsGenerator m_FactGenerator;
        private readonly Random r_Random;

        public FormFactsGeneratorFeature(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            m_FactGenerator = new FactsGenerator(r_LoggedInUser);
            r_Random = new Random();
            displayNextFact();
        }

        private void displayNextFact()
        {
            string fact = m_FactGenerator.GenerateNextFact();

            buttonNextFact.Enabled = false;
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
            displayNextFact();
        }

        private void applyRandomFontAndSize()
        {
            string[] fontFamilies = { "Arial", "Comic Sans MS", "Verdana", "Tahoma", "Times New Roman" };
            int fontSize = r_Random.Next(MinFontSize, MaxFontSize);
            string fontFamily = fontFamilies[r_Random.Next(fontFamilies.Length)];

            lblFact.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
            lblFact.Width = this.ClientSize.Width - 40; 
            lblFact.MaximumSize = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100);
            lblFact.AutoSize = false;
            lblFact.TextAlign = ContentAlignment.TopCenter;
        }

        private void setImageForFact(eFactType i_FactType)
        {
            eFactType factType = (eFactType)i_FactType;

            switch (factType)
            {
                case eFactType.Friends:
                    pictureBoxFacts.Image = Properties.Resources.FriendsImage;
                    break;
                case eFactType.Posts:
                    pictureBoxFacts.Image = Properties.Resources.PostsImage;
                    break;
                case eFactType.Age:
                    pictureBoxFacts.Image = Properties.Resources.AgeImage;
                    break;
                case eFactType.RelationshipStatus:
                    pictureBoxFacts.Image = Properties.Resources.RelationshipImage;
                    break;
                case eFactType.Hometown:
                    pictureBoxFacts.Image = Properties.Resources.HometownImage;
                    break;
                case eFactType.Gender:
                    pictureBoxFacts.Image = Properties.Resources.GenderImage;
                    break;
                case eFactType.Birthday:
                    pictureBoxFacts.Image = Properties.Resources.BirthdayImage;
                    break;
                case eFactType.ProfilePicture:
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
                case eFactType.LikedPages:
                    pictureBoxFacts.Image = Properties.Resources.LikedPagesImage;
                    break;
                case eFactType.Groups:
                    pictureBoxFacts.Image = Properties.Resources.GroupsImage;
                    break;
                case eFactType.ZodiacSign:
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

            lblFact.ForeColor = colors[r_Random.Next(colors.Length)];
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
