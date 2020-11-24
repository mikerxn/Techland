namespace Tech
{
    partial class SettingsControl
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
            this.comboBoxCrs = new System.Windows.Forms.ComboBox();
            this.labelCrs = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboBoxCrs
            // 
            this.comboBoxCrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrs.FormattingEnabled = true;
            this.comboBoxCrs.Location = new System.Drawing.Point(58, 36);
            this.comboBoxCrs.Name = "comboBoxCrs";
            this.comboBoxCrs.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCrs.TabIndex = 32;
            // 
            // labelCrs
            // 
            this.labelCrs.AutoSize = true;
            this.labelCrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrs.ForeColor = System.Drawing.Color.Black;
            this.labelCrs.Location = new System.Drawing.Point(2, 36);
            this.labelCrs.Name = "labelCrs";
            this.labelCrs.Size = new System.Drawing.Size(39, 16);
            this.labelCrs.TabIndex = 31;
            this.labelCrs.Text = "CRS:";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.comboBoxTheme.Location = new System.Drawing.Point(58, 2);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(146, 21);
            this.comboBoxTheme.TabIndex = 30;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheme.ForeColor = System.Drawing.Color.Black;
            this.labelTheme.Location = new System.Drawing.Point(3, 2);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(54, 16);
            this.labelTheme.TabIndex = 29;
            this.labelTheme.Text = "Theme:";
            // 
            // buttonAccount
            // 
            this.buttonAccount.Location = new System.Drawing.Point(300, 2);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(136, 23);
            this.buttonAccount.TabIndex = 33;
            this.buttonAccount.Text = "Account Settings";
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonCustom
            // 
            this.buttonCustom.Location = new System.Drawing.Point(300, 36);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(136, 23);
            this.buttonCustom.TabIndex = 34;
            this.buttonCustom.Text = "Custom Projections";
            this.buttonCustom.UseVisualStyleBackColor = true;
            this.buttonCustom.Click += new System.EventHandler(this.buttonCustom_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(250, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 53);
            this.panel4.TabIndex = 35;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonCustom);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.comboBoxCrs);
            this.Controls.Add(this.labelCrs);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(803, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCrs;
        private System.Windows.Forms.Label labelCrs;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Panel panel4;
    }
}
