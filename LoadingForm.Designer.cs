namespace Tech
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelProsses = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._MinButton = new Tech.ButtonZ();
            this._CloseButton = new Tech.ButtonZ();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.Controls.Add(this.labelProsses);
            this.mainPanel.Controls.Add(this.labelVersion);
            this.mainPanel.Controls.Add(this.labelWelcome);
            this.mainPanel.Controls.Add(this._MinButton);
            this.mainPanel.Controls.Add(this._CloseButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(438, 242);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // labelProsses
            // 
            this.labelProsses.AutoSize = true;
            this.labelProsses.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProsses.ForeColor = System.Drawing.Color.White;
            this.labelProsses.Location = new System.Drawing.Point(12, 218);
            this.labelProsses.Name = "labelProsses";
            this.labelProsses.Size = new System.Drawing.Size(76, 15);
            this.labelProsses.TabIndex = 4;
            this.labelProsses.Text = "Processing...";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(172, 105);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(84, 16);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Version 1.0.0";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(132, 65);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(162, 31);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "TECHLAND";
            // 
            // _MinButton
            // 
            this._MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._MinButton.DisplayText = "_";
            this._MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MinButton.ForeColor = System.Drawing.Color.White;
            this._MinButton.Location = new System.Drawing.Point(370, 0);
            this._MinButton.MouseClickColor1 = System.Drawing.Color.Silver;
            this._MinButton.MouseHoverColor = System.Drawing.Color.Silver;
            this._MinButton.Name = "_MinButton";
            this._MinButton.Size = new System.Drawing.Size(35, 25);
            this._MinButton.TabIndex = 1;
            this._MinButton.Text = "_";
            this._MinButton.TextLocation_X = 6;
            this._MinButton.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this._MinButton, "Minimize");
            this._MinButton.UseVisualStyleBackColor = true;
            this._MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(404, 0);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.Red;
            this._CloseButton.MouseHoverColor = System.Drawing.Color.Red;
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(35, 25);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 10;
            this._CloseButton.TextLocation_Y = 4;
            this.toolTip1.SetToolTip(this._CloseButton, "Close");
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(438, 242);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Activated += new System.EventHandler(this.LoadingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingForm_Closed);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private ButtonZ _MinButton;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelProsses;
    }
}

