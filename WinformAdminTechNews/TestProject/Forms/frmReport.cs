
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
    public partial class frmReport : Form
    {

        TechNewsEntities db = new TechNewsEntities(); 
        DataTable table;
        public frmReport()
        {
            InitializeComponent();
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            cbbList.Items.Add("---Select---");
            cbbList.SelectedIndex = 0;
        }

        public void loadDataUser()
        {
            var data = from a in db.Comments
                       from b in db.Accounts
                       where a.aID == b.aID
                       select new
                       {
                           ID=b.aID,
                           Username = b.aUsername,
                           Fullname = b.aFullname,
                           Email = b.aEmail,
                           Date_Added=b.aDateAdded,
                           Country = b.Country.countryName
                       } into user
                       group user by new
                       {
                           user.ID,
                           user.Username,
                           user.Fullname,
                           user.Email,
                           user.Date_Added,
                           user.Country
                       }
                       into n
                       select new
                       {
                           ID=n.Key.ID,
                           Username = n.Key.Username,
                           Fullname = n.Key.Fullname,
                           Email = n.Key.Email,
                           Date_Added=n.Key.Date_Added,
                           Country=n.Key.Country,
                           Comment_Number = n.Count()
                       }
                       ;
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Fullname", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Date_Added", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("Comment_Number", typeof(int));
            foreach (var i in data)
            {
                DataRow dt = table.NewRow();
                dt["ID"] = i.ID;
                dt["Username"] = i.Username;
                dt["Fullname"] = i.Fullname;
                dt["Email"] = i.Email;
                dt["Date_Added"] = i.Date_Added;
                dt["Date_Added"] = DateTime.Parse((dt["Date_Added"].ToString())).ToString("dd/MM/yyyy");
                dt["Country"] = i.Country;
                dt["Comment_Number"] = i.Comment_Number;
                table.Rows.Add(dt);
            }
            dgvData.DataSource = table;
            dgvData.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            grbTable.Text = "User";
           
        }

        public void loadDataPoster()
        {
            var data = from a in db.Histories
                       from b in db.Accounts
                       where a.posterID == b.aID
                       select new
                       {
                           ID=a.posterID,
                           Username = b.aUsername,
                           Fullname = b.aFullname,
                           Email = b.aEmail,
                           Date_Added=b.aDateAdded,

                       } into info
                       group info by new
                       {
                           info.ID,
                           info.Username,
                           info.Fullname,
                           info.Email,
                           info.Date_Added
                       }
                        into p
                       orderby p.Count() ascending
                       select new
                       {
                           ID=p.Key.ID,
                           Username = p.Key.Username,
                           Fullname = p.Key.Fullname,
                           Email = p.Key.Email,
                           Date_Added=p.Key.Date_Added,
                           Total_Posts = p.Count()
                       };
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Fullname", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Date_Added", typeof(string));
            table.Columns.Add("Total_Posts", typeof(string));

            foreach (var i in data)
            {
                DataRow dt = table.NewRow();
                dt["ID"] = i.ID;
                dt["Username"] = i.Username;
                dt["Fullname"] = i.Fullname;
                dt["Email"] = i.Email;
                dt["Date_Added"] = i.Date_Added;
                dt["Date_Added"] = DateTime.Parse((dt["Date_Added"].ToString())).ToString("dd/MM/yyyy");
                dt["Total_Posts"] = i.Total_Posts;
                table.Rows.Add(dt);
            }

            dgvData.DataSource = table;
            grbTable.Text = "Poster";
        }
        
        public void loadDataHistory()
        {
            var data = from c in db.Histories
                       select new { 
                            ID=c.hID,
                            Date_Submited=c.dateSubmited,
                            Dat_Accepted=c.dateAccepted,
                            Status=c.typeAccept,
                            Post_Title=c.Post.postTitle
                       };
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Date_Submited", typeof(string));
            table.Columns.Add("Date_Accepted", typeof(string));
            table.Columns.Add("Status", typeof(int));
            table.Columns.Add("Post_Title", typeof(string));
            foreach (var i in data)
            {
                DataRow dt = table.NewRow();
                dt["ID"] = i.ID;
                dt["Date_Submited"] = i.Date_Submited;
                dt["Date_Submited"] = DateTime.Parse((dt["Date_Submited"].ToString())).ToString("dd/MM/yyyy");
                dt["Date_Accepted"] = i.Dat_Accepted;
                dt["Date_Accepted"] = DateTime.Parse((dt["Date_Accepted"].ToString())).ToString("dd/MM/yyyy");
                dt["Status"] = i.Status;
                dt["Post_Title"] = i.Post_Title;
                table.Rows.Add(dt);
            }
            dgvData.DataSource = table;
            grbTable.Text = "History";
        }

        public void loadDataCensor()
        {
            var data = from c in db.Accounts
                       join d in db.Histories on c.aID equals d.censorID
                       where c.Role.roleName == "Censor"
                       select new
                       {
                           ID=c.aID,
                           Username = c.aUsername,
                           Fullname = c.aFullname,
                           Email = c.aEmail,
                           Date_Added = c.aDateAdded,
                           Country = c.Country.countryName
                       }
                        into censor
                       group censor by new
                       {
                           censor.ID,
                           censor.Username,
                           censor.Fullname,
                           censor.Email,
                           censor.Date_Added,
                           censor.Country
                       }into p orderby p.Count()
                        select new {
                           ID=p.Key.ID,
                           Username=p.Key.Username,
                           Fullname=p.Key.Fullname,
                           Email=p.Key.Email,
                           Date_Added=p.Key.Date_Added,
                           Country=p.Key.Country,
                           Total_Posts=p.Count()
                        };
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Fullname", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Date_Added", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("Total_Posts", typeof(int));
            foreach (var i in data)
            {
                DataRow dt = table.NewRow();
                dt["ID"] = i.ID;
                dt["Username"] = i.Username;
                dt["Fullname"] = i.Fullname;
                dt["Email"] = i.Email;
                dt["Date_Added"] = i.Date_Added;
                dt["Date_Added"] = DateTime.Parse((dt["Date_Added"].ToString())).ToString("dd/MM/yyyy");
                dt["Country"] = i.Country;
                dt["Total_Posts"] = i.Total_Posts;
                table.Rows.Add(dt);
            }
            dgvData.DataSource = table;
            grbTable.Text = "Censor";
        }

        public void addCombobox()
        {
            cbbList.Items.Clear();
            if(grbTable.Text == "User")
            {
                cbbList.Items.Add("Date_Added(L->H)");
                cbbList.Items.Add("Date_Added(H->L)");
                cbbList.Items.Add("Comment(L->H)");
                cbbList.Items.Add("Comment(H->L)");
            }
            if (grbTable.Text == "Poster" || grbTable.Text == "Censor")
            {
                cbbList.Items.Add("Date_Added(L->H)");
                cbbList.Items.Add("Date_Added(H->L)");
                cbbList.Items.Add("Total_Posts(L->H)");
                cbbList.Items.Add("Total_Posts(H->L)");
            }
            if (grbTable.Text == "History")
            {
                cbbList.Items.Add("Date_Submited(L->H)");
                cbbList.Items.Add("Date_Submited(H->L)");
                cbbList.Items.Add("Date_Accepted(L->H)");
                cbbList.Items.Add("Date_Accepted(H->L)");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDataHistory_Click(object sender, EventArgs e)
        {
            loadDataHistory();
            dgvDetail.DataSource = null;
            addCombobox();
            cbbList.SelectedIndex = 0;
            txtName.Text = "";
        }

        private void btnDataPoster_Click(object sender, EventArgs e)
        {
            loadDataPoster();
            dgvDetail.DataSource = null;
            addCombobox();
            cbbList.SelectedIndex = 0;
            txtName.Text = "";
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            loadDataUser();
            dgvDetail.DataSource = null;
            addCombobox();
            cbbList.SelectedIndex = 0;
            txtName.Text = "";
        }

        private void btnDataPost_Click(object sender, EventArgs e)
        {
            loadDataCensor();
            dgvDetail.DataSource = null;
            addCombobox();
            cbbList.SelectedIndex = 0;
            txtName.Text = "";
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            if(dgvData == null)
            {
                MessageBox.Show("Please choose data!");
            }
            else
            {
                DateTime start = DateTime.Parse(dtpStart.Value.ToString("MM/dd/yyyy"));
                DateTime end = DateTime.Parse(dtpEnd.Value.ToString("MM/dd/yyyy"));
                if (grbTable.Text == "History")
                {
                    var data = from c in db.Histories
                               where c.dateSubmited >= start && c.dateSubmited <= end
                               select new
                               {
                                   ID = c.hID,
                                   Date_Submited = c.dateSubmited,
                                   Dat_Accepted = c.dateAccepted,
                                   Status = c.typeAccept,
                                   Post_Title = c.Post.postTitle
                               };
                    table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Date_Submited", typeof(string));
                    table.Columns.Add("Date_Accepted", typeof(string));
                    table.Columns.Add("Status", typeof(int));
                    table.Columns.Add("Post_Title", typeof(string));
                    foreach (var i in data)
                    {
                        DataRow dt = table.NewRow();
                        dt["ID"] = i.ID;
                        dt["Date_Submited"] = i.Date_Submited;
                        dt["Date_Submited"] = Convert.ToString(DateTime.Parse((dt["Date_Submited"].ToString())).ToString("dd/MM/yyyy"));
                        dt["Date_Accepted"] = i.Dat_Accepted;
                        dt["Date_Accepted"] = Convert.ToString(DateTime.Parse((dt["Date_Accepted"].ToString())).ToString("dd/MM/yyyy"));
                        dt["Status"] = i.Status;
                        dt["Post_Title"] = i.Post_Title;
                        table.Rows.Add(dt);
                    }
                    dgvData.DataSource = table;
                }

                if (grbTable.Text == "User")
                {
                    var data = from a in db.Comments
                               from b in db.Accounts
                               where a.aID == b.aID
                               where b.aDateAdded >= start && b.aDateAdded <= end
                               select new
                               {
                                   ID = b.aID,
                                   Username = b.aUsername,
                                   Fullname = b.aFullname,
                                   Email = b.aEmail,
                                   Date_Added = b.aDateAdded,
                                   Country = b.Country.countryName
                               } into user
                               group user by new
                               {
                                   user.ID,
                                   user.Username,
                                   user.Fullname,
                                   user.Email,
                                   user.Date_Added,
                                   user.Country
                               }
                               into n
                               select new
                               {
                                   ID = n.Key.ID,
                                   Username = n.Key.Username,
                                   Fullname = n.Key.Fullname,
                                   Email = n.Key.Email,
                                   Date_Added = n.Key.Date_Added,
                                   Country = n.Key.Country,
                                   Comment_Number = n.Count()
                               }
                           ;
                    table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Username", typeof(string));
                    table.Columns.Add("Fullname", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Date_Added", typeof(string));
                    table.Columns.Add("Country", typeof(string));
                    table.Columns.Add("Comment_Number", typeof(int));
                    foreach (var i in data)
                    {
                        DataRow dt = table.NewRow();
                        dt["ID"] = i.ID;
                        dt["Username"] = i.Username;
                        dt["Fullname"] = i.Fullname;
                        dt["Email"] = i.Email;
                        dt["Date_Added"] = i.Date_Added;
                        dt["Date_Added"] = DateTime.Parse((dt["Date_Added"].ToString())).ToString("dd/MM/yyyy");
                        dt["Country"] = i.Country;
                        dt["Comment_Number"] = i.Comment_Number;
                        table.Rows.Add(dt);
                    }
                    dgvData.DataSource = table;
                }
                if (grbTable.Text == "Poster")
                {
                    var data = from a in db.Histories
                               from b in db.Accounts
                               where a.posterID == b.aID
                               where b.aDateAdded >= start && b.aDateAdded <= end
                               select new
                               {
                                   ID = a.posterID,
                                   Username = b.aUsername,
                                   Fullname = b.aFullname,
                                   Email = b.aEmail,
                                   Date_Added = b.aDateAdded,

                               } into info
                               group info by new
                               {
                                   info.ID,
                                   info.Username,
                                   info.Fullname,
                                   info.Email,
                                   info.Date_Added
                               }
                                into p
                               orderby p.Count() ascending
                               select new
                               {
                                   ID = p.Key.ID,
                                   Username = p.Key.Username,
                                   Fullname = p.Key.Fullname,
                                   Email = p.Key.Email,
                                   Date_Added = p.Key.Date_Added,
                                   Total_Posts = p.Count()
                               };
                    table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Username", typeof(string));
                    table.Columns.Add("Fullname", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Date_Added", typeof(string));
                    table.Columns.Add("Total_Posts", typeof(string));

                    foreach (var i in data)
                    {
                        DataRow dt = table.NewRow();
                        dt["ID"] = i.ID;
                        dt["Username"] = i.Username;
                        dt["Fullname"] = i.Fullname;
                        dt["Email"] = i.Email;
                        dt["Date_Added"] = i.Date_Added;
                        dt["Date_Added"] = DateTime.Parse((dt["Date_Added"].ToString())).ToString("dd/MM/yyyy");
                        dt["Total_Posts"] = i.Total_Posts;
                        table.Rows.Add(dt);
                    }

                    dgvData.DataSource = table;
                }
                if (grbTable.Text == "Censor")
                {
                    var data = from c in db.Accounts
                               join d in db.Histories on c.aID equals d.censorID
                               where c.Role.roleName == "Censor"
                               where c.aDateAdded >= start && c.aDateAdded <= end
                               select new
                               {
                                   ID = c.aID,
                                   Username = c.aUsername,
                                   Fullname = c.aFullname,
                                   Email = c.aEmail,
                                   Date_Added = c.aDateAdded,
                                   Country = c.Country.countryName
                               }
                            into censor
                               group censor by new
                               {
                                   censor.ID,
                                   censor.Username,
                                   censor.Fullname,
                                   censor.Email,
                                   censor.Date_Added,
                                   censor.Country
                               } into p
                               orderby p.Count()
                               select new
                               {
                                   ID = p.Key.ID,
                                   Username = p.Key.Username,
                                   Fullname = p.Key.Fullname,
                                   Email = p.Key.Email,
                                   Date_Added = p.Key.Date_Added,
                                   Country = p.Key.Country,
                                   Total_Posts = p.Count()
                               };
                    table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Username", typeof(string));
                    table.Columns.Add("Fullname", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Date_Added", typeof(string));
                    table.Columns.Add("Country", typeof(string));
                    table.Columns.Add("Total_Posts", typeof(int));
                    foreach (var i in data)
                    {
                        DataRow dt = table.NewRow();
                        dt["ID"] = i.ID;
                        dt["Username"] = i.Username;
                        dt["Fullname"] = i.Fullname;
                        dt["Email"] = i.Email;
                        dt["Date_Added"] = i.Date_Added;
                        dt["Date_Added"] = DateTime.Parse((dt["Date_Added"].ToString())).ToString("dd/MM/yyyy");
                        dt["Country"] = i.Country;
                        dt["Total_Posts"] = i.Total_Posts;
                        table.Rows.Add(dt);
                    }
                    dgvData.DataSource = table;
                }
            }
            
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            DataTable newtable = new DataTable();
            newtable = table;
            string name = txtName.Text;
            if(grbTable.Text == "History")
            {
                DataRow[] dt = newtable.Select("Post_Title Like'%" + name + "%'");
                if (dt.Length == 0)
                {
                    MessageBox.Show("Can't find name!");
                }
                else
                {
                    newtable = dt.CopyToDataTable();
                }
            }
            else
            {
                DataRow[] dt = newtable.Select("Fullname Like'%" + name + "%'");
                if (dt.Length == 0)
                {
                    MessageBox.Show("Can't find name!");
                }
                else
                {
                    newtable = dt.CopyToDataTable();
                }
            }
            dgvData.DataSource = newtable;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string search = cbbList.SelectedItem.ToString();

            if(search == "---Select---")
            {
                MessageBox.Show("PLease choose item");
            }
            if (search.Equals("Date_Added(L->H)"))
            {
                table.DefaultView.Sort = "Date_Added ASC";
            }
            if (search.Equals("Date_Added(H->L)"))
            {
                table.DefaultView.Sort = "Date_Added DESC";
            }
            if (search.Equals("Comment(L->H)"))
            {
                table.DefaultView.Sort = "Comment_Number ASC";
            }
            if (search.Equals("Comment(H->L)"))
            {
                table.DefaultView.Sort = "Comment_Number DESC";
            }
            if (search.Equals("Total_Posts(L->H)"))
            {
                table.DefaultView.Sort = "Total_Posts ASC";
            }
            if (search.Equals("Total_Posts(H->L)"))
            {
                table.DefaultView.Sort = "Total_Posts DESC";
            }
            if (search.Equals("Date_Submited(L->H)"))
            {
                table.DefaultView.Sort = "Date_Submited ASC";
            }
            if (search.Equals("Date_Submited(H->L)"))
            {
                table.DefaultView.Sort = "Date_Submited DESC";
            }
            if (search.Equals("Date_Accepted(L->H)"))
            {
                table.DefaultView.Sort = "Date_Accepted ASC";
            }
            if (search.Equals("Date_Accepted(H->L)"))
            {
                table.DefaultView.Sort = "Date_Accepted DESC";
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a row!");
            }

            if (grbTable.Text == "User")
            {
                var data = from c in db.Comments
                           where c.aID == id
                           select new
                           {
                               Username = c.Account.aUsername,
                               Comment = c.commentContent,
                               Post_Title = c.Post.postTitle
                           };
                dgvDetail.DataSource = data.ToList();
            }
            if (grbTable.Text == "Poster")
            {
                var data = from c in db.Posts
                           where c.posterID == id
                           select new
                           {
                               Poster = c.Account.aFullname,
                               Post_Title = c.postTitle,
                               Post_Status = c.postStatus,
                               Category = c.Category.cateName
                           };

                dgvDetail.DataSource = data.ToList();
            }
            if (grbTable.Text == "Censor")
            {
                var data = from c in db.Histories
                           join d in db.Accounts on c.posterID equals d.aID
                           where c.censorID == id
                           select new
                           {
                               Accepted = c.typeAccept,
                               Cencor = c.Account.aFullname,
                               Poster = d.aFullname,
                               Post_Title = c.Post.postTitle
                           };
                dgvDetail.DataSource = data.ToList();
            }
            if (grbTable.Text == "History")
            {
                var name = from c in db.Accounts
                           where c.aID == id
                           select new
                           {
                               c.aFullname
                           };
                var data = from c in db.Histories
                           from d in name
                           where c.hID == id
                           select new
                           {
                               Date_Submit = c.dateSubmited,
                               Date_Accept = c.dateAccepted,
                               Accepted = c.typeAccept,
                               Cencor = c.Account.aFullname,
                               Poster = d.aFullname,
                               Post_Title = c.Post.postTitle

                           };
                dgvDetail.DataSource = data.ToList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_Dashboard dashboard = new Form_Dashboard();
            dashboard.Show();
            this.Dispose();
        }
    }
}
