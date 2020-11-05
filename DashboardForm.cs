using System;
using System.Collections.ObjectModel;
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

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            ConsoleBox.Text = RunScript("netsh wlan show" + BSSID + Detailed + Aggressive);

            ConsoleLog = ConsoleBox.Text;

            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:

                    checkBox1.Checked = false;
                    break;
            }

            switch (checkBox2.CheckState)
            {
                case CheckState.Checked:

                    checkBox2.Checked = false;
                    checkBox1.Enabled = true;
                    checkBox3.Enabled = true;
                    break;
            }

            switch (checkBox3.CheckState)
            {
                case CheckState.Checked:

                    checkBox3.Checked = false;
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    break;
            }

            BSSID = " networks";
            Detailed = "";
            Aggressive = "";
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            SubConsoleBox.Text = RunScript(CmdBox.Text);

            ConsoleLog = SubConsoleBox.Text;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            ConsoleBox.Text = RunScript("netsh wlan show filters");

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            ConsoleLog = ConsoleBox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = " networks mode=bssid";
            Detailed = "";
            Aggressive = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = "";
            Detailed = " all";
            Aggressive = "";

            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            checkBox3.Checked = false;
            checkBox3.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            BSSID = "";
            Detailed = "";
            Aggressive = " interfaces";

            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            checkBox2.Checked = false;
            checkBox2.Enabled = false;
        }
    }
}