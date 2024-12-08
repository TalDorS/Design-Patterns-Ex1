using System.Windows.Forms;

namespace BasicFacebookFeatures.UserInterface
{
    partial class FormFactsGeneratorFeature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactsGeneratorFeature));
            this.lblFact = new System.Windows.Forms.Label();
            this.buttonNextFact = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacts = new System.Windows.Forms.PictureBox();
            this.buttonShareFact = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Location = new System.Drawing.Point(75, 90);
            this.lblFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(25, 13);
            this.lblFact.TabIndex = 0;
            this.lblFact.Text = "fact";
            // 
            // buttonNextFact
            // 
            this.buttonNextFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextFact.AutoSize = true;
            this.buttonNextFact.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonNextFact.Location = new System.Drawing.Point(466, 389);
            this.buttonNextFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNextFact.Name = "buttonNextFact";
            this.buttonNextFact.Size = new System.Drawing.Size(146, 44);
            this.buttonNextFact.TabIndex = 1;
            this.buttonNextFact.Text = "Next Fact";
            this.buttonNextFact.UseVisualStyleBackColor = false;
            this.buttonNextFact.Click += new System.EventHandler(this.buttonNextFact_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.labelFacebook);
            this.panelHeader.Controls.Add(this.pictureBoxFacebook);
            this.panelHeader.Location = new System.Drawing.Point(1, -6);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(614, 73);
            this.panelHeader.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(434, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Made By Adva Levine and Tal Dor ©";
            // 
            // labelFacebook
            // 
            this.labelFacebook.AutoSize = true;
            this.labelFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.labelFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFacebook.Location = new System.Drawing.Point(51, 11);
            this.labelFacebook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(206, 51);
            this.labelFacebook.TabIndex = 15;
            this.labelFacebook.Text = "facebook";
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(5, 15);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(32, 34);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 0;
            this.pictureBoxFacebook.TabStop = false;
            // 
            // pictureBoxFacts
            // 
            this.pictureBoxFacts.Location = new System.Drawing.Point(133, 180);
            this.pictureBoxFacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFacts.Name = "pictureBoxFacts";
            this.pictureBoxFacts.Size = new System.Drawing.Size(359, 203);
            this.pictureBoxFacts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacts.TabIndex = 16;
            this.pictureBoxFacts.TabStop = false;
            // 
            // buttonShareFact
            // 
            this.buttonShareFact.BackColor = System.Drawing.Color.Pink;
            this.buttonShareFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShareFact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonShareFact.Location = new System.Drawing.Point(6, 379);
            this.buttonShareFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShareFact.Name = "buttonShareFact";
            this.buttonShareFact.Size = new System.Drawing.Size(85, 48);
            this.buttonShareFact.TabIndex = 17;
            this.buttonShareFact.Text = "Share Fact!";
            this.buttonShareFact.UseVisualStyleBackColor = false;
            this.buttonShareFact.Click += new System.EventHandler(this.buttonShareFact_Click);
            // 
            // FormFactsGeneratorFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 436);
            this.Controls.Add(this.buttonShareFact);
            this.Controls.Add(this.pictureBoxFacts);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonNextFact);
            this.Controls.Add(this.lblFact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFactsGeneratorFeature";
            this.Text = "FactForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Button buttonNextFact;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.PictureBox pictureBoxFacts;
        private System.Windows.Forms.Label label1;
        private Button buttonShareFact;
    }
}