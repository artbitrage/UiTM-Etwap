using System;
using System.IO;
using System.Runtime.InteropServices;
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
        }

        private void btn_CMD_Click(object sender, EventArgs e)
        {
            AllocConsole();

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter txt = new StreamWriter(folderBrowserDialog.SelectedPath + "Report.txt");
                // write a line of text to the file
                txt.WriteLine(ConsoleBox.Text);
                // close the stream
                txt.Close();
                MessageBox.Show("Saved to " + folderBrowserDialog.SelectedPath + "\\Report.txt", "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}