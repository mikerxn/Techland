namespace Tech
{
    partial class Open_OptionControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.FromShapefile = new System.Windows.Forms.Button();
            this.fromGeoJSON = new System.Windows.Forms.Button();
            this.fromOther = new System.Windows.Forms.Button();
            this.FromCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Open Files To Show In The Work Space";
            // 
            // FromShapefile
            // 
            this.FromShapefile.Location = new System.Drawing.Point(99, 222);
            this.FromShapefile.Name = "FromShapefile";
            this.FromShapefile.Size = new System.Drawing.Size(75, 23);
            this.FromShapefile.TabIndex = 8;
            this.FromShapefile.Text = "Shapefile";
            this.FromShapefile.UseVisualStyleBackColor = true;
            this.FromShapefile.Click += new System.EventHandler(this.FromShapefile_Click);
            // 
            // fromGeoJSON
            // 
            this.fromGeoJSON.Location = new System.Drawing.Point(99, 292);
            this.fromGeoJSON.Name = "fromGeoJSON";
            this.fromGeoJSON.Size = new System.Drawing.Size(75, 23);
            this.fromGeoJSON.TabIndex = 7;
            this.fromGeoJSON.Text = "GeoJSON";
            this.fromGeoJSON.UseVisualStyleBackColor = true;
            this.fromGeoJSON.Click += new System.EventHandler(this.fromGeoJSON_Click);
            // 
            // fromOther
            // 
            this.fromOther.Location = new System.Drawing.Point(99, 362);
            this.fromOther.Name = "fromOther";
            this.fromOther.Size = new System.Drawing.Size(75, 23);
            this.fromOther.TabIndex = 6;
            this.fromOther.Text = "Other";
            this.fromOther.UseVisualStyleBackColor = true;
            this.fromOther.Click += new System.EventHandler(this.fromOther_Click);
            // 
            // FromCSV
            // 
            this.FromCSV.Location = new System.Drawing.Point(100, 140);
            this.FromCSV.Name = "FromCSV";
            this.FromCSV.Size = new System.Drawing.Size(75, 23);
            this.FromCSV.TabIndex = 5;
            this.FromCSV.Text = "CSV File";
            this.FromCSV.UseVisualStyleBackColor = true;
            this.FromCSV.Click += new System.EventHandler(this.FromCSV_Click);
            // 
            // Open_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromShapefile);
            this.Controls.Add(this.fromGeoJSON);
            this.Controls.Add(this.fromOther);
            this.Controls.Add(this.FromCSV);
            this.Name = "Open_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FromShapefile;
        private System.Windows.Forms.Button fromGeoJSON;
        private System.Windows.Forms.Button fromOther;
        private System.Windows.Forms.Button FromCSV;
    }
}
