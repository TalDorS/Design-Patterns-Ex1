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
            this.buttonLoginAsDifferentUser = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.LoginPhoto = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginAsDifferentUser
            // 
            this.buttonLoginAsDifferentUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoginAsDifferentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsDifferentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoginAsDifferentUser.Location = new System.Drawing.Point(72, 217);
            this.buttonLoginAsDifferentUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginAsDifferentUser.Name = "buttonLoginAsDifferentUser";
            this.buttonLoginAsDifferentUser.Size = new System.Drawing.Size(202, 52);
            this.buttonLoginAsDifferentUser.TabIndex = 2;
            this.buttonLoginAsDifferentUser.Text = "Login as  a different user";
            this.buttonLoginAsDifferentUser.UseVisualStyleBackColor = false;
            this.buttonLoginAsDifferentUser.Click += new System.EventHandler(this.buttonLoginAsDifferentUser_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(17, 282);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.LoginPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPhoto.Name = "LoginPhoto";
            this.LoginPhoto.Size = new System.Drawing.Size(229, 159);
            this.LoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPhoto.TabIndex = 4;
            this.LoginPhoto.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin.Location = new System.Drawing.Point(72, 174);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(202, 38);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(346, 314);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.LoginPhoto);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLoginAsDifferentUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoginAsDifferentUser;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox LoginPhoto;
        private System.Windows.Forms.Button buttonLogin;
    }
}