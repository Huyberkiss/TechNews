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
    public partial class frmAdvs : Form
    {
        TechNewsEntities db = new TechNewsEntities();
        public frmAdvs()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            var data = from ads in db.Advertisements
                       select new {
                           ID = ads.advID,
                           Image = ads.advImage,
                           Url = ads.advUrl,
                       };
            dtTable.DataSource = data.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_Dashboard dashboard = new Form_Dashboard();
            dashboard.Show();
            this.Dispose();
        }
    }
}
