namespace StudentApp
{
    partial class EditStudent
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.txtAd1 = new System.Windows.Forms.TextBox();
            this.txtAd2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.rdoPostgrad = new System.Windows.Forms.RadioButton();
            this.rdoUndergrad = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSerialise = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Student Details";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblFirstName.Location = new System.Drawing.Point(65, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 22);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblSurname.Location = new System.Drawing.Point(64, 120);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 22);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblAddress1.Location = new System.Drawing.Point(64, 173);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(130, 22);
            this.lblAddress1.TabIndex = 3;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblAddress2.Location = new System.Drawing.Point(64, 228);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(130, 22);
            this.lblAddress2.TabIndex = 4;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblCity.Location = new System.Drawing.Point(65, 280);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 22);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblCounty.Location = new System.Drawing.Point(64, 334);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(67, 22);
            this.lblCounty.TabIndex = 6;
            this.lblCounty.Text = "County";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblEmail.Location = new System.Drawing.Point(513, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 22);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblPhone.Location = new System.Drawing.Point(513, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 22);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblCourse.Location = new System.Drawing.Point(513, 233);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(68, 22);
            this.lblCourse.TabIndex = 9;
            this.lblCourse.Text = "Course";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblLevel.Location = new System.Drawing.Point(513, 285);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(53, 22);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Level";
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(233, 77);
            this.txtFn.Name = "txtFn";
            this.txtFn.ReadOnly = true;
            this.txtFn.Size = new System.Drawing.Size(159, 22);
            this.txtFn.TabIndex = 11;
            // 
            // txtSn
            // 
            this.txtSn.Location = new System.Drawing.Point(233, 129);
            this.txtSn.Name = "txtSn";
            this.txtSn.ReadOnly = true;
            this.txtSn.Size = new System.Drawing.Size(159, 22);
            this.txtSn.TabIndex = 12;
            // 
            // txtAd1
            // 
            this.txtAd1.Location = new System.Drawing.Point(233, 178);
            this.txtAd1.Name = "txtAd1";
            this.txtAd1.Size = new System.Drawing.Size(159, 22);
            this.txtAd1.TabIndex = 13;
            // 
            // txtAd2
            // 
            this.txtAd2.Location = new System.Drawing.Point(233, 233);
            this.txtAd2.Name = "txtAd2";
            this.txtAd2.Size = new System.Drawing.Size(159, 22);
            this.txtAd2.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(233, 285);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(159, 22);
            this.txtCity.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(602, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 22);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(602, 178);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 22);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.TxtPhone_Validated);
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(233, 332);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(159, 24);
            this.cboCounty.TabIndex = 18;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(602, 228);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(153, 24);
            this.cboCourse.TabIndex = 19;
            // 
            // rdoPostgrad
            // 
            this.rdoPostgrad.AutoSize = true;
            this.rdoPostgrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.rdoPostgrad.Location = new System.Drawing.Point(602, 276);
            this.rdoPostgrad.Name = "rdoPostgrad";
            this.rdoPostgrad.Size = new System.Drawing.Size(103, 26);
            this.rdoPostgrad.TabIndex = 20;
            this.rdoPostgrad.TabStop = true;
            this.rdoPostgrad.Text = "Postgrad";
            this.rdoPostgrad.UseVisualStyleBackColor = true;
            this.rdoPostgrad.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rdoUndergrad
            // 
            this.rdoUndergrad.AutoSize = true;
            this.rdoUndergrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.rdoUndergrad.Location = new System.Drawing.Point(602, 308);
            this.rdoUndergrad.Name = "rdoUndergrad";
            this.rdoUndergrad.Size = new System.Drawing.Size(116, 26);
            this.rdoUndergrad.TabIndex = 21;
            this.rdoUndergrad.TabStop = true;
            this.rdoUndergrad.Text = "Undergrad";
            this.rdoUndergrad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnAdd.Location = new System.Drawing.Point(528, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 39);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Save Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSerialise
            // 
            this.btnSerialise.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSerialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnSerialise.Location = new System.Drawing.Point(69, 390);
            this.btnSerialise.Name = "btnSerialise";
            this.btnSerialise.Size = new System.Drawing.Size(227, 39);
            this.btnSerialise.TabIndex = 23;
            this.btnSerialise.Text = "XML Serialisation";
            this.btnSerialise.UseVisualStyleBackColor = false;
            this.btnSerialise.Click += new System.EventHandler(this.BtnSerialise_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSerialise);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdoUndergrad);
            this.Controls.Add(this.rdoPostgrad);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAd2);
            this.Controls.Add(this.txtAd1);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.TextBox txtAd1;
        private System.Windows.Forms.TextBox txtAd2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.RadioButton rdoPostgrad;
        private System.Windows.Forms.RadioButton rdoUndergrad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSerialise;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}