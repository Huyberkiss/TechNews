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
        TechNewsEntities db = new TechNewsEntities();
        public frmUserManagement()
        {
            InitializeComponent();
            btnView_Click(null, null);
            getRole();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertUser insert = new frmInsertUser();
            insert.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                dtTable.DataSource = data.Where(a => a.Username.Contains(txtSearch.Text)).ToList();          
        }

        public void btnView_Click(object sender, EventArgs e)
        {
                var data = (from a in db.Accounts
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
                            });
                dtTable.DataSource = data.ToList();      
        }

        private void getRole()
        {
            var role = (from r in db.Accounts
                        select new { r.roleID, r.Role.roleName }).Distinct().ToList();
            cbbRole.DataSource = role;
            cbbRole.DisplayMember = "roleName";
            cbbRole.ValueMember = "roleID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int indexRow;
      
        private void dtTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dtTable.Rows[indexRow];
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtTable.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            Account update = db.Accounts.Where(a => a.aID.Equals(id)).SingleOrDefault();
            update.roleID = cbbRole.SelectedIndex + 1;
            update.aStatus = cbActive.CheckState == CheckState.Checked ? 0 : cbHidden.CheckState == CheckState.Checked ? 1 : 0;
            db.SaveChanges();
            btnView_Click(sender, e);
        }
    }
}
