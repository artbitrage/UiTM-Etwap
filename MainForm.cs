using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class MainForm : Form
    {
        private readonly string Version = "201104";

        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());

            btn_Dashboard.Enabled = false;
            btn_Users.Enabled = true;
            btn_Console.Enabled = true;
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            btn_Dashboard.Enabled = true;
            btn_Users.Enabled = false;
            btn_Console.Enabled = true;
        }

        private void btn_Console_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsoleForm());

            btn_Dashboard.Enabled = true;
            btn_Users.Enabled = true;
            btn_Console.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutForm());

            btn_Dashboard.Enabled = true;
            btn_Users.Enabled = true;
            btn_Console.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsoleForm());

            btn_Dashboard.Enabled = true;
            btn_Users.Enabled = true;
            btn_Console.Enabled = false;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());

            btn_Dashboard.Enabled = false;
            btn_Users.Enabled = true;
            btn_Console.Enabled = true;
        }

        public string getVersion()
        {
            return Version;
        }

        private void checkForUpdate()
        {
            string URL = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/";
            string ServerVersion;
            string ServerVersionName = "Release.txt";

            WebRequest req = WebRequest.Create(URL + ServerVersionName);
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader stdr = new StreamReader(str);
            ServerVersion = stdr.ReadLine();

            if (getVersion() != ServerVersion)
            {
                UpdateForm updateForm = new UpdateForm();
                updateForm.StartPosition = FormStartPosition.CenterParent;
                updateForm.Show();
            }
            else
            {
                MessageBox.Show("Etwap is up-to-date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkForUpdate();
        }
    }
}