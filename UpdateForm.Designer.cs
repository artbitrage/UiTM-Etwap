namespace Etwap_Detector
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.ReleaseNote = new System.Windows.Forms.RichTextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SaveFileDialogUpdate = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ReleaseNote
            // 
            resources.ApplyResources(this.ReleaseNote, "ReleaseNote");
            this.ReleaseNote.Name = "ReleaseNote";
            // 
            // btn_Update
            // 
            resources.ApplyResources(this.btn_Update, "btn_Update");
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // UpdateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.ReleaseNote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReleaseNote;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogUpdate;
    }
}