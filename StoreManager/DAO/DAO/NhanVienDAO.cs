using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO:Connection
    {
        public List<NhanVien> getNhanVien()
        {
            List<NhanVien> dt = new List<NhanVien>();
            try
            {
                //string sql = "select * from NhanVien where TrangThai=1";
                command = new SqlCommand("Select_NhanVien", connection)
                {
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNhanVien = reader.GetInt32(0);
                    nhanVien.TenNhanVien = reader.GetString(1);
                    nhanVien.Tuoi = reader.GetInt32(2);
                    nhanVien.SoDienThoai = reader.GetString(3);
                    nhanVien.HinhAnh = (byte[])reader["HinhAnh"];
                    nhanVien.TrangThai = reader.GetInt32(5);
                    dt.Add(nhanVien);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public bool ThemNhanVien(NhanVien nhanVien)
        {
            string sql = "insert into NhanVien values(@TenNhanVien,@Tuoi,@SoDienThoai,@HinhAnh,@TrangThai)";
            command=new SqlCommand(sql, connection);
            command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = nhanVien.TenNhanVien;
            command.Parameters.Add("@Tuoi",SqlDbType.Int).Value=nhanVien.Tuoi;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = nhanVien.SoDienThoai;
            command.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
            command.Parameters.Add("@TrangThai",SqlDbType.Int).Value=nhanVien.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;   
        }
        public bool SuaNhanVien(NhanVien nhanVien)
        {
            string sql = "update NhanVien set TenNhanVien=@TenNhanVien,Tuoi=@Tuoi,SoDienThoai=@SoDienThoai,HinhAnh=@HinhAnh where MaNhanVien=@MaNhanVien";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = nhanVien.MaNhanVien;
            command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = nhanVien.TenNhanVien;
            command.Parameters.Add("@Tuoi", SqlDbType.Int).Value = nhanVien.Tuoi;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = nhanVien.SoDienThoai;
            command.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = nhanVien.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool XoaNhanVien(int MaNhanVien)
        {
            string sql = "update NhanVien set TrangThai=0 where MaNhanVien=@MaNhanVien";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = MaNhanVien;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public string TenNhanVien(int manhanvien)
        {
            string sql = "select TenNhanVien from NhanVien where MaNhanVien=@MaNhanVien";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = manhanvien;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(0);
                CloseConnection();
                return name;
            }
            CloseConnection();
            return "";
        }
        public int MaNhanVien(string tennhanvien)
        {
            string sql = "select MaNhanvien where TenNhanVien=@tennhanvien";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@tennhanvien", SqlDbType.NVarChar).Value = tennhanvien;
            OpenConnection();
            command.ExecuteNonQuery();
            if (reader.Read())
            {
                int tmp = reader.GetInt32(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return 0;
        }
        public List<NhanVien> TimKiemNhanVien(string text)
        {
            List<NhanVien> dt = new List<NhanVien>();
            string sql = "select * from NhanVien where concat(MaNhanVien,TenNhanVien,Tuoi,SoDienThoai) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader=command.ExecuteReader();
            while(reader.Read()) { 
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = reader.GetInt32(0);
                nhanVien.TenNhanVien = reader.GetString(1);
                nhanVien.Tuoi = reader.GetInt32(2);
                nhanVien.SoDienThoai=reader.GetString(3);
                nhanVien.HinhAnh = (byte[])reader["HinhAnh"];
                nhanVien.TrangThai = reader.GetInt32(5);
                dt.Add(nhanVien);
            }
            CloseConnection();
            return dt;  
        }
    }
}
