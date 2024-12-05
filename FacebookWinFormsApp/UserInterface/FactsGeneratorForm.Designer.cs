namespace BasicFacebookFeatures.UserInterface
{
    partial class FactsGeneratorForm
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
            this.lblFact = new System.Windows.Forms.Label();
            this.buttonNextFact = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxFacts = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Location = new System.Drawing.Point(100, 111);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(28, 16);
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
            this.buttonNextFact.Location = new System.Drawing.Point(622, 479);
            this.buttonNextFact.Name = "buttonNextFact";
            this.buttonNextFact.Size = new System.Drawing.Size(195, 54);
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
            this.panelHeader.Controls.Add(this.labelFacebook);
            this.panelHeader.Controls.Add(this.richTextBox1);
            this.panelHeader.Controls.Add(this.pictureBoxFacebook);
            this.panelHeader.Location = new System.Drawing.Point(1, -8);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(818, 90);
            this.panelHeader.TabIndex = 15;
            // 
            // labelFacebook
            // 
            this.labelFacebook.AutoSize = true;
            this.labelFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.labelFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFacebook.Location = new System.Drawing.Point(68, 11);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(254, 63);
            this.labelFacebook.TabIndex = 15;
            this.labelFacebook.Text = "facebook";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(157)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(561, 66);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(257, 23);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "Made By Adva Levine and Tal Dor ©";
            // 
            // pictureBoxFacts
            // 
            this.pictureBoxFacts.Location = new System.Drawing.Point(177, 222);
            this.pictureBoxFacts.Name = "pictureBoxFacts";
            this.pictureBoxFacts.Size = new System.Drawing.Size(479, 250);
            this.pictureBoxFacts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacts.TabIndex = 16;
            this.pictureBoxFacts.TabStop = false;
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(7, 18);
            this.pictureBoxFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(42, 37);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 0;
            this.pictureBoxFacebook.TabStop = false;
            // 
            // FactsGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 536);
            this.Controls.Add(this.pictureBoxFacts);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonNextFact);
            this.Controls.Add(this.lblFact);
            this.Name = "FactsGeneratorForm";
            this.Text = "FactForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Button buttonNextFact;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.PictureBox pictureBoxFacts;
    }
}