using LibraryManagement.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class InterfaceForm : Form
    {
        public InterfaceForm()
        {
            InitializeComponent();
        }

        Interface @interface = new Interface();

        private void InterfaceForm_Load(object sender, EventArgs e)
        {
            DataTable dt = @interface.Select();
            UserDGV.DataSource = dt;
        }

        static string myconstrg = ConfigurationManager.ConnectionStrings["LibraryManagement.Properties.Settings.LibraryConnectionString"].ConnectionString;

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchBox.Text;
            SqlConnection connection = new SqlConnection(myconstrg);
            SqlDataAdapter adapter = new SqlDataAdapter(
                $"SELECT * FROM [{@interface.tableName}] " +
                "WHERE eISBN LIKE @keyword " +
                "OR Title LIKE @keyword " +
                "OR Author LIKE @keyword " +
                "OR Series LIKE @keyword " +
                $"OR [{"ebook Category"}] LIKE @keyword " +
                $"OR [{"Online Pub Date"}] LIKE @keyword " +
                $"OR [{"Collection Year"}] LIKE @keyword " +
                "OR Publisher LIKE @keyword " +
                $"OR [{"Primary Subject"}] LIKE @keyword " +
                $"OR [{"Cambridge Core DOI/URL"}] LIKE @keyword", connection);
            
            adapter.SelectCommand.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            UserDGV.DataSource = dt;
        }
    }
}
