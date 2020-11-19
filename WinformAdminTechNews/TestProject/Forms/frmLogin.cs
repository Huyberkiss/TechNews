using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Common;
using TestProject.DB;
using TestProject.Forms;

namespace TestProject
{
    public partial class frmLogin : Form
    {
        TechNewsEntities db = new TechNewsEntities();
        
        public frmLogin()
        {
            InitializeComponent();
            TimeUpdater();


        }
        async void TimeUpdater()
        {
            while (true)
            {
                lblTime.Text = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var passMD5 = new Encryptor().EncryptMD5(txtPassword.Text);
            Account acc = db.Accounts.FirstOrDefault(a => a.aUsername.Equals(txtUsername.Text) && a.aPassword.Equals(passMD5) && a.aStatus == 0);
            if (acc != null )
            {
               
                if (acc.roleID == 1)
                {
                    Form_Dashboard fd = new Form_Dashboard();
                    fd.Show();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Only Admin Login!!!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            } else
            {
                MessageBox.Show("Username and password is incorrect!!!");
                txtPassword.Text = "";
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
