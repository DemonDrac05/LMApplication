using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Library
{
    internal class APM
    {
        public string Username { get; set; }
        public string Password { get; set; }

        static string myconstrg = ConfigurationManager.ConnectionStrings["LibraryManagement.Properties.Settings.LibraryConnectionString"].ConnectionString;

        public string tableName = "APM$";

        public DataTable Select()
        {
            SqlConnection connection = new SqlConnection(myconstrg);
            DataTable dt = new DataTable();
            try
            {
                string sql = $"SELECT * FROM [{tableName}]";

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                connection.Open();
                adapter.Fill(dt);

            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
    }
}
