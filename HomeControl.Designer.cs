namespace Tech
{
    partial class HomeControl
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
            this.components = new System.ComponentModel.Container();
            this.lblNew = new System.Windows.Forms.Label();
            this.newLease = new System.Windows.Forms.Button();
            this.newFree = new System.Windows.Forms.Button();
            this.newMailo = new System.Windows.Forms.Button();
            this.newCustomary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editCustomary = new System.Windows.Forms.Button();
            this.editMailo = new System.Windows.Forms.Button();
            this.editFree = new System.Windows.Forms.Button();
            this.editLease = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTools = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomToSelection = new System.Windows.Forms.Button();
            this.btnZoomToFull = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.comboBoxCrs = new System.Windows.Forms.ComboBox();
            this.buttonSatelite = new System.Windows.Forms.Button();
            this.buttonHybrid = new System.Windows.Forms.Button();
            this.buttonTerrain = new System.Windows.Forms.Button();
            this.buttonVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.ForeColor = System.Drawing.Color.Black;
            this.lblNew.Location = new System.Drawing.Point(59, 47);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(29, 13);
            this.lblNew.TabIndex = 0;
            this.lblNew.Text = "New";
            // 
            // newLease
            // 
            this.newLease.Location = new System.Drawing.Point(4, 4);
            this.newLease.Name = "newLease";
            this.newLease.Size = new System.Drawing.Size(70, 20);
            this.newLease.TabIndex = 1;
            this.newLease.Tag = "lblNew";
            this.newLease.Text = "Lease Hold";
            this.newLease.UseVisualStyleBackColor = true;
            this.newLease.Click += new System.EventHandler(this.newLease_Click);
            // 
            // newFree
            // 
            this.newFree.Location = new System.Drawing.Point(4, 28);
            this.newFree.Name = "newFree";
            this.newFree.Size = new System.Drawing.Size(70, 20);
            this.newFree.TabIndex = 2;
            this.newFree.Tag = "lblNew";
            this.newFree.Text = "Free Hold";
            this.newFree.UseVisualStyleBackColor = true;
            this.newFree.Click += new System.EventHandler(this.newFree_Click);
            // 
            // newMailo
            // 
            this.newMailo.Location = new System.Drawing.Point(75, 28);
            this.newMailo.Name = "newMailo";
            this.newMailo.Size = new System.Drawing.Size(70, 20);
            this.newMailo.TabIndex = 3;
            this.newMailo.Tag = "lblNew";
            this.newMailo.Text = "Mailo";
            this.newMailo.UseVisualStyleBackColor = true;
            this.newMailo.Click += new System.EventHandler(this.newMailo_Click);
            // 
            // newCustomary
            // 
            this.newCustomary.Location = new System.Drawing.Point(75, 4);
            this.newCustomary.Name = "newCustomary";
            this.newCustomary.Size = new System.Drawing.Size(70, 20);
            this.newCustomary.TabIndex = 4;
            this.newCustomary.Tag = "lblNew";
            this.newCustomary.Text = "Customary";
            this.newCustomary.UseVisualStyleBackColor = true;
            this.newCustomary.Click += new System.EventHandler(this.newCustomary_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(146, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 53);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(292, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 53);
            this.panel2.TabIndex = 11;
            // 
            // editCustomary
            // 
            this.editCustomary.Location = new System.Drawing.Point(220, 4);
            this.editCustomary.Name = "editCustomary";
            this.editCustomary.Size = new System.Drawing.Size(70, 20);
            this.editCustomary.TabIndex = 10;
            this.editCustomary.Tag = "lblNew";
            this.editCustomary.Text = "Customary";
            this.editCustomary.UseVisualStyleBackColor = true;
            this.editCustomary.Click += new System.EventHandler(this.editCustomary_Click);
            // 
            // editMailo
            // 
            this.editMailo.Location = new System.Drawing.Point(220, 28);
            this.editMailo.Name = "editMailo";
            this.editMailo.Size = new System.Drawing.Size(70, 20);
            this.editMailo.TabIndex = 9;
            this.editMailo.Tag = "lblNew";
            this.editMailo.Text = "Mailo";
            this.editMailo.UseVisualStyleBackColor = true;
            this.editMailo.Click += new System.EventHandler(this.editMailo_Click);
            // 
            // editFree
            // 
            this.editFree.Location = new System.Drawing.Point(150, 28);
            this.editFree.Name = "editFree";
            this.editFree.Size = new System.Drawing.Size(70, 20);
            this.editFree.TabIndex = 8;
            this.editFree.Tag = "lblNew";
            this.editFree.Text = "Free Hold";
            this.editFree.UseVisualStyleBackColor = true;
            this.editFree.Click += new System.EventHandler(this.editFree_Click);
            // 
            // editLease
            // 
            this.editLease.Location = new System.Drawing.Point(150, 4);
            this.editLease.Name = "editLease";
            this.editLease.Size = new System.Drawing.Size(70, 20);
            this.editLease.TabIndex = 7;
            this.editLease.Tag = "lblNew";
            this.editLease.Text = "Lease Hold";
            this.editLease.UseVisualStyleBackColor = true;
            this.editLease.Click += new System.EventHandler(this.editLease_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.ForeColor = System.Drawing.Color.Black;
            this.lblEdit.Location = new System.Drawing.Point(207, 47);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(25, 13);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.Text = "Edit";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(406, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 53);
            this.panel3.TabIndex = 17;
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.ForeColor = System.Drawing.Color.Black;
            this.lblTools.Location = new System.Drawing.Point(333, 47);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(33, 13);
            this.lblTools.TabIndex = 12;
            this.lblTools.Text = "Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(409, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "CRS:";
            this.toolTip1.SetToolTip(this.label2, "Co-ordinate Reference System");
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackgroundImage = global::Tech.Properties.Resources.ZoomIn2;
            this.btnZoomIn.Location = new System.Drawing.Point(318, 28);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(20, 20);
            this.btnZoomIn.TabIndex = 69;
            this.btnZoomIn.Tag = "";
            this.toolTip1.SetToolTip(this.btnZoomIn, "Zoom In");
            this.btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnZoomToSelection
            // 
            this.btnZoomToSelection.BackgroundImage = global::Tech.Properties.Resources.ZoomSelection;
            this.btnZoomToSelection.Location = new System.Drawing.Point(362, 28);
            this.btnZoomToSelection.Name = "btnZoomToSelection";
            this.btnZoomToSelection.Size = new System.Drawing.Size(20, 20);
            this.btnZoomToSelection.TabIndex = 68;
            this.btnZoomToSelection.Tag = "";
            this.toolTip1.SetToolTip(this.btnZoomToSelection, "Zoom To Selection");
            this.btnZoomToSelection.UseVisualStyleBackColor = true;
            // 
            // btnZoomToFull
            // 
            this.btnZoomToFull.BackgroundImage = global::Tech.Properties.Resources.ZoomFull;
            this.btnZoomToFull.Location = new System.Drawing.Point(384, 28);
            this.btnZoomToFull.Name = "btnZoomToFull";
            this.btnZoomToFull.Size = new System.Drawing.Size(20, 20);
            this.btnZoomToFull.TabIndex = 67;
            this.btnZoomToFull.Tag = "";
            this.toolTip1.SetToolTip(this.btnZoomToFull, "Zoom To Full");
            this.btnZoomToFull.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackgroundImage = global::Tech.Properties.Resources.ZoomOut;
            this.btnZoomOut.Location = new System.Drawing.Point(340, 28);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(20, 20);
            this.btnZoomOut.TabIndex = 66;
            this.btnZoomOut.Tag = "";
            this.toolTip1.SetToolTip(this.btnZoomOut, "Zoom Out");
            this.btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // btnPan
            // 
            this.btnPan.BackgroundImage = global::Tech.Properties.Resources.pan3;
            this.btnPan.Location = new System.Drawing.Point(296, 28);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(20, 20);
            this.btnPan.TabIndex = 65;
            this.btnPan.Tag = "";
            this.toolTip1.SetToolTip(this.btnPan, "Pan");
            this.btnPan.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = global::Tech.Properties.Resources.import;
            this.btnImport.Location = new System.Drawing.Point(318, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(20, 20);
            this.btnImport.TabIndex = 20;
            this.btnImport.Tag = "lblNew";
            this.toolTip1.SetToolTip(this.btnImport, "Import");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Tech.Properties.Resources.pri;
            this.btnPrint.Location = new System.Drawing.Point(362, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(20, 20);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Tag = "lblNew";
            this.toolTip1.SetToolTip(this.btnPrint, "Print");
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnShare
            // 
            this.btnShare.BackgroundImage = global::Tech.Properties.Resources.share;
            this.btnShare.Location = new System.Drawing.Point(384, 4);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(20, 20);
            this.btnShare.TabIndex = 18;
            this.btnShare.Tag = "lblNew";
            this.toolTip1.SetToolTip(this.btnShare, "Share");
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Tech.Properties.Resources.export1;
            this.btnExport.Location = new System.Drawing.Point(340, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(20, 20);
            this.btnExport.TabIndex = 16;
            this.btnExport.Tag = "";
            this.toolTip1.SetToolTip(this.btnExport, "Convert Files");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Tech.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(296, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(20, 20);
            this.btnSave.TabIndex = 13;
            this.btnSave.Tag = "lblNew";
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(612, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 53);
            this.panel4.TabIndex = 24;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(501, 47);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(45, 13);
            this.lblSettings.TabIndex = 21;
            this.lblSettings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(409, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Theme:";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.comboBoxTheme.Location = new System.Drawing.Point(464, 4);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(146, 21);
            this.comboBoxTheme.TabIndex = 26;
            // 
            // comboBoxCrs
            // 
            this.comboBoxCrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrs.FormattingEnabled = true;
            this.comboBoxCrs.Location = new System.Drawing.Point(464, 28);
            this.comboBoxCrs.Name = "comboBoxCrs";
            this.comboBoxCrs.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCrs.TabIndex = 28;
            // 
            // buttonSatelite
            // 
            this.buttonSatelite.Location = new System.Drawing.Point(707, 3);
            this.buttonSatelite.Name = "buttonSatelite";
            this.buttonSatelite.Size = new System.Drawing.Size(75, 23);
            this.buttonSatelite.TabIndex = 73;
            this.buttonSatelite.Text = "Satelite layer";
            this.buttonSatelite.UseVisualStyleBackColor = true;
            // 
            // buttonHybrid
            // 
            this.buttonHybrid.Location = new System.Drawing.Point(620, 32);
            this.buttonHybrid.Name = "buttonHybrid";
            this.buttonHybrid.Size = new System.Drawing.Size(75, 23);
            this.buttonHybrid.TabIndex = 72;
            this.buttonHybrid.Text = "Hybrid layer";
            this.buttonHybrid.UseVisualStyleBackColor = true;
            // 
            // buttonTerrain
            // 
            this.buttonTerrain.Location = new System.Drawing.Point(707, 32);
            this.buttonTerrain.Name = "buttonTerrain";
            this.buttonTerrain.Size = new System.Drawing.Size(75, 23);
            this.buttonTerrain.TabIndex = 71;
            this.buttonTerrain.Text = "Terrain layer";
            this.buttonTerrain.UseVisualStyleBackColor = true;
            // 
            // buttonVector
            // 
            this.buttonVector.Location = new System.Drawing.Point(620, 3);
            this.buttonVector.Name = "buttonVector";
            this.buttonVector.Size = new System.Drawing.Size(75, 23);
            this.buttonVector.TabIndex = 70;
            this.buttonVector.Text = "Vector layer";
            this.buttonVector.UseVisualStyleBackColor = true;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonSatelite);
            this.Controls.Add(this.buttonHybrid);
            this.Controls.Add(this.buttonTerrain);
            this.Controls.Add(this.buttonVector);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomToSelection);
            this.Controls.Add(this.btnZoomToFull);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnPan);
            this.Controls.Add(this.comboBoxCrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editCustomary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.editMailo);
            this.Controls.Add(this.lblTools);
            this.Controls.Add(this.newCustomary);
            this.Controls.Add(this.editFree);
            this.Controls.Add(this.newMailo);
            this.Controls.Add(this.editLease);
            this.Controls.Add(this.newFree);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.newLease);
            this.Controls.Add(this.lblNew);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(803, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button newLease;
        private System.Windows.Forms.Button newFree;
        private System.Windows.Forms.Button newMailo;
        private System.Windows.Forms.Button newCustomary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editCustomary;
        private System.Windows.Forms.Button editMailo;
        private System.Windows.Forms.Button editFree;
        private System.Windows.Forms.Button editLease;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCrs;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomToSelection;
        private System.Windows.Forms.Button btnZoomToFull;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button buttonSatelite;
        private System.Windows.Forms.Button buttonHybrid;
        private System.Windows.Forms.Button buttonTerrain;
        private System.Windows.Forms.Button buttonVector;
    }
}
