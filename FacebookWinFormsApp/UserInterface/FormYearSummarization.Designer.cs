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
            this.buttonSummarizer = new System.Windows.Forms.Button();
            this.labelChooseYear = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxProfilePhotos = new System.Windows.Forms.PictureBox();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.buttonMoveToLeftProfilePhoto = new System.Windows.Forms.Button();
            this.buttonMoveToRightProfilePhoto = new System.Windows.Forms.Button();
            this.richTextBoxPosts = new System.Windows.Forms.RichTextBox();
            this.buttonMoveToLeftPost = new System.Windows.Forms.Button();
            this.buttonMoveToRightPost = new System.Windows.Forms.Button();
            this.labelPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSummarizer
            // 
            this.buttonSummarizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.buttonSummarizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummarizer.ForeColor = System.Drawing.Color.White;
            this.buttonSummarizer.Location = new System.Drawing.Point(396, 35);
            this.buttonSummarizer.Name = "buttonSummarizer";
            this.buttonSummarizer.Size = new System.Drawing.Size(108, 23);
            this.buttonSummarizer.TabIndex = 0;
            this.buttonSummarizer.Text = "Get Summary";
            this.buttonSummarizer.UseVisualStyleBackColor = false;
            this.buttonSummarizer.Click += new System.EventHandler(this.buttonSummarizer_Click);
            // 
            // labelChooseYear
            // 
            this.labelChooseYear.AutoSize = true;
            this.labelChooseYear.Location = new System.Drawing.Point(328, 22);
            this.labelChooseYear.Name = "labelChooseYear";
            this.labelChooseYear.Size = new System.Drawing.Size(176, 13);
            this.labelChooseYear.TabIndex = 2;
            this.labelChooseYear.Text = "Please choose a year to summarize:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 38);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(59, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pictureBoxProfilePhotos
            // 
            this.pictureBoxProfilePhotos.Location = new System.Drawing.Point(331, 104);
            this.pictureBoxProfilePhotos.Name = "pictureBoxProfilePhotos";
            this.pictureBoxProfilePhotos.Size = new System.Drawing.Size(189, 129);
            this.pictureBoxProfilePhotos.TabIndex = 4;
            this.pictureBoxProfilePhotos.TabStop = false;
            // 
            // labelPhotos
            // 
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Location = new System.Drawing.Point(328, 88);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(73, 13);
            this.labelPhotos.TabIndex = 5;
            this.labelPhotos.Text = "aaaaaaaaaaa";
            this.labelPhotos.Visible = false;
            // 
            // buttonMoveToLeftProfilePhoto
            // 
            this.buttonMoveToLeftProfilePhoto.Location = new System.Drawing.Point(287, 152);
            this.buttonMoveToLeftProfilePhoto.Name = "buttonMoveToLeftProfilePhoto";
            this.buttonMoveToLeftProfilePhoto.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToLeftProfilePhoto.TabIndex = 6;
            this.buttonMoveToLeftProfilePhoto.Text = "<";
            this.buttonMoveToLeftProfilePhoto.UseVisualStyleBackColor = true;
            this.buttonMoveToLeftProfilePhoto.Visible = false;
            this.buttonMoveToLeftProfilePhoto.Click += new System.EventHandler(this.buttonMoveToLeftProfilePhoto_Click);
            // 
            // buttonMoveToRightProfilePhoto
            // 
            this.buttonMoveToRightProfilePhoto.Location = new System.Drawing.Point(526, 152);
            this.buttonMoveToRightProfilePhoto.Name = "buttonMoveToRightProfilePhoto";
            this.buttonMoveToRightProfilePhoto.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToRightProfilePhoto.TabIndex = 7;
            this.buttonMoveToRightProfilePhoto.Text = ">";
            this.buttonMoveToRightProfilePhoto.UseVisualStyleBackColor = true;
            this.buttonMoveToRightProfilePhoto.Visible = false;
            this.buttonMoveToRightProfilePhoto.Click += new System.EventHandler(this.buttonMoveToRightProfilePhoto_Click);
            // 
            // richTextBoxPosts
            // 
            this.richTextBoxPosts.Location = new System.Drawing.Point(331, 299);
            this.richTextBoxPosts.Name = "richTextBoxPosts";
            this.richTextBoxPosts.Size = new System.Drawing.Size(189, 84);
            this.richTextBoxPosts.TabIndex = 8;
            this.richTextBoxPosts.Text = "";
            // 
            // buttonMoveToLeftPost
            // 
            this.buttonMoveToLeftPost.Location = new System.Drawing.Point(287, 324);
            this.buttonMoveToLeftPost.Name = "buttonMoveToLeftPost";
            this.buttonMoveToLeftPost.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToLeftPost.TabIndex = 9;
            this.buttonMoveToLeftPost.Text = "<";
            this.buttonMoveToLeftPost.UseVisualStyleBackColor = true;
            this.buttonMoveToLeftPost.Visible = false;
            this.buttonMoveToLeftPost.Click += new System.EventHandler(this.buttonMoveToLeftPost_Click);
            // 
            // buttonMoveToRightPost
            // 
            this.buttonMoveToRightPost.Location = new System.Drawing.Point(526, 324);
            this.buttonMoveToRightPost.Name = "buttonMoveToRightPost";
            this.buttonMoveToRightPost.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToRightPost.TabIndex = 10;
            this.buttonMoveToRightPost.Text = ">";
            this.buttonMoveToRightPost.UseVisualStyleBackColor = true;
            this.buttonMoveToRightPost.Visible = false;
            this.buttonMoveToRightPost.Click += new System.EventHandler(this.buttonMoveToRightPost_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(328, 283);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(73, 13);
            this.labelPosts.TabIndex = 11;
            this.labelPosts.Text = "aaaaaaaaaaa";
            this.labelPosts.Visible = false;
            // 
            // FormYearSummarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 634);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.buttonMoveToRightPost);
            this.Controls.Add(this.buttonMoveToLeftPost);
            this.Controls.Add(this.richTextBoxPosts);
            this.Controls.Add(this.buttonMoveToRightProfilePhoto);
            this.Controls.Add(this.buttonMoveToLeftProfilePhoto);
            this.Controls.Add(this.labelPhotos);
            this.Controls.Add(this.pictureBoxProfilePhotos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelChooseYear);
            this.Controls.Add(this.buttonSummarizer);
            this.Name = "FormYearSummarization";
            this.Text = "FormYearSummarization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSummarizer;
        private System.Windows.Forms.Label labelChooseYear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private PictureBox pictureBoxProfilePhotos;
        private Label labelPhotos;
        private Button buttonMoveToLeftProfilePhoto;
        private Button buttonMoveToRightProfilePhoto;
        private RichTextBox richTextBoxPosts;
        private Button buttonMoveToLeftPost;
        private Button buttonMoveToRightPost;
        private Label labelPosts;
    }
}