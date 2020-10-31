using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DB
{
    class DBConnection
    {
        SqlConnection conn;
        public DBConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-GK1DSIU;Initial Catalog=TechNews;Integrated Security=True");
            conn.Open();
        }

        public SqlConnection GetConnection()
        {
            return this.conn;
        }

        public SqlDataReader ExecuteQuery(string sql)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return cmd.ExecuteReader();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
