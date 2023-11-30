using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO:Connection
    {
        public bool ThemHoaDon(HoaDon hd)
        {
            OpenConnection();
            string sql = "insert into HoaDon values(@MaHoaDon,@MaKhachHang,@MaNhanVien,@MaKhuyenMai,@MaThue,@TenHoaDon,@NgayLap," +
                "@TongTien,@TongTienKhuyenMai,@TongTienThue,@HinhThucThanhToan,@ThanhTien,@TrangThai)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hd.MaHoaDon ;
            command.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = hd.MaKhachHang;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = hd.MaNhanVien;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.Int).Value = hd.MaKhuyenMai;
            command.Parameters.Add("@MaThue", SqlDbType.Int).Value = hd.MaThue;
            command.Parameters.Add("@NgayLap",SqlDbType.DateTime).Value = hd.NgayLapHoaDon; 
            command.Parameters.Add("@TenHoaDon", SqlDbType.NVarChar).Value = hd.TenHoaDon;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TongTien;
            command.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar).Value = hd.HinhThucThanhToan;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = hd.ThanhTien;
            command.Parameters.Add("@TongTienThue", SqlDbType.Float).Value=hd.TongTienThue;
            command.Parameters.Add("@TongTienKhuyenMai", SqlDbType.Float).Value = hd.TongTienKhuyenMai;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = hd.TrangThai;
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n>0;
        }

        public List<HoaDon> getHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            //string sql = "select * from HoaDon where TrangThai = 1";
            command = new SqlCommand("Select_HoaDon", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            OpenConnection();
            reader=command.ExecuteReader();
                while (reader.Read())
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaKhachHang = reader.GetInt32(1);
                    hd.MaNhanVien = reader.GetInt32(2);
                    hd.MaKhuyenMai = reader.GetInt32(3);
                    hd.MaThue = reader.GetInt32(4);
                    hd.TenHoaDon = reader.GetString(5);
                    hd.NgayLapHoaDon = reader.GetDateTime(6);
                    hd.TongTien = Convert.ToSingle(reader.GetDouble(7));
                    hd.HinhThucThanhToan = reader.GetString(10);
                    hd.ThanhTien = Convert.ToSingle(reader.GetDouble(11));
                    list.Add(hd);
                }
            CloseConnection();
            return list;
        }
        public List<string> DanhSachSanPham()
        { 
            List<string> list = new List<string>();
            /*string sql = "SELECT SanPham.MaSanPham, TenSanPham, TheLoai.TenTheLoai, ChatLieu.TenChatLieu, ThuongHieu.TenThuongHieu, MauSac.TenMau, KichCo.TenKichCo, SanPham.GiaSanPham,ChiTietSanPham.SoLuongTon,ChiTietSanPham.MaChiTietSanPham FROM SanPham " +
                "JOIN ChatLieu ON SanPham.MaChatLieu = ChatLieu.MaChatLieu JOIN TheLoai ON SanPham.MaTheLoai = TheLoai.MaTheLoai " +
                "JOIN ThuongHieu ON SanPham.MaThuongHieu = ThuongHieu.MaThuongHieu JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham " +
                "JOIN MauSac ON ChiTietSanPham.MaMauSac = MauSac.MaMau JOIN KichCo ON ChiTietSanPham.MaKichCo = KichCo.MaKichCo where SanPham.GiaSanPham>0 and ChiTietSanPham.SoLuongTon>0";*/
            command=new SqlCommand("Select_DanhSachSanPhamBan", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            OpenConnection();
            reader = command.ExecuteReader(); 
            while (reader.Read())
            {
                list.Add(reader.GetInt32(0) + "," + reader.GetString(1) + ","+reader.GetString(2)+"," + reader.GetString(3)+"," 
                    + reader.GetString(4)+"," + reader.GetString(5)+","+reader.GetString(6) + ","
                    + reader.GetDouble(7) +  "," + reader.GetInt32(8)+","+reader.GetInt32(9));
            }
            CloseConnection();
            return list;
        } 
        public bool CapNhatHoaDon(HoaDon hoadon)
        {
            string sql = "update HoaDon set MaKhuyenMai=@MaKhuyenMai, MaThue=@MaThue,TongTienThue=@TongTienThue,TongTienKhuyenMai=@TongTienKhuyenMai,HinhThucThanhToan=@HinhThucThanhToan,TongTien=@TongTien,ThanhTien=@ThanhTien where MaHoaDon=@MaHoaDon";
            command=new SqlCommand(sql,connection);
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = hoadon.MaHoaDon ;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.Int).Value = hoadon.MaKhuyenMai;
            command.Parameters.Add("@MaThue", SqlDbType.Int).Value = hoadon.MaThue;
            command.Parameters.Add("@TongTienThue", SqlDbType.Float).Value = hoadon.TongTienThue;
            command.Parameters.Add("@TongKhuyenMai", SqlDbType.Float).Value = hoadon.TongTienKhuyenMai;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = hoadon.TongTien;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = hoadon.ThanhTien;
            command.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar).Value = hoadon.HinhThucThanhToan;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public DateTime NgayMua(int mahoadon)
        {
            string sql = "select NgayLapHoaDon from HoaDon where MaHoaDon=@MaHoaDon";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaHoaDon",SqlDbType.Int).Value=mahoadon;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                DateTime tmp = reader.GetDateTime(0);
                CloseConnection(); 
                return tmp;
            }
            CloseConnection();
            return new DateTime();
            
        }
        public HoaDon LayHoaDon(int mahoadon)
        {
            string sql = "select * from HoaDon where MaHoaDon=@MaHoaDon";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaHoaDon",SqlDbType.Int).Value = mahoadon;
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                HoaDon hoadon=new HoaDon();
                hoadon.MaHoaDon = reader.GetInt32(0);
                hoadon.MaKhachHang=reader.GetInt32(1);
                hoadon.MaNhanVien=reader.GetInt32(2);
                hoadon.MaKhuyenMai = reader.GetInt32(3);
                hoadon.MaThue=reader.GetInt32(4);
                hoadon.TenHoaDon=reader.GetString(5);
                hoadon.NgayLapHoaDon=reader.GetDateTime(6);
                double tongtien=reader.GetDouble(7);
                hoadon.TongTien = Convert.ToSingle(tongtien);
                double tienkhuyenmai=reader.GetDouble(8);
                hoadon.TongTienKhuyenMai=Convert.ToSingle(tienkhuyenmai);
                double tienthue=reader.GetDouble(9);
                hoadon.TongTienThue=Convert.ToSingle(tienthue);
                hoadon.HinhThucThanhToan = reader.GetString(10);
                double thanhtien=reader.GetDouble(11);
                hoadon.ThanhTien=Convert.ToSingle(thanhtien);
                CloseConnection();
                return hoadon;
            }
            CloseConnection();
            return null;
        }
        public List<HoaDon> TimKiemHoaDon(string text)
        {
            List<HoaDon> dt = new List<HoaDon>();
            string sql = "select MaHoaDon,KhachHang.MaKhachHang,NhanVien.MaNhanVien,KhuyenMai.MaKhuyenMai,Thue.MaThue,HoaDon.TenHoaDon,HoaDon.NgayLapHoaDon,HoaDon.TongTien,HoaDon.TongTienKhuyenMai,HoaDon.TongTienThue,HoaDon.HinhThucThanhToan,HoaDon.ThanhTien,HoaDon.TrangThai " +
                "from HoaDon join KhuyenMai on HoaDon.MaKhuyenMai=KhuyenMai.MaKhuyenMai join Thue on Thue.MaThue=HoaDon.MaThue join NhanVien on NhanVien.MaNhanVien=HoaDon.MaNhanVien " +
                "join KhachHang on KhachHang.MaKhachHang=HoaDon.MaKhachHang " +
                "where CONCAT(MaHoaDon,KhachHang.MaKhachHang,NhanVien.MaNhanVien,KhuyenMai.MaKhuyenMai,Thue.MaThue,HoaDon.TenHoaDon,HoaDon.NgayLapHoaDon,HoaDon.TongTien,HoaDon.TongTienKhuyenMai,HoaDon.TongTienThue,HoaDon.HinhThucThanhToan,HoaDon.ThanhTien,HoaDon.TrangThai) " +
                "COLLATE Latin1_General_CI_AI like '%"+text+"%' and HoaDon.TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader=command.ExecuteReader();
            while (reader.Read())
            {
                HoaDon hoadon = new HoaDon();
                hoadon.MaHoaDon = reader.GetInt32(0);
                hoadon.MaKhachHang = reader.GetInt32(1);
                hoadon.MaNhanVien = reader.GetInt32(2);
                hoadon.MaKhuyenMai = reader.GetInt32(3);
                hoadon.MaThue = reader.GetInt32(4);
                hoadon.TenHoaDon = reader.GetString(5);
                hoadon.NgayLapHoaDon = reader.GetDateTime(6);
                double tongtien = reader.GetDouble(7);
                hoadon.TongTien = Convert.ToSingle(tongtien);
                double tienkhuyenmai = reader.GetDouble(8);
                hoadon.TongTienKhuyenMai = Convert.ToSingle(tienkhuyenmai);
                double tienthue = reader.GetDouble(9);
                hoadon.TongTienThue = Convert.ToSingle(tienthue);
                hoadon.HinhThucThanhToan = reader.GetString(10);
                double thanhtien = reader.GetDouble(11);
                hoadon.ThanhTien = Convert.ToSingle(thanhtien);
                hoadon.TrangThai = reader.GetInt32(12);
                dt.Add(hoadon);
            }
            CloseConnection();
            return dt;
        }
        public List<string> LichSuMuaHang(int makhachhang)
        {
            List<string> dt = new List<string>();
            string sql = "select MaHoaDon,NgayLapHoaDon,TongTien from HoaDon where MaKhachHang=@MaKhachHang";
            OpenConnection();
            command=new SqlCommand(sql, connection);
            command.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = makhachhang;
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                double tmp=reader.GetDouble(2);
                float tongtien = Convert.ToSingle(tmp);
                dt.Add(reader.GetInt32(0)+","+reader.GetDateTime(1)+","+tongtien.ToString("0"));
            }
            CloseConnection();
            return dt;
        }
        public int KhoaLonNhat()
        {
            string sql = "select Max(MaHoaDon) from HoaDon";
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
        public List<string> DanhSachMaHoaDon()
        {
            string sql = "select HoaDon.MaHoaDon from HoaDon  where NOT EXISTS (select MaPhieuTra from PhieuTra where HoaDon.MaHoaDon=PhieuTra.MaHoaDon)";
            OpenConnection();
            command = new SqlCommand(sql, connection);  
            reader = command.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetInt32(0)+"");
            }
            CloseConnection();
            return list;

        }
        public bool XoaHoaDon(int mahoadon)
        {
            string sql = "update HoaDon set TrangThai=0 where MaHoaDon=@MaHoaDon";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = mahoadon;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
    }
}
