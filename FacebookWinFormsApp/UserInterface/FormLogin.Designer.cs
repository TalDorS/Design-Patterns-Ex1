namespace BasicFacebookFeatures.UserInterface
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLoginAsNewUser = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.LoginPhoto = new System.Windows.Forms.PictureBox();
            this.buttonLoginAsExisting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginAsNewUser
            // 
            this.buttonLoginAsNewUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoginAsNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoginAsNewUser.Location = new System.Drawing.Point(73, 226);
            this.buttonLoginAsNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginAsNewUser.Name = "buttonLoginAsNewUser";
            this.buttonLoginAsNewUser.Size = new System.Drawing.Size(202, 37);
            this.buttonLoginAsNewUser.TabIndex = 2;
            this.buttonLoginAsNewUser.Text = "Login as a New User";
            this.buttonLoginAsNewUser.UseVisualStyleBackColor = false;
            this.buttonLoginAsNewUser.Click += new System.EventHandler(this.buttonLoginAsNewUser_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Checked = true;
            this.checkBoxRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(2, 283);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(130, 21);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // LoginPhoto
            // 
            this.LoginPhoto.Image = global::BasicFacebookFeatures.Properties.Resources.images;
            this.LoginPhoto.Location = new System.Drawing.Point(61, 10);
            this.LoginPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPhoto.Name = "LoginPhoto";
            this.LoginPhoto.Size = new System.Drawing.Size(229, 159);
            this.LoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPhoto.TabIndex = 4;
            this.LoginPhoto.TabStop = false;
            // 
            // buttonLoginAsExisting
            // 
            this.buttonLoginAsExisting.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoginAsExisting.Enabled = false;
            this.buttonLoginAsExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsExisting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoginAsExisting.Location = new System.Drawing.Point(73, 183);
            this.buttonLoginAsExisting.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginAsExisting.Name = "buttonLoginAsExisting";
            this.buttonLoginAsExisting.Size = new System.Drawing.Size(202, 38);
            this.buttonLoginAsExisting.TabIndex = 6;
            this.buttonLoginAsExisting.Text = "Login As an Existing User";
            this.buttonLoginAsExisting.UseVisualStyleBackColor = false;
            this.buttonLoginAsExisting.Click += new System.EventHandler(this.buttonLoginAsExisting_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(346, 305);
            this.Controls.Add(this.buttonLoginAsExisting);
            this.Controls.Add(this.LoginPhoto);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLoginAsNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoginAsNewUser;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox LoginPhoto;
        private System.Windows.Forms.Button buttonLoginAsExisting;
    }
}