using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class ChiTietPhieuTraDAO:Connection
    {
        public bool ThemChiTietPhieuTra(ChiTietPhieuTra chiTietPhieuTra)
        {
            string sql = "insert into ChiTietPhieuTra values(@MaPhieuTra,@MaChiTietSanPham,@LyDoTra,@GiaSanPham,@SoLuong,@ThanhTien)";
            command = new SqlCommand(sql,connection);
            command.Parameters.Add("@MaPhieuTra",SqlDbType.Int).Value=chiTietPhieuTra.MaPhieuTra;
            command.Parameters.Add("@MaChiTietSanPham", SqlDbType.Int).Value = chiTietPhieuTra.MaChiTietSanPham;
            command.Parameters.Add("@LyDoTra", SqlDbType.NVarChar).Value = chiTietPhieuTra.LyDoTra;
            command.Parameters.Add("@GiaSanPham", SqlDbType.Float).Value = chiTietPhieuTra.GiaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = chiTietPhieuTra.SoLuong;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = chiTietPhieuTra.ThanhTien;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n>0;
        }
        public List<string> ChiTietPhieuTra(int maphieutra)
        {
            List<string> dt = new List<string>();
            string sql = "select ChiTietSanPham.MaChiTietSanPham,SanPham.TenSanPham,MauSac.TenMau,KichCo.TenKichCo,ChiTietPhieuTra.LyDoTra,ChiTietPhieuTra.GiaSanPham,ChiTietPhieuTra.SoLuong,ChiTietPhieuTra.ThanhTien " +
                "from SanPham join ChiTietSanPham " +
                "on SanPham.MaSanPham=ChiTietSanPham.MaSanPham join KichCo on KichCo.MaKichCo=ChiTietSanPham.MaKichCo " +
                "join MauSac on MauSac.MaMau=ChiTietSanPham.MaMauSac join ChiTietPhieuTra on ChiTietSanPham.MaChiTietSanPham=ChiTietPhieuTra.MaChiTietSanPham " +
                "join PhieuTra on PhieuTra.MaPhieuTra=ChiTietPhieuTra.MaPhieuTra where PhieuTra.MaPhieuTra=@MaPhieuTra";
            command=new SqlCommand(sql,connection);
            command.Parameters.Add("@MaPhieuTra", SqlDbType.Int).Value = maphieutra;
            OpenConnection();
            reader=command.ExecuteReader();
            while (reader.Read())
            {
                double giasanpham = reader.GetDouble(5);
                double thanhtien=reader.GetDouble(7);
                dt.Add(reader.GetInt32(0)+","+reader.GetString(1)+","+reader.GetString(2)+","+reader.GetString(3)+","+reader.GetString(4)+","+Convert.ToSingle(giasanpham).ToString("0")+","+reader.GetInt32(6)+","+Convert.ToSingle(thanhtien).ToString("0"));
            }
            CloseConnection();
            return dt;
        }
    }
}
