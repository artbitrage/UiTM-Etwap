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
        public static string BSSID = "";
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
            if (checkBox1.Checked == true)
            {
                BSSID = " networks mode=bssid";
                if (checkBox3.Checked == true)
                {
                    checkBox1.Checked = false;
                }
            }
            if (checkBox1.Checked == false)
            {
                BSSID = " networks";
            }

            if (checkBox3.Checked == true)
            {
                BSSID = "";
                Aggressive = " interfaces";
                if (checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                }
            }
            if (checkBox3.Checked == false)
            {
                Aggressive = "";
            }

            ConsoleBox.Text = RunScript("netsh wlan show" + BSSID + Aggressive);

            ConsoleLog = ConsoleBox.Text;
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
    }
}