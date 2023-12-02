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
    public class ChiTietPhieuNhapDAO:Connection
    {
        public List<ChiTietPhieuNhap> getchiTietPhieuNhap()
        {
            List<ChiTietPhieuNhap> dt = new List<ChiTietPhieuNhap>();
            try
            {
                //string sql = "select * from ChiTietPhieuNhap";
                command = new SqlCommand("Select_ChiTietPhieuNhap", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                    chiTietPhieuNhap.MaPhieuNhap = reader.GetInt32(0);
                    chiTietPhieuNhap.MaChiTietSanPham = reader.GetInt32(1);
                    chiTietPhieuNhap.SoLuongNhap = reader.GetInt32(2);
                    chiTietPhieuNhap.DonVi = reader.GetString(3);
                    double tiennhap = reader.GetDouble(4);
                    chiTietPhieuNhap.TienNhap = Convert.ToSingle(tiennhap);
                    double thanhtien = reader.GetDouble(5);
                    chiTietPhieuNhap.ThanhTien = Convert.ToSingle(thanhtien);
                    dt.Add(chiTietPhieuNhap);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string sql = "insert into ChiTietPhieuNhap values(@MaPhieuNhap,@MaChiTietSanPham,@SoLuongNhap,@donvi,@TienNhap,@ThanhTien)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietSanPham;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuongNhap;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = chiTietPhieuNhap.DonVi;
            command.Parameters.Add("@TienNhap", SqlDbType.Float).Value = chiTietPhieuNhap.TienNhap;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietPhieuNhap.ThanhTien;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string sql = "update ChiTietPhieuNhap set SoLuongNhap=@SoLuongNhap,DonVi=@donvi,TienNhap=@TienNhap,ThanhTien@ThanhTien where MaPhieuNhap=@MaPhieuNhap and MaChiTietSanPham=@MaChiTietSanPham";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuNhap.MaChiTietSanPham;
            command.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuongNhap;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = chiTietPhieuNhap.DonVi;
            command.Parameters.Add("@TienNhap", SqlDbType.Float).Value = chiTietPhieuNhap.TienNhap;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietPhieuNhap.ThanhTien;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public List<string> DanhSachChiTietPhieuNhap(int maphieunhap)
        {
            List<string> dt = new List<string>();
            /*string sql = "SELECT ChiTietSanPham.MaChiTietSanPham,SanPham.TenSanPham,MauSac.TenMau,KichCo.TenKichCo,ChiTietPhieuNhap.SoLuongNhap,ChiTietPhieuNhap.DonVi,ChiTietPhieuNhap.TienNhap,ChiTietPhieuNhap.ThanhTien " +
                "FROM ChiTietSanPham " +
                "JOIN SanPham ON ChiTietSanPham.MaSanPham = SanPham.MaSanPham JOIN MauSac ON ChiTietSanPham.MaMauSac = MauSac.MaMau JOIN KichCo ON ChiTietSanPham.MaKichCo = KichCo.MaKichCo JOIN ChiTietPhieuNhap " +
                "ON ChiTietSanPham.MaChiTietSanPham = ChiTietPhieuNhap.MaChiTietSanPham " +
                "JOIN PhieuNhap ON PhieuNhap.MaPhieuNhap = ChiTietPhieuNhap.MaPhieuNhap where PhieuNhap.MaPhieuNhap=@MaPhieuNhap";*/
            command = new SqlCommand("Select_DanhSachChiTietPhieuNhap", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            command.Parameters.Add("@MaPhieuNhap",SqlDbType.Int).Value=maphieunhap;
            OpenConnection();
            reader=command.ExecuteReader();
            while(reader.Read())
            {
                double tiennhap=reader.GetDouble(6);
                double thanhtien=reader.GetDouble(7);   
                dt.Add(reader.GetInt32(0)+","+ reader.GetString(1)+","+ reader.GetString(2)+","+ reader.GetString(3)+","+reader.GetInt32(4)+","+ reader.GetString(5)+","+tiennhap.ToString("0")+","+thanhtien.ToString("0"));
            }
            CloseConnection();  
            return dt;
        }
    }
}
