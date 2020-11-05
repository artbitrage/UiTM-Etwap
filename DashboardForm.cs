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
            ConsoleBox.Clear();
            if (checkBox1.Checked == true)
            {
                BSSID = " mode=bssid";
            }
            if (checkBox1.Checked == false)
            {
                BSSID = "";
            }

            ConsoleBox.Text = RunScript("netsh wlan show network" + BSSID);

            ConsoleLog = ConsoleBox.Text;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            SubConsoleBox.Clear();
            SubConsoleBox.Text = RunScript(CmdBox.Text);

            ConsoleLog = SubConsoleBox.Text;
        }
    }
}