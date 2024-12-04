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
        public FactsGeneratorForm(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            DisplayNextFact();
        }

        private void DisplayNextFact()
        {
            string fact = m_FactGenerator.GenerateNextFact();
            lblFact.Text = fact;
        }

        private void btnNextFact_Click(object sender, EventArgs e)
        {
            DisplayNextFact();
        }

        private void buttonNextFact_Click(object sender, EventArgs e)
        {
            m_FactGenerator.executeGenerator();
        }
    }
}
