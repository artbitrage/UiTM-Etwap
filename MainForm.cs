using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Etwaps_Detector
{
    public partial class MainForm : Form
    {
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
            openChildForm(new DashboardForm());

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();

            AllocConsole();

            string msg_Intro = "Hello World!";

            Console.WriteLine(msg_Intro);
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
    }
}