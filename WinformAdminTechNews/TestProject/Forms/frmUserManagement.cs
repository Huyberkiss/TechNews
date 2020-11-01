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
            using (TechNewsEntities db = new TechNewsEntities())
            {
                var data = from a in db.Accounts
                           select new
                           {
                               ID = a.aID,
                               Username = a.aUsername,
                               Fullname = a.aFullname,
                               Birthday = a.aBirthday,
                               Gender = a.aGender,
                               Phone = a.aPhone,
                               Email = a.aEmail,
                               Address = a.aAddress,
                               Status = a.aStatus,
                               DateAdd = a.aDateAdded,
                               Role = a.Role.roleName,
                               Country = a.Country.countryName
                           };
                dtTable.DataSource = data.ToList();
                //dtTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //dtTable.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertUser insert = new frmInsertUser();
            insert.Show();
        }
    }
}
