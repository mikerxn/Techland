namespace Tech
{
    partial class Help_OptionControl
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
            this.buttonOnline = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOnline
            // 
            this.buttonOnline.Location = new System.Drawing.Point(400, 100);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(75, 24);
            this.buttonOnline.TabIndex = 3;
            this.buttonOnline.Text = "Online Help";
            this.buttonOnline.UseVisualStyleBackColor = true;
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(200, 100);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(75, 24);
            this.buttonManual.TabIndex = 2;
            this.buttonManual.Text = "User Manual";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // Help_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.buttonOnline);
            this.Controls.Add(this.buttonManual);
            this.Name = "Help_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOnline;
        private System.Windows.Forms.Button buttonManual;
    }
}
