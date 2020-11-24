﻿namespace Tech
{
    partial class ConvertOther
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
            this.btnOutputOtherFormats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowserInputFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.PanelOtherFileResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOtherFileResults
            // 
            this.PanelOtherFileResults.BackColor = System.Drawing.Color.White;
            this.PanelOtherFileResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOtherFileResults.Controls.Add(this.richTextBox);
            this.PanelOtherFileResults.Location = new System.Drawing.Point(70, 39);
            this.PanelOtherFileResults.Name = "PanelOtherFileResults";
            this.PanelOtherFileResults.Size = new System.Drawing.Size(562, 26);
            this.PanelOtherFileResults.TabIndex = 26;
            // 
            // btnOutputOtherFormats
            // 
            this.btnOutputOtherFormats.Location = new System.Drawing.Point(610, 377);
            this.btnOutputOtherFormats.Name = "btnOutputOtherFormats";
            this.btnOutputOtherFormats.Size = new System.Drawing.Size(62, 22);
            this.btnOutputOtherFormats.TabIndex = 23;
            this.btnOutputOtherFormats.Text = "SAVE AS";
            this.btnOutputOtherFormats.UseVisualStyleBackColor = true;
            this.btnOutputOtherFormats.Click += new System.EventHandler(this.btnOutputOtherFormats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Input File:";
            // 
            // BrowserInputFile
            // 
            this.BrowserInputFile.Location = new System.Drawing.Point(638, 40);
            this.BrowserInputFile.Name = "BrowserInputFile";
            this.BrowserInputFile.Size = new System.Drawing.Size(40, 22);
            this.BrowserInputFile.TabIndex = 20;
            this.BrowserInputFile.Text = ".....";
            this.BrowserInputFile.UseVisualStyleBackColor = true;
            this.BrowserInputFile.Click += new System.EventHandler(this.BrowserInputFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "CSV Files|*.csv";
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
            // ConvertOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.PanelOtherFileResults);
            this.Controls.Add(this.btnOutputOtherFormats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowserInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConvertOther";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert To Other Format";
            this.PanelOtherFileResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelOtherFileResults;
        private System.Windows.Forms.Button btnOutputOtherFormats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowserInputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}