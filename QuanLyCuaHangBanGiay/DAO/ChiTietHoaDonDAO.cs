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
    public class ChiTietHoaDonDAO:Connection
    {
        public bool ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES(@MaHoaDon,@MaChiTietSanPham,@GiaSanPham,@SoLuong,@ThanhTien)";
            OpenConnection();
            command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = cthd.MaChiTietSanPham;
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value =cthd.MaHoaDon;
            command.Parameters.Add("@GiaSanPham", SqlDbType.Float).Value = cthd.GiaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cthd.SoLuong;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = cthd.ThanhTien;
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0; 
        }
        public int SoLuongSanPhamDaBan()
        {
            string sql = "select SUM(SoLuong) from ChiTietHoaDon";
            command= new SqlCommand(sql, connection);  
            OpenConnection();
            reader=command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    int tmp = reader.GetInt32(0);
                    CloseConnection();
                    return tmp;
                }
            }
            catch (Exception ex)
            {
                CloseConnection();
                return 0;
            }
            
            CloseConnection();
            return 0;
        }
        public List<string> ChiTietHoaDon(int mahoadon)
        {
            List<string> list = new List<string>();
            /*string sql = "SELECT ctsp.MaChiTietSanPham ,sp.TenSanPham , ms.TenMau ,kc.TenKichCo, cthd.SoLuong ,sp.GiaSanPham ,cthd.ThanhTien FROM ChiTietSanPham ctsp " +
                "JOIN SanPham sp ON ctsp.MaSanPham = sp.MaSanPham " +
                "JOIN MauSac ms ON ctsp.MaMauSac = ms.MaMau JOIN KichCo kc ON ctsp.MaKichCo = kc.MaKichCo " +
                "JOIN ChiTietHoaDon cthd ON ctsp.MaChiTietSanPham = cthd.MaChiTietSanPham " +
                "JOIN HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon where cthd.MaHoaDon=@MaHoaDon";*/
            command = new SqlCommand("Select_ChiTietHoaDon", connection) { 
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.Add("@MaHoaDon",SqlDbType.Int).Value=mahoadon;   
            OpenConnection();
            reader=command.ExecuteReader();
            while (reader.Read())
            {
                double GiaSanPham = reader.GetDouble(5);
                double ThanhTien=reader.GetDouble(6);
                list.Add(reader.GetInt32(0)+","+reader.GetString(1)+","+reader.GetString(2)+","+reader.GetString(3)+","+reader.GetInt32(4)+","+GiaSanPham.ToString("0")+","+ThanhTien.ToString("0"));
            }
            CloseConnection();
            return list;
        }
      
    }
}
