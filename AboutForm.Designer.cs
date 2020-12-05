namespace Etwap_Detector
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDev = new System.Windows.Forms.Panel();
            this.lnklblVersion = new System.Windows.Forms.LinkLabel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lnklblLicense = new System.Windows.Forms.LinkLabel();
            this.panelDesc.SuspendLayout();
            this.panelDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            // 
            // panelDesc
            // 
            this.panelDesc.Controls.Add(this.lblSubtitle);
            this.panelDesc.Controls.Add(this.lblBuild);
            this.panelDesc.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.panelDesc, "panelDesc");
            this.panelDesc.Name = "panelDesc";
            // 
            // lblSubtitle
            // 
            resources.ApplyResources(this.lblSubtitle, "lblSubtitle");
            this.lblSubtitle.Name = "lblSubtitle";
            // 
            // lblBuild
            // 
            resources.ApplyResources(this.lblBuild, "lblBuild");
            this.lblBuild.Name = "lblBuild";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // panelDev
            // 
            this.panelDev.Controls.Add(this.lnklblLicense);
            this.panelDev.Controls.Add(this.lnklblVersion);
            resources.ApplyResources(this.panelDev, "panelDev");
            this.panelDev.Name = "panelDev";
            // 
            // lnklblVersion
            // 
            resources.ApplyResources(this.lnklblVersion, "lnklblVersion");
            this.lnklblVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblVersion.Name = "lnklblVersion";
            this.lnklblVersion.TabStop = true;
            this.lnklblVersion.UseCompatibleTextRendering = true;
            this.lnklblVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblVersion_LinkClicked);
            // 
            // panelBottom
            // 
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Name = "panelBottom";
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Etwap_Detector.Properties.Resources.android_chrome_96x96;
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // lnklblLicense
            // 
            resources.ApplyResources(this.lnklblLicense, "lnklblLicense");
            this.lnklblLicense.Name = "lnklblLicense";
            this.lnklblLicense.TabStop = true;
            this.lnklblLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblLicense_LinkClicked);
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
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.panelDesc.ResumeLayout(false);
            this.panelDesc.PerformLayout();
            this.panelDev.ResumeLayout(false);
            this.panelDev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesc;
        private System.Windows.Forms.Panel panelDev;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnklblVersion;
        private System.Windows.Forms.LinkLabel lnklblLicense;
    }
}