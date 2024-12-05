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
        private const string k_DisplayMemberName = "Name";
        private const string k_DisplayMemberMessage = "Message";
        private const string k_NoFriendsMessage = "No friends available";
        private const string k_NoGroupsMessage = "No groups available";
        private const string k_NoEventsMessage = "No events available";
        private const string k_NoPostsMessage = "No posts available";
        private readonly User r_LoggedInUser;
        private FactsGeneratorForm m_FactGenerator;
        private FormYearSummarization m_formYearSummarization;

        public bool LogoutButtonClicked { get; private set; }

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25; 
            r_LoggedInUser = i_LoggedInUser;
            populateLabels();
            populateUserPictureBox();
        }

        private void populateLabels()
        {
            this.labelUser.Text = $"Hello, {r_LoggedInUser.Name}";
        }

        private void populateUserPictureBox()
        {
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
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

        private void buttonViewFriends_Click(object sender, EventArgs e)
        {
            loadFriends();
        }

        private void loadFriends()
        {
            populateListBox(listBoxFriendsList, r_LoggedInUser.Friends, k_DisplayMemberName, k_NoFriendsMessage);
        }

        private void listBoxFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriendsList.SelectedItem is User selectedFriend)
            {
                updateFriendPictureBox(selectedFriend);
            }
        }

        private void updateFriendPictureBox(User i_SelectedFriend)
        {
            try
            {
                pictureBoxFriendPicture.LoadAsync(i_SelectedFriend.PictureNormalURL);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to load friend's picture: {exception.Message}");
            }
        }

        private void buttonViewGroups_Click(object sender, EventArgs e)
        {
            loadGroups();
        }

        private void loadGroups()
        {
            populateListBox(listBoxGroupsList, r_LoggedInUser.Groups, k_DisplayMemberName, k_NoGroupsMessage);
        }

        private void listBoxGroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroupsList.SelectedItem is Group selectedGroup)
            {
                updateGroupPictureBox(selectedGroup);
            }
        }

        private void updateGroupPictureBox(Group i_SelectedGroup)
        {
            try
            {
                pictureBoxGroupPicture.LoadAsync(i_SelectedGroup.PictureNormalURL);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to load group's picture: {exception.Message}");
            }
        }

        private void buttonViewEvents_Click(object sender, EventArgs e)
        {
            loadEvents();
        }

        private void loadEvents()
        {
            populateListBox(listBoxEventsList, r_LoggedInUser.Events, k_DisplayMemberName, k_NoEventsMessage);
        }

        private void listBoxEventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEventsList.SelectedItem is Event selectedEvent)
            {
                updateEventPictureBox(selectedEvent);
            }
        }

        private void updateEventPictureBox(Event i_SelectedEvent)
        {
            try
            {
                pictureBoxEventPicture.LoadAsync(i_SelectedEvent.PictureNormalURL);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to load event's picture: {exception.Message}");
            }
        }

        private void buttonViewPosts_Click(object sender, EventArgs e)
        {
            loadPosts();
        }

        private void loadPosts()
        {
            populateListBox(listBoxPosts, r_LoggedInUser.Posts, k_DisplayMemberMessage, k_NoPostsMessage);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem is Post selectedPost)
            {
                loadPostComments(selectedPost);
            }
        }

        private void loadPostComments(Post i_SelectedPost)
        {
            listBoxPostComments.Items.Clear(); 
            listBoxPostComments.DisplayMember = k_DisplayMemberMessage;

            try
            {
                foreach (Comment comment in i_SelectedPost.Comments)
                {
                    listBoxPostComments.Items.Add(comment);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to load comments: {exception.Message}");
            }
            if (listBoxPostComments.Items.Count == 0)
            {
                MessageBox.Show("No comments available for this post");
            }
        }

        private void buttonGetInfo_Click(object sender, EventArgs e)
        {
            populateInfoLabels();
        }

        private void populateInfoLabels()
        {
            this.labelName.Text = $"Your Name Is: {r_LoggedInUser.Name}";
            this.labelBirthdayDate.Text = $"Your Birthday Date: {r_LoggedInUser.Birthday}";
            this.labelNumberOfFriends.Text = $"You Have {r_LoggedInUser.Friends.Count} Friends";
            this.labelGender.Text = $"Your Gender Is: {r_LoggedInUser.Gender.ToString()}";
            this.labelNumOfPhotos.Text = $"You Have Uploaded {getNumberOfPhotos()} Photos";
            this.labelNumberOfPosts.Text = $"You Have Made {r_LoggedInUser.Posts.Count.ToString()} Posts";
        }

        private int getNumberOfPhotos()
        {
            int totalPhotos = 0;

            try
            {
                foreach (Album album in r_LoggedInUser.Albums)
                {
                    if (album.Photos != null)
                    {
                        totalPhotos += album.Photos.Count;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to calculate the number of photos: {ex.Message}");
            }

            return totalPhotos;
        }

        private void populateListBox<T>(ListBox i_ListBox, IEnumerable<T> i_Items, string i_DisplayMember, string i_EmptyMessage)
        {
            i_ListBox.Items.Clear();
            i_ListBox.DisplayMember = i_DisplayMember;

            try
            {
                foreach (T item in i_Items)
                {
                    i_ListBox.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to load items: {exception.Message}");
            }

            if (i_ListBox.Items.Count == 0)
            {
                MessageBox.Show(i_EmptyMessage);
            }
        }
    }
}
