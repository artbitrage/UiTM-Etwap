
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceForm));
            this.listView_AP = new System.Windows.Forms.ListView();
            this.clmAccessPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSignal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSecure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.lbl_SSID = new System.Windows.Forms.Label();
            this.txBox_SSID = new System.Windows.Forms.TextBox();
            this.lbl_Stat = new System.Windows.Forms.Label();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txBox_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_AP = new System.Windows.Forms.Label();
            this.pnl_Btns.SuspendLayout();
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
            this.pnl_Btns.Controls.Add(this.lbl_AP);
            this.pnl_Btns.Controls.Add(this.lbl_SSID);
            this.pnl_Btns.Controls.Add(this.txBox_SSID);
            this.pnl_Btns.Controls.Add(this.lbl_Stat);
            this.pnl_Btns.Controls.Add(this.btn_Disconnect);
            this.pnl_Btns.Controls.Add(this.lbl_Status);
            this.pnl_Btns.Controls.Add(this.txBox_Password);
            this.pnl_Btns.Controls.Add(this.lbl_Password);
            this.pnl_Btns.Controls.Add(this.btn_Connect);
            this.pnl_Btns.Name = "pnl_Btns";
            // 
            // lbl_SSID
            // 
            resources.ApplyResources(this.lbl_SSID, "lbl_SSID");
            this.lbl_SSID.Name = "lbl_SSID";
            // 
            // txBox_SSID
            // 
            this.txBox_SSID.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txBox_SSID, "txBox_SSID");
            this.txBox_SSID.Name = "txBox_SSID";
            this.txBox_SSID.ReadOnly = true;
            // 
            // lbl_Stat
            // 
            resources.ApplyResources(this.lbl_Stat, "lbl_Stat");
            this.lbl_Stat.Name = "lbl_Stat";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Disconnect, "btn_Disconnect");
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // lbl_Status
            // 
            resources.ApplyResources(this.lbl_Status, "lbl_Status");
            this.lbl_Status.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Status.Name = "lbl_Status";
            // 
            // txBox_Password
            // 
            resources.ApplyResources(this.txBox_Password, "txBox_Password");
            this.txBox_Password.Name = "txBox_Password";
            // 
            // lbl_Password
            // 
            resources.ApplyResources(this.lbl_Password, "lbl_Password");
            this.lbl_Password.Name = "lbl_Password";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Connect, "btn_Connect");
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // lbl_AP
            // 
            resources.ApplyResources(this.lbl_AP, "lbl_AP");
            this.lbl_AP.Name = "lbl_AP";
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
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Label lbl_Stat;
        private System.Windows.Forms.TextBox txBox_SSID;
        private System.Windows.Forms.Label lbl_SSID;
        private System.Windows.Forms.Label lbl_AP;
    }
}