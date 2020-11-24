namespace Tech
{
    partial class SaveAs_OptionControl
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
            this.PanelOtherFileResults = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnOutputOtherFormats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowserInputFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelOtherFileResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOtherFileResults
            // 
            this.PanelOtherFileResults.BackColor = System.Drawing.Color.White;
            this.PanelOtherFileResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOtherFileResults.Controls.Add(this.richTextBox);
            this.PanelOtherFileResults.Location = new System.Drawing.Point(62, 67);
            this.PanelOtherFileResults.Name = "PanelOtherFileResults";
            this.PanelOtherFileResults.Size = new System.Drawing.Size(562, 26);
            this.PanelOtherFileResults.TabIndex = 30;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(560, 24);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // btnOutputOtherFormats
            // 
            this.btnOutputOtherFormats.Location = new System.Drawing.Point(602, 405);
            this.btnOutputOtherFormats.Name = "btnOutputOtherFormats";
            this.btnOutputOtherFormats.Size = new System.Drawing.Size(62, 22);
            this.btnOutputOtherFormats.TabIndex = 29;
            this.btnOutputOtherFormats.Text = "SAVE AS";
            this.btnOutputOtherFormats.UseVisualStyleBackColor = true;
            this.btnOutputOtherFormats.Click += new System.EventHandler(this.btnOutputOtherFormats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Input File:";
            // 
            // BrowserInputFile
            // 
            this.BrowserInputFile.Location = new System.Drawing.Point(630, 68);
            this.BrowserInputFile.Name = "BrowserInputFile";
            this.BrowserInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserInputFile.TabIndex = 27;
            this.BrowserInputFile.Text = ".....";
            this.BrowserInputFile.UseVisualStyleBackColor = true;
            this.BrowserInputFile.Click += new System.EventHandler(this.BrowserInputFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "CSV Files|*.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Browse For A File To Convert Its Format";
            // 
            // SaveAs_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelOtherFileResults);
            this.Controls.Add(this.btnOutputOtherFormats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowserInputFile);
            this.Name = "SaveAs_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.PanelOtherFileResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelOtherFileResults;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnOutputOtherFormats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowserInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label2;
    }
}
