namespace Tech
{
    partial class ImportShapefile
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
            this.PanelShapefile = new System.Windows.Forms.Panel();
            this.ShapefilePath = new System.Windows.Forms.TextBox();
            this.BrowserShapefile = new System.Windows.Forms.Button();
            this.LoadShapefile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelShapefile
            // 
            this.PanelShapefile.BackColor = System.Drawing.Color.White;
            this.PanelShapefile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelShapefile.Location = new System.Drawing.Point(12, 49);
            this.PanelShapefile.Name = "PanelShapefile";
            this.PanelShapefile.Size = new System.Drawing.Size(660, 352);
            this.PanelShapefile.TabIndex = 11;
            // 
            // ShapefilePath
            // 
            this.ShapefilePath.Location = new System.Drawing.Point(12, 14);
            this.ShapefilePath.Name = "ShapefilePath";
            this.ShapefilePath.Size = new System.Drawing.Size(485, 20);
            this.ShapefilePath.TabIndex = 10;
            // 
            // BrowserShapefile
            // 
            this.BrowserShapefile.Location = new System.Drawing.Point(515, 10);
            this.BrowserShapefile.Name = "BrowserShapefile";
            this.BrowserShapefile.Size = new System.Drawing.Size(70, 24);
            this.BrowserShapefile.TabIndex = 9;
            this.BrowserShapefile.Text = "Browse";
            this.BrowserShapefile.UseVisualStyleBackColor = true;
            this.BrowserShapefile.Click += new System.EventHandler(this.BrowserShapefile_Click);
            // 
            // LoadShapefile
            // 
            this.LoadShapefile.Location = new System.Drawing.Point(596, 10);
            this.LoadShapefile.Name = "LoadShapefile";
            this.LoadShapefile.Size = new System.Drawing.Size(70, 24);
            this.LoadShapefile.TabIndex = 8;
            this.LoadShapefile.Text = "Load";
            this.LoadShapefile.UseVisualStyleBackColor = true;
            // 
            // ImportShapefile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.PanelShapefile);
            this.Controls.Add(this.ShapefilePath);
            this.Controls.Add(this.BrowserShapefile);
            this.Controls.Add(this.LoadShapefile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportShapefile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import A Shapefile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelShapefile;
        private System.Windows.Forms.TextBox ShapefilePath;
        private System.Windows.Forms.Button BrowserShapefile;
        private System.Windows.Forms.Button LoadShapefile;
    }
}