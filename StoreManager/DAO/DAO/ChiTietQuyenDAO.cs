using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
namespace DAO
{
    public class ChiTietQuyenDAO:Connection
    {
        public List<ChiTietQuyen> getChiTietQuyen()
        {
            List<ChiTietQuyen> dt = new List<ChiTietQuyen>();
            try
            {
                //string sql = "select * from ChiTietQuyen";
                command = new SqlCommand("Select_ChiTietQuyen", connection) { 
                    CommandType = CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietQuyen chitiet = new ChiTietQuyen();
                    chitiet.Id = reader.GetInt32(0);
                    chitiet.MaNhomQuyen = reader.GetInt32(1);
                    chitiet.MaChucNang = reader.GetInt32(2);
                    chitiet.HanhDong = reader.GetString(3);
                    dt.Add(chitiet);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public bool ThemChiTietQuyen(ChiTietQuyen chiTietQuyen)
        {
            string sql = "insert into ChiTietQuyen values(@MaNhomQuyen,@MaChucNang,@HanhDong)";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = chiTietQuyen.MaNhomQuyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = chiTietQuyen.MaChucNang;
            command.Parameters.Add("@HanhDong", SqlDbType.NVarChar).Value = chiTietQuyen.HanhDong;
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public string ChucNang(int MaNhomQuyen)
        {
            string sql = "select distinct MaChucNang from ChiTietQuyen where MaNhomQuyen=@MaNhomQuyen";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = MaNhomQuyen;
            OpenConnection();
            string s = "";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                s += reader.GetInt32(0) + ",";
            }
            if (s == "")
            {
                CloseConnection();
                return "";
            }
            else
            {
                CloseConnection();
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
        public string HanhDong(int MaNhomQuyen, int MaChucNang)
        {
            string sql = "select HanhDong from ChiTietQuyen where MaNhomQuyen=@MaNhomQuyen and MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = MaNhomQuyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = MaChucNang;
            reader = command.ExecuteReader();
            string s = "";
            while (reader.Read())
            {
                s += reader.GetString(0) + ",";
            }
            s = s.Substring(0, s.Length - 1);
            CloseConnection();
            return s;
        }
        public bool kiemTraHanhDong(int manhomquyen, int machucnang, string HanhDong)
        {
            string sql = "select * from ChiTietQuyen where MaNhomQuyen=@MaNhomQuyen and MaChucNang=@MaChucNang and HanhDong=@HanhDong";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = manhomquyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = machucnang;
            command.Parameters.Add("@HanhDong", SqlDbType.NVarChar).Value = HanhDong;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
        public bool XoaChiTietQuyen(int MaNhomQuyen,int MaChucNang,string HanhDong)
        {
            string sql = "delete ChiTietQuyen where MaNhomQuyen=@MaNhomQuyen and MaChucNang=@MaChucNang and HanhDong=@HanhDong";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value=MaNhomQuyen;
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = MaChucNang;
            command.Parameters.Add("@HanhDong",SqlDbType.NVarChar).Value=HanhDong;  
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;   
        }
        public List<ChiTietQuyen> TimKiemChiTietQuyen(string text)
        {
            List<ChiTietQuyen> dt = new List<ChiTietQuyen>();
            string sql = "select ChiTietQuyen.Id,ChiTietQuyen.MaNhomQuyen,ChiTietQuyen.MaChucNang,ChiTietQuyen.HanhDong from ChiTietQuyen join ChucNang on " +
                "ChiTietQuyen.MaChucNang=ChucNang.MaChucNang join NhomQuyen on ChiTietQuyen.MaNhomQuyen=NhomQuyen.MaNhomQuyen " +
                "where concat(ChiTietQuyen.MaNhomQuyen,ChiTietQuyen.MaChucNang,ChiTietQuyen.HanhDong,ChucNang.TenChucNang,NhomQuyen.TenNhomQuyen) " +
                "like '%"+text+"%' and ChucNang.TrangThai=1 and NhomQuyen.TrangThai=1";
            OpenConnection();
            command=new SqlCommand(sql, connection);
            reader = command.ExecuteReader();   
            while(reader.Read())
            {
                ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
                chiTietQuyen.MaNhomQuyen = reader.GetInt32(1);
                chiTietQuyen.MaChucNang=reader.GetInt32(2);
                chiTietQuyen.HanhDong = reader.GetString(3);
                dt.Add(chiTietQuyen);
            }
            CloseConnection();  
            return dt;
        }
    }
}
