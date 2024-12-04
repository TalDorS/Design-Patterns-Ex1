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
        }

        protected override void OnShown(EventArgs e)
        {
            m_YearSummarizer = new YearSummarizer(r_LoggedInUser);
        }

        private void buttonSummarizer_Click(object sender, EventArgs e)
        {
            m_YearSummarizer.CurrentYear = this.dateTimePicker1.Value.Year;
            turnControlsVisible();
            populateLabelsText();
            populatePictureBoxes();
            populatePostRichBox();
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
        }

        //TODO: ADD MORE PICTUREBOXES TO POPULATE
        private void populatePictureBoxes()
        {
            Photo firstProfilePhoto = m_YearSummarizer.GetFirstProfilePhoto();

            if (firstProfilePhoto != null)
            {
                setPhotoToPictureBox(pictureBoxProfilePhotos, firstProfilePhoto);
            }
        }

        private void populatePostRichBox()
        {
            Post firstPost = m_YearSummarizer.GetFirstPost();

            if(firstPost != null)
            {
                this.richTextBoxPosts.Text = $"{firstPost.Description}";
            }
        }

        private void setPhotoToPictureBox(PictureBox i_PictureBox, Photo i_Photo)
        {
            i_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            i_PictureBox.LoadAsync(i_Photo.PictureNormalURL);
        }

        private void buttonMoveToLeftProfilePhoto_Click(object sender, EventArgs e)
        {
            Photo previousProfilePhoto = m_YearSummarizer.GetPreviousProfilePhoto();

            setPhotoToPictureBox(pictureBoxProfilePhotos, previousProfilePhoto);
        }

        private void buttonMoveToRightProfilePhoto_Click(object sender, EventArgs e)
        {
            Photo nextProfilePhoto = m_YearSummarizer.GetNextProfilePhoto();



            setPhotoToPictureBox(pictureBoxProfilePhotos, nextProfilePhoto);
        }

        private void buttonMoveToLeftPost_Click(object sender, EventArgs e)
        {
            //if (m_PostListByYear != null && m_PostListByYear.Count > 0 && m_CurrentPostIndex != 0)
            //{
            //    m_CurrentProfilePhotoIndex--;
            //    Post currentPost = m_PostListByYear[m_CurrentPostIndex];
            //    this.labelPosts.Text = $"{currentPost.ToString()}"
            //                           + $"Post Made In {currentPost.CreatedTime.ToString()}";
            //}
        }

        private void buttonMoveToRightPost_Click(object sender, EventArgs e)
        {
            //if (m_PostListByYear != null && m_PostListByYear.Count > 0 && (m_CurrentPostIndex + 1) != m_PostListByYear.Count)
            //{
            //    m_CurrentProfilePhotoIndex++;
            //    Post currentPost = m_PostListByYear[m_CurrentPostIndex];
            //    this.labelPosts.Text = $"{currentPost.ToString()}"
            //                           + $"Post Made In {currentPost.CreatedTime.ToString()}";
            //}
        }
    }
}
