namespace Tech
{
    partial class EditLeaseForm
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
            this.closeButton = new Tech.ButtonZ();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.induvidualhold = new System.Windows.Forms.CheckBox();
            this.communityhold = new System.Windows.Forms.CheckBox();
            this.familyhold = new System.Windows.Forms.CheckBox();
            this.LandOwner = new System.Windows.Forms.TextBox();
            this.County = new System.Windows.Forms.TextBox();
            this.District = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.landuse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Village = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.Ward = new System.Windows.Forms.TextBox();
            this.Applicant = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ww = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.labelNin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NINNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BZBackColor = System.Drawing.Color.DimGray;
            this.closeButton.DisplayText = "X";
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(866, 0);
            this.closeButton.MouseClickColor1 = System.Drawing.Color.Red;
            this.closeButton.MouseHoverColor = System.Drawing.Color.Red;
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 22);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.TextLocation_X = 9;
            this.closeButton.TextLocation_Y = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.induvidualhold);
            this.groupBox2.Controls.Add(this.communityhold);
            this.groupBox2.Controls.Add(this.familyhold);
            this.groupBox2.Controls.Add(this.LandOwner);
            this.groupBox2.Controls.Add(this.County);
            this.groupBox2.Controls.Add(this.District);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.landuse);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Village);
            this.groupBox2.Controls.Add(this.Area);
            this.groupBox2.Controls.Add(this.Ward);
            this.groupBox2.Controls.Add(this.Applicant);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ww);
            this.groupBox2.Controls.Add(this.Division);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(24, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 228);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Land Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 24;
            // 
            // induvidualhold
            // 
            this.induvidualhold.AutoSize = true;
            this.induvidualhold.Location = new System.Drawing.Point(430, 154);
            this.induvidualhold.Name = "induvidualhold";
            this.induvidualhold.Size = new System.Drawing.Size(153, 17);
            this.induvidualhold.TabIndex = 23;
            this.induvidualhold.Text = "hold the land as individuals";
            this.induvidualhold.UseVisualStyleBackColor = true;
            // 
            // communityhold
            // 
            this.communityhold.AutoSize = true;
            this.communityhold.Location = new System.Drawing.Point(209, 154);
            this.communityhold.Name = "communityhold";
            this.communityhold.Size = new System.Drawing.Size(163, 17);
            this.communityhold.TabIndex = 23;
            this.communityhold.Text = "hold the land as a community";
            this.communityhold.UseVisualStyleBackColor = true;
            // 
            // familyhold
            // 
            this.familyhold.AutoSize = true;
            this.familyhold.Location = new System.Drawing.Point(16, 154);
            this.familyhold.Name = "familyhold";
            this.familyhold.Size = new System.Drawing.Size(139, 17);
            this.familyhold.TabIndex = 22;
            this.familyhold.Text = "hold the land as a family";
            this.familyhold.UseVisualStyleBackColor = true;
            // 
            // LandOwner
            // 
            this.LandOwner.Location = new System.Drawing.Point(446, 109);
            this.LandOwner.Name = "LandOwner";
            this.LandOwner.Size = new System.Drawing.Size(150, 20);
            this.LandOwner.TabIndex = 21;
            // 
            // County
            // 
            this.County.Location = new System.Drawing.Point(693, 24);
            this.County.Name = "County";
            this.County.Size = new System.Drawing.Size(150, 20);
            this.County.TabIndex = 20;
            // 
            // District
            // 
            this.District.Location = new System.Drawing.Point(107, 66);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(150, 20);
            this.District.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Parish/Ward:";
            // 
            // landuse
            // 
            this.landuse.Location = new System.Drawing.Point(421, 66);
            this.landuse.Name = "landuse";
            this.landuse.Size = new System.Drawing.Size(150, 20);
            this.landuse.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Village/Zone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Occupation of land:";
            // 
            // Village
            // 
            this.Village.Location = new System.Drawing.Point(107, 24);
            this.Village.Name = "Village";
            this.Village.Size = new System.Drawing.Size(150, 20);
            this.Village.TabIndex = 6;
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(163, 109);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(68, 20);
            this.Area.TabIndex = 16;
            // 
            // Ward
            // 
            this.Ward.Location = new System.Drawing.Point(390, 24);
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(150, 20);
            this.Ward.TabIndex = 8;
            // 
            // Applicant
            // 
            this.Applicant.AutoSize = true;
            this.Applicant.Location = new System.Drawing.Point(13, 192);
            this.Applicant.Name = "Applicant";
            this.Applicant.Size = new System.Drawing.Size(99, 13);
            this.Applicant.TabIndex = 15;
            this.Applicant.Text = "Name Of Applicant:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(333, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Date of application:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Owner of adjacent land:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Approximate area (ha):";
            // 
            // ww
            // 
            this.ww.AutoSize = true;
            this.ww.Location = new System.Drawing.Point(577, 69);
            this.ww.Name = "ww";
            this.ww.Size = new System.Drawing.Size(107, 13);
            this.ww.TabIndex = 9;
            this.ww.Text = "Division/Sub-County:";
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(713, 66);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(130, 20);
            this.Division.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "District:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "County/Municipality:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.labelNin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NINNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbxMaritalStatus);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbxSex);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(546, 63);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(150, 20);
            this.txtContact.TabIndex = 18;
            // 
            // labelNin
            // 
            this.labelNin.AutoSize = true;
            this.labelNin.Location = new System.Drawing.Point(13, 27);
            this.labelNin.Name = "labelNin";
            this.labelNin.Size = new System.Drawing.Size(29, 13);
            this.labelNin.TabIndex = 5;
            this.labelNin.Text = "NIN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contact:";
            // 
            // NINNumber
            // 
            this.NINNumber.Location = new System.Drawing.Point(52, 24);
            this.NINNumber.Name = "NINNumber";
            this.NINNumber.Size = new System.Drawing.Size(150, 20);
            this.NINNumber.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(296, 66);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 20);
            this.txtAddress.TabIndex = 16;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(296, 24);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 20);
            this.FirstName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // cmbxMaritalStatus
            // 
            this.cmbxMaritalStatus.FormattingEnabled = true;
            this.cmbxMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cmbxMaritalStatus.Location = new System.Drawing.Point(146, 66);
            this.cmbxMaritalStatus.Name = "cmbxMaritalStatus";
            this.cmbxMaritalStatus.Size = new System.Drawing.Size(76, 21);
            this.cmbxMaritalStatus.TabIndex = 14;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(546, 24);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 20);
            this.LastName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "MARITAL STATUS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SEX:";
            // 
            // cmbxSex
            // 
            this.cmbxSex.FormattingEnabled = true;
            this.cmbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbxSex.Location = new System.Drawing.Point(745, 22);
            this.cmbxSex.Name = "cmbxSex";
            this.cmbxSex.Size = new System.Drawing.Size(75, 21);
            this.cmbxSex.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "LeaseHold Registration Form";
            // 
            // EditLeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(896, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLeaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Lease Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonZ closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox induvidualhold;
        private System.Windows.Forms.CheckBox communityhold;
        private System.Windows.Forms.CheckBox familyhold;
        private System.Windows.Forms.TextBox LandOwner;
        private System.Windows.Forms.TextBox County;
        private System.Windows.Forms.TextBox District;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox landuse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Village;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox Ward;
        private System.Windows.Forms.Label Applicant;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ww;
        private System.Windows.Forms.TextBox Division;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label labelNin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NINNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxMaritalStatus;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxSex;
        private System.Windows.Forms.Label label1;
    }
}