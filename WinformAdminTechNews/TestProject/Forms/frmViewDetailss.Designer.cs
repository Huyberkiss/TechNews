namespace TestProject.Forms
{
    partial class frmViewDetailss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewDetailss));
            this.gBContainer = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategogy = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateUpload = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.txtContainer = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gBContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBContainer
            // 
            this.gBContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.gBContainer.Controls.Add(this.button1);
            this.gBContainer.Controls.Add(this.groupBox2);
            this.gBContainer.Controls.Add(this.txtContainer);
            this.gBContainer.Controls.Add(this.lblTitle);
            this.gBContainer.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBContainer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gBContainer.Location = new System.Drawing.Point(12, 12);
            this.gBContainer.Name = "gBContainer";
            this.gBContainer.Size = new System.Drawing.Size(789, 808);
            this.gBContainer.TabIndex = 0;
            this.gBContainer.TabStop = false;
            this.gBContainer.Text = "--------------";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.lblCategogy);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblDateUpload);
            this.groupBox2.Controls.Add(this.lblAuthors);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(6, 23);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(76, 25);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblCategogy
            // 
            this.lblCategogy.AutoSize = true;
            this.lblCategogy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategogy.Location = new System.Drawing.Point(124, 78);
            this.lblCategogy.Name = "lblCategogy";
            this.lblCategogy.Size = new System.Drawing.Size(76, 20);
            this.lblCategogy.TabIndex = 7;
            this.lblCategogy.Text = "categogy";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date upload:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categogy:";
            // 
            // lblDateUpload
            // 
            this.lblDateUpload.AutoSize = true;
            this.lblDateUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateUpload.Location = new System.Drawing.Point(124, 53);
            this.lblDateUpload.Name = "lblDateUpload";
            this.lblDateUpload.Size = new System.Drawing.Size(91, 20);
            this.lblDateUpload.TabIndex = 4;
            this.lblDateUpload.Text = "10/10/2019";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(124, 23);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(56, 20);
            this.lblAuthors.TabIndex = 3;
            this.lblAuthors.Text = "author";
            // 
            // txtContainer
            // 
            this.txtContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainer.Location = new System.Drawing.Point(6, 279);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.ReadOnly = true;
            this.txtContainer.Size = new System.Drawing.Size(776, 510);
            this.txtContainer.TabIndex = 5;
            this.txtContainer.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(21, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(750, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 83);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmViewDetailss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(810, 833);
            this.Controls.Add(this.gBContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewDetailss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewDetails";
            this.Load += new System.EventHandler(this.frmViewDetails_Load);
            this.gBContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBContainer;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox txtContainer;
        private System.Windows.Forms.Label lblDateUpload;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCategogy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}