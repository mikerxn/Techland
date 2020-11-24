namespace Tech
{
    partial class New_OptionControl
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
            this.newLease = new System.Windows.Forms.Button();
            this.newMailo = new System.Windows.Forms.Button();
            this.newCustomary = new System.Windows.Forms.Button();
            this.newFree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newLease
            // 
            this.newLease.Location = new System.Drawing.Point(100, 140);
            this.newLease.Name = "newLease";
            this.newLease.Size = new System.Drawing.Size(75, 23);
            this.newLease.TabIndex = 0;
            this.newLease.Text = "Lease Hold";
            this.newLease.UseVisualStyleBackColor = true;
            this.newLease.Click += new System.EventHandler(this.newLease_Click);
            // 
            // newMailo
            // 
            this.newMailo.Location = new System.Drawing.Point(100, 350);
            this.newMailo.Name = "newMailo";
            this.newMailo.Size = new System.Drawing.Size(75, 23);
            this.newMailo.TabIndex = 1;
            this.newMailo.Text = "Mailo";
            this.newMailo.UseVisualStyleBackColor = true;
            this.newMailo.Click += new System.EventHandler(this.newMailo_Click);
            // 
            // newCustomary
            // 
            this.newCustomary.Location = new System.Drawing.Point(100, 280);
            this.newCustomary.Name = "newCustomary";
            this.newCustomary.Size = new System.Drawing.Size(75, 23);
            this.newCustomary.TabIndex = 2;
            this.newCustomary.Text = "Customary";
            this.newCustomary.UseVisualStyleBackColor = true;
            this.newCustomary.Click += new System.EventHandler(this.newCustomary_Click);
            // 
            // newFree
            // 
            this.newFree.Location = new System.Drawing.Point(100, 210);
            this.newFree.Name = "newFree";
            this.newFree.Size = new System.Drawing.Size(75, 23);
            this.newFree.TabIndex = 3;
            this.newFree.Text = "Free Hold";
            this.newFree.UseVisualStyleBackColor = true;
            this.newFree.Click += new System.EventHandler(this.newFree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click To Register A New Land Owner";
            // 
            // New_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newFree);
            this.Controls.Add(this.newCustomary);
            this.Controls.Add(this.newMailo);
            this.Controls.Add(this.newLease);
            this.Name = "New_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newLease;
        private System.Windows.Forms.Button newMailo;
        private System.Windows.Forms.Button newCustomary;
        private System.Windows.Forms.Button newFree;
        private System.Windows.Forms.Label label1;
    }
}
