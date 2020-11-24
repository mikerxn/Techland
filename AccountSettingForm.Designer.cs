namespace Tech
{
    partial class AccountSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonSavePrevillages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Double Click To Edit The Previllages Of The User";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "FILE",
            "CREATE",
            "ALTER",
            "INDEX",
            "DROP",
            "CREATE TEMPORARY TABLES",
            "SHOW VIEW",
            "CREATE ROUTINE",
            "ALTER ROUTINE",
            "EXECUTE",
            "CREATE VIEW",
            "EVENT",
            "TRIGGER",
            "GRANT",
            "SUPER",
            "PROCESS",
            "RELOAD",
            "SHUTDOWN",
            "SHOW DATABASES",
            "LOCK TABLES",
            "REFERENCES",
            "REPLICATION CLIENT",
            "REPLICATION SLAVE",
            "CREATE USER"});
            this.checkedListBox1.Location = new System.Drawing.Point(36, 92);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(303, 424);
            this.checkedListBox1.TabIndex = 1;
            // 
            // buttonSavePrevillages
            // 
            this.buttonSavePrevillages.Location = new System.Drawing.Point(264, 580);
            this.buttonSavePrevillages.Name = "buttonSavePrevillages";
            this.buttonSavePrevillages.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePrevillages.TabIndex = 2;
            this.buttonSavePrevillages.Text = "SAVE";
            this.buttonSavePrevillages.UseVisualStyleBackColor = true;
            // 
            // AccountSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.buttonSavePrevillages);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AccountSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonSavePrevillages;
    }
}