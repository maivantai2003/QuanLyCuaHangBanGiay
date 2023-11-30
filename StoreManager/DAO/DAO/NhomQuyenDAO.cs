using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhomQuyenDAO:Connection
    {
        public NhomQuyenDAO() { }
        public List<NhomQuyen> getNhomQuyen()
        {
            List<NhomQuyen> dt = new List<NhomQuyen>();
            try
            {
                OpenConnection();
                //string sql = "select * from NhomQuyen where TrangThai=1";
                command = new SqlCommand("Select_NhomQuyen", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhomQuyen nhomQuyen = new NhomQuyen();
                    nhomQuyen.MaNhomQuyen = reader.GetInt32(0);
                    nhomQuyen.TenNhomQuyen = reader.GetString(1);
                    nhomQuyen.TrangThai = reader.GetInt32(2);
                    dt.Add(nhomQuyen);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public string TenNhomQuyen(int MaNhomQuyen)
        {
            string sql = "select TenNhomQuyen from NhomQuyen where MaNhomQuyen=@MaNhomQuyen";
            OpenConnection();
            command= new SqlCommand(sql,connection);
            command.Parameters.Add("@MaNhomQuyen",SqlDbType.Int).Value=MaNhomQuyen;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string tmp=reader.GetString(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return "";
        }
        public int MaNhomQuyen(string TenNhomQuyen)
        {
            string sql = "select MaNhomQuyen from NhomQuyen where TenNhomQuyen=@TenNhomQuyen";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenNhomQuyen", SqlDbType.NVarChar).Value =TenNhomQuyen;
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
        public bool ThemNhomQuyen(NhomQuyen nhomquyen)
        {
            string sql = "insert into NhomQuyen values(@TenNhomQuyen,@TrangThai)";
            command = new SqlCommand(sql,connection);
            command.Parameters.Add("@TenNhomQuyen", SqlDbType.NVarChar).Value = nhomquyen.TenNhomQuyen;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = nhomquyen.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool SuaNhomQuyen(NhomQuyen nhomquyen)
        {
            string sql = "update NhomQuyen set TenNhomQuyen=@TenNhomQuyen where MaNhomQuyen=@MaNhomQuyen";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = nhomquyen.MaNhomQuyen;
            command.Parameters.Add("@TenNhomQuyen", SqlDbType.NVarChar).Value = nhomquyen.TenNhomQuyen;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool XoaNhomQuyen(int MaNhomQuyen)
        {
            string sql = "update NhomQuyen set TrangThai=0 where MaNhomQuyen=@MaNhomQuyen";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value =MaNhomQuyen;
           
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }

        public List<NhomQuyen> TimKiemNhomQuyen(string text)
        {
            List<NhomQuyen> nhomQuyen = new List<NhomQuyen>();
            string sql = "select * from NhomQuyen where concat(MaNhomQuyen,TenNhomQuyen,TrangThai) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            command = new SqlCommand(sql,connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhomQuyen nhomquyen = new NhomQuyen();
                nhomquyen.MaNhomQuyen = reader.GetInt32(0);
                nhomquyen.TenNhomQuyen = reader.GetString(1);
                nhomquyen.TrangThai = reader.GetInt32(2);
                nhomQuyen.Add(nhomquyen);
            }
            CloseConnection();
            return nhomQuyen;
        }
        public bool KiemTraNhomQuyen(string tennhomquyen)
        {
            string sql = "select * from NhomQuyen where TenNhomQuyen=@TenNhomQuyen";
            command = new SqlCommand(sql,connection); 
            command.Parameters.Add("@TenNhomQuyen",SqlDbType.NVarChar).Value= tennhomquyen;
            OpenConnection();
            reader = command.ExecuteReader();
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
