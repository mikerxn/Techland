namespace Tech
{
    partial class RibbonControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpButton = new Word.TabButton();
            this.aboutButton = new Word.TabButton();
            this.settingsButton = new Word.TabButton();
            this.toolsButton = new Word.TabButton();
            this.mapsButton = new Word.TabButton();
            this.HomeButton = new Word.TabButton();
            this.FileButton = new Tech.ButtonZ();
            this.tabPanel = new Tech.TabPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.toolsButton);
            this.panel1.Controls.Add(this.mapsButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.FileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 32);
            this.panel1.TabIndex = 3;
            // 
            // helpButton
            // 
            this.helpButton.BackColorTB = System.Drawing.Color.White;
            this.helpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.helpButton.ChangeColorMouseHC = true;
            this.helpButton.DisplayText = "HELP";
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.Black;
            this.helpButton.Location = new System.Drawing.Point(391, 8);
            this.helpButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.helpButton.Name = "helpButton";
            this.helpButton.ShowBorder = true;
            this.helpButton.Size = new System.Drawing.Size(56, 25);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "HELP";
            this.helpButton.TextLocation_X = 8;
            this.helpButton.TextLocation_Y = 8;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpsButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColorTB = System.Drawing.Color.White;
            this.aboutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.aboutButton.ChangeColorMouseHC = true;
            this.aboutButton.DisplayText = "ABOUT";
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.Black;
            this.aboutButton.Location = new System.Drawing.Point(329, 8);
            this.aboutButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.ShowBorder = true;
            this.aboutButton.Size = new System.Drawing.Size(56, 25);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "ABOUT";
            this.aboutButton.TextLocation_X = 8;
            this.aboutButton.TextLocation_Y = 8;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColorTB = System.Drawing.Color.White;
            this.settingsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.settingsButton.ChangeColorMouseHC = true;
            this.settingsButton.DisplayText = "SETTINGS";
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Location = new System.Drawing.Point(247, 7);
            this.settingsButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShowBorder = true;
            this.settingsButton.Size = new System.Drawing.Size(76, 25);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.TextLocation_X = 8;
            this.settingsButton.TextLocation_Y = 8;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolsButton
            // 
            this.toolsButton.BackColorTB = System.Drawing.Color.White;
            this.toolsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toolsButton.ChangeColorMouseHC = true;
            this.toolsButton.DisplayText = "TOOLS";
            this.toolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolsButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsButton.ForeColor = System.Drawing.Color.Black;
            this.toolsButton.Location = new System.Drawing.Point(185, 7);
            this.toolsButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.toolsButton.Name = "toolsButton";
            this.toolsButton.ShowBorder = true;
            this.toolsButton.Size = new System.Drawing.Size(56, 25);
            this.toolsButton.TabIndex = 3;
            this.toolsButton.Text = "TOOLS";
            this.toolsButton.TextLocation_X = 8;
            this.toolsButton.TextLocation_Y = 8;
            this.toolsButton.UseVisualStyleBackColor = true;
            this.toolsButton.Click += new System.EventHandler(this.toolsButton_Click);
            // 
            // mapsButton
            // 
            this.mapsButton.BackColorTB = System.Drawing.Color.White;
            this.mapsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mapsButton.ChangeColorMouseHC = true;
            this.mapsButton.DisplayText = "MAPS";
            this.mapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapsButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapsButton.ForeColor = System.Drawing.Color.Black;
            this.mapsButton.Location = new System.Drawing.Point(123, 7);
            this.mapsButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.mapsButton.Name = "mapsButton";
            this.mapsButton.ShowBorder = true;
            this.mapsButton.Size = new System.Drawing.Size(56, 25);
            this.mapsButton.TabIndex = 2;
            this.mapsButton.Text = "MAPS";
            this.mapsButton.TextLocation_X = 8;
            this.mapsButton.TextLocation_Y = 8;
            this.mapsButton.UseVisualStyleBackColor = true;
            this.mapsButton.Click += new System.EventHandler(this.mapsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColorTB = System.Drawing.Color.White;
            this.HomeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HomeButton.ChangeColorMouseHC = true;
            this.HomeButton.DisplayText = "HOME";
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.Black;
            this.HomeButton.Location = new System.Drawing.Point(61, 7);
            this.HomeButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.ShowBorder = true;
            this.HomeButton.Size = new System.Drawing.Size(56, 25);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.TextLocation_X = 8;
            this.HomeButton.TextLocation_Y = 8;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.FileButton.DisplayText = "FILE";
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.ForeColor = System.Drawing.Color.White;
            this.FileButton.Location = new System.Drawing.Point(0, 7);
            this.FileButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(75)))), ((int)(((byte)(145)))));
            this.FileButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(55, 25);
            this.FileButton.TabIndex = 0;
            this.FileButton.Text = "FILE";
            this.FileButton.TextLocation_X = 8;
            this.FileButton.TextLocation_Y = 8;
            this.FileButton.UseVisualStyleBackColor = true;
            // 
            // tabPanel
            // 
            this.tabPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 32);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(803, 90);
            this.tabPanel.SkipXRange = new System.Drawing.Point(0, 0);
            this.tabPanel.TabIndex = 4;
            // 
            // RibbonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.panel1);
            this.Name = "RibbonControl";
            this.Size = new System.Drawing.Size(803, 122);
            this.Load += new System.EventHandler(this.RibbonControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public ButtonZ FileButton;
        public Word.TabButton HomeButton;
        public Word.TabButton mapsButton;
        public Word.TabButton toolsButton;
        public Word.TabButton settingsButton;
        public Word.TabButton aboutButton;
        public Word.TabButton helpButton;
        public TabPanel tabPanel;
    }
}
