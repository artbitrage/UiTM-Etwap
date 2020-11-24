using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        public static string ConsoleLog = "";
        public static string BSSID = " networks";
        public static string Detailed = "";
        public static string Aggressive = "";
        public static string Profile = "";

        private string RunScript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            runspace.Close();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject pSObject in results)
                stringBuilder.AppendLine(pSObject.ToString());
            return stringBuilder.ToString();
        }

        private void Btn_Scan_Click(object sender, EventArgs e)
        {
            ConsoleBox.Text = RunScript("netsh wlan show" + BSSID + Detailed + Aggressive + Profile);

            ConsoleLog = ConsoleBox.Text;

            switch (cbx_BSSID.CheckState)
            {
                case CheckState.Checked:

                    cbx_BSSID.Checked = false;
                    cbx_Detailed.Enabled = true;
                    cbx_Aggressive.Enabled = true;
                    cbx_Profiles.Enabled = true;
                    break;
            }

            switch (cbx_Detailed.CheckState)
            {
                case CheckState.Checked:

                    cbx_Detailed.Checked = false;
                    cbx_BSSID.Enabled = true;
                    cbx_Aggressive.Enabled = true;
                    cbx_Profiles.Enabled = true;
                    break;
            }

            switch (cbx_Aggressive.CheckState)
            {
                case CheckState.Checked:

                    cbx_Aggressive.Checked = false;
                    cbx_BSSID.Enabled = true;
                    cbx_Detailed.Enabled = true;
                    cbx_Profiles.Enabled = true;
                    break;
            }

            switch (cbx_Profiles.CheckState)
            {
                case CheckState.Checked:

                    cbx_Profiles.Checked = false;
                    cbx_BSSID.Enabled = true;
                    cbx_Detailed.Enabled = true;
                    cbx_Aggressive.Enabled = true;
                    break;
            }

            BSSID = " networks";
            Detailed = "";
            Aggressive = "";
            Profile = "";
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            SubConsoleBox.Text = RunScript(CmdBox.Text);

            ConsoleLog = SubConsoleBox.Text;
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            ConsoleBox.Text = RunScript("netsh wlan show filters");

            cbx_BSSID.Checked = false;
            cbx_Detailed.Checked = false;
            cbx_Aggressive.Checked = false;
            cbx_Profiles.Checked = false;
            cbx_Stations.Checked = false;

            ConsoleLog = ConsoleBox.Text;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = " networks mode=bssid";
            Detailed = "";
            Aggressive = "";
            Profile = "";

            cbx_Detailed.Checked = false;
            cbx_Detailed.Enabled = false;
            cbx_Aggressive.Checked = false;
            cbx_Aggressive.Enabled = false;
            cbx_Profiles.Checked = false;
            cbx_Profiles.Enabled = false;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = "";
            Detailed = " all";
            Aggressive = "";
            Profile = "";

            cbx_BSSID.Checked = false;
            cbx_BSSID.Enabled = false;
            cbx_Aggressive.Checked = false;
            cbx_Aggressive.Enabled = false;
            cbx_Profiles.Checked = false;
            cbx_Profiles.Enabled = false;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = "";
            Detailed = "";
            Aggressive = " interfaces";
            Profile = "";

            cbx_BSSID.Checked = false;
            cbx_BSSID.Enabled = false;
            cbx_Detailed.Checked = false;
            cbx_Detailed.Enabled = false;
            cbx_Profiles.Checked = false;
            cbx_Profiles.Enabled = false;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = "";
            Detailed = "";
            Aggressive = "";
            Profile = " profiles";

            cbx_BSSID.Checked = false;
            cbx_BSSID.Enabled = false;
            cbx_Detailed.Checked = false;
            cbx_Detailed.Enabled = false;
            cbx_Aggressive.Checked = false;
            cbx_Aggressive.Enabled = false;
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                AddExtension = true,
                Filter = "Text files (*.txt)|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    Process.Start(fileName);
                    string text = System.IO.File.ReadAllText(fileName);
                    CmdBox.Text = text;
                    SubConsoleBox.Text = RunScript(text);
                    ConsoleLog = SubConsoleBox.Text;
                }
            }
        }
    }
}