using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Etwap_Updater
{
    public partial class UpdaterForm : Form
    {
        private readonly string URL = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/";

        public UpdaterForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            ReleaseNote.ReadOnly = true;
            try
            {
                try
                {
                    string contents;
                    using (var wc = new WebClient())
                        contents = wc.DownloadString("https://servdocs.syafiqhadzir.dev/Projects/Etwap/ReleaseNote.txt");

                    ReleaseNote.Text = contents.ToString();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception lv_err)
            {
                MessageBox.Show(lv_err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    WebClient webClient = new WebClient();
                    var client = new WebClient();
                    File.Delete(@".\Etwap-Detector.exe");
                    client.DownloadFile(URL, @"Etwap-Detector.exe");
                    Process.Start(@".\Etwap-Detector.exe");
                    Close();
                }
                catch (Exception interr)
                {
                    MessageBox.Show(interr.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception uperr)
            {
                MessageBox.Show(uperr.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}