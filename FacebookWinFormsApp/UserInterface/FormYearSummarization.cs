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
        private List<Photo> m_PhotoList;
        private int m_CurrentProfilePhotoIndex = 0;

        public int CurrentYear { get; private set; }

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
            CurrentYear = this.dateTimePicker1.Value.Year;
            m_PhotoList = m_YearSummarizer.GetProfilePhotosByYear(CurrentYear);
            turnControlsVisible();
            populateLabelsText();
            populatePictureBoxes();
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
            this.labelPhotos.Text = $"{CurrentYear}'s Photos, from oldest to newest:";
        }

        private void populatePictureBoxes()
        {
            if (m_PhotoList != null && m_PhotoList.Count > 0)
            {
                setPhotoToPictureBox(pictureBoxProfilePhotos, m_PhotoList[0]);
            }
        }

        private void setPhotoToPictureBox(PictureBox i_PictureBox, Photo i_Photo)
        {
            i_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            i_PictureBox.LoadAsync(i_Photo.PictureNormalURL);
        }

        private void buttonMoveToLeftProfilePhoto_Click(object sender, EventArgs e)
        {
            if (m_PhotoList != null && m_PhotoList.Count > 0 && m_CurrentProfilePhotoIndex != 0)
            {
                m_CurrentProfilePhotoIndex--;
                setPhotoToPictureBox(pictureBoxProfilePhotos, m_PhotoList[m_CurrentProfilePhotoIndex]);
            }
        }

        private void buttonMoveToRightProfilePhoto_Click(object sender, EventArgs e)
        {
            if (m_PhotoList != null && m_PhotoList.Count > 0 && (m_CurrentProfilePhotoIndex + 1) != m_PhotoList.Count)
            {
                m_CurrentProfilePhotoIndex++;
                setPhotoToPictureBox(pictureBoxProfilePhotos, m_PhotoList[m_CurrentProfilePhotoIndex]);
            }
        }
    }
}
