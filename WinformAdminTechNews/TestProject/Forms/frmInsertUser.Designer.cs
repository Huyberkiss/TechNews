namespace TestProject.Forms
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.lblErrorUser = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorFullName = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(254, 250);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(259, 288);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 17);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(239, 329);
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
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(308, 174);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(200, 22);
            this.txtPass.TabIndex = 14;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(308, 209);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(308, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.btnSubmit.Location = new System.Drawing.Point(308, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 27);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(308, 281);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(200, 24);
            this.cbbRole.TabIndex = 25;
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(308, 322);
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
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Location = new System.Drawing.Point(529, 245);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(12, 17);
            this.lblErrorEmail.TabIndex = 31;
            this.lblErrorEmail.Text = " ";
            // 
            // frmInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorFullName);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorUser);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEmail);
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.Label lblErrorUser;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Label lblErrorFullName;
        private System.Windows.Forms.Label lblErrorEmail;
    }
}