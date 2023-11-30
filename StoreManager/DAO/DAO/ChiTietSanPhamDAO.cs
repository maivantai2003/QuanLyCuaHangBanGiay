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
    public class ChiTietSanPhamDAO:Connection
    {
        public List<ChiTietSanPham> getChiTietSanPham()
        {
            List<ChiTietSanPham> dt = new List<ChiTietSanPham>();
            try
            {
                //string sql = "select * from ChiTietSanPham where TrangThai=1";

                command = new SqlCommand("Select_ChiTietSanPham", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietSanPham sanpham = new ChiTietSanPham();
                    sanpham.MaChiTietSanPham = reader.GetInt32(0);
                    sanpham.MaSanPham = reader.GetInt32(1);
                    sanpham.MaMauSac = reader.GetInt32(2);
                    sanpham.MaKichCo = reader.GetInt32(3);
                    sanpham.HinhAnh = (byte[])reader["HinhAnh"];
                    sanpham.SoLuongNhap = reader.GetInt32(5);
                    sanpham.SoLuongTon = reader.GetInt32(7);

                    dt.Add(sanpham);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public int MaSanPham(int machitietsanpham)
        {
            string sql = "select MaSanPham from ChiTietSanPham where MaChiTietSanPham=@MaChiTietSanPham";
            command=new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChiTietSanPham",SqlDbType.Int).Value=machitietsanpham;
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
        public bool ThemChiTietSanPham(ChiTietSanPham chiTietSanPham)
        {
            string sql = "insert into ChiTietSanPham values(@MaSanPham,@MaMauSac,@MaKichCo,@HinhAnh,@SoLuongNhap,@SoLuongTon,@TrangThai)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = chiTietSanPham.MaSanPham;
            command.Parameters.Add("@MaMauSac", SqlDbType.Int).Value = chiTietSanPham.MaMauSac;
            command.Parameters.Add("@MaKichCo", SqlDbType.Int).Value = chiTietSanPham.MaKichCo;
            command.Parameters.AddWithValue("@HinhAnh", chiTietSanPham.HinhAnh);
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietSanPham.SoLuongNhap;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = chiTietSanPham.SoLuongTon;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = chiTietSanPham.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool KiemTraChiTietSanPham(int MaSanPham, int MaKichCo, int MaMauSac)
        {
            string sql = "select MaChiTietSanPham from ChiTietSanPham where MaSanPham=@MaSanPham and MaKichCo=@MaKichCo and MaMauSac=@MaMauSac";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = MaSanPham;
            command.Parameters.Add("@MaKichCo", SqlDbType.Int).Value = MaKichCo;
            command.Parameters.Add("@MaMauSac", SqlDbType.Int).Value = MaMauSac;
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
        public int MaChiTietSanPham(int MaSanPham, int MaKichCo, int MaMauSac)
        {
            //string sql = "select MaChiTietSanPham from ChiTietSanPham where MaSanPham=@MaSanPham and MaKichCo=@MaKichCo and MaMauSac=@MaMauSac";
            command = new SqlCommand("Select_MaChiTietSanPham", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            command.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = MaSanPham;
            command.Parameters.Add("@MaKichCo", SqlDbType.Int).Value = MaKichCo;
            command.Parameters.Add("@MaMauSac", SqlDbType.Int).Value = MaMauSac;
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
        /*public bool SuaChiTietSanPham(int MaSanPham, int MaKichCo, int MaMauSac)
        {
            string sql = "update ChiTietSanPham set MaMau=@MaMau, MaKichCo=@MaKichCo where MaChiTietSanPham=@MaChiTietSanPham";
            return true;
        }*/
        public List<string> DanhSachChiTietSanPham(int masanpham)
        {
           /* string sql = "SELECT sp.TenSanPham, ms.TenMau, kc.TenKichCo, tl.TenTheLoai, th.TenThuongHieu,cl.TenChatLieu, ctsp.SoLuongTon,ctsp.MaChiTietSanPham FROM ChiTietSanPham ctsp JOIN" +
                " SanPham sp ON ctsp.MaSanPham = sp.MaSanPham " +
                "JOIN ChatLieu cl ON sp.MaChatLieu = cl.MaChatLieu JOIN TheLoai tl ON sp.MaTheLoai = tl.MaTheLoai JOIN ThuongHieu th ON sp.MaThuongHieu = th.MaThuongHieu JOIN MauSac ms ON " +
                "ctsp.MaMauSac = ms.MaMau JOIN KichCo kc ON ctsp.MaKichCo = kc.MaKichCo where sp.MaSanPham=@MaSanPham";*/
            command = new SqlCommand("Select_DanhSachChiTietSanPham", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.Add("@MaSanPham",SqlDbType.Int).Value = masanpham;
            OpenConnection();
            reader = command.ExecuteReader();
            List<string> dt = new List<string>();
            while (reader.Read())
            {
               
                dt.Add(reader.GetString(0) + "," + reader.GetString(1) + "," + reader.GetString(2) + "," + reader.GetString(3) + "," + reader.GetString(4) + "," + reader.GetString(5) + ","+reader.GetInt32(6)+","+reader.GetInt32(7));
            }
            CloseConnection();
            return dt;
        }
        public bool CapNhatCTSoLuongNhap(int machitietsp, int soluongnhap)
        {
            string sql = "update ChiTietSanPham set SoLuongNhap=@SoLuongNhap where MaChiTietSanPham=@MaChiTietSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = machitietsp;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = soluongnhap;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool CapNhatCTSoLuongTon(int machitietsp, int soluongton)
        {
            string sql = "update ChiTietSanPham set SoLuongTon=@SoLuongTon where MaChiTietSanPham=@MaChiTietSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = machitietsp;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = soluongton;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public int SoLuongCTNhap(int machitietsp)
        {
            string sql = "select SoLuongNhap from ChiTietSanPham where MaChiTietSanPham=@MaChiTietSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChiTietSanPham",SqlDbType.Int).Value=machitietsp;
            OpenConnection();
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
        public int SoLuongCTTon(int machitietsp)
        {
            string sql = "select SoLuongTon from ChiTietSanPham where MaChiTietSanPham=@MaChiTietSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = machitietsp;
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
        public byte[] HinhAnh(int MaChiTietSanPham)
        {
            string sql = "select HinhAnh from ChiTietSanPham where MaChiTietSanPham=@MaChiTietSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChiTietSanPham",SqlDbType.Int).Value=MaChiTietSanPham;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                byte[] s = (byte[])reader[0];
                CloseConnection();
                return s;
            }
            CloseConnection();
            return null;
        }
    }
}
