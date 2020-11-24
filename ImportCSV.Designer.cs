namespace Tech
{
    partial class ImportCSV
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
            this.CSVPath = new System.Windows.Forms.TextBox();
            this.BrowserCSV = new System.Windows.Forms.Button();
            this.LoadCSVFile = new System.Windows.Forms.Button();
            this.dataGridViewCSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // CSVPath
            // 
            this.CSVPath.Location = new System.Drawing.Point(13, 15);
            this.CSVPath.Name = "CSVPath";
            this.CSVPath.Size = new System.Drawing.Size(485, 20);
            this.CSVPath.TabIndex = 7;
            // 
            // BrowserCSV
            // 
            this.BrowserCSV.Location = new System.Drawing.Point(516, 11);
            this.BrowserCSV.Name = "BrowserCSV";
            this.BrowserCSV.Size = new System.Drawing.Size(70, 24);
            this.BrowserCSV.TabIndex = 5;
            this.BrowserCSV.Text = "Browse";
            this.BrowserCSV.UseVisualStyleBackColor = true;
            this.BrowserCSV.Click += new System.EventHandler(this.BrowserCSV_Click);
            // 
            // LoadCSVFile
            // 
            this.LoadCSVFile.Location = new System.Drawing.Point(597, 11);
            this.LoadCSVFile.Name = "LoadCSVFile";
            this.LoadCSVFile.Size = new System.Drawing.Size(70, 24);
            this.LoadCSVFile.TabIndex = 4;
            this.LoadCSVFile.Text = "Load";
            this.LoadCSVFile.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCSV
            // 
            this.dataGridViewCSV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCSV.GridColor = System.Drawing.Color.White;
            this.dataGridViewCSV.Location = new System.Drawing.Point(13, 41);
            this.dataGridViewCSV.Name = "dataGridViewCSV";
            this.dataGridViewCSV.Size = new System.Drawing.Size(659, 359);
            this.dataGridViewCSV.TabIndex = 6;
            // 
            // ImportCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.CSVPath);
            this.Controls.Add(this.dataGridViewCSV);
            this.Controls.Add(this.BrowserCSV);
            this.Controls.Add(this.LoadCSVFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import A CSV File";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CSVPath;
        private System.Windows.Forms.Button BrowserCSV;
        private System.Windows.Forms.Button LoadCSVFile;
        private System.Windows.Forms.DataGridView dataGridViewCSV;
    }
}