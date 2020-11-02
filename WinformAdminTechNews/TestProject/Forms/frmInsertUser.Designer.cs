﻿namespace TestProject.Forms
{
    partial class frmInsertUser
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.lblErrorUser = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorFullName = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorAddress = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Location = new System.Drawing.Point(0, 1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 98);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(288, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 48);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Insert User";
            // 
            // button1
            // 
            this.button1.Image = global::TestProject.Properties.Resources.user;
            this.button1.Location = new System.Drawing.Point(86, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 69);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(223, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(227, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(231, 214);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Fullname:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(240, 286);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(247, 323);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(236, 252);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(64, 17);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(254, 361);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(236, 394);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(259, 434);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 17);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(239, 473);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 17);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Country:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(308, 140);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 22);
            this.txtUser.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(308, 174);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(200, 22);
            this.txtPass.TabIndex = 14;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(308, 209);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(306, 318);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(333, 282);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(60, 21);
            this.cbMale.TabIndex = 17;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(436, 282);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(76, 21);
            this.cbFemale.TabIndex = 18;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.cbFemale_CheckedChanged);
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(308, 247);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(200, 22);
            this.dateBirthday.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(306, 356);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(306, 391);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.btnSubmit.Location = new System.Drawing.Point(354, 519);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(306, 425);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(200, 24);
            this.cbbRole.TabIndex = 25;
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(306, 466);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(200, 24);
            this.cbbCountry.TabIndex = 26;
            // 
            // lblErrorUser
            // 
            this.lblErrorUser.AutoSize = true;
            this.lblErrorUser.Location = new System.Drawing.Point(529, 140);
            this.lblErrorUser.Name = "lblErrorUser";
            this.lblErrorUser.Size = new System.Drawing.Size(16, 17);
            this.lblErrorUser.TabIndex = 27;
            this.lblErrorUser.Text = "  ";
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.Location = new System.Drawing.Point(529, 179);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(12, 17);
            this.lblErrorPass.TabIndex = 28;
            this.lblErrorPass.Text = " ";
            // 
            // lblErrorFullName
            // 
            this.lblErrorFullName.AutoSize = true;
            this.lblErrorFullName.Location = new System.Drawing.Point(529, 214);
            this.lblErrorFullName.Name = "lblErrorFullName";
            this.lblErrorFullName.Size = new System.Drawing.Size(12, 17);
            this.lblErrorFullName.TabIndex = 29;
            this.lblErrorFullName.Text = " ";
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Location = new System.Drawing.Point(529, 323);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(12, 17);
            this.lblErrorPhone.TabIndex = 30;
            this.lblErrorPhone.Text = " ";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Location = new System.Drawing.Point(529, 361);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(12, 17);
            this.lblErrorEmail.TabIndex = 31;
            this.lblErrorEmail.Text = " ";
            // 
            // lblErrorAddress
            // 
            this.lblErrorAddress.AutoSize = true;
            this.lblErrorAddress.Location = new System.Drawing.Point(529, 396);
            this.lblErrorAddress.Name = "lblErrorAddress";
            this.lblErrorAddress.Size = new System.Drawing.Size(12, 17);
            this.lblErrorAddress.TabIndex = 32;
            this.lblErrorAddress.Text = " ";
            // 
            // frmInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.lblErrorAddress);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorPhone);
            this.Controls.Add(this.lblErrorFullName);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorUser);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmInsertUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsertUser";
            this.Load += new System.EventHandler(this.frmInsertUser_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.Label lblErrorUser;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Label lblErrorFullName;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}