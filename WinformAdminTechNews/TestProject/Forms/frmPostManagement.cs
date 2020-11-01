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
    public partial class frmPostManagement : Form
    {
        TechNewsEntities DBTechNews = new TechNewsEntities();
        public frmPostManagement()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData() {
            var listData = from c in DBTechNews.Posts select new { PostID = c.postID, postTitle = c.postTitle, postContent = c.postContent, postStatus = c.postStatus, cateID = c.Category.cateName, hID = c.History.dateAccepted };
            //var listData = from c in DBTechNews.Posts select new { PostID = c.postID, postTitle = c.postTitle, postContent = c.postContent};
            dataGView.DataSource = listData.ToList();
        }

        private void frmPostManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
