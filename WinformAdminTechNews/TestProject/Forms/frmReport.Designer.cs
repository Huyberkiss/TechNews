namespace TestProject.Forms
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.grbTable = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDataHistory = new System.Windows.Forms.Button();
            this.btnDataCensor = new System.Windows.Forms.Button();
            this.btnDataPoster = new System.Windows.Forms.Button();
            this.btnDataUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbbList = new System.Windows.Forms.ComboBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grbTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(5, 22);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(873, 270);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.grbTable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(897, 543);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Form";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvDetail);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox7.Location = new System.Drawing.Point(5, 343);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(885, 194);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Detail";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(7, 27);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(872, 161);
            this.dgvDetail.TabIndex = 0;
            // 
            // grbTable
            // 
            this.grbTable.Controls.Add(this.dgvData);
            this.grbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.grbTable.Location = new System.Drawing.Point(5, 39);
            this.grbTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTable.Name = "grbTable";
            this.grbTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTable.Size = new System.Drawing.Size(885, 298);
            this.grbTable.TabIndex = 1;
            this.grbTable.TabStop = false;
            this.grbTable.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.groupBox2.Controls.Add(this.btnDataHistory);
            this.groupBox2.Controls.Add(this.btnDataCensor);
            this.groupBox2.Controls.Add(this.btnDataPoster);
            this.groupBox2.Controls.Add(this.btnDataUser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(915, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(413, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // btnDataHistory
            // 
            this.btnDataHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataHistory.Location = new System.Drawing.Point(64, 33);
            this.btnDataHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDataHistory.Name = "btnDataHistory";
            this.btnDataHistory.Size = new System.Drawing.Size(109, 38);
            this.btnDataHistory.TabIndex = 3;
            this.btnDataHistory.Text = "History";
            this.btnDataHistory.UseVisualStyleBackColor = true;
            this.btnDataHistory.Click += new System.EventHandler(this.btnDataHistory_Click);
            // 
            // btnDataCensor
            // 
            this.btnDataCensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataCensor.Location = new System.Drawing.Point(252, 102);
            this.btnDataCensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDataCensor.Name = "btnDataCensor";
            this.btnDataCensor.Size = new System.Drawing.Size(109, 38);
            this.btnDataCensor.TabIndex = 2;
            this.btnDataCensor.Text = "Censor";
            this.btnDataCensor.UseVisualStyleBackColor = true;
            this.btnDataCensor.Click += new System.EventHandler(this.btnDataPost_Click);
            // 
            // btnDataPoster
            // 
            this.btnDataPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataPoster.Location = new System.Drawing.Point(252, 33);
            this.btnDataPoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDataPoster.Name = "btnDataPoster";
            this.btnDataPoster.Size = new System.Drawing.Size(109, 38);
            this.btnDataPoster.TabIndex = 1;
            this.btnDataPoster.Text = "Poster";
            this.btnDataPoster.UseVisualStyleBackColor = true;
            this.btnDataPoster.Click += new System.EventHandler(this.btnDataPoster_Click);
            // 
            // btnDataUser
            // 
            this.btnDataUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataUser.Location = new System.Drawing.Point(64, 102);
            this.btnDataUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDataUser.Name = "btnDataUser";
            this.btnDataUser.Size = new System.Drawing.Size(109, 38);
            this.btnDataUser.TabIndex = 0;
            this.btnDataUser.Text = "User";
            this.btnDataUser.UseVisualStyleBackColor = true;
            this.btnDataUser.Click += new System.EventHandler(this.btnDataUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(979, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1147, 26);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.groupBox3.Controls.Add(this.btnSort);
            this.groupBox3.Controls.Add(this.cbbList);
            this.groupBox3.Controls.Add(this.btnSearchName);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.btnSearchDate);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(916, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(413, 274);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(301, 210);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(95, 42);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbbList
            // 
            this.cbbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbList.FormattingEnabled = true;
            this.cbbList.Location = new System.Drawing.Point(21, 224);
            this.cbbList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbList.Name = "cbbList";
            this.cbbList.Size = new System.Drawing.Size(273, 28);
            this.cbbList.TabIndex = 6;
            this.cbbList.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(301, 158);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(95, 42);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(21, 174);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 26);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Location = new System.Drawing.Point(301, 42);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(95, 41);
            this.btnSearchDate.TabIndex = 3;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Black;
            this.groupBox5.Controls.Add(this.dtpEnd);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(21, 101);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(275, 53);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "End Date";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(5, 25);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(261, 23);
            this.dtpEnd.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.dtpStart);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(21, 42);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(275, 53);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(5, 25);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(261, 23);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1337, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grbTable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDataHistory;
        private System.Windows.Forms.Button btnDataCensor;
        private System.Windows.Forms.Button btnDataPoster;
        private System.Windows.Forms.Button btnDataUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbbList;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox grbTable;
    }
}