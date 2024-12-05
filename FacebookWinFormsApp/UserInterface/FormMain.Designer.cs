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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonYearSummary = new System.Windows.Forms.Button();
            this.buttonGenerateFact = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.groupBoxExclusiveFeatures = new System.Windows.Forms.GroupBox();
            this.groupBoxAppId = new System.Windows.Forms.GroupBox();
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
            this.groupBoxFacebookInfo = new System.Windows.Forms.GroupBox();
            this.labelNumberOfPosts = new System.Windows.Forms.Label();
            this.labelNumOfPhotos = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelNumberOfFriends = new System.Windows.Forms.Label();
            this.labelBirthdayDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonGetInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            this.groupBoxExclusiveFeatures.SuspendLayout();
            this.groupBoxAppId.SuspendLayout();
            this.groupBoxFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
            this.groupBoxGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupPicture)).BeginInit();
            this.groupBoxEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPosts.SuspendLayout();
            this.groupBoxFacebookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Location = new System.Drawing.Point(710, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(109, 34);
            this.buttonLogout.TabIndex = 65;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonYearSummary
            // 
            this.buttonYearSummary.BackColor = System.Drawing.Color.Turquoise;
            this.buttonYearSummary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYearSummary.ForeColor = System.Drawing.Color.White;
            this.buttonYearSummary.Location = new System.Drawing.Point(7, 75);
            this.buttonYearSummary.Name = "buttonYearSummary";
            this.buttonYearSummary.Size = new System.Drawing.Size(236, 42);
            this.buttonYearSummary.TabIndex = 64;
            this.buttonYearSummary.Text = "Year Summarizer";
            this.buttonYearSummary.UseVisualStyleBackColor = false;
            this.buttonYearSummary.Click += new System.EventHandler(this.buttonYearSummary_Click);
            // 
            // buttonGenerateFact
            // 
            this.buttonGenerateFact.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonGenerateFact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateFact.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateFact.Location = new System.Drawing.Point(7, 26);
            this.buttonGenerateFact.Name = "buttonGenerateFact";
            this.buttonGenerateFact.Size = new System.Drawing.Size(234, 43);
            this.buttonGenerateFact.TabIndex = 63;
            this.buttonGenerateFact.Text = "Random Fact Generator";
            this.buttonGenerateFact.UseVisualStyleBackColor = false;
            this.buttonGenerateFact.Click += new System.EventHandler(this.buttonGenerateFact_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(67, 52);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 62;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(6, 36);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 61;
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
            this.panelHeader.Size = new System.Drawing.Size(894, 72);
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
            this.label1.Location = new System.Drawing.Point(706, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Made By Adva Levine and Tal Dor ©";
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(824, 6);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 0;
            this.pictureBoxFacebook.TabStop = false;
            // 
            // groupBoxExclusiveFeatures
            // 
            this.groupBoxExclusiveFeatures.Controls.Add(this.buttonGenerateFact);
            this.groupBoxExclusiveFeatures.Controls.Add(this.buttonYearSummary);
            this.groupBoxExclusiveFeatures.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExclusiveFeatures.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBoxExclusiveFeatures.Location = new System.Drawing.Point(625, 179);
            this.groupBoxExclusiveFeatures.Name = "groupBoxExclusiveFeatures";
            this.groupBoxExclusiveFeatures.Size = new System.Drawing.Size(258, 126);
            this.groupBoxExclusiveFeatures.TabIndex = 69;
            this.groupBoxExclusiveFeatures.TabStop = false;
            this.groupBoxExclusiveFeatures.Text = "Our Exclusive Features!";
            // 
            // groupBoxAppId
            // 
            this.groupBoxAppId.Controls.Add(this.textBoxAppID);
            this.groupBoxAppId.ForeColor = System.Drawing.Color.HotPink;
            this.groupBoxAppId.Location = new System.Drawing.Point(631, 83);
            this.groupBoxAppId.Name = "groupBoxAppId";
            this.groupBoxAppId.Size = new System.Drawing.Size(254, 90);
            this.groupBoxAppId.TabIndex = 70;
            this.groupBoxAppId.TabStop = false;
            this.groupBoxAppId.Text = "Application ID";
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
            this.pictureBoxFriendPicture.Location = new System.Drawing.Point(194, 19);
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
            this.listBoxFriendsList.Location = new System.Drawing.Point(6, 19);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(182, 84);
            this.listBoxFriendsList.TabIndex = 71;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // buttonViewFriends
            // 
            this.buttonViewFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(206)))), ((int)(((byte)(191)))));
            this.buttonViewFriends.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewFriends.ForeColor = System.Drawing.Color.White;
            this.buttonViewFriends.Location = new System.Drawing.Point(83, 137);
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
            this.buttonViewGroups.Location = new System.Drawing.Point(83, 291);
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
            this.pictureBoxGroupPicture.Location = new System.Drawing.Point(194, 19);
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
            this.listBoxGroupsList.Location = new System.Drawing.Point(6, 19);
            this.listBoxGroupsList.Name = "listBoxGroupsList";
            this.listBoxGroupsList.Size = new System.Drawing.Size(182, 84);
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
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(194, 19);
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
            this.listBoxEventsList.Location = new System.Drawing.Point(6, 19);
            this.listBoxEventsList.Name = "listBoxEventsList";
            this.listBoxEventsList.Size = new System.Drawing.Size(182, 84);
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
            this.groupBoxInfo.ForeColor = System.Drawing.Color.Pink;
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 78);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(331, 490);
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
            this.groupBoxPosts.Location = new System.Drawing.Point(433, 369);
            this.groupBoxPosts.Name = "groupBoxPosts";
            this.groupBoxPosts.Size = new System.Drawing.Size(386, 111);
            this.groupBoxPosts.TabIndex = 74;
            this.groupBoxPosts.TabStop = false;
            this.groupBoxPosts.Text = "Your Posts";
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 20;
            this.listBoxPostComments.Location = new System.Drawing.Point(196, 19);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(187, 84);
            this.listBoxPostComments.TabIndex = 72;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(6, 19);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(182, 84);
            this.listBoxPosts.TabIndex = 71;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(93)))));
            this.buttonViewPosts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewPosts.ForeColor = System.Drawing.Color.White;
            this.buttonViewPosts.Location = new System.Drawing.Point(552, 486);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(151, 39);
            this.buttonViewPosts.TabIndex = 75;
            this.buttonViewPosts.Text = "View Posts";
            this.buttonViewPosts.UseVisualStyleBackColor = false;
            this.buttonViewPosts.Click += new System.EventHandler(this.buttonViewPosts_Click);
            // 
            // groupBoxFacebookInfo
            // 
            this.groupBoxFacebookInfo.Controls.Add(this.labelNumberOfPosts);
            this.groupBoxFacebookInfo.Controls.Add(this.labelNumOfPhotos);
            this.groupBoxFacebookInfo.Controls.Add(this.labelGender);
            this.groupBoxFacebookInfo.Controls.Add(this.labelNumberOfFriends);
            this.groupBoxFacebookInfo.Controls.Add(this.labelBirthdayDate);
            this.groupBoxFacebookInfo.Controls.Add(this.labelName);
            this.groupBoxFacebookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(170)))));
            this.groupBoxFacebookInfo.Location = new System.Drawing.Point(349, 83);
            this.groupBoxFacebookInfo.Name = "groupBoxFacebookInfo";
            this.groupBoxFacebookInfo.Size = new System.Drawing.Size(258, 222);
            this.groupBoxFacebookInfo.TabIndex = 76;
            this.groupBoxFacebookInfo.TabStop = false;
            this.groupBoxFacebookInfo.Text = "Your Info";
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelNumberOfPosts.Location = new System.Drawing.Point(6, 182);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(174, 20);
            this.labelNumberOfPosts.TabIndex = 83;
            this.labelNumberOfPosts.Text = "You Have Made <> Posts";
            // 
            // labelNumOfPhotos
            // 
            this.labelNumOfPhotos.AutoSize = true;
            this.labelNumOfPhotos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfPhotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelNumOfPhotos.Location = new System.Drawing.Point(6, 151);
            this.labelNumOfPhotos.Name = "labelNumOfPhotos";
            this.labelNumOfPhotos.Size = new System.Drawing.Size(144, 20);
            this.labelNumOfPhotos.TabIndex = 82;
            this.labelNumOfPhotos.Text = "You Have <> Photos";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelGender.Location = new System.Drawing.Point(7, 119);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(111, 20);
            this.labelGender.TabIndex = 80;
            this.labelGender.Text = "Your Gender Is: ";
            // 
            // labelNumberOfFriends
            // 
            this.labelNumberOfFriends.AutoSize = true;
            this.labelNumberOfFriends.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelNumberOfFriends.Location = new System.Drawing.Point(6, 87);
            this.labelNumberOfFriends.Name = "labelNumberOfFriends";
            this.labelNumberOfFriends.Size = new System.Drawing.Size(146, 20);
            this.labelNumberOfFriends.TabIndex = 79;
            this.labelNumberOfFriends.Text = "You Have <> Friends";
            // 
            // labelBirthdayDate
            // 
            this.labelBirthdayDate.AutoSize = true;
            this.labelBirthdayDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelBirthdayDate.Location = new System.Drawing.Point(7, 58);
            this.labelBirthdayDate.Name = "labelBirthdayDate";
            this.labelBirthdayDate.Size = new System.Drawing.Size(140, 20);
            this.labelBirthdayDate.TabIndex = 78;
            this.labelBirthdayDate.Text = "Your Birthday Date: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(6, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 20);
            this.labelName.TabIndex = 77;
            this.labelName.Text = "Your Name Is: ";
            // 
            // buttonGetInfo
            // 
            this.buttonGetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(170)))));
            this.buttonGetInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetInfo.ForeColor = System.Drawing.Color.White;
            this.buttonGetInfo.Location = new System.Drawing.Point(400, 311);
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.Size = new System.Drawing.Size(151, 39);
            this.buttonGetInfo.TabIndex = 77;
            this.buttonGetInfo.Text = "Get Info";
            this.buttonGetInfo.UseVisualStyleBackColor = false;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 572);
            this.Controls.Add(this.buttonGetInfo);
            this.Controls.Add(this.groupBoxFacebookInfo);
            this.Controls.Add(this.groupBoxPosts);
            this.Controls.Add(this.buttonViewPosts);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxAppId);
            this.Controls.Add(this.groupBoxExclusiveFeatures);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            this.groupBoxExclusiveFeatures.ResumeLayout(false);
            this.groupBoxAppId.ResumeLayout(false);
            this.groupBoxAppId.PerformLayout();
            this.groupBoxFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
            this.groupBoxGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupPicture)).EndInit();
            this.groupBoxEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxPosts.ResumeLayout(false);
            this.groupBoxFacebookInfo.ResumeLayout(false);
            this.groupBoxFacebookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonLogout;
        private Button buttonYearSummary;
        private Button buttonGenerateFact;
        private PictureBox pictureBoxProfile;
        private TextBox textBoxAppID;
        private Panel panelHeader;
        private Label label1;
        private PictureBox pictureBoxFacebook;
        private Label labelUser;
        private GroupBox groupBoxExclusiveFeatures;
        private GroupBox groupBoxAppId;
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
        private GroupBox groupBoxFacebookInfo;
        private Label labelName;
        private Label labelNumberOfFriends;
        private Label labelBirthdayDate;
        private Label labelNumberOfPosts;
        private Label labelNumOfPhotos;
        private Label labelGender;
        private Button buttonGetInfo;
    }
}

