using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class ThueDAO:Connection
    {
        public List<Thue> getThue()
        {
           List<Thue> list = new List<Thue>();
            
            //string query = "select * from Thue where TrangThai=1";
            OpenConnection();
            command = new SqlCommand("Select_Thue", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Thue t = new Thue();
                    t.MaThue = reader.GetInt32(0);
                    t.TenThue = reader.GetString(1);
                    t.MucThue = Convert.ToSingle(reader.GetDouble(2));
                    t.TrangThai = reader.GetInt32(3);
                    list.Add(t);
                }
            }
            CloseConnection();
            return list;
        }
        public bool ThemThue(Thue thue)
        {
            string sql = "insert into Thue values(@TenThue,@MucThue,@TrangThai)";
            command=new SqlCommand(sql, connection);
            command.Parameters.Add("@TenThue",SqlDbType.NVarChar).Value=thue.TenThue;
            command.Parameters.Add("@MucThue",SqlDbType.Float).Value=thue.MucThue;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = thue.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool Sua(Thue thue)
        {

            string sql = "update Thue set TenThue=@TenThue, MucThue=@MucThue where MaThue=@MaThue";
            command=new SqlCommand(sql, connection);
            command.Parameters.Add("@MaThue",SqlDbType.Int).Value=thue.MaThue;
            command.Parameters.Add("@TenThue",SqlDbType.NVarChar).Value = thue.TenThue;
            command.Parameters.Add("@MucThue", SqlDbType.Float).Value = thue.MucThue;
            OpenConnection();
            int n=command.ExecuteNonQuery();    
            CloseConnection();
            return n > 0;   

        }
        public float TienThue(string tenthue)
        {
            string sql = "select MucThue from Thue where TenThue=@TenThue";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenThue",SqlDbType.NVarChar).Value=tenthue;
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                double tmp = reader.GetDouble(0);
                float s=Convert.ToSingle(tmp);
                CloseConnection();
                return s;
            }
            CloseConnection();
            return 0f;
        }
        public bool XoaThue(int MaThue)
        {
            string sql = "update Thue set TrangThai=0 where MaThue=@MaThue";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaThue", SqlDbType.Int).Value = MaThue;
            int n = command.ExecuteNonQuery();  
            CloseConnection();
            return n > 0;
  
        }
    }
   

}

