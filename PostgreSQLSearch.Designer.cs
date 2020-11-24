namespace Tech
{
    partial class PostgreSQLSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPostgreSQlDatabaseConnection = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Import = new System.Windows.Forms.TabPage();
            this.Export = new System.Windows.Forms.TabPage();
            this.ImportList = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.CancelExport = new System.Windows.Forms.Button();
            this.AboutExport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.ExportOptions = new System.Windows.Forms.Button();
            this.ExportList = new System.Windows.Forms.GroupBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Import.SuspendLayout();
            this.Export.SuspendLayout();
            this.ImportList.SuspendLayout();
            this.ExportList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnPostgreSQlDatabaseConnection);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PostgreSQL Connection";
            // 
            // btnPostgreSQlDatabaseConnection
            // 
            this.btnPostgreSQlDatabaseConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPostgreSQlDatabaseConnection.Location = new System.Drawing.Point(6, 16);
            this.btnPostgreSQlDatabaseConnection.Name = "btnPostgreSQlDatabaseConnection";
            this.btnPostgreSQlDatabaseConnection.Size = new System.Drawing.Size(348, 23);
            this.btnPostgreSQlDatabaseConnection.TabIndex = 0;
            this.btnPostgreSQlDatabaseConnection.Text = "PostgreSQL Connection";
            this.btnPostgreSQlDatabaseConnection.UseVisualStyleBackColor = true;
            this.btnPostgreSQlDatabaseConnection.Click += new System.EventHandler(this.btnPostgreSQlDatabaseConnection_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Import);
            this.TabControl.Controls.Add(this.Export);
            this.TabControl.Location = new System.Drawing.Point(12, 76);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(360, 383);
            this.TabControl.TabIndex = 2;
            // 
            // Import
            // 
            this.Import.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Import.Controls.Add(this.buttonCancel);
            this.Import.Controls.Add(this.buttonAbout);
            this.Import.Controls.Add(this.btnImport);
            this.Import.Controls.Add(this.buttonOptions);
            this.Import.Controls.Add(this.ImportList);
            this.Import.Location = new System.Drawing.Point(4, 22);
            this.Import.Name = "Import";
            this.Import.Padding = new System.Windows.Forms.Padding(3);
            this.Import.Size = new System.Drawing.Size(352, 357);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Export.Controls.Add(this.CancelExport);
            this.Export.Controls.Add(this.AboutExport);
            this.Export.Controls.Add(this.btnExport);
            this.Export.Controls.Add(this.ExportOptions);
            this.Export.Controls.Add(this.ExportList);
            this.Export.Location = new System.Drawing.Point(4, 22);
            this.Export.Name = "Export";
            this.Export.Padding = new System.Windows.Forms.Padding(3);
            this.Export.Size = new System.Drawing.Size(352, 357);
            this.Export.TabIndex = 1;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // ImportList
            // 
            this.ImportList.Controls.Add(this.buttonImport);
            this.ImportList.Controls.Add(this.panel1);
            this.ImportList.Location = new System.Drawing.Point(7, 7);
            this.ImportList.Name = "ImportList";
            this.ImportList.Size = new System.Drawing.Size(339, 250);
            this.ImportList.TabIndex = 0;
            this.ImportList.TabStop = false;
            this.ImportList.Text = "Import List";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 191);
            this.panel1.TabIndex = 0;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(7, 218);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(326, 23);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(7, 283);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonOptions.TabIndex = 1;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(90, 283);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(179, 283);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(265, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // CancelExport
            // 
            this.CancelExport.Location = new System.Drawing.Point(264, 282);
            this.CancelExport.Name = "CancelExport";
            this.CancelExport.Size = new System.Drawing.Size(75, 23);
            this.CancelExport.TabIndex = 9;
            this.CancelExport.Text = "Cancel";
            this.CancelExport.UseVisualStyleBackColor = true;
            // 
            // AboutExport
            // 
            this.AboutExport.Location = new System.Drawing.Point(178, 282);
            this.AboutExport.Name = "AboutExport";
            this.AboutExport.Size = new System.Drawing.Size(75, 23);
            this.AboutExport.TabIndex = 8;
            this.AboutExport.Text = "About";
            this.AboutExport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(89, 282);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // ExportOptions
            // 
            this.ExportOptions.Location = new System.Drawing.Point(6, 282);
            this.ExportOptions.Name = "ExportOptions";
            this.ExportOptions.Size = new System.Drawing.Size(75, 23);
            this.ExportOptions.TabIndex = 6;
            this.ExportOptions.Text = "Options";
            this.ExportOptions.UseVisualStyleBackColor = true;
            // 
            // ExportList
            // 
            this.ExportList.Controls.Add(this.buttonExport);
            this.ExportList.Controls.Add(this.panel2);
            this.ExportList.Location = new System.Drawing.Point(6, 6);
            this.ExportList.Name = "ExportList";
            this.ExportList.Size = new System.Drawing.Size(339, 250);
            this.ExportList.TabIndex = 5;
            this.ExportList.TabStop = false;
            this.ExportList.Text = "Export List";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(7, 218);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(326, 23);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(7, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 191);
            this.panel2.TabIndex = 0;
            // 
            // PostgreSQLSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 514);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PostgreSQLSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostgreSQL Database Manager";
            this.groupBox1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.Import.ResumeLayout(false);
            this.Export.ResumeLayout(false);
            this.ImportList.ResumeLayout(false);
            this.ExportList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPostgreSQlDatabaseConnection;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Import;
        private System.Windows.Forms.TabPage Export;
        private System.Windows.Forms.GroupBox ImportList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button CancelExport;
        private System.Windows.Forms.Button AboutExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button ExportOptions;
        private System.Windows.Forms.GroupBox ExportList;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel2;
    }
}