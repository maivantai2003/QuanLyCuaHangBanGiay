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
    public class PhieuNhapDAO:Connection
    {
        public List<PhieuNhap> getPhieuNhap()
        {
            List<PhieuNhap> dt = new List<PhieuNhap>();
            try
            {
                /*string sql = "select * from PhieuNhap";*/
                command = new SqlCommand("Select_PhieuNhap", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap phieuNhap = new PhieuNhap();
                    phieuNhap.MaPhieuNhap = reader.GetInt32(0);
                    phieuNhap.MaNhaCungCap = reader.GetInt32(1);
                    phieuNhap.MaNhanVien = reader.GetInt32(2);
                    phieuNhap.NgayNhap = Convert.ToDateTime(reader.GetDateTime(3));
                    phieuNhap.TenPhieuNhap = reader.GetString(4);
                    double tongtiennhap = reader.GetDouble(5);
                    phieuNhap.TongTienNhap = Convert.ToSingle(tongtiennhap);
                    phieuNhap.TrangThai = reader.GetInt32(6);
                    dt.Add(phieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public bool ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            string sql = "insert into PhieuNhap values(@MaPhieuNhap,@MaNhaCungCap,@MaNhanVien,@NgayNhap,@TenPhieuNhap,@TongTienNhap,@TrangThai)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = phieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.Int).Value = phieuNhap.MaNhaCungCap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieuNhap.MaNhanVien;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = phieuNhap.NgayNhap;
            command.Parameters.Add("@TenPhieuNhap", SqlDbType.NVarChar).Value = phieuNhap.TenPhieuNhap;
            command.Parameters.Add("@TongTienNhap", SqlDbType.Float).Value = phieuNhap.TongTienNhap;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = phieuNhap.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public int KhoaLonNhat()
        {
            string sql = "select Max(MaPhieuNhap) from PhieuNhap";
            OpenConnection();
            command = new SqlCommand(sql, connection);
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
        public bool SuaPhieuNhap(PhieuNhap phieuNhap)
        {
            string sql = "update PhieuNhap set MaNhaCungCap=@MaNhaCungCap,MaNhanVien=@MaNhanVien,NgayNhap=@NgayNhap,TenPhieuNhap=@TenPhieuNhap,TongTienNhap=@TongTienNhap where MaPhieuNhap=@MaPhieuNhap";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaPhieuNhap",SqlDbType.Int).Value=phieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.Int).Value = phieuNhap.MaNhaCungCap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieuNhap.MaNhanVien;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = phieuNhap.NgayNhap;
            command.Parameters.Add("@TenPhieuNhap", SqlDbType.NVarChar).Value = phieuNhap.TenPhieuNhap;
            command.Parameters.Add("@TongTienNhap", SqlDbType.Float).Value = phieuNhap.TongTienNhap;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = phieuNhap.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool XoaPhieuNhap(int maphieunhap)
        {
            string sql = "update PhieuNhap set TrangThai=0 where MaPhieuNhap=@MaPhieuNhap";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = maphieunhap;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public List<string> DanhSachSanPhamNhap()
        {
            /*string sql = "SELECT SanPham.MaSanPham,SanPham.TenSanPham, MauSac.TenMau, KichCo.TenKichCo, SanPham.GiaNhap FROM SanPham " +
                "JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham JOIN MauSac ON ChiTietSanPham.MaMauSac = MauSac.MaMau " +
                "JOIN KichCo ON ChiTietSanPham.MaKichCo = KichCo.MaKichCo";*/
            command = new SqlCommand("Select_DanhSachSanPham", connection) {
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            reader = command.ExecuteReader();
            List<string> dt = new List<string>();
            while (reader.Read())
            {
                dt.Add(reader.GetInt32(0)+","+ reader.GetString(1) + "," +reader.GetString(2) + "," + reader.GetString(3) +","+reader.GetDouble(4));
            }
            CloseConnection();
            return dt;
        }
        public PhieuNhap LayPhieuNhap(int maphieunhap)
        {
            string sql = "select MaPhieuNhap,MaNhanVien,NgayNhap,MaNhaCungCap,TongTienNhap from PhieuNhap where MaPhieuNhap=@MaPhieuNhap";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = maphieunhap;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MaPhieuNhap=reader.GetInt32(0);
                phieuNhap.MaNhanVien=reader.GetInt32(1);
                phieuNhap.NgayNhap=reader.GetDateTime(2);
                phieuNhap.MaNhaCungCap = reader.GetInt32(3);
                double TongTienNhap=reader.GetDouble(4);
                phieuNhap.TongTienNhap=Convert.ToSingle(TongTienNhap);
                CloseConnection();
                return phieuNhap;
            }
            CloseConnection();
            return null;
        }
        public List<PhieuNhap> TimKiemPhieuNhap(string text)
        {
            List<PhieuNhap> arrayphieunhap = new List<PhieuNhap>();
            string sql = "select MaPhieuNhap, PhieuNhap.MaNhaCungCap,PhieuNhap.MaNhanVien, NgayNhap, TenPhieuNhap, TongTienNhap, PhieuNhap.TrangThai from PhieuNhap " +
                "join NhanVien on NhanVien.MaNhanVien=PhieuNhap.MaNhanVien " +
                "join NhaCungCap on NhaCungCap.MaNhaCungCap=PhieuNhap.MaNhaCungCap " +
                "where concat(MaPhieuNhap, PhieuNhap.MaNhaCungCap,PhieuNhap.MaNhanVien, NgayNhap, TenPhieuNhap, TongTienNhap,NhanVien.TenNhanVien,NhaCungCap.TenNhaCungCap)COLLATE Latin1_General_CI_AI like '%" + text + "%' and PhieuNhap.TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                double ttt;
                PhieuNhap phieunhap = new PhieuNhap();
                phieunhap.MaPhieuNhap = reader.GetInt32(0);
                phieunhap.MaNhaCungCap = reader.GetInt32(1);
                phieunhap.MaNhanVien = reader.GetInt32(2);
                phieunhap.NgayNhap = reader.GetDateTime(3);
                phieunhap.TenPhieuNhap = reader.GetString(4);
                ttt = reader.GetDouble(5);
                phieunhap.TongTienNhap = Convert.ToSingle(ttt);
                phieunhap.TrangThai = reader.GetInt32(6);
                arrayphieunhap.Add(phieunhap);
            }
            CloseConnection();
            return arrayphieunhap;
        }
    }
}
