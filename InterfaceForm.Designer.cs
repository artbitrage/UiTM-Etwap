
namespace Etwap_Detector
{
    partial class InterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceForm));
            this.listView_AP = new System.Windows.Forms.ListView();
            this.clmAccessPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSignal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSecure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Refreshed = new System.Windows.Forms.Label();
            this.grp_Manager = new System.Windows.Forms.GroupBox();
            this.lbl_SSID = new System.Windows.Forms.Label();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.txBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txBox_SSID = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.grp_Status = new System.Windows.Forms.GroupBox();
            this.lbl_AP = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_StatInt = new System.Windows.Forms.Label();
            this.pnl_Btns.SuspendLayout();
            this.grp_Manager.SuspendLayout();
            this.grp_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_AP
            // 
            this.listView_AP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAccessPoint,
            this.clmSignal,
            this.clmSecure});
            this.listView_AP.HideSelection = false;
            resources.ApplyResources(this.listView_AP, "listView_AP");
            this.listView_AP.Name = "listView_AP";
            this.listView_AP.UseCompatibleStateImageBehavior = false;
            this.listView_AP.View = System.Windows.Forms.View.Details;
            this.listView_AP.SelectedIndexChanged += new System.EventHandler(this.ListView_AP_SelectedIndexChanged);
            // 
            // clmAccessPoint
            // 
            resources.ApplyResources(this.clmAccessPoint, "clmAccessPoint");
            // 
            // clmSignal
            // 
            resources.ApplyResources(this.clmSignal, "clmSignal");
            // 
            // clmSecure
            // 
            resources.ApplyResources(this.clmSecure, "clmSecure");
            // 
            // pnl_Btns
            // 
            resources.ApplyResources(this.pnl_Btns, "pnl_Btns");
            this.pnl_Btns.Controls.Add(this.btn_Refresh);
            this.pnl_Btns.Controls.Add(this.lbl_Refreshed);
            this.pnl_Btns.Controls.Add(this.grp_Manager);
            this.pnl_Btns.Controls.Add(this.grp_Status);
            this.pnl_Btns.Name = "pnl_Btns";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Refresh, "btn_Refresh");
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // lbl_Refreshed
            // 
            resources.ApplyResources(this.lbl_Refreshed, "lbl_Refreshed");
            this.lbl_Refreshed.Name = "lbl_Refreshed";
            // 
            // grp_Manager
            // 
            this.grp_Manager.Controls.Add(this.lbl_SSID);
            this.grp_Manager.Controls.Add(this.lbl_Warning);
            this.grp_Manager.Controls.Add(this.txBox_Password);
            this.grp_Manager.Controls.Add(this.btn_Connect);
            this.grp_Manager.Controls.Add(this.txBox_SSID);
            this.grp_Manager.Controls.Add(this.lbl_Password);
            resources.ApplyResources(this.grp_Manager, "grp_Manager");
            this.grp_Manager.Name = "grp_Manager";
            this.grp_Manager.TabStop = false;
            // 
            // lbl_SSID
            // 
            resources.ApplyResources(this.lbl_SSID, "lbl_SSID");
            this.lbl_SSID.Name = "lbl_SSID";
            // 
            // lbl_Warning
            // 
            resources.ApplyResources(this.lbl_Warning, "lbl_Warning");
            this.lbl_Warning.BackColor = System.Drawing.Color.Red;
            this.lbl_Warning.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl_Warning.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Warning.Name = "lbl_Warning";
            this.toolTip.SetToolTip(this.lbl_Warning, resources.GetString("lbl_Warning.ToolTip"));
            // 
            // txBox_Password
            // 
            resources.ApplyResources(this.txBox_Password, "txBox_Password");
            this.txBox_Password.Name = "txBox_Password";
            this.txBox_Password.UseSystemPasswordChar = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Connect, "btn_Connect");
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // txBox_SSID
            // 
            this.txBox_SSID.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txBox_SSID, "txBox_SSID");
            this.txBox_SSID.Name = "txBox_SSID";
            this.txBox_SSID.ReadOnly = true;
            // 
            // lbl_Password
            // 
            resources.ApplyResources(this.lbl_Password, "lbl_Password");
            this.lbl_Password.Name = "lbl_Password";
            // 
            // grp_Status
            // 
            this.grp_Status.Controls.Add(this.lbl_StatInt);
            this.grp_Status.Controls.Add(this.lbl_AP);
            this.grp_Status.Controls.Add(this.lbl_Status);
            resources.ApplyResources(this.grp_Status, "grp_Status");
            this.grp_Status.Name = "grp_Status";
            this.grp_Status.TabStop = false;
            // 
            // lbl_AP
            // 
            resources.ApplyResources(this.lbl_AP, "lbl_AP");
            this.lbl_AP.Name = "lbl_AP";
            // 
            // lbl_Status
            // 
            resources.ApplyResources(this.lbl_Status, "lbl_Status");
            this.lbl_Status.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Status.Name = "lbl_Status";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip.ToolTipTitle = "Warning!";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lbl_StatInt
            // 
            resources.ApplyResources(this.lbl_StatInt, "lbl_StatInt");
            this.lbl_StatInt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_StatInt.Name = "lbl_StatInt";
            // 
            // InterfaceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Btns);
            this.Controls.Add(this.listView_AP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfaceForm";
            this.Load += new System.EventHandler(this.InterfaceForm_Load);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Btns.PerformLayout();
            this.grp_Manager.ResumeLayout(false);
            this.grp_Manager.PerformLayout();
            this.grp_Status.ResumeLayout(false);
            this.grp_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_AP;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.ColumnHeader clmAccessPoint;
        private System.Windows.Forms.ColumnHeader clmSignal;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txBox_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ColumnHeader clmSecure;
        private System.Windows.Forms.TextBox txBox_SSID;
        private System.Windows.Forms.Label lbl_SSID;
        private System.Windows.Forms.Label lbl_AP;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox grp_Status;
        private System.Windows.Forms.GroupBox grp_Manager;
        private System.Windows.Forms.Label lbl_Refreshed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_StatInt;
    }
}