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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSummarizer
            // 
            this.buttonSummarizer.Location = new System.Drawing.Point(97, 27);
            this.buttonSummarizer.Name = "buttonSummarizer";
            this.buttonSummarizer.Size = new System.Drawing.Size(108, 23);
            this.buttonSummarizer.TabIndex = 0;
            this.buttonSummarizer.Text = "Summarize!";
            this.buttonSummarizer.UseVisualStyleBackColor = true;
            this.buttonSummarizer.Click += new System.EventHandler(this.buttonSummarizer_Click);
            // 
            // labelChooseYear
            // 
            this.labelChooseYear.AutoSize = true;
            this.labelChooseYear.Location = new System.Drawing.Point(29, 14);
            this.labelChooseYear.Name = "labelChooseYear";
            this.labelChooseYear.Size = new System.Drawing.Size(176, 13);
            this.labelChooseYear.TabIndex = 2;
            this.labelChooseYear.Text = "Please choose a year to summarize:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 30);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(59, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pictureBoxProfilePhotos
            // 
            this.pictureBoxProfilePhotos.Location = new System.Drawing.Point(135, 157);
            this.pictureBoxProfilePhotos.Name = "pictureBoxProfilePhotos";
            this.pictureBoxProfilePhotos.Size = new System.Drawing.Size(189, 129);
            this.pictureBoxProfilePhotos.TabIndex = 4;
            this.pictureBoxProfilePhotos.TabStop = false;
            // 
            // labelPhotos
            // 
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Location = new System.Drawing.Point(132, 141);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(0, 13);
            this.labelPhotos.TabIndex = 5;
            this.labelPhotos.Visible = false;
            // 
            // buttonMoveToLeftProfilePhoto
            // 
            this.buttonMoveToLeftProfilePhoto.Location = new System.Drawing.Point(91, 205);
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
            this.buttonMoveToRightProfilePhoto.Location = new System.Drawing.Point(330, 205);
            this.buttonMoveToRightProfilePhoto.Name = "buttonMoveToRightProfilePhoto";
            this.buttonMoveToRightProfilePhoto.Size = new System.Drawing.Size(38, 23);
            this.buttonMoveToRightProfilePhoto.TabIndex = 7;
            this.buttonMoveToRightProfilePhoto.Text = ">";
            this.buttonMoveToRightProfilePhoto.UseVisualStyleBackColor = true;
            this.buttonMoveToRightProfilePhoto.Visible = false;
            this.buttonMoveToRightProfilePhoto.Click += new System.EventHandler(this.buttonMoveToRightProfilePhoto_Click);
            // 
            // FormYearSummarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
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
    }
}