using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class KhachHangDAO:Connection
    {
        public List<KhachHang> getKhachHang()
        {
            List<KhachHang> dt=new List<KhachHang>();
            //string sql = "select * from KhachHang";
            command = new SqlCommand("Select_KhachHang", connection) { 
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            reader= command.ExecuteReader(); 
            while(reader.Read()) { 
                KhachHang khachhang=new KhachHang();
                khachhang.MaKhachHang = reader.GetInt32(0);
                khachhang.TenKhachHang=reader.GetString(1);
                khachhang.Tuoi = reader.GetInt32(2);
                khachhang.SoDienThoai=reader.GetString(3);
                khachhang.DiaChi = reader.GetString(4);
                khachhang.TrangThai = reader.GetInt32(5);
                dt.Add(khachhang);
            }
            CloseConnection();
            return dt;
        }
        public List<KhachHang> TimKiemKhachHang(string text)
        {
            List<KhachHang> dt = new List<KhachHang>();
            string sql = "select * from KhachHang where concat(MaKhachHang,TenKhachHang,Tuoi,SoDienThoai,DiaChi) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                KhachHang khachhang = new KhachHang();
                khachhang.MaKhachHang = reader.GetInt32(0);
                khachhang.TenKhachHang = reader.GetString(1);
                khachhang.Tuoi = reader.GetInt32(2);
                khachhang.SoDienThoai = reader.GetString(3);
                khachhang.DiaChi = reader.GetString(4);
                khachhang.TrangThai = reader.GetInt32(5);
                dt.Add(khachhang);
            }
            CloseConnection();
            return dt;
        }
        public bool ThemKhachHang(KhachHang khachhang)
        {
            string sql = "insert into KhachHang values(@MaKhachHang,@TenKhachHang,@Tuoi,@SoDienThoai,@DiaChi,@TrangThai)";
            command = new SqlCommand(sql,connection);
            command.Parameters.Add("@MaKhachHang",SqlDbType.Int).Value=khachhang.MaKhachHang;
            command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = khachhang.TenKhachHang;
            command.Parameters.Add("@Tuoi",SqlDbType.Int).Value = khachhang.Tuoi;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachhang.DiaChi;
            command.Parameters.Add("@SoDienThoai",SqlDbType.NVarChar).Value=khachhang.SoDienThoai;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = khachhang.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;   
        }
        public bool KiemTraSoDienThoai(string sodienthoai)
        {
            string sql = "select MaKhachHang from KhachHang where SoDienThoai=@SoDienThoai";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@SoDienThoai",SqlDbType.NVarChar).Value =sodienthoai;
            reader=command.ExecuteReader();
            if(reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;   
        }
        public int MaKhachHang(string sodienthoai)
        {
            string sql = "select MaKhachHang from KhachHang where SoDienThoai=@SoDienThoai";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = sodienthoai;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                int tmp=reader.GetInt32(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return 0;
        }
        public KhachHang LayKhachHang(int makhachhang)
        {
            string sql = "select * from KhachHang where MaKhachHang=@MaKhachHang";
            OpenConnection();
            command= new SqlCommand(sql, connection); 
            command.Parameters.Add("@MaKhachHang",SqlDbType.Int).Value=makhachhang;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                KhachHang khachHang=new KhachHang();
                khachHang.TenKhachHang=reader.GetString(1);
                khachHang.SoDienThoai = reader.GetString(3);
                CloseConnection();
                return khachHang;
            }
            CloseConnection();
            return null;
        }
        public KhachHang ThongTinKhachHang(string sodienthoai)
        {
            string sql = "select * from KhachHang where SoDienThoai=@SoDienThoai";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = sodienthoai;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                KhachHang khachHang = new KhachHang();
                khachHang.TenKhachHang = reader.GetString(1);
                khachHang.Tuoi = reader.GetInt32(2);
                CloseConnection();
                return khachHang;
            }
            CloseConnection();
            return null;
        }

    }
}
