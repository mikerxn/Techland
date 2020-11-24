namespace Tech
{
    partial class MapsControl
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
            this.buttonSatellite = new System.Windows.Forms.Button();
            this.buttonVector = new System.Windows.Forms.Button();
            this.buttonTerain = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHybridMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSatellite
            // 
            this.buttonSatellite.ForeColor = System.Drawing.Color.Black;
            this.buttonSatellite.Location = new System.Drawing.Point(45, 21);
            this.buttonSatellite.Name = "buttonSatellite";
            this.buttonSatellite.Size = new System.Drawing.Size(110, 24);
            this.buttonSatellite.TabIndex = 0;
            this.buttonSatellite.Text = "Satellite Layer";
            this.buttonSatellite.UseVisualStyleBackColor = true;
            this.buttonSatellite.Click += new System.EventHandler(this.buttonSatellite_Click);
            // 
            // buttonVector
            // 
            this.buttonVector.ForeColor = System.Drawing.Color.Black;
            this.buttonVector.Location = new System.Drawing.Point(245, 21);
            this.buttonVector.Name = "buttonVector";
            this.buttonVector.Size = new System.Drawing.Size(110, 24);
            this.buttonVector.TabIndex = 1;
            this.buttonVector.Text = "Vector Layer";
            this.buttonVector.UseVisualStyleBackColor = true;
            this.buttonVector.Click += new System.EventHandler(this.buttonVector_Click);
            // 
            // buttonTerain
            // 
            this.buttonTerain.ForeColor = System.Drawing.Color.Black;
            this.buttonTerain.Location = new System.Drawing.Point(445, 21);
            this.buttonTerain.Name = "buttonTerain";
            this.buttonTerain.Size = new System.Drawing.Size(110, 24);
            this.buttonTerain.TabIndex = 2;
            this.buttonTerain.Text = "Terrain Layer";
            this.buttonTerain.UseVisualStyleBackColor = true;
            this.buttonTerain.Click += new System.EventHandler(this.buttonTerain_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(200, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 53);
            this.panel4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(400, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 53);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(600, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 53);
            this.panel2.TabIndex = 27;
            // 
            // buttonHybridMap
            // 
            this.buttonHybridMap.ForeColor = System.Drawing.Color.Black;
            this.buttonHybridMap.Location = new System.Drawing.Point(645, 21);
            this.buttonHybridMap.Name = "buttonHybridMap";
            this.buttonHybridMap.Size = new System.Drawing.Size(110, 24);
            this.buttonHybridMap.TabIndex = 28;
            this.buttonHybridMap.Text = "Hybrid Layer";
            this.buttonHybridMap.UseVisualStyleBackColor = true;
            this.buttonHybridMap.Click += new System.EventHandler(this.buttonHybridMap_Click);
            // 
            // MapsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonHybridMap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonTerain);
            this.Controls.Add(this.buttonVector);
            this.Controls.Add(this.buttonSatellite);
            this.Name = "MapsControl";
            this.Size = new System.Drawing.Size(803, 59);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonVector;
        private System.Windows.Forms.Button buttonTerain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonSatellite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHybridMap;
    }
}
