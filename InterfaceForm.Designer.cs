
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
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.pnl_Btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_AP
            // 
            this.listView_AP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAccessPoint,
            this.clmSignal});
            this.listView_AP.HideSelection = false;
            resources.ApplyResources(this.listView_AP, "listView_AP");
            this.listView_AP.Name = "listView_AP";
            this.listView_AP.UseCompatibleStateImageBehavior = false;
            this.listView_AP.View = System.Windows.Forms.View.Details;
            // 
            // clmAccessPoint
            // 
            resources.ApplyResources(this.clmAccessPoint, "clmAccessPoint");
            // 
            // clmSignal
            // 
            resources.ApplyResources(this.clmSignal, "clmSignal");
            // 
            // pnl_Btns
            // 
            this.pnl_Btns.Controls.Add(this.btn_Connect);
            resources.ApplyResources(this.pnl_Btns, "pnl_Btns");
            this.pnl_Btns.Name = "pnl_Btns";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Connect, "btn_Connect");
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_AP;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.ColumnHeader clmAccessPoint;
        private System.Windows.Forms.ColumnHeader clmSignal;
        private System.Windows.Forms.Button btn_Connect;
    }
}