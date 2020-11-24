namespace Tech
{
    partial class Import_OptionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelOtherFileFormats = new System.Windows.Forms.Panel();
            this.OtherFormatsPath = new System.Windows.Forms.TextBox();
            this.BrowserOtherFormats = new System.Windows.Forms.Button();
            this.LoadOtherFormats = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelOtherFileFormats
            // 
            this.PanelOtherFileFormats.BackColor = System.Drawing.Color.White;
            this.PanelOtherFileFormats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOtherFileFormats.Location = new System.Drawing.Point(7, 91);
            this.PanelOtherFileFormats.Name = "PanelOtherFileFormats";
            this.PanelOtherFileFormats.Size = new System.Drawing.Size(660, 352);
            this.PanelOtherFileFormats.TabIndex = 18;
            // 
            // OtherFormatsPath
            // 
            this.OtherFormatsPath.Location = new System.Drawing.Point(7, 56);
            this.OtherFormatsPath.Name = "OtherFormatsPath";
            this.OtherFormatsPath.Size = new System.Drawing.Size(485, 20);
            this.OtherFormatsPath.TabIndex = 17;
            // 
            // BrowserOtherFormats
            // 
            this.BrowserOtherFormats.Location = new System.Drawing.Point(510, 52);
            this.BrowserOtherFormats.Name = "BrowserOtherFormats";
            this.BrowserOtherFormats.Size = new System.Drawing.Size(70, 24);
            this.BrowserOtherFormats.TabIndex = 16;
            this.BrowserOtherFormats.Text = "Browse";
            this.BrowserOtherFormats.UseVisualStyleBackColor = true;
            this.BrowserOtherFormats.Click += new System.EventHandler(this.BrowserOtherFormats_Click);
            // 
            // LoadOtherFormats
            // 
            this.LoadOtherFormats.Location = new System.Drawing.Point(591, 52);
            this.LoadOtherFormats.Name = "LoadOtherFormats";
            this.LoadOtherFormats.Size = new System.Drawing.Size(70, 24);
            this.LoadOtherFormats.TabIndex = 15;
            this.LoadOtherFormats.Text = "Load";
            this.LoadOtherFormats.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Import A File";
            // 
            // Import_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelOtherFileFormats);
            this.Controls.Add(this.OtherFormatsPath);
            this.Controls.Add(this.BrowserOtherFormats);
            this.Controls.Add(this.LoadOtherFormats);
            this.Name = "Import_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelOtherFileFormats;
        private System.Windows.Forms.TextBox OtherFormatsPath;
        private System.Windows.Forms.Button BrowserOtherFormats;
        private System.Windows.Forms.Button LoadOtherFormats;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
    }
}
