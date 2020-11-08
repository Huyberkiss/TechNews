namespace TestProject.Forms
{
    partial class frmPostManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostManagement));
            this.gBData = new System.Windows.Forms.GroupBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.gBTools = new System.Windows.Forms.GroupBox();
            this.cbboxStatus = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.gBData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.gBTools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBData
            // 
            this.gBData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.gBData.Controls.Add(this.dataGView);
            this.gBData.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBData.Location = new System.Drawing.Point(12, 12);
            this.gBData.Name = "gBData";
            this.gBData.Size = new System.Drawing.Size(892, 532);
            this.gBData.TabIndex = 0;
            this.gBData.TabStop = false;
            this.gBData.Text = "POST MANAGEMENT";
            // 
            // dataGView
            // 
            this.dataGView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGView.Location = new System.Drawing.Point(3, 57);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowHeadersWidth = 51;
            this.dataGView.RowTemplate.Height = 24;
            this.dataGView.Size = new System.Drawing.Size(886, 472);
            this.dataGView.TabIndex = 0;
            // 
            // gBTools
            // 
            this.gBTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.gBTools.Controls.Add(this.cbboxStatus);
            this.gBTools.Controls.Add(this.txtAuthor);
            this.gBTools.Controls.Add(this.label2);
            this.gBTools.Controls.Add(this.button1);
            this.gBTools.Controls.Add(this.btnViewDetails);
            this.gBTools.Location = new System.Drawing.Point(918, 282);
            this.gBTools.Name = "gBTools";
            this.gBTools.Size = new System.Drawing.Size(352, 259);
            this.gBTools.TabIndex = 1;
            this.gBTools.TabStop = false;
            this.gBTools.Text = "Tools";
            // 
            // cbboxStatus
            // 
            this.cbboxStatus.FormattingEnabled = true;
            this.cbboxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbboxStatus.Location = new System.Drawing.Point(176, 56);
            this.cbboxStatus.Name = "cbboxStatus";
            this.cbboxStatus.Size = new System.Drawing.Size(164, 24);
            this.cbboxStatus.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(83, 18);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(257, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(6, 46);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(164, 79);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "View Detail";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(189)))), ((int)(((byte)(201)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(918, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Title";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(334, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1016, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1184, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // frmPostManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTools);
            this.Controls.Add(this.gBData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPostManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPostManagement";
            this.Load += new System.EventHandler(this.frmPostManagement_Load);
            this.gBData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.gBTools.ResumeLayout(false);
            this.gBTools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBData;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.GroupBox gBTools;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbboxStatus;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}