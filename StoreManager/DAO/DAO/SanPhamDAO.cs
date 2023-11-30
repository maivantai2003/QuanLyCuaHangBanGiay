using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
namespace DAO
{
    public class SanPhamDAO:Connection
    {
        public List<SanPham> getSanPham()
        {
            List<SanPham> dt = new List<SanPham>();
            try
            {
                /*string sql = "select * from SanPham";*/
                command = new SqlCommand("Select_SanPham", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.MaSanPham = reader.GetInt32(0);
                    sanPham.MaThuongHieu = reader.GetInt32(1);
                    sanPham.MaTheLoai = reader.GetInt32(2);
                    sanPham.MaChatLieu = reader.GetInt32(3);
                    sanPham.TenSanPham = reader.GetString(4);
                    double giasanpham = reader.GetDouble(5);
                    double gianhap = reader.GetDouble(6);
                    sanPham.GiaSanPham = Convert.ToSingle(giasanpham);
                    sanPham.GiaNhap = Convert.ToSingle(gianhap);
                    sanPham.SoLuongNhap = reader.GetInt32(7);
                    sanPham.SoLuongTon = reader.GetInt32(8);
                    sanPham.TrangThai = reader.GetInt32(9);
                    dt.Add(sanPham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public int KhoaLonNhat()
        {
            string sql = "select Max(MaSanPham) from SanPham";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                int tmp=reader.GetInt32(0);
                CloseConnection();
                return tmp; 
            }
            CloseConnection();
            return 0;
        }
        public bool ThemSanPham(SanPham sanPham)
        {
            string sql = "INSERT INTO SanPham VALUES(@MaSanPham,@maThuongHieu, @maTheLoai, @maChatLieu, @tenSanPham, @giaSanPham, @giaNhap, @soLuongNhap,@soLuongTon, @trangThai)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = sanPham.MaSanPham;
            command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = sanPham.MaThuongHieu;
            command.Parameters.Add("@maTheLoai", SqlDbType.Int).Value = sanPham.MaTheLoai;
            command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = sanPham.MaChatLieu;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
            command.Parameters.Add("@giaSanPham", SqlDbType.Float).Value = sanPham.GiaSanPham;
            command.Parameters.Add("@giaNhap", SqlDbType.Float).Value = sanPham.GiaNhap;
            command.Parameters.Add("@soLuongNhap", SqlDbType.Int).Value = sanPham.SoLuongNhap;
            command.Parameters.Add("@soLuongTon", SqlDbType.Int).Value = sanPham.SoLuongTon;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = sanPham.TrangThai;
            OpenConnection();
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public bool SuaSanPham(SanPham sanPham)
        {
            string sql = "update SanPham set MaThuongHieu=@maThuongHieu, MaTheLoai=@maTheLoai, MaChatLieu=@maChatLieu,TenSanPham= @tenSanPham, GiaSanPham=@giaSanPham where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = sanPham.MaSanPham;
            command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = sanPham.MaThuongHieu;
            command.Parameters.Add("@maTheLoai", SqlDbType.Int).Value = sanPham.MaTheLoai;
            command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = sanPham.MaChatLieu;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
            command.Parameters.Add("@giaSanPham", SqlDbType.Float).Value = sanPham.GiaSanPham;
            OpenConnection();
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public string TenSanPham(int MaSanPham)
        {
            string sql = "select TenSanPham from SanPham where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = MaSanPham;
            OpenConnection();
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
        public int MaSanPham(string tensanpham)
        {
            string sql = "select MaSanPham from SanPham where TenSanPham=@TenSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = tensanpham;
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
        public float GiaNhap(int MaSanPham)
        {
            string sql = "select GiaNhap from Sanpham where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = MaSanPham;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                double tmp = reader.GetDouble(0);
                CloseConnection();
                float gianhap = Convert.ToSingle(tmp);
                return gianhap;
            }
            CloseConnection();
            return 0f;
        }
        public bool XoaSanPham(int masanpham)
        {
            string sql = "update SanPham set TrangThai=0 where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham",SqlDbType.Int).Value = masanpham;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public List<SanPham> TimKiemSanPham(string text)
        {
            List<SanPham> arraysanpham = new List<SanPham>();
            //string sql = "select * from SanPham where concat(MaSanPham,MaThuongHieu,MaTheLoai,MaChatLieu,TenSanPham,GiaSanPham,GiaNhap,SoLuongNhap,SoLuongTon) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            string sql = "select MaSanPham,ThuongHieu.MaThuongHieu,TheLoai.MaTheLoai,ChatLieu.MaChatLieu,TenSanPham,GiaSanPham,GiaNhap,SoLuongNhap,SoLuongTon,SanPham.TrangThai from SanPham join TheLoai " +
                "on TheLoai.MaTheLoai=SanPham.MaTheLoai join ThuongHieu on ThuongHieu.MaThuongHieu=SanPham.MaThuongHieu join ChatLieu on ChatLieu.MaChatLieu=SanPham.MaChatLieu " +
                "where CONCAT(MaSanPham,ThuongHieu.MaThuongHieu,TheLoai.MaTheLoai,ChatLieu.MaChatLieu,TenSanPham,GiaSanPham,GiaNhap,SoLuongNhap,SoLuongTon,ThuongHieu.TenThuongHieu,TheLoai.TenTheLoai,ChatLieu.TenChatLieu)COLLATE Latin1_General_CI_AI like '%"+text+"%' and SanPham.TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double gsp, gn;
                SanPham sanpham = new SanPham();
                sanpham.MaSanPham = reader.GetInt32(0);
                sanpham.MaThuongHieu = reader.GetInt32(1);
                sanpham.MaTheLoai = reader.GetInt32(2);
                sanpham.MaChatLieu = reader.GetInt32(3);
                sanpham.TenSanPham = reader.GetString(4);
                gsp = reader.GetDouble(5);
                sanpham.GiaSanPham = Convert.ToSingle(gsp);
                gn = reader.GetDouble(6);
                sanpham.GiaNhap = Convert.ToSingle(gn);
                sanpham.SoLuongNhap = reader.GetInt32(7);
                sanpham.SoLuongTon = reader.GetInt32(8);
                sanpham.TrangThai = reader.GetInt32(9);
                arraysanpham.Add(sanpham);
            }
            CloseConnection();
            return arraysanpham;
        }
        public bool CapNhatSoLuongNhap(int msp,int soluongnhap)
        {
            string sql = "update SanPham set SoLuongNhap=@SoLuongNhap where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = msp;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = soluongnhap;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;   
        }
        public bool CapNhatSoLuongTon(int msp, int soluongton)
        {
            string sql = "update SanPham set SoLuongTon=@SoLuongTon where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = msp;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = soluongton;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public int SoLuongNhap(int msp)
        {
            string sql = "select SoLuongNhap from SanPham  where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = msp;
            OpenConnection();
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                int tmp=reader.GetInt32(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return 0;
        }
        public int SoLuongTon(int msp)
        {
            string sql = "select SoLuongTon from SanPham  where MaSanPham=@MaSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = msp;
            OpenConnection();
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                int tmp = reader.GetInt32(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return 0;
        }
    }
}
