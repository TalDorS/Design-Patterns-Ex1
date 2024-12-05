using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.UserInterface
{
    public partial class FormYearSummarization : Form
    {
        private readonly User r_LoggedInUser;
        private YearSummarizer m_YearSummarizer;

        public FormYearSummarization(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            this.labelEnterYearPrompt.Text = $"Please choose a year between 2004-{DateTime.Now.Year}";
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_YearSummarizer = new YearSummarizer(r_LoggedInUser);
        }

        private void buttonSummarizer_Click(object sender, EventArgs e)
        {
            summarizeYear();
        }

        private void turnControlsVisible()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }

        private void populateLabelsText()
        {
            this.labelPhotos.Text = $"{m_YearSummarizer.CurrentYear}'s Photos, from oldest to newest:";
            this.labelPosts.Text = $"{m_YearSummarizer.CurrentYear}'s Posts, from oldest to newest:";
            this.labelEvents.Text = $"{m_YearSummarizer.CurrentYear}'s Events, from oldest to newest:";
        }

        private void populatePictureBoxes()
        {
            Photo firstProfilePhoto = m_YearSummarizer.GetFirstProfilePhoto();

            if (firstProfilePhoto != null)
            {
                setPhotoToPictureBox(pictureBoxProfilePhotos, firstProfilePhoto);
            }
            else
            {
                clearPictureBox(pictureBoxProfilePhotos);
            }
        }

        private void populatePostRichBox()
        {
            Post firstPost = m_YearSummarizer.GetFirstPost();

            if (firstPost != null)
            {
                this.richTextBoxPosts.Text = firstPost.ToString();
            }
            else
            {
                this.richTextBoxPosts.Text = "No posts available for the selected year.";
            }
        }

        private void populateEvents()
        {
            Event firstEvent = m_YearSummarizer.GetFirstEvent();

            if (firstEvent != null)
            {
                updateEventUI(firstEvent);
            }
            else
            {
                richTextBoxEventName.Text = string.Empty;
                richTextBoxEventStartDate.Text = string.Empty;
                richTextBoxEventEndDate.Text = string.Empty;
                clearPictureBox(pictureBoxEvents);
            }
        }

        private void setPhotoToPictureBox(PictureBox i_PictureBox, Photo i_Photo)
        {
            i_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                i_PictureBox.LoadAsync(i_Photo.PictureNormalURL);
            }
            catch
            {
                clearPictureBox(i_PictureBox);
            }
        }

        private void clearPictureBox(PictureBox i_PictureBox)
        {
            i_PictureBox.Image = null;
            i_PictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void buttonMoveToLeftProfilePhoto_Click(object sender, EventArgs e)
        {
            Photo previousProfilePhoto = m_YearSummarizer.GetPreviousProfilePhoto();

            if (previousProfilePhoto != null)
            {
                setPhotoToPictureBox(pictureBoxProfilePhotos, previousProfilePhoto);
            }
        }

        private void buttonMoveToRightProfilePhoto_Click(object sender, EventArgs e)
        {
            Photo nextProfilePhoto = m_YearSummarizer.GetNextProfilePhoto();

            if (nextProfilePhoto != null)
            {
                setPhotoToPictureBox(pictureBoxProfilePhotos, nextProfilePhoto);
            }
        }

        private void buttonMoveToLeftPost_Click(object sender, EventArgs e)
        {
            updatePostUI(m_YearSummarizer.GetPreviousPost());
        }

        private void buttonMoveToRightPost_Click(object sender, EventArgs e)
        {
            updatePostUI(m_YearSummarizer.GetNextPost());
        }

        private void buttonMoveToLeftEvent_Click(object sender, EventArgs e)
        {
            updateEventUI(m_YearSummarizer.GetPreviousEvent());
        }

        private void buttonMoveToRightEvent_Click(object sender, EventArgs e)
        {
            updateEventUI(m_YearSummarizer.GetNextEvent());
        }

        private void updateEventUI(Event i_Event)
        {
            if (i_Event != null)
            {
                pictureBoxEvents.LoadAsync(i_Event.PictureNormalURL);
                richTextBoxEventName.Text = i_Event.Name;
                richTextBoxEventStartDate.Text = i_Event.StartTime.ToString();
                richTextBoxEventEndDate.Text = i_Event.EndTime.ToString();
            }
        }

        private void updatePostUI(Post i_Post)
        {
            if (i_Post == null)
            {
                return;
            }

            richTextBoxPosts.Text = i_Post.ToString();
        }

        private void summarizeYear()
        {
            int selectedYear = this.dateTimePicker1.Value.Year;
            m_YearSummarizer.PopulateLists(selectedYear);

            updateUIForSummarizedYear();
        }

        private void updateUIForSummarizedYear()
        {
            turnControlsVisible();
            populateLabelsText();
            populatePictureBoxes();
            populatePostRichBox();
            populateEvents();
        }
    }
}
