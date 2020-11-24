namespace Tech
{
    partial class OtherConnectionDetails
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
            this.Connect = new System.Windows.Forms.Button();
            this.PostgreSQL = new System.Windows.Forms.GroupBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.PostgreSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 215);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(275, 23);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "OK";
            this.Connect.UseVisualStyleBackColor = true;
            // 
            // PostgreSQL
            // 
            this.PostgreSQL.Controls.Add(this.txtport);
            this.PostgreSQL.Controls.Add(this.txthost);
            this.PostgreSQL.Controls.Add(this.txtdatabase);
            this.PostgreSQL.Controls.Add(this.txtpassword);
            this.PostgreSQL.Controls.Add(this.txtusername);
            this.PostgreSQL.Controls.Add(this.database);
            this.PostgreSQL.Controls.Add(this.server);
            this.PostgreSQL.Controls.Add(this.password);
            this.PostgreSQL.Controls.Add(this.username);
            this.PostgreSQL.Location = new System.Drawing.Point(12, 13);
            this.PostgreSQL.Name = "PostgreSQL";
            this.PostgreSQL.Size = new System.Drawing.Size(275, 185);
            this.PostgreSQL.TabIndex = 2;
            this.PostgreSQL.TabStop = false;
            this.PostgreSQL.Text = "Database Connection";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(202, 113);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(54, 20);
            this.txtport.TabIndex = 1;
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(97, 113);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(99, 20);
            this.txthost.TabIndex = 1;
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(97, 150);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(159, 20);
            this.txtdatabase.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(97, 73);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(159, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(97, 33);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(159, 20);
            this.txtusername.TabIndex = 1;
            // 
            // database
            // 
            this.database.AutoSize = true;
            this.database.Location = new System.Drawing.Point(6, 153);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(56, 13);
            this.database.TabIndex = 0;
            this.database.Text = "Database:";
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Location = new System.Drawing.Point(6, 116);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(66, 13);
            this.server.TabIndex = 0;
            this.server.Text = "Server Host:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(6, 76);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 0;
            this.password.Text = "Password:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(6, 36);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // OtherConnectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(299, 251);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.PostgreSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OtherConnectionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Database Connection";
            this.PostgreSQL.ResumeLayout(false);
            this.PostgreSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.GroupBox PostgreSQL;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label database;
        private System.Windows.Forms.Label server;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
    }
}