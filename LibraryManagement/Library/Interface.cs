using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Library
{
    internal class Interface
    {
        public float eISBN { get; set; }
        public string Title { get; set; }
        public string ProductType { get; set; }
        public string Author { get; set; }
        public string TitleVolume { get; set; }
        public string Edition { get; set; }
        public string Series { get; set; }
        public string eBookCategory { get; set; }
        public DateTime? OnlinePubDate { get; set; }
        public float CollectionYear { get; set; }
        public string Publisher { get; set; }
        public string PrimarySubject { get; set; }
        public string DisciplineSubject1 { get; set; }
        public string CoreSubject2 { get; set; }
        public string CoreSubject3 { get; set; }
        public string CambridgeCore_DOI_URL { get; set; }
        public string Condition { get; set; }

        static string myconstrg = ConfigurationManager.ConnectionStrings["LibraryManagement.Properties.Settings.LibraryConnectionString"].ConnectionString;

        public string tableName = "'Vilnius University$'";
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
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }

        public bool Update(Interface @interface)
        {
            bool isSucess = false;
            SqlConnection connection = new SqlConnection(myconstrg);
            try
            {
                string sql = "UPDATE 'Vilnius University$' SET " +
                    "eISBN = @eISBN" +
                    "Title = @Title" +
                    "ProductType = @[Product Type]" +
                    "Author = @Author" +
                    "TitleVolume = @[Title Volume]" +
                    "Edition = @Edition" +
                    "Series = @Series" +
                    "eBookCategory = @[eBook Category]" +
                    "OnlinePubDate = @[Online Pub Date]" +
                    "CollectionYear = @[Collection Year]" +
                    "Publisher = @Publisher" +
                    "PrimarySubject = @[Primary Subject]" +
                    "DisciplineSubject1 = @[Discipline (Subject 1)]" +
                    "CoreSubject2 = @[Core Subject 2]" +
                    "CoreSubject3 = @[Core Subject 3]" +
                    "CambridgeCore_DOI_URL = @[Cambridge Core DOI/URL]" +
                    "Condition = @Condition";

                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@eISBN",
                    @interface.eISBN);
                cmd.Parameters.AddWithValue("@Title",
                    @interface.Title);
                cmd.Parameters.AddWithValue("@[Product Type]",
                    @interface.ProductType);
                cmd.Parameters.AddWithValue("@Author",
                    @interface.Author);
                cmd.Parameters.AddWithValue("@[Title Volume]",
                    @interface.TitleVolume);
                cmd.Parameters.AddWithValue("@Edition",
                    @interface.Edition);
                cmd.Parameters.AddWithValue("@Series",
                    @interface.Series);
                cmd.Parameters.AddWithValue("@[eBook Category]",
                    @interface.eBookCategory);
                cmd.Parameters.AddWithValue("@[Online Pub Date]",
                    @interface.OnlinePubDate);
                cmd.Parameters.AddWithValue("@[Collection Year]",
                    @interface.CollectionYear);
                cmd.Parameters.AddWithValue("@Publisher", 
                    @interface.Publisher);
                cmd.Parameters.AddWithValue("@[Primary Subject]",
                    @interface.PrimarySubject);
                cmd.Parameters.AddWithValue("@[Discipline (Subject 1)]",
                    @interface.DisciplineSubject1);
                cmd.Parameters.AddWithValue("@[Core Subject 2]",
                    @interface.CoreSubject2);
                cmd.Parameters.AddWithValue("@[Core Subject 3]",
                    @interface.CoreSubject3);
                cmd.Parameters.AddWithValue("@[Cambridge Core DOI/URL]",
                    @interface.CambridgeCore_DOI_URL);
                cmd.Parameters.AddWithValue("@Condition",
                    @interface.Condition);

                connection.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) isSucess = true;
                else isSucess = false;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return isSucess;
        }
    }
}
