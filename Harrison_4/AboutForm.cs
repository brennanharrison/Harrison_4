// Programmer: Brennan Harrison
// Project: Harrison_4
// Date: 11/21/2018
// Description: Create a registration application for Hopkins Film School (AboutForm Class).

using System.Windows.Forms;

namespace Harrison_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // closeButton click event handler.
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            // Close the AboutForm (and return to the RegistrationForm).
            this.Close();
        }
    }
}
