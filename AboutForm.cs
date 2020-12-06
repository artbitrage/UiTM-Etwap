using System;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class AboutForm : Form
    {
        private readonly string Version = "201202";

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
        }

        private void LnklblVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://servdocs.syafiqhadzir.dev/Projects/Etwap/" + Version + "/ReleaseNote.txt");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnklblLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://servdocs.syafiqhadzir.dev/Projects/Etwap/" + Version + "/License.txt");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}