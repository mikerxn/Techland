namespace Tech
{
    partial class ConvertImage
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
            this.PanelOtherFileResults = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowserInputFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanelOtherFileResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOtherFileResults
            // 
            this.PanelOtherFileResults.BackColor = System.Drawing.Color.White;
            this.PanelOtherFileResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOtherFileResults.Controls.Add(this.richTextBox);
            this.PanelOtherFileResults.Location = new System.Drawing.Point(67, 25);
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
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(607, 363);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(62, 22);
            this.btnImage.TabIndex = 29;
            this.btnImage.Text = "SAVE";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Input File:";
            // 
            // BrowserInputFile
            // 
            this.BrowserInputFile.Location = new System.Drawing.Point(635, 26);
            this.BrowserInputFile.Name = "BrowserInputFile";
            this.BrowserInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserInputFile.TabIndex = 27;
            this.BrowserInputFile.Text = ".....";
            this.BrowserInputFile.UseVisualStyleBackColor = true;
            this.BrowserInputFile.Click += new System.EventHandler(this.BrowserInputFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image Files|*.jpg";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ConvertImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.PanelOtherFileResults);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowserInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConvertImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert To Image";
            this.PanelOtherFileResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelOtherFileResults;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowserInputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}