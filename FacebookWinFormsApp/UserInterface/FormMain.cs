using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.UserInterface;
using BasicFacebookFeatures.Logic;

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
        private DateTime m_LastLoginTime;
        private FormFactsGeneratorFeature m_FactGenerator;
        private FormYearSummarization m_formYearSummarization;

        public bool LogoutButtonClicked { get; private set; }

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25; 
            r_LoggedInUser = i_LoggedInUser;
            AppSettings appSettings = AppSettings.LoadFromFile();
            if (appSettings.LastUserId != r_LoggedInUser.Id)
            {
                m_LastLoginTime = DateTime.MinValue; 
                appSettings.LastUserId = r_LoggedInUser.Id;
            }
            else
            {
                m_LastLoginTime = appSettings.LastLoginTime == DateTime.MinValue ? DateTime.Now : appSettings.LastLoginTime;
            }
            clearNotifications();
            populateLabels();
            populateUserPictureBox();
        }

        private void populateLabels()
        {
            AppSettings appSettings = AppSettings.LoadFromFile();

            this.labelUser.Text = $"Hello, {r_LoggedInUser.Name}";

            if (appSettings.LastUserId == r_LoggedInUser.Id)
            {
                labelLastSeen.Text = appSettings.LastLoginTime == DateTime.MinValue
                    ? "First time login\n"
                    : $"Last logged in:\n {appSettings.LastLoginTime.ToString("f")}";
            }
            else
            {
                labelLastSeen.Text = "New user, welcome!";
            }

            appSettings.LastLoginTime = DateTime.Now;
            appSettings.LastUserId = r_LoggedInUser.Id;
            appSettings.SaveToFile();
        }

        private void populateUserPictureBox()
        {
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
        }

        private void clearNotifications()
        {
            listBoxNotifications.Items.Clear();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            executeLogout();
        }

        private void executeLogout()
        {
            LogoutButtonClicked = true;
            AppSettings appSettings = AppSettings.LoadFromFile();

            appSettings.RememberUser = false;
            appSettings.LastAccessToken = null;
            appSettings.LastUserId = null; 
            appSettings.SaveToFile();
            FacebookService.Logout();
            this.Hide();
            using (FormLogin formLogin = new FormLogin())
            {
                formLogin.ShowDialog();
            }
            this.Close();
        }

        private void buttonGenerateFact_Click(object sender, EventArgs e)
        {
            if(m_FactGenerator == null)
            {
                m_FactGenerator = new FormFactsGeneratorFeature(r_LoggedInUser);
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
            try
            {
                populateListBox(listBoxFriendsList, r_LoggedInUser.Friends, k_DisplayMemberName, k_NoFriendsMessage);
                addNotification("Successfully loaded friends.");
            }
            catch (Exception ex)
            {
                addNotification($"Failed to load friends: {ex.Message}");
            }
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
            try
            {
                populateListBox(listBoxGroupsList, r_LoggedInUser.Groups, k_DisplayMemberName, k_NoGroupsMessage);
                addNotification("Successfully loaded groups.");
            }
            catch (Exception ex)
            {
                addNotification($"Failed to load groups: {ex.Message}");
            }
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
            try
            {
                populateListBox(listBoxEventsList, r_LoggedInUser.Events, k_DisplayMemberName, k_NoEventsMessage);
                addNotification("Successfully loaded events.");
            }
            catch (Exception ex)
            {
                addNotification($"Failed to load events: {ex.Message}");
            }
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
            try
            {
                populateListBox(listBoxPosts, r_LoggedInUser.Posts, k_DisplayMemberMessage, k_NoPostsMessage);
                addNotification("Successfully loaded posts.");
            }
            catch (Exception ex)
            {
                addNotification($"Failed to load posts: {ex.Message}");
            }
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

        private void buttonGetInsights_Click(object sender, EventArgs e)
        {
            buttonGetInsights.Enabled = false;
            populateInsightsLabels();
            addNotification("Successfully loaded insights.");
            buttonGetInsights.Enabled = true;
        }

        private void populateInsightsLabels()
        {
            try
            {
                if (r_LoggedInUser.Posts?.Count > 0 && r_LoggedInUser.Posts[r_LoggedInUser.Posts.Count - 1].CreatedTime.HasValue)
                {
                    labelJoinedFacebook.Text = $"You joined Facebook on: {r_LoggedInUser.Posts[r_LoggedInUser.Posts.Count - 1].CreatedTime.Value.ToShortDateString()}";
                }
                else
                {
                    labelJoinedFacebook.Text = "Join date information unavailable.";
                }

                labelFirstFirend.Text = r_LoggedInUser.Friends?.Count > 0
                    ? $"Your first friend on Facebook was: {r_LoggedInUser.Friends[0].Name}"
                    : "No friends found.";

                if (r_LoggedInUser.Posts?.Count > 0 && r_LoggedInUser.Posts[0].CreatedTime.HasValue)
                {
                    labelFirstPost.Text = $"You made your first post on: {r_LoggedInUser.Posts[0].CreatedTime.Value.ToShortDateString()}";
                }
                else
                {
                    labelFirstPost.Text = "No posts found.";
                }

                if (r_LoggedInUser.Checkins?.Count > 0 && r_LoggedInUser.Checkins[0].CreatedTime.HasValue)
                {
                    labelFirstCheckin.Text = $"You made your first check-in on: {r_LoggedInUser.Checkins[0].CreatedTime.Value.ToShortDateString()}";
                }
                else
                {
                    labelFirstCheckin.Text = "No check-ins found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching insights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void addNotification(string i_NotificationMessage)
        {
            listBoxNotifications.Items.Add($"{DateTime.Now.ToShortTimeString()} - {i_NotificationMessage}");
            listBoxNotifications.SelectedIndex = listBoxNotifications.Items.Count - 1;
            if (listBoxNotifications.Items.Count > 10) 
            {
                listBoxNotifications.Items.RemoveAt(0);
            }
        }
    }
}
