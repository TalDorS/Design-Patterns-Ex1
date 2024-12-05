using System.Windows.Forms;
using System;

namespace BasicFacebookFeatures.UserInterface
{
    partial class FormYearSummarization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYearSummarization));
            this.buttonSummarizer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxProfilePhotos = new System.Windows.Forms.PictureBox();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.buttonMoveToLeftProfilePhoto = new System.Windows.Forms.Button();
            this.buttonMoveToRightProfilePhoto = new System.Windows.Forms.Button();
            this.richTextBoxPosts = new System.Windows.Forms.RichTextBox();
            this.buttonMoveToLeftPost = new System.Windows.Forms.Button();
            this.buttonMoveToRightPost = new System.Windows.Forms.Button();
            this.labelPosts = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelEnterYearPrompt = new System.Windows.Forms.Label();
            this.richTextBoxFeatureDescription = new System.Windows.Forms.RichTextBox();
            this.richTextBoxChooseYear = new System.Windows.Forms.RichTextBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.tableLayoutPanelEvents = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxEventName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEventStartDate = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEventEndDate = new System.Windows.Forms.RichTextBox();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.buttonMoveToRightEvent = new System.Windows.Forms.Button();
            this.buttonMoveToLeftEvent = new System.Windows.Forms.Button();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelStartingDate = new System.Windows.Forms.Label();
            this.labelEndingDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhotos)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSummarizer
            // 
            this.buttonSummarizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonSummarizer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummarizer.ForeColor = System.Drawing.Color.White;
            this.buttonSummarizer.Location = new System.Drawing.Point(5, 437);
            this.buttonSummarizer.Name = "buttonSummarizer";
            this.buttonSummarizer.Size = new System.Drawing.Size(221, 130);
            this.buttonSummarizer.TabIndex = 0;
            this.buttonSummarizer.Text = "Get Summary!";
            this.buttonSummarizer.UseVisualStyleBackColor = false;
            this.buttonSummarizer.Click += new System.EventHandler(this.buttonSummarizer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 410);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pictureBoxProfilePhotos
            // 
            this.pictureBoxProfilePhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePhotos.Location = new System.Drawing.Point(395, 369);
            this.pictureBoxProfilePhotos.Name = "pictureBoxProfilePhotos";
            this.pictureBoxProfilePhotos.Size = new System.Drawing.Size(189, 106);
            this.pictureBoxProfilePhotos.TabIndex = 4;
            this.pictureBoxProfilePhotos.TabStop = false;
            // 
            // labelPhotos
            // 
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Location = new System.Drawing.Point(392, 353);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(45, 13);
            this.labelPhotos.TabIndex = 5;
            this.labelPhotos.Text = "Picutres";
            // 
            // buttonMoveToLeftProfilePhoto
            // 
            this.buttonMoveToLeftProfilePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonMoveToLeftProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToLeftProfilePhoto.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToLeftProfilePhoto.Location = new System.Drawing.Point(351, 404);
            this.buttonMoveToLeftProfilePhoto.Name = "buttonMoveToLeftProfilePhoto";
            this.buttonMoveToLeftProfilePhoto.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToLeftProfilePhoto.TabIndex = 6;
            this.buttonMoveToLeftProfilePhoto.Text = "<";
            this.buttonMoveToLeftProfilePhoto.UseVisualStyleBackColor = false;
            this.buttonMoveToLeftProfilePhoto.Click += new System.EventHandler(this.buttonMoveToLeftProfilePhoto_Click);
            // 
            // buttonMoveToRightProfilePhoto
            // 
            this.buttonMoveToRightProfilePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonMoveToRightProfilePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToRightProfilePhoto.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToRightProfilePhoto.Location = new System.Drawing.Point(590, 404);
            this.buttonMoveToRightProfilePhoto.Name = "buttonMoveToRightProfilePhoto";
            this.buttonMoveToRightProfilePhoto.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToRightProfilePhoto.TabIndex = 7;
            this.buttonMoveToRightProfilePhoto.Text = ">";
            this.buttonMoveToRightProfilePhoto.UseVisualStyleBackColor = false;
            this.buttonMoveToRightProfilePhoto.Click += new System.EventHandler(this.buttonMoveToRightProfilePhoto_Click);
            // 
            // richTextBoxPosts
            // 
            this.richTextBoxPosts.BackColor = System.Drawing.Color.White;
            this.richTextBoxPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxPosts.Location = new System.Drawing.Point(395, 499);
            this.richTextBoxPosts.Name = "richTextBoxPosts";
            this.richTextBoxPosts.ReadOnly = true;
            this.richTextBoxPosts.Size = new System.Drawing.Size(189, 106);
            this.richTextBoxPosts.TabIndex = 8;
            this.richTextBoxPosts.Text = "";
            // 
            // buttonMoveToLeftPost
            // 
            this.buttonMoveToLeftPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonMoveToLeftPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToLeftPost.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToLeftPost.Location = new System.Drawing.Point(351, 542);
            this.buttonMoveToLeftPost.Name = "buttonMoveToLeftPost";
            this.buttonMoveToLeftPost.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToLeftPost.TabIndex = 9;
            this.buttonMoveToLeftPost.Text = "<";
            this.buttonMoveToLeftPost.UseVisualStyleBackColor = false;
            this.buttonMoveToLeftPost.Click += new System.EventHandler(this.buttonMoveToLeftPost_Click);
            // 
            // buttonMoveToRightPost
            // 
            this.buttonMoveToRightPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonMoveToRightPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToRightPost.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToRightPost.Location = new System.Drawing.Point(590, 542);
            this.buttonMoveToRightPost.Name = "buttonMoveToRightPost";
            this.buttonMoveToRightPost.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToRightPost.TabIndex = 10;
            this.buttonMoveToRightPost.Text = ">";
            this.buttonMoveToRightPost.UseVisualStyleBackColor = false;
            this.buttonMoveToRightPost.Click += new System.EventHandler(this.buttonMoveToRightPost_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(392, 483);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(33, 13);
            this.labelPosts.TabIndex = 11;
            this.labelPosts.Text = "Posts";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.panelHeader.Controls.Add(this.labelFacebook);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBoxFacebook);
            this.panelHeader.Location = new System.Drawing.Point(-1, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(748, 72);
            this.panelHeader.TabIndex = 12;
            // 
            // labelFacebook
            // 
            this.labelFacebook.AutoSize = true;
            this.labelFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.labelFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.Color.White;
            this.labelFacebook.Location = new System.Drawing.Point(77, 12);
            this.labelFacebook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(206, 51);
            this.labelFacebook.TabIndex = 16;
            this.labelFacebook.Text = "facebook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(560, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Made By Adva Levine and Tal Dor ©";
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(3, 12);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 0;
            this.pictureBoxFacebook.TabStop = false;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Controls.Add(this.buttonSummarizer, 0, 3);
            this.tableLayoutPanelLeft.Controls.Add(this.labelEnterYearPrompt, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.dateTimePicker1, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.richTextBoxFeatureDescription, 0, 0);
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(-1, 74);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 4;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(231, 572);
            this.tableLayoutPanelLeft.TabIndex = 14;
            // 
            // labelEnterYearPrompt
            // 
            this.labelEnterYearPrompt.AutoSize = true;
            this.labelEnterYearPrompt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterYearPrompt.Location = new System.Drawing.Point(5, 388);
            this.labelEnterYearPrompt.Name = "labelEnterYearPrompt";
            this.labelEnterYearPrompt.Size = new System.Drawing.Size(191, 13);
            this.labelEnterYearPrompt.TabIndex = 5;
            this.labelEnterYearPrompt.Text = "Please choose a year between 2004-";
            // 
            // richTextBoxFeatureDescription
            // 
            this.richTextBoxFeatureDescription.BackColor = System.Drawing.Color.White;
            this.richTextBoxFeatureDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxFeatureDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxFeatureDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxFeatureDescription.Location = new System.Drawing.Point(5, 5);
            this.richTextBoxFeatureDescription.Name = "richTextBoxFeatureDescription";
            this.richTextBoxFeatureDescription.ReadOnly = true;
            this.richTextBoxFeatureDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxFeatureDescription.Size = new System.Drawing.Size(221, 336);
            this.richTextBoxFeatureDescription.TabIndex = 4;
            this.richTextBoxFeatureDescription.Text = resources.GetString("richTextBoxFeatureDescription.Text");
            // 
            // richTextBoxChooseYear
            // 
            this.richTextBoxChooseYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxChooseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxChooseYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.richTextBoxChooseYear.Location = new System.Drawing.Point(318, 79);
            this.richTextBoxChooseYear.Name = "richTextBoxChooseYear";
            this.richTextBoxChooseYear.Size = new System.Drawing.Size(341, 53);
            this.richTextBoxChooseYear.TabIndex = 13;
            this.richTextBoxChooseYear.Text = "  Year Summary";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(283, 135);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(40, 13);
            this.labelEvents.TabIndex = 16;
            this.labelEvents.Text = "Events";
            // 
            // tableLayoutPanelEvents
            // 
            this.tableLayoutPanelEvents.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanelEvents.ColumnCount = 3;
            this.tableLayoutPanelEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanelEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelEvents.Controls.Add(this.richTextBoxEventName, 0, 0);
            this.tableLayoutPanelEvents.Controls.Add(this.richTextBoxEventStartDate, 1, 0);
            this.tableLayoutPanelEvents.Controls.Add(this.richTextBoxEventEndDate, 2, 0);
            this.tableLayoutPanelEvents.Location = new System.Drawing.Point(283, 243);
            this.tableLayoutPanelEvents.Name = "tableLayoutPanelEvents";
            this.tableLayoutPanelEvents.RowCount = 1;
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanelEvents.Size = new System.Drawing.Size(396, 64);
            this.tableLayoutPanelEvents.TabIndex = 17;
            // 
            // richTextBoxEventName
            // 
            this.richTextBoxEventName.BackColor = System.Drawing.Color.White;
            this.richTextBoxEventName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxEventName.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxEventName.Name = "richTextBoxEventName";
            this.richTextBoxEventName.ReadOnly = true;
            this.richTextBoxEventName.Size = new System.Drawing.Size(117, 55);
            this.richTextBoxEventName.TabIndex = 0;
            this.richTextBoxEventName.Text = "";
            // 
            // richTextBoxEventStartDate
            // 
            this.richTextBoxEventStartDate.BackColor = System.Drawing.Color.White;
            this.richTextBoxEventStartDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxEventStartDate.Location = new System.Drawing.Point(132, 6);
            this.richTextBoxEventStartDate.Name = "richTextBoxEventStartDate";
            this.richTextBoxEventStartDate.ReadOnly = true;
            this.richTextBoxEventStartDate.Size = new System.Drawing.Size(135, 55);
            this.richTextBoxEventStartDate.TabIndex = 1;
            this.richTextBoxEventStartDate.Text = "";
            // 
            // richTextBoxEventEndDate
            // 
            this.richTextBoxEventEndDate.BackColor = System.Drawing.Color.White;
            this.richTextBoxEventEndDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxEventEndDate.Location = new System.Drawing.Point(276, 6);
            this.richTextBoxEventEndDate.Name = "richTextBoxEventEndDate";
            this.richTextBoxEventEndDate.ReadOnly = true;
            this.richTextBoxEventEndDate.Size = new System.Drawing.Size(105, 55);
            this.richTextBoxEventEndDate.TabIndex = 2;
            this.richTextBoxEventEndDate.Text = "";
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEvents.Location = new System.Drawing.Point(286, 151);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(393, 86);
            this.pictureBoxEvents.TabIndex = 0;
            this.pictureBoxEvents.TabStop = false;
            // 
            // buttonMoveToRightEvent
            // 
            this.buttonMoveToRightEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonMoveToRightEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToRightEvent.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToRightEvent.Location = new System.Drawing.Point(685, 214);
            this.buttonMoveToRightEvent.Name = "buttonMoveToRightEvent";
            this.buttonMoveToRightEvent.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToRightEvent.TabIndex = 18;
            this.buttonMoveToRightEvent.Text = ">";
            this.buttonMoveToRightEvent.UseVisualStyleBackColor = false;
            this.buttonMoveToRightEvent.Click += new System.EventHandler(this.buttonMoveToRightEvent_Click);
            // 
            // buttonMoveToLeftEvent
            // 
            this.buttonMoveToLeftEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.buttonMoveToLeftEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToLeftEvent.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToLeftEvent.Location = new System.Drawing.Point(242, 214);
            this.buttonMoveToLeftEvent.Name = "buttonMoveToLeftEvent";
            this.buttonMoveToLeftEvent.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToLeftEvent.TabIndex = 19;
            this.buttonMoveToLeftEvent.Text = "<";
            this.buttonMoveToLeftEvent.UseVisualStyleBackColor = false;
            this.buttonMoveToLeftEvent.Click += new System.EventHandler(this.buttonMoveToLeftEvent_Click);
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventName.Location = new System.Drawing.Point(315, 310);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(67, 13);
            this.labelEventName.TabIndex = 20;
            this.labelEventName.Text = "Event Name";
            // 
            // labelStartingDate
            // 
            this.labelStartingDate.AutoSize = true;
            this.labelStartingDate.Location = new System.Drawing.Point(460, 310);
            this.labelStartingDate.Name = "labelStartingDate";
            this.labelStartingDate.Size = new System.Drawing.Size(69, 13);
            this.labelStartingDate.TabIndex = 21;
            this.labelStartingDate.Text = "Starting Date";
            // 
            // labelEndingDate
            // 
            this.labelEndingDate.AutoSize = true;
            this.labelEndingDate.Location = new System.Drawing.Point(587, 310);
            this.labelEndingDate.Name = "labelEndingDate";
            this.labelEndingDate.Size = new System.Drawing.Size(66, 13);
            this.labelEndingDate.TabIndex = 22;
            this.labelEndingDate.Text = "Ending Date";
            // 
            // FormYearSummarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 646);
            this.Controls.Add(this.labelEndingDate);
            this.Controls.Add(this.labelStartingDate);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.buttonMoveToLeftEvent);
            this.Controls.Add(this.buttonMoveToRightEvent);
            this.Controls.Add(this.pictureBoxEvents);
            this.Controls.Add(this.tableLayoutPanelEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.richTextBoxChooseYear);
            this.Controls.Add(this.tableLayoutPanelLeft);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.buttonMoveToRightPost);
            this.Controls.Add(this.buttonMoveToLeftPost);
            this.Controls.Add(this.richTextBoxPosts);
            this.Controls.Add(this.buttonMoveToRightProfilePhoto);
            this.Controls.Add(this.buttonMoveToLeftProfilePhoto);
            this.Controls.Add(this.labelPhotos);
            this.Controls.Add(this.pictureBoxProfilePhotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormYearSummarization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYearSummarization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhotos)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSummarizer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private PictureBox pictureBoxProfilePhotos;
        private Label labelPhotos;
        private Button buttonMoveToLeftProfilePhoto;
        private Button buttonMoveToRightProfilePhoto;
        private RichTextBox richTextBoxPosts;
        private Button buttonMoveToLeftPost;
        private Button buttonMoveToRightPost;
        private Label labelPosts;
        private Panel panelHeader;
        private PictureBox pictureBoxFacebook;
        private TableLayoutPanel tableLayoutPanelLeft;
        private RichTextBox richTextBoxFeatureDescription;
        private Label labelEnterYearPrompt;
        private RichTextBox richTextBoxChooseYear;
        private Label labelEvents;
        private TableLayoutPanel tableLayoutPanelEvents;
        private RichTextBox richTextBoxEventName;
        private RichTextBox richTextBoxEventStartDate;
        private RichTextBox richTextBoxEventEndDate;
        private PictureBox pictureBoxEvents;
        private Button buttonMoveToRightEvent;
        private Button buttonMoveToLeftEvent;
        private Label label1;
        private Label labelFacebook;
        private Label labelEventName;
        private Label labelStartingDate;
        private Label labelEndingDate;
    }
}