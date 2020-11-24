namespace Etwap_Detector
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.btn_Scan = new System.Windows.Forms.Button();
            this.btn_Nmap = new System.Windows.Forms.Button();
            this.btn_Deauth = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.panel_Console = new System.Windows.Forms.Panel();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.panel_Config = new System.Windows.Forms.Panel();
            this.btnExec = new System.Windows.Forms.Button();
            this.CmdBox = new System.Windows.Forms.TextBox();
            this.SubConsoleBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_Stations = new System.Windows.Forms.CheckBox();
            this.cbx_Profiles = new System.Windows.Forms.CheckBox();
            this.cbx_Aggressive = new System.Windows.Forms.CheckBox();
            this.cbx_Detailed = new System.Windows.Forms.CheckBox();
            this.cbx_BSSID = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.openFileDialogUpload = new System.Windows.Forms.OpenFileDialog();
            this.panel_Console.SuspendLayout();
            this.panel_Config.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Scan
            // 
            resources.ApplyResources(this.btn_Scan, "btn_Scan");
            this.btn_Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
            // 
            // btn_Nmap
            // 
            resources.ApplyResources(this.btn_Nmap, "btn_Nmap");
            this.btn_Nmap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nmap.Name = "btn_Nmap";
            this.btn_Nmap.UseVisualStyleBackColor = true;
            // 
            // btn_Deauth
            // 
            resources.ApplyResources(this.btn_Deauth, "btn_Deauth");
            this.btn_Deauth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deauth.Name = "btn_Deauth";
            this.btn_Deauth.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            resources.ApplyResources(this.btn_Filter, "btn_Filter");
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // panel_Console
            // 
            resources.ApplyResources(this.panel_Console, "panel_Console");
            this.panel_Console.Controls.Add(this.ConsoleBox);
            this.panel_Console.Name = "panel_Console";
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ConsoleBox, "ConsoleBox");
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Name = "ConsoleBox";
            // 
            // panel_Config
            // 
            this.panel_Config.Controls.Add(this.btnExec);
            this.panel_Config.Controls.Add(this.CmdBox);
            this.panel_Config.Controls.Add(this.SubConsoleBox);
            this.panel_Config.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel_Config, "panel_Config");
            this.panel_Config.Name = "panel_Config";
            // 
            // btnExec
            // 
            resources.ApplyResources(this.btnExec, "btnExec");
            this.btnExec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExec.Name = "btnExec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // CmdBox
            // 
            resources.ApplyResources(this.CmdBox, "CmdBox");
            this.CmdBox.Name = "CmdBox";
            // 
            // SubConsoleBox
            // 
            this.SubConsoleBox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.SubConsoleBox, "SubConsoleBox");
            this.SubConsoleBox.ForeColor = System.Drawing.Color.White;
            this.SubConsoleBox.Name = "SubConsoleBox";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbx_Stations);
            this.panel3.Controls.Add(this.cbx_Profiles);
            this.panel3.Controls.Add(this.cbx_Aggressive);
            this.panel3.Controls.Add(this.cbx_Detailed);
            this.panel3.Controls.Add(this.cbx_BSSID);
            this.panel3.Controls.Add(this.label1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // cbx_Stations
            // 
            resources.ApplyResources(this.cbx_Stations, "cbx_Stations");
            this.cbx_Stations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Stations.Name = "cbx_Stations";
            this.cbx_Stations.UseVisualStyleBackColor = true;
            // 
            // cbx_Profiles
            // 
            resources.ApplyResources(this.cbx_Profiles, "cbx_Profiles");
            this.cbx_Profiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Profiles.Name = "cbx_Profiles";
            this.cbx_Profiles.UseVisualStyleBackColor = true;
            this.cbx_Profiles.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // cbx_Aggressive
            // 
            resources.ApplyResources(this.cbx_Aggressive, "cbx_Aggressive");
            this.cbx_Aggressive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Aggressive.Name = "cbx_Aggressive";
            this.cbx_Aggressive.UseVisualStyleBackColor = true;
            this.cbx_Aggressive.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // cbx_Detailed
            // 
            resources.ApplyResources(this.cbx_Detailed, "cbx_Detailed");
            this.cbx_Detailed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Detailed.Name = "cbx_Detailed";
            this.cbx_Detailed.UseVisualStyleBackColor = true;
            this.cbx_Detailed.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // cbx_BSSID
            // 
            resources.ApplyResources(this.cbx_BSSID, "cbx_BSSID");
            this.cbx_BSSID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_BSSID.Name = "cbx_BSSID";
            this.cbx_BSSID.UseVisualStyleBackColor = true;
            this.cbx_BSSID.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Name = "label1";
            // 
            // btn_Upload
            // 
            resources.ApplyResources(this.btn_Upload, "btn_Upload");
            this.btn_Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // openFileDialogUpload
            // 
            this.openFileDialogUpload.FileName = "openFileDialogUpload";
            // 
            // DashboardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.panel_Config);
            this.Controls.Add(this.panel_Console);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Deauth);
            this.Controls.Add(this.btn_Nmap);
            this.Controls.Add(this.btn_Scan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.panel_Console.ResumeLayout(false);
            this.panel_Console.PerformLayout();
            this.panel_Config.ResumeLayout(false);
            this.panel_Config.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.Button btn_Nmap;
        private System.Windows.Forms.Button btn_Deauth;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Panel panel_Console;
        private System.Windows.Forms.Panel panel_Config;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbx_Stations;
        private System.Windows.Forms.CheckBox cbx_Profiles;
        private System.Windows.Forms.CheckBox cbx_Aggressive;
        private System.Windows.Forms.CheckBox cbx_Detailed;
        private System.Windows.Forms.CheckBox cbx_BSSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubConsoleBox;
        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox CmdBox;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialogUpload;
    }
}