using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class Connection
    {
        public string strConnection = "Data Source=DESKTOP-8PN4OOJ\\SQLEXPRESS;Initial Catalog=QUANLYCUAHANGGIAY;Integrated Security=True";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public Connection()
        {
            connection = new SqlConnection(strConnection);
        }
        public void OpenConnection()
        {
            if(connection.State==ConnectionState.Closed) { 
                connection.Open();
            }
        }
        public void CloseConnection() {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
