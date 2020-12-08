using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class MainForm : Form
    {
        private readonly string Version = "201209";

        private readonly string URL = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/";
        private readonly string ServerVersion;
        private readonly string ServerVersionName = "Release.txt";

        public MainForm()
        {
            InitializeComponent();

            try
            {
                WebRequest req = WebRequest.Create(URL + ServerVersionName);
                WebResponse res = req.GetResponse();
                Stream str = res.GetResponseStream();
                StreamReader stdr = new StreamReader(str);
                ServerVersion = stdr.ReadLine();
            }
            catch
            {
                lbl_Update.Text = "No internet connection!";
            }
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
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

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());

            btn_Dashboard.Enabled = false;
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SimpleWifi.dll");
            if (File.Exists(path))
            {
                btn_Interface.Enabled = true;
            }
            btn_Console.Enabled = true;
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InterfaceForm());

            btn_Dashboard.Enabled = true;
            btn_Interface.Enabled = false;
            btn_Console.Enabled = true;
        }

        private void Btn_Console_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsoleForm());

            btn_Dashboard.Enabled = true;
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SimpleWifi.dll");
            if (File.Exists(path))
            {
                btn_Interface.Enabled = true;
            }
            btn_Console.Enabled = false;
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());

            btn_Dashboard.Enabled = false;
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SimpleWifi.dll");
            if (File.Exists(path))
            {
                btn_Interface.Enabled = true;
            }

            try
            {
                if (GetVersion() != ServerVersion)
                {
                    lbl_Update.Text = "New update available!";
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon.BalloonTipText = "New update available!";
                    notifyIcon.ShowBalloonTip(1000);
                }
                else
                {
                    lbl_Update.Text = "Etwap is up-to-date!";
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon.BalloonTipText = "Etwap is up-to-date!";
                    notifyIcon.ShowBalloonTip(1000);
                }
            }
            catch
            {
                lbl_Update.Text = "No internet connection!";
            }
        }

        public string GetVersion()
        {
            return Version;
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());

            btn_Dashboard.Enabled = true;
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SimpleWifi.dll");
            if (File.Exists(path))
            {
                btn_Interface.Enabled = true;
            }
            btn_Console.Enabled = true;
        }

        private void ConsoleMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsoleForm());

            btn_Dashboard.Enabled = true;
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SimpleWifi.dll");
            if (File.Exists(path))
            {
                btn_Interface.Enabled = true;
            }
            btn_Console.Enabled = false;
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (GetVersion() != ServerVersion)
                    {
                        DialogResult dialogResult = MessageBox.Show("There is an update available. Would you like to download it now?", "Software Update", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start(@".\Etwap-Updater.exe");
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Etwap is up-to-date!", "Software Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}