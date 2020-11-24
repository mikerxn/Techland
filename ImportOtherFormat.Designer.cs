namespace Tech
{
    partial class ImportOtherFormat
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
            this.PanelOtherFileFormats = new System.Windows.Forms.Panel();
            this.OtherFormatsPath = new System.Windows.Forms.TextBox();
            this.BrowserOtherFormats = new System.Windows.Forms.Button();
            this.LoadOtherFormats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelOtherFileFormats
            // 
            this.PanelOtherFileFormats.BackColor = System.Drawing.Color.White;
            this.PanelOtherFileFormats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOtherFileFormats.Location = new System.Drawing.Point(12, 49);
            this.PanelOtherFileFormats.Name = "PanelOtherFileFormats";
            this.PanelOtherFileFormats.Size = new System.Drawing.Size(660, 352);
            this.PanelOtherFileFormats.TabIndex = 14;
            this.PanelOtherFileFormats.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOtherFileFormats_Paint);
            // 
            // OtherFormatsPath
            // 
            this.OtherFormatsPath.Location = new System.Drawing.Point(12, 14);
            this.OtherFormatsPath.Name = "OtherFormatsPath";
            this.OtherFormatsPath.Size = new System.Drawing.Size(485, 20);
            this.OtherFormatsPath.TabIndex = 13;
            this.OtherFormatsPath.TextChanged += new System.EventHandler(this.OtherFormatsPath_TextChanged);
            // 
            // BrowserOtherFormats
            // 
            this.BrowserOtherFormats.Location = new System.Drawing.Point(515, 10);
            this.BrowserOtherFormats.Name = "BrowserOtherFormats";
            this.BrowserOtherFormats.Size = new System.Drawing.Size(70, 24);
            this.BrowserOtherFormats.TabIndex = 12;
            this.BrowserOtherFormats.Text = "Browse";
            this.BrowserOtherFormats.UseVisualStyleBackColor = true;
            this.BrowserOtherFormats.Click += new System.EventHandler(this.BrowserOtherFormats_Click);
            // 
            // LoadOtherFormats
            // 
            this.LoadOtherFormats.Location = new System.Drawing.Point(596, 10);
            this.LoadOtherFormats.Name = "LoadOtherFormats";
            this.LoadOtherFormats.Size = new System.Drawing.Size(70, 24);
            this.LoadOtherFormats.TabIndex = 11;
            this.LoadOtherFormats.Text = "Load";
            this.LoadOtherFormats.UseVisualStyleBackColor = true;
            this.LoadOtherFormats.Click += new System.EventHandler(this.LoadOtherFormats_Click);
            // 
            // ImportOtherFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.PanelOtherFileFormats);
            this.Controls.Add(this.OtherFormatsPath);
            this.Controls.Add(this.BrowserOtherFormats);
            this.Controls.Add(this.LoadOtherFormats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportOtherFormat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import A File of Another Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelOtherFileFormats;
        private System.Windows.Forms.TextBox OtherFormatsPath;
        private System.Windows.Forms.Button BrowserOtherFormats;
        private System.Windows.Forms.Button LoadOtherFormats;
    }
}