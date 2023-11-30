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
    public class NhaCungCapDAO:Connection
    {
        public List<NhaCungCap> getNhaCungCap()
        {
            List<NhaCungCap> dt=new List<NhaCungCap> ();
            //string sql = "select * from NhaCungCap where TrangThai=1";
            command=new SqlCommand("Select_NhaCungCap", connection) { 
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            reader=command.ExecuteReader();
            while (reader.Read())
            {
                NhaCungCap nhancungcap=new NhaCungCap();
                nhancungcap.MaNhaCungCap = reader.GetInt32(0);
                nhancungcap.TenNhaCungCap = reader.GetString(1);
                nhancungcap.DiaChi=reader.GetString(2);
                nhancungcap.SoDienThoai=reader.GetString(3);
                nhancungcap.TrangThai = reader.GetInt32(4);
                dt.Add(nhancungcap);
            }
            CloseConnection();
            return dt;
        }
        public bool ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO NhaCungCap VALUES(@tenNhaCungCap, @diaChi, @soDienThoai, @trangThai)";
            command.Connection = connection;
            command.Parameters.Add("@tenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNhaCungCap;
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
            command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = nhaCungCap.SoDienThoai;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = nhaCungCap.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        public bool SuaThongTinNhaCungCap(NhaCungCap nhaCungCap)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE NhaCungCap SET TenNhaCungCap = @tenNhaCungCap, DiaChi = @diaChi, SoDienThoai = @soDienThoai WHERE MaNhaCungCap = @maNhaCungCap";
                command.Connection = connection;
                command.Parameters.Add("@tenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNhaCungCap;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
                command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = nhaCungCap.SoDienThoai;
                command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = nhaCungCap.MaNhaCungCap;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ketQua > 0;
        }

        public bool XoaNhaCungCap(int manhacungcap)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE NhaCungCap set TrangThai=0 WHERE MaNhaCungCap = @maNhaCungCap";
            command.Connection = connection;
            command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = manhacungcap;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public string TenNhaCungCap(int manhacungcap)
        {
            string sql = "select TenNhaCungCap from NhaCungCap where MaNhaCungCap=@MaNhaCungCap";
            command = new SqlCommand(sql,connection);
            command.Parameters.Add("@MaNhaCungCap",SqlDbType.Int).Value=manhacungcap;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string tmp =reader.GetString(0);
                CloseConnection();
                return tmp; 
            }
            CloseConnection();
            return "";
        }
        public int MaNhaCungCap(string tennhacungcap)
        {
            string sql = "select MaNhaCungCap from NhaCungCap where TenNhaCungCap=@TenNhaCungCap";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = tennhacungcap;
            OpenConnection();
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
        public bool KiemTraNhaCungCap(string tennhacungcap,string sodienthoai)
        {
            string sql = "select MaNhaCungCap from NhaCungCap where TenNhaCungCap=@TenNhaCungCap or SoDienThoai=@SoDienThoai and TrangThai=1";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = tennhacungcap;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = sodienthoai;
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
        public List<NhaCungCap> TimKiemNhaCungCap(string text)
        {
            List<NhaCungCap> arraynhacungcap = new List<NhaCungCap>();
            string sql = "select * from NhaCungCap where concat(MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai) COLLATE Latin1_General_CI_AI like '%" + text + "%' and TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhaCungCap nhacungcap = new NhaCungCap();
                nhacungcap.MaNhaCungCap = reader.GetInt32(0);
                nhacungcap.TenNhaCungCap = reader.GetString(1);
                nhacungcap.DiaChi = reader.GetString(2);
                nhacungcap.SoDienThoai = reader.GetString(3);
                nhacungcap.TrangThai = reader.GetInt32(4);
                arraynhacungcap.Add(nhacungcap);
            }
            CloseConnection();
            return arraynhacungcap;
        }
       
    }
}
