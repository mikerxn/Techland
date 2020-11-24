namespace Tech
{
    partial class NewPlot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManualCordinatesPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowserInputFileToUse = new System.Windows.Forms.Button();
            this.InputFileToUsePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputfilePath = new System.Windows.Forms.TextBox();
            this.BrowserInputFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 1);
            this.panel1.TabIndex = 39;
            // 
            // ManualCordinatesPanel
            // 
            this.ManualCordinatesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualCordinatesPanel.Location = new System.Drawing.Point(13, 136);
            this.ManualCordinatesPanel.Name = "ManualCordinatesPanel";
            this.ManualCordinatesPanel.Size = new System.Drawing.Size(657, 264);
            this.ManualCordinatesPanel.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Manually Fill In The Co-Ordinates To Use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(666, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // BrowserInputFileToUse
            // 
            this.BrowserInputFileToUse.Location = new System.Drawing.Point(629, 61);
            this.BrowserInputFileToUse.Name = "BrowserInputFileToUse";
            this.BrowserInputFileToUse.Size = new System.Drawing.Size(40, 22);
            this.BrowserInputFileToUse.TabIndex = 35;
            this.BrowserInputFileToUse.Text = ".....";
            this.BrowserInputFileToUse.UseVisualStyleBackColor = true;
            this.BrowserInputFileToUse.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputFileToUsePath
            // 
            this.InputFileToUsePath.Location = new System.Drawing.Point(145, 63);
            this.InputFileToUsePath.Name = "InputFileToUsePath";
            this.InputFileToUsePath.Size = new System.Drawing.Size(478, 20);
            this.InputFileToUsePath.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Import A CSV File To Use:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Input File:";
            // 
            // InputfilePath
            // 
            this.InputfilePath.Location = new System.Drawing.Point(68, 12);
            this.InputfilePath.Name = "InputfilePath";
            this.InputfilePath.Size = new System.Drawing.Size(555, 20);
            this.InputfilePath.TabIndex = 31;
            // 
            // BrowserInputFile
            // 
            this.BrowserInputFile.Location = new System.Drawing.Point(629, 11);
            this.BrowserInputFile.Name = "BrowserInputFile";
            this.BrowserInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserInputFile.TabIndex = 30;
            this.BrowserInputFile.Text = ".....";
            this.BrowserInputFile.UseVisualStyleBackColor = true;
            this.BrowserInputFile.Click += new System.EventHandler(this.BrowserInputFile_Click);
            // 
            // NewPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManualCordinatesPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrowserInputFileToUse);
            this.Controls.Add(this.InputFileToUsePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputfilePath);
            this.Controls.Add(this.BrowserInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Plot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ManualCordinatesPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowserInputFileToUse;
        private System.Windows.Forms.TextBox InputFileToUsePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputfilePath;
        private System.Windows.Forms.Button BrowserInputFile;
    }
}