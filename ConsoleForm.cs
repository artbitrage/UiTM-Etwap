using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
            ConsoleBox.ReadOnly = true;
            ConsoleBox.Text = DashboardForm.ConsoleLog;
            ConsoleBox.Text = InterfaceForm.ConsoleLog;
        }

        private void Btn_Console_Click(object sender, EventArgs e)
        {
            ConsoleBox.Clear();
            var ConsoleApp = Process.Start(@"Etwap-Console.exe");
            ConsoleBox.Text = ConsoleApp.ToString();
            ConsoleBox.Text = "Executing Etwap-Console.exe ...";
            ConsoleApp.WaitForExit();
            ConsoleBox.Text = "Exit application.";
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(folderBrowserDialog.SelectedPath + "\\Report.txt", ConsoleBox.Text);
                MessageBox.Show("Saved to " + folderBrowserDialog.SelectedPath + "\\Report.txt", "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}