namespace Tech
{
    partial class Options_OptionControl
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
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateDatabase = new System.Windows.Forms.CheckBox();
            this.StartupVersion = new System.Windows.Forms.CheckBox();
            this.DefaultSettings = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interface Translation:";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "American English",
            "British English"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(195, 26);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(211, 21);
            this.comboBoxLanguage.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxLanguage);
            this.groupBox1.Location = new System.Drawing.Point(20, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Locale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DefaultSettings);
            this.groupBox2.Controls.Add(this.StartupVersion);
            this.groupBox2.Controls.Add(this.UpdateDatabase);
            this.groupBox2.Location = new System.Drawing.Point(20, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Updates And Startup";
            // 
            // UpdateDatabase
            // 
            this.UpdateDatabase.AutoSize = true;
            this.UpdateDatabase.Location = new System.Drawing.Point(24, 33);
            this.UpdateDatabase.Name = "UpdateDatabase";
            this.UpdateDatabase.Size = new System.Drawing.Size(290, 17);
            this.UpdateDatabase.TabIndex = 0;
            this.UpdateDatabase.Text = "Automatically Update Database When Data Is Changed";
            this.UpdateDatabase.UseVisualStyleBackColor = true;
            // 
            // StartupVersion
            // 
            this.StartupVersion.AutoSize = true;
            this.StartupVersion.Location = new System.Drawing.Point(24, 72);
            this.StartupVersion.Name = "StartupVersion";
            this.StartupVersion.Size = new System.Drawing.Size(171, 17);
            this.StartupVersion.TabIndex = 1;
            this.StartupVersion.Text = "Check The Version On Startup";
            this.StartupVersion.UseVisualStyleBackColor = true;
            // 
            // DefaultSettings
            // 
            this.DefaultSettings.AutoSize = true;
            this.DefaultSettings.Location = new System.Drawing.Point(24, 109);
            this.DefaultSettings.Name = "DefaultSettings";
            this.DefaultSettings.Size = new System.Drawing.Size(123, 17);
            this.DefaultSettings.TabIndex = 4;
            this.DefaultSettings.Text = "Use Default Settings";
            this.DefaultSettings.UseVisualStyleBackColor = true;
            // 
            // Options_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Options_OptionControl";
            this.Size = new System.Drawing.Size(675, 494);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox DefaultSettings;
        private System.Windows.Forms.CheckBox StartupVersion;
        private System.Windows.Forms.CheckBox UpdateDatabase;
    }
}
