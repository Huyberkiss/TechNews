using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.DB;

namespace TestProject.Forms
{
    public partial class frmViewDetailss : Form
    {
        TechNewsEntities DBTechNews = new TechNewsEntities();
        public frmViewDetailss()
        {
            InitializeComponent();
        }
        public frmViewDetailss(int id)
        {
            InitializeComponent();
            showData(id);
           
        }

        public void sizeFrame() {
            this.Size = new Size(650, 700);

            int width = this.Width;
            int height = this.Height;

            gBContainer.Width = width-20;
            gBContainer.Height = height - 70;
            
            txtContainer.Width = gBContainer.Width - 10;
            txtContainer.Height = gBContainer.Height-250;
            
        }
        public void showData(int id) {
            var list = DBTechNews.Posts.FirstOrDefault(p => p.postID==id);
            if (list != null) {
                lblTitle.Text = list.postTitle;
                lblAuthors.Text = list.postID.ToString();
                lblDateUpload.Text = list.History.dateAccepted.ToString();
                lblCategogy.Text = list.Category.cateName.ToString();
                txtContainer.Text = list.postContent.ToString();
                //string date = DBTechNews.Histories.FirstOrDefault(c => c.dateAccepted);
                //lblDateUpload.Text = ;
            }
        }

        private void frmViewDetails_Load(object sender, EventArgs e)
        {
            sizeFrame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
