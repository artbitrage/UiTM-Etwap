using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class UpdateForm : Form
    {
        private readonly string URL = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/";
        private readonly string AppName = "Etwap.exe";

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            ReleaseNote.ReadOnly = true;

            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(@"https://servdocs.syafiqhadzir.dev/Projects/Etwap/ReleaseNote.txt").Result;

            try
            {
                ReleaseNote.Text = File.ReadAllText(result);
            }
            catch (Exception Update)
            {
                MessageBox.Show(Update.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            byte[] appdata = client.DownloadData(URL + AppName);

            SaveFileDialogUpdate.FileName = "Etwap.exe";
            SaveFileDialogUpdate.Filter = "(*.exe)|*.exe|(*.*)|*.*";
            SaveFileDialogUpdate.Title = "Save Update File";

            if (SaveFileDialogUpdate.ShowDialog() == DialogResult.OK)
            {
                using FileStream fs = File.Create(SaveFileDialogUpdate.FileName);
                fs.Write(appdata, 0, appdata.Length);
            }
        }
    }
}