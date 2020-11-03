using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Etwap_Detector
{
    public partial class UpdateForm : Form
    {
        private string URL = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/";
        private string AppName = "Etwap.exe";

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm();
            form.Text = "New Update Available!";

            ReleaseNote.Text = File.ReadAllText("https://servdocs.syafiqhadzir.dev/Projects/Etwap/ReleaseNotes.txt");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            byte[] appdata = client.DownloadData(URL + AppName);

            if (SaveFileDialogUpdate.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(SaveFileDialogUpdate.FileName))
                {
                    fs.Write(appdata, 0, appdata.Length);
                }
            }
        }
    }
}