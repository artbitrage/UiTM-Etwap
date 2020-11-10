using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class MainForm : Form
    {
        private string Version = "201111";

        private string URL = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/";
        private string ServerVersion;
        private string ServerVersionName = "Release.txt";

        public MainForm()
        {
            InitializeComponent();

            WebRequest req = WebRequest.Create(URL + ServerVersionName);
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader stdr = new StreamReader(str);
            ServerVersion = stdr.ReadLine();
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
            btn_Users.Enabled = false;
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
            btn_Users.Enabled = false;
            btn_Console.Enabled = false;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());

            btn_Dashboard.Enabled = false;
            btn_Users.Enabled = false;
            btn_Console.Enabled = true;

            if (getVersion() != ServerVersion)
            {
                lbl_Update.Text = "New update available!";
            }
            else
            {
                lbl_Update.Text = "Etwap is up-to-date!";
            }
        }

        public string getVersion()
        {
            return Version;
        }

        private void checkForUpdate()
        {
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

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutForm());

            btn_Dashboard.Enabled = true;
            btn_Users.Enabled = false;
            btn_Console.Enabled = true;
        }

        private void consoleMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ConsoleForm());

            btn_Dashboard.Enabled = true;
            btn_Users.Enabled = false;
            btn_Console.Enabled = false;
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            checkForUpdate();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}