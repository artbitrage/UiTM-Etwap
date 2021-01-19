
namespace Nmap_Downloader
{
    partial class DownloadForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.lbl_Perc = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Enabled = false;
            this.txtUrl.Location = new System.Drawing.Point(12, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(360, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 38);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(360, 23);
            this.progressBar.Step = 100;
            this.progressBar.TabIndex = 0;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Location = new System.Drawing.Point(169, 73);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(47, 13);
            this.lbl_Progress.TabIndex = 0;
            this.lbl_Progress.Text = "0.00 MB";
            this.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Perc
            // 
            this.lbl_Perc.AutoSize = true;
            this.lbl_Perc.Location = new System.Drawing.Point(173, 99);
            this.lbl_Perc.Name = "lbl_Perc";
            this.lbl_Perc.Size = new System.Drawing.Size(39, 13);
            this.lbl_Perc.TabIndex = 0;
            this.lbl_Perc.Text = "0.00 %";
            this.lbl_Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Download
            // 
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.Enabled = false;
            this.btn_Download.Location = new System.Drawing.Point(92, 131);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(63, 31);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "&Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.Location = new System.Drawing.Point(230, 131);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(63, 31);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "&Cancel";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Location = new System.Drawing.Point(309, 140);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(57, 13);
            this.lbl_Speed.TabIndex = 0;
            this.lbl_Speed.Text = "0.00 MB/s";
            this.lbl_Speed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(161, 131);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(63, 31);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 174);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbl_Speed);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.lbl_Perc);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadForm";
            this.Text = "NMAP Downloader";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DownloadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Label lbl_Perc;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Button btnPause;
    }
}

