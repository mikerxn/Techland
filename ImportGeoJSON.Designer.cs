namespace Tech
{
    partial class ImportGeoJSON
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
            this.PanelGeoJSON = new System.Windows.Forms.Panel();
            this.GeoJSONPath = new System.Windows.Forms.TextBox();
            this.BrowserGeoJSON = new System.Windows.Forms.Button();
            this.LoadGeoJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGeoJSON
            // 
            this.PanelGeoJSON.BackColor = System.Drawing.Color.White;
            this.PanelGeoJSON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGeoJSON.Location = new System.Drawing.Point(12, 49);
            this.PanelGeoJSON.Name = "PanelGeoJSON";
            this.PanelGeoJSON.Size = new System.Drawing.Size(660, 352);
            this.PanelGeoJSON.TabIndex = 14;
            // 
            // GeoJSONPath
            // 
            this.GeoJSONPath.Location = new System.Drawing.Point(12, 14);
            this.GeoJSONPath.Name = "GeoJSONPath";
            this.GeoJSONPath.Size = new System.Drawing.Size(485, 20);
            this.GeoJSONPath.TabIndex = 13;
            // 
            // BrowserGeoJSON
            // 
            this.BrowserGeoJSON.Location = new System.Drawing.Point(515, 10);
            this.BrowserGeoJSON.Name = "BrowserGeoJSON";
            this.BrowserGeoJSON.Size = new System.Drawing.Size(70, 24);
            this.BrowserGeoJSON.TabIndex = 12;
            this.BrowserGeoJSON.Text = "Browse";
            this.BrowserGeoJSON.UseVisualStyleBackColor = true;
            this.BrowserGeoJSON.Click += new System.EventHandler(this.BrowserGeoJSON_Click);
            // 
            // LoadGeoJSON
            // 
            this.LoadGeoJSON.Location = new System.Drawing.Point(596, 10);
            this.LoadGeoJSON.Name = "LoadGeoJSON";
            this.LoadGeoJSON.Size = new System.Drawing.Size(70, 24);
            this.LoadGeoJSON.TabIndex = 11;
            this.LoadGeoJSON.Text = "Load";
            this.LoadGeoJSON.UseVisualStyleBackColor = true;
            // 
            // ImportGeoJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.PanelGeoJSON);
            this.Controls.Add(this.GeoJSONPath);
            this.Controls.Add(this.BrowserGeoJSON);
            this.Controls.Add(this.LoadGeoJSON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportGeoJSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import A GeoJSON File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGeoJSON;
        private System.Windows.Forms.TextBox GeoJSONPath;
        private System.Windows.Forms.Button BrowserGeoJSON;
        private System.Windows.Forms.Button LoadGeoJSON;
    }
}