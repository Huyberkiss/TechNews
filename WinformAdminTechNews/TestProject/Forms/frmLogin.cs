using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Common;
using TestProject.Forms;

namespace TestProject
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GK1DSIU;Initial Catalog=TechNews;Integrated Security=True");
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
            SqlDataAdapter sda = new SqlDataAdapter("select roleID from Account where aUsername='" + txtUsername.Text + "' and aPassword='"+ Encryptor.EncryptMD5(txtPassword.Text) +"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                int role = Convert.ToInt32(dt.Rows[0]["roleID"].ToString());
                if(role == 1)
                {
                    Form_Dashboard fd = new Form_Dashboard();
                    fd.Show();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                } else
                {
                    MessageBox.Show("Only Admin Login!!!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            } else
            {
                MessageBox.Show("Username and password is incorrect!!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
