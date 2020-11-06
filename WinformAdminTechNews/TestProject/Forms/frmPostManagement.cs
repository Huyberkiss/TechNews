using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Controls;
using Microsoft.VisualBasic;
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
        void bindingData()
        {
            txtAuthor.DataBindings.Clear();
            txtAuthor.DataBindings.Add(new Binding("Text", dataGView.DataSource, "Author", true, DataSourceUpdateMode.Never));
            //cbboxStatus.DataBindings.Clear();
            //cbboxStatus.DataBindings.Add(new Binding("Text", dataGView.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        public void loadData()
        {
            var listData = from c in DBTechNews.Posts

                           select new { PostID = c.postID, PostTitle = c.postTitle, Author = c.postID, PostContent = c.postContent, cateID = c.Category.cateName, StatusID = c.postStatus, HistoryAccepted = c.History.dateAccepted, HistorySubmit = c.History.dateSubmited };
            dataGView.DataSource = listData.ToList();

        }

        private void frmPostManagement_Load(object sender, EventArgs e)
        {
            loadData();
            bindingData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGView.SelectedCells[0].OwningRow.Cells["PostID"].Value.ToString());

            frmViewDetailss frmView = new frmViewDetailss(id);
            frmView.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
            bindingData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGView.SelectedCells[0].OwningRow.Cells["PostID"].Value.ToString());
            int status = -1;
            //ComboBoxItem typeItem = (ComboBoxItem)cbboxStatus.SelectedItem;
            string value = cbboxStatus.Text;
            if (value == "Active")
            {
                status = 0;
            }
            else
            {
                status = 1;
            }
            Post post = DBTechNews.Posts.Find(id);
            post.postStatus = status;
            DBTechNews.SaveChanges();
            loadData();
            bindingData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
            string textSeach = txtSearch.Text.ToString();
            var dataSearch = from c in DBTechNews.Posts
                             select new { PostID = c.postID, PostTitle = c.postTitle, Author = c.postID, PostContent = c.postContent, cateID = c.Category.cateName, StatusID = c.postStatus, HistoryAccepted = c.History.dateAccepted, HistorySubmit = c.History.dateSubmited };
            dataGView.DataSource = dataSearch.ToList();
        }
    }
}
