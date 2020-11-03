namespace Etwap_Detector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btn_Console = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pnl_MainVersion = new System.Windows.Forms.Panel();
            this.lbl_MainVersion = new System.Windows.Forms.Label();
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.pnl_MainVersion.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.btn_Console);
            this.MainPanel.Controls.Add(this.panel_Logo);
            this.MainPanel.Controls.Add(this.pnl_MainVersion);
            this.MainPanel.Controls.Add(this.btn_Users);
            this.MainPanel.Controls.Add(this.btn_Dashboard);
            this.MainPanel.Controls.Add(this.menuStrip);
            this.MainPanel.Name = "MainPanel";
            // 
            // btn_Console
            // 
            resources.ApplyResources(this.btn_Console, "btn_Console");
            this.btn_Console.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Console.Name = "btn_Console";
            this.btn_Console.UseVisualStyleBackColor = true;
            this.btn_Console.Click += new System.EventHandler(this.btn_Console_Click);
            // 
            // panel_Logo
            // 
            resources.ApplyResources(this.panel_Logo, "panel_Logo");
            this.panel_Logo.BackgroundImage = global::Etwap_Detector.Properties.Resources.android_chrome_96x96;
            this.panel_Logo.Name = "panel_Logo";
            // 
            // pnl_MainVersion
            // 
            resources.ApplyResources(this.pnl_MainVersion, "pnl_MainVersion");
            this.pnl_MainVersion.Controls.Add(this.lbl_MainVersion);
            this.pnl_MainVersion.Controls.Add(this.lbl_MainTitle);
            this.pnl_MainVersion.Name = "pnl_MainVersion";
            // 
            // lbl_MainVersion
            // 
            resources.ApplyResources(this.lbl_MainVersion, "lbl_MainVersion");
            this.lbl_MainVersion.Name = "lbl_MainVersion";
            // 
            // lbl_MainTitle
            // 
            resources.ApplyResources(this.lbl_MainTitle, "lbl_MainTitle");
            this.lbl_MainTitle.Name = "lbl_MainTitle";
            // 
            // btn_Users
            // 
            resources.ApplyResources(this.btn_Users, "btn_Users");
            this.btn_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Dashboard
            // 
            resources.ApplyResources(this.btn_Dashboard, "btn_Dashboard");
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip.Name = "menuStrip";
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            resources.ApplyResources(this.consoleToolStripMenuItem, "consoleToolStripMenuItem");
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelChildForm
            // 
            resources.ApplyResources(this.panelChildForm, "panelChildForm");
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.pnl_MainVersion.ResumeLayout(false);
            this.pnl_MainVersion.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_MainVersion;
        private System.Windows.Forms.Label lbl_MainTitle;
        private System.Windows.Forms.Label lbl_MainVersion;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_Console;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}