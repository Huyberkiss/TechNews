using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Forms;

namespace TestProject
{
    public partial class frmLogin : Form
    {
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

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (Form_Dashboard fb = new Form_Dashboard())
            {
                fb.ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
