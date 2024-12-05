using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UserInterface
{
    public partial class FactsGeneratorForm : Form
    {

        private readonly User r_LoggedInUser;
        private RandomFactGenerator m_FactGenerator;
        private readonly Random m_Random;
        //private Timer m_AnimationTimer;
        //private float m_OpacityStep;

        public FactsGeneratorForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            m_FactGenerator = new RandomFactGenerator(r_LoggedInUser);
            m_Random = new Random();
            DisplayNextFact();
        }

        private void DisplayNextFact()
        {
            buttonNextFact.Enabled = false;
            string fact = m_FactGenerator.GenerateNextFact();
            lblFact.Text = fact;
            applyRandomFontAndSize();
            applyRandomColor();
            centerLabel();
            this.Invalidate();

            // Re-enable the button after a short delay to allow user to see the new fact
            Task.Delay(300).ContinueWith(t =>
            {
                // Re-enable the button after a delay (in milliseconds)
                buttonNextFact.Invoke((MethodInvoker)(() => buttonNextFact.Enabled = true));
            });
        }

        private void btnNextFact_Click(object sender, EventArgs e)
        {
            DisplayNextFact();
        }

        private void buttonNextFact_Click(object sender, EventArgs e)
        {
            DisplayNextFact();
        }

        private void applyRandomFontAndSize()
        {
            string[] fontFamilies = { "Arial", "Comic Sans MS", "Verdana", "Tahoma", "Times New Roman" };

            int fontSize = m_Random.Next(15, 21); // Random font size between 15 and 20
            string fontFamily = fontFamilies[m_Random.Next(fontFamilies.Length)];

            lblFact.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
            
            // Set label width to be within the form width, with some padding
            lblFact.Width = this.ClientSize.Width - 40;  // Leave 20px padding on each side
            lblFact.MaximumSize = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100); // Max height is form height minus padding
            lblFact.AutoSize = false; // Disable AutoSize to control width and height manually
            lblFact.TextAlign = ContentAlignment.TopCenter; // Center the text
        }
        private void applyRandomColor()
        {
            Color[] colors =
            {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Purple,
                Color.Orange
            };

            lblFact.ForeColor = colors[m_Random.Next(colors.Length)];
        }
        private void centerLabel()
        {
            lblFact.AutoSize = true;
            lblFact.Left = (this.ClientSize.Width - lblFact.Width) / 2; 
            lblFact.Top = 60; 
        }

    }
}
