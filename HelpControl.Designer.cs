namespace Tech
{
    partial class HelpControl
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
            this.buttonManual = new System.Windows.Forms.Button();
            this.buttonOnline = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(250, 20);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(75, 24);
            this.buttonManual.TabIndex = 0;
            this.buttonManual.Text = "User Manual";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // buttonOnline
            // 
            this.buttonOnline.Location = new System.Drawing.Point(490, 20);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(75, 24);
            this.buttonOnline.TabIndex = 1;
            this.buttonOnline.Text = "Online Help";
            this.buttonOnline.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(401, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 53);
            this.panel4.TabIndex = 26;
            // 
            // HelpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonOnline);
            this.Controls.Add(this.buttonManual);
            this.Name = "HelpControl";
            this.Size = new System.Drawing.Size(803, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Button buttonOnline;
        private System.Windows.Forms.Panel panel4;
    }
}
