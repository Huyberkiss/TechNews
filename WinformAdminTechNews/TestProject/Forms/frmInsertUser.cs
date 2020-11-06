using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.DB;
using System.Text.RegularExpressions;
using System.CodeDom;
using System.Drawing;
using TestProject.Common;

namespace TestProject.Forms
{
    public partial class frmInsertUser : Form
    {
        TechNewsEntities db = new TechNewsEntities();
        public frmInsertUser()
        {
            InitializeComponent();
            getRole();
            getCountry();
        }

        private void frmInsertUser_Load(object sender, EventArgs e)
        {
            
        }
        private void getRole()
        {
            var role = (from r in db.Roles
                        select new { r.roleID, r.roleName }).Distinct().ToList();
            cbbRole.DataSource = role;
            cbbRole.DisplayMember = "roleName";
            cbbRole.ValueMember = "roleID";
        }

        private void getCountry()
        {
            var country = (from c in db.Countries
                           select new { c.countryID, c.countryName }).Distinct().ToList();
            cbbCountry.DataSource = country;
            cbbCountry.ValueMember = "countryID";
            cbbCountry.DisplayMember = "countryName";

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if ((db.Accounts.FirstOrDefault(u => u.aUsername.Equals(txtUser.Text)) as Account != null) || txtUser.Text == "")
            {
                lblErrorUser.Text = "Username was existed or empty!";
                lblErrorUser.ForeColor = Color.Red;
            }
            else if (txtPass.Text == "")
            {
                lblErrorPass.Text = "Password is not empty!";
                lblErrorPass.ForeColor = Color.Red;
            }
            else if (txtFullName.Text == "")
            {
                lblErrorFullName.Text = "Fullname is not empty!";
                lblErrorFullName.ForeColor = Color.Red;
            }

            else if ((db.Accounts.FirstOrDefault(a => a.aEmail.Equals(txtEmail.Text)) as Account != null) || txtEmail.Text == "")
            {
                lblErrorEmail.Text = "Email was existed or empty!";
                lblErrorEmail.ForeColor = Color.Red;
            }           
            else
            {
                int r = 0;
                int c = 0;
                if (cbbRole.SelectedIndex >= 0)
                {
                    r = cbbRole.SelectedIndex + 1;
                }
                if (cbbCountry.SelectedIndex >= 0)
                {
                    c = cbbCountry.SelectedIndex + 1;
                }
                db.Accounts.Add(new Account()
                {
                    aUsername = txtUser.Text.Trim(),
                    aPassword = new Encryptor().EncryptMD5(txtPass.Text.Trim()),
                    aFullname = txtFullName.Text.Trim(),               
                    aEmail = txtEmail.Text.Trim(),
                    aStatus = 0,
                    aDateAdded = DateTime.Now,
                    roleID = Convert.ToInt32(r),
                    countryID = Convert.ToInt32(c)
                });
                db.SaveChanges();
                new frmUserManagement().Show();
                Hide();              
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex email = new Regex(@"^[a-zA-Z0-9]+([.-_][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-_][a-zA-Z0-9]+)*([.-_][a-zA-Z0-9]{2,})+$");
            if (txtEmail.Text.Length > 0 && txtEmail.Text.Trim().Length != 0)
            {
                if (!email.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Please enter the correct email format!");
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            Regex username = new Regex(@"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
            if (txtUser.Text.Length > 0 && txtUser.Text.Trim().Length != 0)
            {
                if (!username.IsMatch(txtUser.Text.Trim()))
                {
                    MessageBox.Show("Username must be from 8 to 20 characters!");
                    txtUser.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            Regex password = new Regex(@"^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{8,}$");
            if (txtPass.Text.Length > 0 && txtPass.Text.Trim().Length != 0)
            {
                if (!password.IsMatch(txtPass.Text.Trim()))
                {
                    MessageBox.Show("password must be than 8 characters!");
                    txtPass.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new frmUserManagement().Show();
            this.Dispose();
            
        }
    }
}
