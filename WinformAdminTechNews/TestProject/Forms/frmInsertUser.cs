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
            var role = (from r in db.Accounts
                        select new { r.roleID, r.Role.roleName }).Distinct().ToList();
            cbbRole.DataSource = role;
            cbbRole.DisplayMember = "roleName";
            cbbRole.ValueMember = "roleID";
        }

        private void getCountry()
        {
            var country = (from c in db.Accounts
                           where c.countryID == c.Country.countryID
                           select new { c.countryID, c.Country.countryName }).Distinct().ToList();
            cbbCountry.DataSource = country;
            cbbCountry.ValueMember = "countryID";
            cbbCountry.DisplayMember = "countryName";
            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if ((db.Accounts.FirstOrDefault(u => u.aUsername.Equals(txtUser.Text)) as Account != null) || txtUser == null)
            {
                lblErrorUser.Text = "Username was existed or empty!";
                lblErrorUser.ForeColor = Color.Red;
            }
            else if ((db.Accounts.FirstOrDefault(a => a.aPhone.Value.ToString() == txtPhone.Text) as Account != null) || txtPhone == null)
            {
                lblErrorPhone.Text = "Number phone was existed or empty!";
                lblErrorPhone.ForeColor = Color.Red;
            }
            else if (db.Accounts.FirstOrDefault(a => a.aEmail.Equals(txtEmail.Text)) as Account != null)
            {
                lblErrorEmail.Text = "Email was existed or empty!";
                lblErrorEmail.ForeColor = Color.Red;
            } else if(txtPass.Text == null)
            {
                lblErrorPass.Text = "Password is not empty!";
                lblErrorPass.ForeColor = Color.Red;
            } else if (txtAddress == null)
            {
                lblErrorAddress.Text = "Address is not empty!";
                lblErrorAddress.ForeColor = Color.Red;
            } else if (txtFullName == null)
            {
                lblErrorFullName.Text = "Fullname is not empty!";
                lblErrorFullName.ForeColor = Color.Red;
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
                    aPassword = Common.Encryptor.EncryptMD5(txtPass.Text).Trim(),
                    aFullname = txtFullName.Text.Trim(),
                    aBirthday = dateBirthday.Value,
                    aGender = cbMale.CheckState == CheckState.Checked ? 0 : cbFemale.CheckState == CheckState.Checked ? 1 : 0,
                    aPhone = Convert.ToInt32(txtPhone.Text),
                    aEmail = txtEmail.Text.Trim(),
                    aAddress = txtAddress.Text.Trim(),
                    aStatus = 0,
                    aDateAdded = DateTime.Now,
                    roleID = Convert.ToInt32(r),
                    countryID = Convert.ToInt32(c)
                });
                db.SaveChanges();
                Hide();
                
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex email = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Regex phone = new Regex(@"^([0-9]{10})$");
            if (txtPhone.Text.Length > 0 && txtPhone.Text.Trim().Length != 0)
            {
                if (!phone.IsMatch(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Please enter the correct phone is 10 digit!");
                    txtPhone.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        { 
            if (cbFemale.Checked)
            {
                cbMale.CheckState = CheckState.Unchecked;
            }
            else if (cbMale.Checked)
            {
                cbFemale.CheckState = CheckState.Unchecked;
            }
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked)
            {
                cbFemale.CheckState = CheckState.Unchecked;
            }
            if (cbFemale.Checked)
            {
                cbMale.CheckState = CheckState.Unchecked;
            }
        }
    }
}
