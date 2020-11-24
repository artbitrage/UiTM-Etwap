namespace Etwap_Detector
{
    partial class ConsoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleForm));
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_CMD = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ConsoleBox, "ConsoleBox");
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Name = "ConsoleBox";
            // 
            // btn_Export
            // 
            resources.ApplyResources(this.btn_Export, "btn_Export");
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // btn_CMD
            // 
            resources.ApplyResources(this.btn_CMD, "btn_CMD");
            this.btn_CMD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CMD.Name = "btn_CMD";
            this.btn_CMD.UseVisualStyleBackColor = true;
            this.btn_CMD.Click += new System.EventHandler(this.Btn_CMD_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            // 
            // ConsoleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_CMD);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.ConsoleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleForm";
            this.Load += new System.EventHandler(this.ConsoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_CMD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}