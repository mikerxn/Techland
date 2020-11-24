namespace Tech
{
    partial class Account_OptionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_OptionControl));
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernem = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonPrevilages = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicturePanel.BackgroundImage")));
            this.PicturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicturePanel.Location = new System.Drawing.Point(331, 148);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(91, 93);
            this.PicturePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsernem
            // 
            this.txtUsernem.Location = new System.Drawing.Point(317, 288);
            this.txtUsernem.Name = "txtUsernem";
            this.txtUsernem.Size = new System.Drawing.Size(124, 20);
            this.txtUsernem.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(317, 359);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(124, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // buttonPrevilages
            // 
            this.buttonPrevilages.Location = new System.Drawing.Point(534, 451);
            this.buttonPrevilages.Name = "buttonPrevilages";
            this.buttonPrevilages.Size = new System.Drawing.Size(120, 23);
            this.buttonPrevilages.TabIndex = 5;
            this.buttonPrevilages.Text = "EDIT PREVILLAGES";
            this.buttonPrevilages.UseVisualStyleBackColor = true;
            this.buttonPrevilages.Click += new System.EventHandler(this.buttonPrevilages_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Details And Previllage Settings";
            // 
            // Account_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPrevilages);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsernem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicturePanel);
            this.Name = "Account_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernem;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonPrevilages;
        private System.Windows.Forms.Label label3;
    }
}
