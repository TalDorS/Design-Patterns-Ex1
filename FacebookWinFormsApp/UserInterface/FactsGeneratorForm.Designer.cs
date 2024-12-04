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
            this.SuspendLayout();
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Location = new System.Drawing.Point(117, 80);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(28, 16);
            this.lblFact.TabIndex = 0;
            this.lblFact.Text = "fact";
            // 
            // buttonNextFact
            // 
            this.buttonNextFact.Location = new System.Drawing.Point(631, 397);
            this.buttonNextFact.Name = "buttonNextFact";
            this.buttonNextFact.Size = new System.Drawing.Size(164, 48);
            this.buttonNextFact.TabIndex = 1;
            this.buttonNextFact.Text = "Next Fact";
            this.buttonNextFact.UseVisualStyleBackColor = true;
            this.buttonNextFact.Click += new System.EventHandler(this.buttonNextFact_Click);
            // 
            // FactsGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNextFact);
            this.Controls.Add(this.lblFact);
            this.Name = "FactsGeneratorForm";
            this.Text = "FactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Button buttonNextFact;
    }
}