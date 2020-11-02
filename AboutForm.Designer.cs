namespace Etwaps_Detector
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelDesc = new System.Windows.Forms.Panel();
            this.panelDev = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            // 
            // panelDesc
            // 
            this.panelDesc.Controls.Add(this.labelSubtitle);
            this.panelDesc.Controls.Add(this.labelVersion);
            this.panelDesc.Controls.Add(this.labelTitle);
            resources.ApplyResources(this.panelDesc, "panelDesc");
            this.panelDesc.Name = "panelDesc";
            // 
            // panelDev
            // 
            resources.ApplyResources(this.panelDev, "panelDev");
            this.panelDev.Name = "panelDev";
            // 
            // panelBottom
            // 
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Name = "panelBottom";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.Name = "labelVersion";
            // 
            // labelSubtitle
            // 
            resources.ApplyResources(this.labelSubtitle, "labelSubtitle");
            this.labelSubtitle.Name = "labelSubtitle";
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Etwaps_Detector.Properties.Resources.android_chrome_96x96;
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelDev);
            this.Controls.Add(this.panelDesc);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.panelDesc.ResumeLayout(false);
            this.panelDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesc;
        private System.Windows.Forms.Panel panelDev;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelTitle;
    }
}