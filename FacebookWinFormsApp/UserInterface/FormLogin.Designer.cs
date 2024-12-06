namespace BasicFacebookFeatures.UI
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
            this.buttonLoginAsNewUser = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.LoginPhoto = new System.Windows.Forms.PictureBox();
            this.buttonLoginAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginAsNewUser
            // 
            this.buttonLoginAsNewUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoginAsNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoginAsNewUser.Location = new System.Drawing.Point(96, 267);
            this.buttonLoginAsNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginAsNewUser.Name = "buttonLoginAsNewUser";
            this.buttonLoginAsNewUser.Size = new System.Drawing.Size(269, 64);
            this.buttonLoginAsNewUser.TabIndex = 2;
            this.buttonLoginAsNewUser.Text = "Login as a New User";
            this.buttonLoginAsNewUser.UseVisualStyleBackColor = false;
            this.buttonLoginAsNewUser.Click += new System.EventHandler(this.buttonLoginAsNewUser_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(23, 347);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(152, 24);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // LoginPhoto
            // 
            this.LoginPhoto.Image = global::BasicFacebookFeatures.Properties.Resources.images;
            this.LoginPhoto.Location = new System.Drawing.Point(81, 12);
            this.LoginPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPhoto.Name = "LoginPhoto";
            this.LoginPhoto.Size = new System.Drawing.Size(305, 196);
            this.LoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPhoto.TabIndex = 4;
            this.LoginPhoto.TabStop = false;
            // 
            // buttonLoginAs
            // 
            this.buttonLoginAs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoginAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoginAs.Location = new System.Drawing.Point(96, 214);
            this.buttonLoginAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginAs.Name = "buttonLoginAs";
            this.buttonLoginAs.Size = new System.Drawing.Size(269, 47);
            this.buttonLoginAs.TabIndex = 6;
            this.buttonLoginAs.Text = "Login As an Existing User";
            this.buttonLoginAs.UseVisualStyleBackColor = false;
            this.buttonLoginAs.Click += new System.EventHandler(this.buttonLoginAs_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(461, 386);
            this.Controls.Add(this.buttonLoginAs);
            this.Controls.Add(this.LoginPhoto);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLoginAsNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonLoginAs;
    }
}