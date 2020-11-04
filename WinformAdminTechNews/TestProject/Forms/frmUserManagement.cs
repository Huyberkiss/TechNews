using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            showData();
            getRole();
        }
     
      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertUser insert = new frmInsertUser();
            insert.Show();
        }
    
        public void showData()
        {
            var data = (from a in db.Accounts
                        select new
                        {
                            ID = a.aID,
                            Username = a.aUsername,
                            Fullname = a.aFullname,
                            Email = a.aEmail,
                            Status = (a.aStatus == 0) ? "Active" : "Inactive",
                            DateAdd = a.aDateAdded,
                            Role = a.Role.roleName,
                            Country = a.Country.countryName
                        });
            dtTable.DataSource = data.ToList();
        }
        
        private void getRole()
        {
            var role = (from r in db.Roles
                        select new { r.roleID, r.roleName }).Distinct().ToList();
            cbbRole.DataSource = role;
            cbbRole.DisplayMember = "roleName";
            cbbRole.ValueMember = "roleID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            new Form_Dashboard().Show();
            this.Dispose();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtTable.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            Account update = db.Accounts.Where(a => a.aID.Equals(id)).SingleOrDefault();
            update.roleID = cbbRole.SelectedIndex + 1;
            update.aStatus = cbActive.CheckState == CheckState.Checked ? 0 : 1;
            db.SaveChanges();
            showData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var data = from a in db.Accounts
                       select new
                       {
                           ID = a.aID,
                           Username = a.aUsername,
                           Fullname = a.aFullname,
                           Email = a.aEmail,
                           Status = a.aStatus,
                           DateAdd = a.aDateAdded,
                           Role = a.Role.roleName,
                           Country = a.Country.countryName
                       };
            dtTable.DataSource = data.Where(a => a.Username.Contains(txtSearch.Text)).ToList();
        }

        private void dtTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbRole.Text = dtTable.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                string status = dtTable.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                cbActive.CheckState = status == "Active" ? CheckState.Checked : CheckState.Unchecked;
            } catch (Exception ex)
            {
                MessageBox.Show("Don't click title!");
            }
                   
        }
    }
}
