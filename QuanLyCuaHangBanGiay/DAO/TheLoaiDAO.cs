using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TheLoaiDAO:Connection
    {
        public List<TheLoai> getTheLoai()
        {
            List<TheLoai> dt = new List<TheLoai>();
            try
            {
                //string sql = "select * from TheLoai where TrangThai=1";
                command = new SqlCommand("Select_TheLoai", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TheLoai theLoai = new TheLoai();
                    theLoai.MaTheLoai = reader.GetInt32(0);
                    theLoai.TenTheLoai = reader.GetString(1);
                    theLoai.TrangThai = reader.GetInt32(2);
                    dt.Add(theLoai);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            CloseConnection();
            return dt;
        }
        public bool ThemTheLoai(TheLoai theLoai)
        {
            string sql = "insert into TheLoai values(@TenTheLoai,@TrangThai)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenTheLoai",SqlDbType.NVarChar).Value=theLoai.TenTheLoai;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = theLoai.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;   
        }
        public bool SuaTheLoai(TheLoai theLoai)
        {
            string sql = "update TheLoai set TenTheLoai=@TenTheLoai where MaTheLoai=@MaTheLoai";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTheLoai", SqlDbType.Int).Value = theLoai.MaTheLoai;
            command.Parameters.Add("@TenTheLoai", SqlDbType.NVarChar).Value = theLoai.TenTheLoai;
            //command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = theLoai.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool XoaTheLoai(int matheLoai)
        {
            string sql = "update TheLoai set TrangThai=0 where MaTheLoai=@MaTheLoai";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTheLoai", SqlDbType.Int).Value = matheLoai;        
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public string TenTheLoai(int matheloai)
        {
            try
            {
                string sql = "select TenTheLoai from TheLoai where MaTheLoai=@matheloai";
                command = new SqlCommand(sql, connection);
                OpenConnection();
                command.Parameters.Add("@matheloai", SqlDbType.Int).Value = matheloai;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string tmp = reader.GetString(0);
                    CloseConnection();
                    return tmp;
                }
                CloseConnection();
                return "";
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public int MaTheLoai(string tentheloai)
        {
            try
            {
                string sql = "select MaTheLoai from TheLoai where TenTheLoai=@tentheloai";
                command = new SqlCommand(sql, connection);
                OpenConnection();
                command.Parameters.Add("@tentheloai", SqlDbType.NVarChar).Value = tentheloai;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int tmp = reader.GetInt32(0);
                    CloseConnection();
                    return tmp;
                }
                CloseConnection();
                return 0;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public List<TheLoai> TimKiemTheLoai(string text)
        {
            List<TheLoai> arraytheloai = new List<TheLoai>();
            string sql = "select * from TheLoai where concat(MaTheLoai,TenTheLoai) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                TheLoai theloai = new TheLoai();
                theloai.MaTheLoai = reader.GetInt32(0);
                theloai.TenTheLoai = reader.GetString(1);
                theloai.TrangThai = reader.GetInt32(2);
                arraytheloai.Add(theloai);
            }
            CloseConnection();
            return arraytheloai;
        }
        public bool KiemTraTheLoai(string tentheloai)
        {
            string sql = "select * from TheLoai where TenTheLoai=@TenTheLoai";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenTheLoai",SqlDbType.NVarChar).Value=tentheloai;
            OpenConnection();
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true; 
            }
            CloseConnection();
            return false;   
        }
    }
}
