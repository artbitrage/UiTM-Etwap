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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.btn_Console = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pnl_MainVersion = new System.Windows.Forms.Panel();
            this.lbl_MainVersion = new System.Windows.Forms.Label();
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.btn_Interface = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuEtwap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.pnl_MainVersion.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Controls.Add(this.panelUpdate);
            this.MainPanel.Controls.Add(this.btn_Console);
            this.MainPanel.Controls.Add(this.panel_Logo);
            this.MainPanel.Controls.Add(this.pnl_MainVersion);
            this.MainPanel.Controls.Add(this.btn_Interface);
            this.MainPanel.Controls.Add(this.btn_Dashboard);
            this.MainPanel.Controls.Add(this.menuStrip);
            this.MainPanel.Name = "MainPanel";
            // 
            // panelUpdate
            // 
            resources.ApplyResources(this.panelUpdate, "panelUpdate");
            this.panelUpdate.Controls.Add(this.lbl_Update);
            this.panelUpdate.Name = "panelUpdate";
            // 
            // lbl_Update
            // 
            resources.ApplyResources(this.lbl_Update, "lbl_Update");
            this.lbl_Update.Name = "lbl_Update";
            // 
            // btn_Console
            // 
            resources.ApplyResources(this.btn_Console, "btn_Console");
            this.btn_Console.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Console.Name = "btn_Console";
            this.btn_Console.UseVisualStyleBackColor = true;
            this.btn_Console.Click += new System.EventHandler(this.Btn_Console_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackgroundImage = global::Etwap_Detector.Properties.Resources.android_chrome_96x96;
            resources.ApplyResources(this.panel_Logo, "panel_Logo");
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
            // btn_Interface
            // 
            resources.ApplyResources(this.btn_Interface, "btn_Interface");
            this.btn_Interface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Interface.Name = "btn_Interface";
            this.btn_Interface.UseVisualStyleBackColor = true;
            this.btn_Interface.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // btn_Dashboard
            // 
            resources.ApplyResources(this.btn_Dashboard, "btn_Dashboard");
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.toolStripMenu});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.consoleMenuItem,
            this.updateMenuItem,
            this.ExitMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            resources.ApplyResources(this.toolStripMenuItem, "toolStripMenuItem");
            // 
            // aboutMenuItem
            // 
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // consoleMenuItem
            // 
            resources.ApplyResources(this.consoleMenuItem, "consoleMenuItem");
            this.consoleMenuItem.Name = "consoleMenuItem";
            this.consoleMenuItem.Click += new System.EventHandler(this.ConsoleMenuItem_Click);
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            resources.ApplyResources(this.updateMenuItem, "updateMenuItem");
            this.updateMenuItem.Click += new System.EventHandler(this.UpdateMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenuItem,
            this.openMenuItem,
            this.configMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            // 
            // createMenuItem
            // 
            this.createMenuItem.Name = "createMenuItem";
            resources.ApplyResources(this.createMenuItem, "createMenuItem");
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            resources.ApplyResources(this.openMenuItem, "openMenuItem");
            // 
            // configMenuItem
            // 
            this.configMenuItem.Name = "configMenuItem";
            resources.ApplyResources(this.configMenuItem, "configMenuItem");
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            resources.ApplyResources(this.autoToolStripMenuItem, "autoToolStripMenuItem");
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            resources.ApplyResources(this.manualToolStripMenuItem, "manualToolStripMenuItem");
            // 
            // panelChildForm
            // 
            resources.ApplyResources(this.panelChildForm, "panelChildForm");
            this.panelChildForm.Name = "panelChildForm";
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEtwap,
            this.toolStripMenuConsole,
            this.toolStripMenuUpdate,
            this.toolStripMenuIExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // toolStripMenuEtwap
            // 
            this.toolStripMenuEtwap.Image = global::Etwap_Detector.Properties.Resources.favicon_32x32;
            this.toolStripMenuEtwap.Name = "toolStripMenuEtwap";
            resources.ApplyResources(this.toolStripMenuEtwap, "toolStripMenuEtwap");
            this.toolStripMenuEtwap.Click += new System.EventHandler(this.ToolStripMenuEtwap_Click);
            // 
            // toolStripMenuUpdate
            // 
            this.toolStripMenuUpdate.Name = "toolStripMenuUpdate";
            resources.ApplyResources(this.toolStripMenuUpdate, "toolStripMenuUpdate");
            this.toolStripMenuUpdate.Click += new System.EventHandler(this.ToolStripMenuUpdate_Click);
            // 
            // toolStripMenuIExit
            // 
            this.toolStripMenuIExit.Name = "toolStripMenuIExit";
            resources.ApplyResources(this.toolStripMenuIExit, "toolStripMenuIExit");
            this.toolStripMenuIExit.Click += new System.EventHandler(this.ToolStripMenuIExit_Click);
            // 
            // toolStripMenuConsole
            // 
            this.toolStripMenuConsole.Name = "toolStripMenuConsole";
            resources.ApplyResources(this.toolStripMenuConsole, "toolStripMenuConsole");
            this.toolStripMenuConsole.Click += new System.EventHandler(this.ToolStripMenuConsole_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.pnl_MainVersion.ResumeLayout(false);
            this.pnl_MainVersion.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btn_Interface;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel pnl_MainVersion;
        private System.Windows.Forms.Label lbl_MainTitle;
        private System.Windows.Forms.Label lbl_MainVersion;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_Console;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEtwap;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuConsole;
    }
}