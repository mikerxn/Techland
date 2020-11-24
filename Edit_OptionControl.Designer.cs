namespace Tech
{
    partial class Edit_OptionControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.editFree = new System.Windows.Forms.Button();
            this.editCustomary = new System.Windows.Forms.Button();
            this.editMailo = new System.Windows.Forms.Button();
            this.editLease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click To Edit An Existing Land Owner";
            // 
            // editFree
            // 
            this.editFree.Location = new System.Drawing.Point(100, 210);
            this.editFree.Name = "editFree";
            this.editFree.Size = new System.Drawing.Size(75, 23);
            this.editFree.TabIndex = 8;
            this.editFree.Text = "Free Hold";
            this.editFree.UseVisualStyleBackColor = true;
            this.editFree.Click += new System.EventHandler(this.editFree_Click);
            // 
            // editCustomary
            // 
            this.editCustomary.Location = new System.Drawing.Point(100, 280);
            this.editCustomary.Name = "editCustomary";
            this.editCustomary.Size = new System.Drawing.Size(75, 23);
            this.editCustomary.TabIndex = 7;
            this.editCustomary.Text = "Customary";
            this.editCustomary.UseVisualStyleBackColor = true;
            this.editCustomary.Click += new System.EventHandler(this.editCustomary_Click);
            // 
            // editMailo
            // 
            this.editMailo.Location = new System.Drawing.Point(100, 350);
            this.editMailo.Name = "editMailo";
            this.editMailo.Size = new System.Drawing.Size(75, 23);
            this.editMailo.TabIndex = 6;
            this.editMailo.Text = "Mailo";
            this.editMailo.UseVisualStyleBackColor = true;
            this.editMailo.Click += new System.EventHandler(this.editMailo_Click);
            // 
            // editLease
            // 
            this.editLease.Location = new System.Drawing.Point(100, 140);
            this.editLease.Name = "editLease";
            this.editLease.Size = new System.Drawing.Size(75, 23);
            this.editLease.TabIndex = 5;
            this.editLease.Text = "Lease Hold";
            this.editLease.UseVisualStyleBackColor = true;
            this.editLease.Click += new System.EventHandler(this.editLease_Click);
            // 
            // Edit_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editFree);
            this.Controls.Add(this.editCustomary);
            this.Controls.Add(this.editMailo);
            this.Controls.Add(this.editLease);
            this.Name = "Edit_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editFree;
        private System.Windows.Forms.Button editCustomary;
        private System.Windows.Forms.Button editMailo;
        private System.Windows.Forms.Button editLease;
    }
}
