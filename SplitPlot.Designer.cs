namespace Tech
{
    partial class SplitPlot
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
            this.buttonLoadSplitData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QueryPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InputfilePath = new System.Windows.Forms.TextBox();
            this.BrowserInputFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadSplitData
            // 
            this.buttonLoadSplitData.Location = new System.Drawing.Point(612, 382);
            this.buttonLoadSplitData.Name = "buttonLoadSplitData";
            this.buttonLoadSplitData.Size = new System.Drawing.Size(60, 22);
            this.buttonLoadSplitData.TabIndex = 28;
            this.buttonLoadSplitData.Text = "Load";
            this.buttonLoadSplitData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search For A Plot To Split";
            // 
            // QueryPanel
            // 
            this.QueryPanel.BackColor = System.Drawing.Color.White;
            this.QueryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryPanel.Location = new System.Drawing.Point(12, 54);
            this.QueryPanel.Name = "QueryPanel";
            this.QueryPanel.Size = new System.Drawing.Size(660, 322);
            this.QueryPanel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Input File:";
            // 
            // InputfilePath
            // 
            this.InputfilePath.Location = new System.Drawing.Point(79, 7);
            this.InputfilePath.Name = "InputfilePath";
            this.InputfilePath.Size = new System.Drawing.Size(547, 20);
            this.InputfilePath.TabIndex = 24;
            // 
            // BrowserInputFile
            // 
            this.BrowserInputFile.Location = new System.Drawing.Point(632, 6);
            this.BrowserInputFile.Name = "BrowserInputFile";
            this.BrowserInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserInputFile.TabIndex = 23;
            this.BrowserInputFile.Text = ".....";
            this.BrowserInputFile.UseVisualStyleBackColor = true;
            this.BrowserInputFile.Click += new System.EventHandler(this.BrowserInputFile_Click);
            // 
            // SplitPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.buttonLoadSplitData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QueryPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputfilePath);
            this.Controls.Add(this.BrowserInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SplitPlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split Plots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadSplitData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel QueryPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputfilePath;
        private System.Windows.Forms.Button BrowserInputFile;
    }
}