using AltoHttp;
using System;
using System.IO;
using System.Windows.Forms;

namespace Nmap_Downloader
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        private HttpDownloader httpDownloader;
        private readonly string RepoUrl = "https://servdocs.syafiqhadzir.dev/Projects/Etwap/Nmap/nmap-setup.exe";

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            txtUrl.Text = RepoUrl.ToString();
            try
            {
                try
                {
                    string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "AltoHttp.dll");
                    if (File.Exists(path))
                        btn_Download.Enabled = true;
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

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            httpDownloader = new HttpDownloader(txtUrl.Text, $"{Application.StartupPath}\\{Path.GetFileName(txtUrl.Text)}");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();
            btnPause.Enabled = true;
        }

        private void HttpDownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            lbl_Perc.Text = $"{e.Progress:0.00} %";
            lbl_Speed.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lbl_Progress.Text = string.Format("{0} MB", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Invoke((MethodInvoker)delegate { lbl_Perc.Text = "100.0 %"; });
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

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "&Pause")
            {
                if (httpDownloader != null)
                {
                    httpDownloader.Pause();
                    btnPause.Text = "&Resume";
                }
            }
            else if (btnPause.Text == "&Resume")
            {
                if (httpDownloader != null)
                {
                    httpDownloader.Resume();
                    btnPause.Text = "&Pause";
                }
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}