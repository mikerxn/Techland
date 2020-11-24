namespace Tech
{
    partial class JoinPlots
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
            this.buttonJoinPlots = new System.Windows.Forms.Button();
            this.QueryPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstInputfilePath = new System.Windows.Forms.TextBox();
            this.BrowserFirstInputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondInputfilePath = new System.Windows.Forms.TextBox();
            this.BrowserSecondInputFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonJoinPlots
            // 
            this.buttonJoinPlots.Location = new System.Drawing.Point(611, 376);
            this.buttonJoinPlots.Name = "buttonJoinPlots";
            this.buttonJoinPlots.Size = new System.Drawing.Size(60, 22);
            this.buttonJoinPlots.TabIndex = 39;
            this.buttonJoinPlots.Text = "Join Plots";
            this.buttonJoinPlots.UseVisualStyleBackColor = true;
            // 
            // QueryPanel
            // 
            this.QueryPanel.BackColor = System.Drawing.Color.White;
            this.QueryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryPanel.Location = new System.Drawing.Point(11, 89);
            this.QueryPanel.Name = "QueryPanel";
            this.QueryPanel.Size = new System.Drawing.Size(660, 281);
            this.QueryPanel.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "First File:";
            // 
            // FirstInputfilePath
            // 
            this.FirstInputfilePath.Location = new System.Drawing.Point(80, 14);
            this.FirstInputfilePath.Name = "FirstInputfilePath";
            this.FirstInputfilePath.Size = new System.Drawing.Size(547, 20);
            this.FirstInputfilePath.TabIndex = 34;
            // 
            // BrowserFirstInputFile
            // 
            this.BrowserFirstInputFile.Location = new System.Drawing.Point(633, 13);
            this.BrowserFirstInputFile.Name = "BrowserFirstInputFile";
            this.BrowserFirstInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserFirstInputFile.TabIndex = 33;
            this.BrowserFirstInputFile.Text = ".....";
            this.BrowserFirstInputFile.UseVisualStyleBackColor = true;
            this.BrowserFirstInputFile.Click += new System.EventHandler(this.BrowserFirstInputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Second File:";
            // 
            // SecondInputfilePath
            // 
            this.SecondInputfilePath.Location = new System.Drawing.Point(80, 53);
            this.SecondInputfilePath.Name = "SecondInputfilePath";
            this.SecondInputfilePath.Size = new System.Drawing.Size(547, 20);
            this.SecondInputfilePath.TabIndex = 41;
            // 
            // BrowserSecondInputFile
            // 
            this.BrowserSecondInputFile.Location = new System.Drawing.Point(633, 52);
            this.BrowserSecondInputFile.Name = "BrowserSecondInputFile";
            this.BrowserSecondInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserSecondInputFile.TabIndex = 40;
            this.BrowserSecondInputFile.Text = ".....";
            this.BrowserSecondInputFile.UseVisualStyleBackColor = true;
            this.BrowserSecondInputFile.Click += new System.EventHandler(this.BrowserSecondInputFile_Click);
            // 
            // JoinPlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondInputfilePath);
            this.Controls.Add(this.BrowserSecondInputFile);
            this.Controls.Add(this.buttonJoinPlots);
            this.Controls.Add(this.QueryPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstInputfilePath);
            this.Controls.Add(this.BrowserFirstInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JoinPlots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Plot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJoinPlots;
        private System.Windows.Forms.Panel QueryPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstInputfilePath;
        private System.Windows.Forms.Button BrowserFirstInputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondInputfilePath;
        private System.Windows.Forms.Button BrowserSecondInputFile;
    }
}