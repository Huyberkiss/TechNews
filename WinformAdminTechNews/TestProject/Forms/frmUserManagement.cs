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
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            show();
        }

        public void show()
        {
            TechNewsEntities db = new TechNewsEntities();
            var data = (from d in db.Accounts select d);
            dtTable.DataSource = data.ToList();
        }
    }
}
