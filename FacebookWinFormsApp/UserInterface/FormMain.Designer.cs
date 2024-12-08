using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonYearSummary = new System.Windows.Forms.Button();
            this.buttonGenerateFacts = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.groupBoxExclusiveFeatures = new System.Windows.Forms.GroupBox();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.buttonViewFriends = new System.Windows.Forms.Button();
            this.buttonViewGroups = new System.Windows.Forms.Button();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.pictureBoxGroupPicture = new System.Windows.Forms.PictureBox();
            this.listBoxGroupsList = new System.Windows.Forms.ListBox();
            this.buttonViewEvents = new System.Windows.Forms.Button();
            this.groupBoxEvents = new System.Windows.Forms.GroupBox();
            this.pictureBoxEventPicture = new System.Windows.Forms.PictureBox();
            this.listBoxEventsList = new System.Windows.Forms.ListBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxPosts = new System.Windows.Forms.GroupBox();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonViewPosts = new System.Windows.Forms.Button();
            this.labelJoinedFacebook = new System.Windows.Forms.Label();
            this.labelFirstFirend = new System.Windows.Forms.Label();
            this.labelFirstPost = new System.Windows.Forms.Label();
            this.groupBoxFacebookUsageInsights = new System.Windows.Forms.GroupBox();
            this.labelFirstCheckin = new System.Windows.Forms.Label();
            this.buttonGetInsights = new System.Windows.Forms.Button();
            this.groupBoxLastSeen = new System.Windows.Forms.GroupBox();
            this.labelLastSeen = new System.Windows.Forms.Label();
            this.groupBoxNotifications = new System.Windows.Forms.GroupBox();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.groupBoxExclusiveFeatures.SuspendLayout();
            this.groupBoxFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
            this.groupBoxGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupPicture)).BeginInit();
            this.groupBoxEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPosts.SuspendLayout();
            this.groupBoxFacebookUsageInsights.SuspendLayout();
            this.groupBoxLastSeen.SuspendLayout();
            this.groupBoxNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Location = new System.Drawing.Point(773, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(109, 34);
            this.buttonLogout.TabIndex = 65;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonYearSummary
            // 
            this.buttonYearSummary.BackColor = System.Drawing.Color.Turquoise;
            this.buttonYearSummary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYearSummary.ForeColor = System.Drawing.Color.White;
            this.buttonYearSummary.Location = new System.Drawing.Point(20, 76);
            this.buttonYearSummary.Name = "buttonYearSummary";
            this.buttonYearSummary.Size = new System.Drawing.Size(236, 42);
            this.buttonYearSummary.TabIndex = 64;
            this.buttonYearSummary.Text = "Year Summarizer";
            this.buttonYearSummary.UseVisualStyleBackColor = false;
            this.buttonYearSummary.Click += new System.EventHandler(this.buttonYearSummary_Click);
            // 
            // buttonGenerateFacts
            // 
            this.buttonGenerateFacts.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonGenerateFacts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateFacts.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateFacts.Location = new System.Drawing.Point(21, 27);
            this.buttonGenerateFacts.Name = "buttonGenerateFacts";
            this.buttonGenerateFacts.Size = new System.Drawing.Size(234, 43);
            this.buttonGenerateFacts.TabIndex = 63;
            this.buttonGenerateFacts.Text = "Facts Generator";
            this.buttonGenerateFacts.UseVisualStyleBackColor = false;
            this.buttonGenerateFacts.Click += new System.EventHandler(this.buttonGenerateFact_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.panelHeader.Controls.Add(this.labelUser);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.buttonLogout);
            this.panelHeader.Controls.Add(this.pictureBoxFacebook);
            this.panelHeader.Controls.Add(this.pictureBoxProfile);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(956, 76);
            this.panelHeader.TabIndex = 68;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(85, 38);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(59, 21);
            this.labelUser.TabIndex = 63;
            this.labelUser.Text = "Hello, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(706, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Made By Adva Levine and Tal Dor ©";
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(889, 6);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 0;
            this.pictureBoxFacebook.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(67, 65);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 62;
            this.pictureBoxProfile.TabStop = false;
            // 
            // groupBoxExclusiveFeatures
            // 
            this.groupBoxExclusiveFeatures.Controls.Add(this.buttonGenerateFacts);
            this.groupBoxExclusiveFeatures.Controls.Add(this.buttonYearSummary);
            this.groupBoxExclusiveFeatures.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExclusiveFeatures.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBoxExclusiveFeatures.Location = new System.Drawing.Point(368, 247);
            this.groupBoxExclusiveFeatures.Name = "groupBoxExclusiveFeatures";
            this.groupBoxExclusiveFeatures.Size = new System.Drawing.Size(279, 132);
            this.groupBoxExclusiveFeatures.TabIndex = 69;
            this.groupBoxExclusiveFeatures.TabStop = false;
            this.groupBoxExclusiveFeatures.Text = "Our Exclusive Features!";
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.Controls.Add(this.pictureBoxFriendPicture);
            this.groupBoxFriends.Controls.Add(this.listBoxFriendsList);
            this.groupBoxFriends.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(206)))), ((int)(((byte)(191)))));
            this.groupBoxFriends.Location = new System.Drawing.Point(6, 28);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(303, 107);
            this.groupBoxFriends.TabIndex = 62;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Your Friends";
            // 
            // pictureBoxFriendPicture
            // 
            this.pictureBoxFriendPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFriendPicture.Location = new System.Drawing.Point(194, 24);
            this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
            this.pictureBoxFriendPicture.Size = new System.Drawing.Size(100, 84);
            this.pictureBoxFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendPicture.TabIndex = 72;
            this.pictureBoxFriendPicture.TabStop = false;
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 20;
            this.listBoxFriendsList.Location = new System.Drawing.Point(6, 26);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(182, 64);
            this.listBoxFriendsList.TabIndex = 71;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // buttonViewFriends
            // 
            this.buttonViewFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(206)))), ((int)(((byte)(191)))));
            this.buttonViewFriends.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewFriends.ForeColor = System.Drawing.Color.White;
            this.buttonViewFriends.Location = new System.Drawing.Point(83, 141);
            this.buttonViewFriends.Name = "buttonViewFriends";
            this.buttonViewFriends.Size = new System.Drawing.Size(151, 39);
            this.buttonViewFriends.TabIndex = 71;
            this.buttonViewFriends.Text = "View Friends";
            this.buttonViewFriends.UseVisualStyleBackColor = false;
            this.buttonViewFriends.Click += new System.EventHandler(this.buttonViewFriends_Click);
            // 
            // buttonViewGroups
            // 
            this.buttonViewGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.buttonViewGroups.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewGroups.ForeColor = System.Drawing.Color.White;
            this.buttonViewGroups.Location = new System.Drawing.Point(83, 297);
            this.buttonViewGroups.Name = "buttonViewGroups";
            this.buttonViewGroups.Size = new System.Drawing.Size(151, 39);
            this.buttonViewGroups.TabIndex = 73;
            this.buttonViewGroups.Text = "View Groups";
            this.buttonViewGroups.UseVisualStyleBackColor = false;
            this.buttonViewGroups.Click += new System.EventHandler(this.buttonViewGroups_Click);
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.pictureBoxGroupPicture);
            this.groupBoxGroups.Controls.Add(this.listBoxGroupsList);
            this.groupBoxGroups.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(168)))), ((int)(((byte)(241)))));
            this.groupBoxGroups.Location = new System.Drawing.Point(6, 182);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(303, 107);
            this.groupBoxGroups.TabIndex = 72;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Your Groups";
            // 
            // pictureBoxGroupPicture
            // 
            this.pictureBoxGroupPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxGroupPicture.Location = new System.Drawing.Point(194, 24);
            this.pictureBoxGroupPicture.Name = "pictureBoxGroupPicture";
            this.pictureBoxGroupPicture.Size = new System.Drawing.Size(100, 84);
            this.pictureBoxGroupPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroupPicture.TabIndex = 72;
            this.pictureBoxGroupPicture.TabStop = false;
            // 
            // listBoxGroupsList
            // 
            this.listBoxGroupsList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroupsList.FormattingEnabled = true;
            this.listBoxGroupsList.ItemHeight = 20;
            this.listBoxGroupsList.Location = new System.Drawing.Point(6, 26);
            this.listBoxGroupsList.Name = "listBoxGroupsList";
            this.listBoxGroupsList.Size = new System.Drawing.Size(182, 64);
            this.listBoxGroupsList.TabIndex = 71;
            this.listBoxGroupsList.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupsList_SelectedIndexChanged);
            // 
            // buttonViewEvents
            // 
            this.buttonViewEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.buttonViewEvents.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewEvents.ForeColor = System.Drawing.Color.White;
            this.buttonViewEvents.Location = new System.Drawing.Point(89, 445);
            this.buttonViewEvents.Name = "buttonViewEvents";
            this.buttonViewEvents.Size = new System.Drawing.Size(151, 39);
            this.buttonViewEvents.TabIndex = 75;
            this.buttonViewEvents.Text = "View Events";
            this.buttonViewEvents.UseVisualStyleBackColor = false;
            this.buttonViewEvents.Click += new System.EventHandler(this.buttonViewEvents_Click);
            // 
            // groupBoxEvents
            // 
            this.groupBoxEvents.Controls.Add(this.pictureBoxEventPicture);
            this.groupBoxEvents.Controls.Add(this.listBoxEventsList);
            this.groupBoxEvents.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.groupBoxEvents.Location = new System.Drawing.Point(6, 336);
            this.groupBoxEvents.Name = "groupBoxEvents";
            this.groupBoxEvents.Size = new System.Drawing.Size(309, 107);
            this.groupBoxEvents.TabIndex = 74;
            this.groupBoxEvents.TabStop = false;
            this.groupBoxEvents.Text = "Your Events";
            // 
            // pictureBoxEventPicture
            // 
            this.pictureBoxEventPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(203, 23);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(100, 84);
            this.pictureBoxEventPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEventPicture.TabIndex = 72;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // listBoxEventsList
            // 
            this.listBoxEventsList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEventsList.FormattingEnabled = true;
            this.listBoxEventsList.ItemHeight = 20;
            this.listBoxEventsList.Location = new System.Drawing.Point(6, 24);
            this.listBoxEventsList.Name = "listBoxEventsList";
            this.listBoxEventsList.Size = new System.Drawing.Size(182, 64);
            this.listBoxEventsList.TabIndex = 71;
            this.listBoxEventsList.SelectedIndexChanged += new System.EventHandler(this.listBoxEventsList_SelectedIndexChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.groupBoxFriends);
            this.groupBoxInfo.Controls.Add(this.buttonViewEvents);
            this.groupBoxInfo.Controls.Add(this.buttonViewFriends);
            this.groupBoxInfo.Controls.Add(this.groupBoxEvents);
            this.groupBoxInfo.Controls.Add(this.groupBoxGroups);
            this.groupBoxInfo.Controls.Add(this.buttonViewGroups);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.ForeColor = System.Drawing.Color.Pink;
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 82);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(333, 497);
            this.groupBoxInfo.TabIndex = 73;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Your Profile";
            // 
            // groupBoxPosts
            // 
            this.groupBoxPosts.Controls.Add(this.listBoxPostComments);
            this.groupBoxPosts.Controls.Add(this.listBoxPosts);
            this.groupBoxPosts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(93)))));
            this.groupBoxPosts.Location = new System.Drawing.Point(368, 392);
            this.groupBoxPosts.Name = "groupBoxPosts";
            this.groupBoxPosts.Size = new System.Drawing.Size(568, 140);
            this.groupBoxPosts.TabIndex = 74;
            this.groupBoxPosts.TabStop = false;
            this.groupBoxPosts.Text = "Your Posts";
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 20;
            this.listBoxPostComments.Location = new System.Drawing.Point(272, 31);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(288, 104);
            this.listBoxPostComments.TabIndex = 72;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(6, 31);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(260, 104);
            this.listBoxPosts.TabIndex = 71;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(93)))));
            this.buttonViewPosts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewPosts.ForeColor = System.Drawing.Color.White;
            this.buttonViewPosts.Location = new System.Drawing.Point(558, 532);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(151, 39);
            this.buttonViewPosts.TabIndex = 75;
            this.buttonViewPosts.Text = "View Posts";
            this.buttonViewPosts.UseVisualStyleBackColor = false;
            this.buttonViewPosts.Click += new System.EventHandler(this.buttonViewPosts_Click);
            // 
            // labelJoinedFacebook
            // 
            this.labelJoinedFacebook.AutoSize = true;
            this.labelJoinedFacebook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoinedFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelJoinedFacebook.Location = new System.Drawing.Point(7, 33);
            this.labelJoinedFacebook.Name = "labelJoinedFacebook";
            this.labelJoinedFacebook.Size = new System.Drawing.Size(162, 19);
            this.labelJoinedFacebook.TabIndex = 77;
            this.labelJoinedFacebook.Text = "You joined Facebook on: ";
            // 
            // labelFirstFirend
            // 
            this.labelFirstFirend.AutoSize = true;
            this.labelFirstFirend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstFirend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelFirstFirend.Location = new System.Drawing.Point(7, 59);
            this.labelFirstFirend.Name = "labelFirstFirend";
            this.labelFirstFirend.Size = new System.Drawing.Size(215, 19);
            this.labelFirstFirend.TabIndex = 78;
            this.labelFirstFirend.Text = "Your first friend on Facebook was:";
            // 
            // labelFirstPost
            // 
            this.labelFirstPost.AutoSize = true;
            this.labelFirstPost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelFirstPost.Location = new System.Drawing.Point(6, 87);
            this.labelFirstPost.Name = "labelFirstPost";
            this.labelFirstPost.Size = new System.Drawing.Size(187, 19);
            this.labelFirstPost.TabIndex = 79;
            this.labelFirstPost.Text = "You made your first post on: ";
            // 
            // groupBoxFacebookUsageInsights
            // 
            this.groupBoxFacebookUsageInsights.Controls.Add(this.labelFirstCheckin);
            this.groupBoxFacebookUsageInsights.Controls.Add(this.labelFirstPost);
            this.groupBoxFacebookUsageInsights.Controls.Add(this.labelFirstFirend);
            this.groupBoxFacebookUsageInsights.Controls.Add(this.labelJoinedFacebook);
            this.groupBoxFacebookUsageInsights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFacebookUsageInsights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(170)))));
            this.groupBoxFacebookUsageInsights.Location = new System.Drawing.Point(351, 84);
            this.groupBoxFacebookUsageInsights.Name = "groupBoxFacebookUsageInsights";
            this.groupBoxFacebookUsageInsights.Size = new System.Drawing.Size(378, 148);
            this.groupBoxFacebookUsageInsights.TabIndex = 76;
            this.groupBoxFacebookUsageInsights.TabStop = false;
            this.groupBoxFacebookUsageInsights.Text = "Faceebok Usage Insights";
            // 
            // labelFirstCheckin
            // 
            this.labelFirstCheckin.AutoSize = true;
            this.labelFirstCheckin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelFirstCheckin.Location = new System.Drawing.Point(6, 116);
            this.labelFirstCheckin.Name = "labelFirstCheckin";
            this.labelFirstCheckin.Size = new System.Drawing.Size(169, 19);
            this.labelFirstCheckin.TabIndex = 80;
            this.labelFirstCheckin.Text = "Your first check-in was at: ";
            // 
            // buttonGetInsights
            // 
            this.buttonGetInsights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(170)))));
            this.buttonGetInsights.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetInsights.ForeColor = System.Drawing.Color.White;
            this.buttonGetInsights.Location = new System.Drawing.Point(735, 204);
            this.buttonGetInsights.Name = "buttonGetInsights";
            this.buttonGetInsights.Size = new System.Drawing.Size(149, 36);
            this.buttonGetInsights.TabIndex = 77;
            this.buttonGetInsights.Text = "Get Insights";
            this.buttonGetInsights.UseVisualStyleBackColor = false;
            this.buttonGetInsights.Click += new System.EventHandler(this.buttonGetInsights_Click);
            // 
            // groupBoxLastSeen
            // 
            this.groupBoxLastSeen.Controls.Add(this.labelLastSeen);
            this.groupBoxLastSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLastSeen.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBoxLastSeen.Location = new System.Drawing.Point(742, 85);
            this.groupBoxLastSeen.Name = "groupBoxLastSeen";
            this.groupBoxLastSeen.Size = new System.Drawing.Size(195, 88);
            this.groupBoxLastSeen.TabIndex = 81;
            this.groupBoxLastSeen.TabStop = false;
            this.groupBoxLastSeen.Text = "Last seen";
            // 
            // labelLastSeen
            // 
            this.labelLastSeen.AutoSize = true;
            this.labelLastSeen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastSeen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelLastSeen.Location = new System.Drawing.Point(7, 33);
            this.labelLastSeen.Name = "labelLastSeen";
            this.labelLastSeen.Size = new System.Drawing.Size(55, 15);
            this.labelLastSeen.TabIndex = 77;
            this.labelLastSeen.Text = "Last seen";
            // 
            // groupBoxNotifications
            // 
            this.groupBoxNotifications.BackColor = System.Drawing.Color.LightYellow;
            this.groupBoxNotifications.Controls.Add(this.listBoxNotifications);
            this.groupBoxNotifications.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBoxNotifications.Location = new System.Drawing.Point(661, 250);
            this.groupBoxNotifications.Name = "groupBoxNotifications";
            this.groupBoxNotifications.Size = new System.Drawing.Size(275, 132);
            this.groupBoxNotifications.TabIndex = 65;
            this.groupBoxNotifications.TabStop = false;
            this.groupBoxNotifications.Text = "Notifications";
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 18;
            this.listBoxNotifications.Location = new System.Drawing.Point(11, 34);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(252, 76);
            this.listBoxNotifications.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 578);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxNotifications);
            this.Controls.Add(this.groupBoxLastSeen);
            this.Controls.Add(this.buttonGetInsights);
            this.Controls.Add(this.groupBoxFacebookUsageInsights);
            this.Controls.Add(this.groupBoxPosts);
            this.Controls.Add(this.buttonViewPosts);
            this.Controls.Add(this.groupBoxExclusiveFeatures);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceBook WinForms";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.groupBoxExclusiveFeatures.ResumeLayout(false);
            this.groupBoxFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
            this.groupBoxGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupPicture)).EndInit();
            this.groupBoxEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxPosts.ResumeLayout(false);
            this.groupBoxFacebookUsageInsights.ResumeLayout(false);
            this.groupBoxFacebookUsageInsights.PerformLayout();
            this.groupBoxLastSeen.ResumeLayout(false);
            this.groupBoxLastSeen.PerformLayout();
            this.groupBoxNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonLogout;
        private Button buttonYearSummary;
        private Button buttonGenerateFacts;
        private PictureBox pictureBoxProfile;
        private Panel panelHeader;
        private Label label1;
        private PictureBox pictureBoxFacebook;
        private Label labelUser;
        private GroupBox groupBoxExclusiveFeatures;
        private GroupBox groupBoxFriends;
        private PictureBox pictureBoxFriendPicture;
        private ListBox listBoxFriendsList;
        private Button buttonViewFriends;
        private Button buttonViewGroups;
        private GroupBox groupBoxGroups;
        private PictureBox pictureBoxGroupPicture;
        private ListBox listBoxGroupsList;
        private Button buttonViewEvents;
        private GroupBox groupBoxEvents;
        private PictureBox pictureBoxEventPicture;
        private ListBox listBoxEventsList;
        private GroupBox groupBoxInfo;
        private GroupBox groupBoxPosts;
        private ListBox listBoxPostComments;
        private ListBox listBoxPosts;
        private Button buttonViewPosts;
        private Label labelJoinedFacebook;
        private Label labelFirstFirend;
        private Label labelFirstPost;
        private GroupBox groupBoxFacebookUsageInsights;
        private Button buttonGetInsights;
        private Label labelFirstCheckin;
        private GroupBox groupBoxLastSeen;
        private Label labelLastSeen;
        private GroupBox groupBoxNotifications;
        private ListBox listBoxNotifications;
    }
}

