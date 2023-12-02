using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAO
{
    public class ThongKeDAO : Connection
    {
        public DataTable ThongKeSanPhamDaBan()
        {
            DataTable tb = new DataTable();
            /*string sql = "SELECT TenSanPham, SUM(SoLuong) AS SL FROM SanPham JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham " +
                "JOIN ChiTietHoaDon ON ChiTietSanPham.MaChiTietSanPham = ChiTietHoaDon.MaChiTietSanPham GROUP BY TenSanPham";*/
            command = new SqlCommand("ThongKe_SanPhamBan", connection) {
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(tb);
            CloseConnection();
            return tb;
        }
        public DataTable ThongKeSoLuongNhap()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT TenSanPham, SUM(ChiTietPhieuNhap.SoLuongNhap) AS SL FROM SanPham JOIN ChiTietSanPham ON SanPham.MaSanPham = ChiTietSanPham.MaSanPham JOIN ChiTietPhieuNhap ON" +
                " ChiTietSanPham.MaChiTietSanPham = ChiTietPhieuNhap.MaChiTietSanPham GROUP BY SanPham.TenSanPham";
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(tb);
            CloseConnection();
            return tb;
        }
        public DataTable ThongKeSoLuongTon()
        {
            DataTable tb = new DataTable();
            //string sql = "select TenSanPham,SUM(SoLuongTon) from SanPham GROUP BY TenSanPham";
            OpenConnection();
            command = new SqlCommand("ThongKe_SanPhamTon", connection) {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(tb);
            CloseConnection();
            return tb;
        }
        public DataTable ThongKeChiTietSanPhamNhap()
        {
            DataTable tb = new DataTable();
            OpenConnection();
            command = new SqlCommand("ThongKe_ChiTietSanPhamNhap", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(tb);
            CloseConnection();
            return tb;
        }
        public DataTable ThongKeSanPhamPhoBien()
        {
            DataTable tb = new DataTable();
            command = new SqlCommand("ThongKe_SanPhamPhoBien", connection) {
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(tb);
            CloseConnection();
            return tb;
        }
        public DataTable ThongKeChiTietSanPhamDaBan()
        {
            DataTable tb = new DataTable();
            OpenConnection();
            command = new SqlCommand("ThongKe_ChiTietSanPhamBan", connection) {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(tb);
            CloseConnection();
            return tb;
        }
        public float TongTienTra()
        {
            string sql = "select SUM(TongTienTra) from PhieuTra where TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection(); reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    double tongtientra = reader.GetDouble(0);
                    float tmp = Convert.ToSingle(tongtientra);
                    CloseConnection();
                    return tmp;
                }
            }
            catch(Exception ex)
            {
                CloseConnection();
                return 0f;
            }
            
            CloseConnection();
            return 0f;
        }
       /* public DataTable ThongKeChiTietSanPhamPhoBien()
        {

        }*/
       public DataTable ThongKeDoanhThu(DateTime date1,DateTime date2)
        {
            DataTable dataTable = new DataTable();
            string sql;
            if (date1.Date == date2.Date)
            {
                sql = "select CONVERT(DATE, HoaDon.NgayLapHoaDon) AS Ngay,SUM(HoaDon.TongTien) AS doanhthu from HoaDon  " +
                "group by CONVERT(DATE, HoaDon.NgayLapHoaDon)";
                command = new SqlCommand(sql, connection);
            }
            else
            {
                sql = "select CONVERT(DATE, HoaDon.NgayLapHoaDon) AS Ngay,SUM(HoaDon.TongTien) AS doanhthu from HoaDon  " +
                "where CONVERT(DATE, HoaDon.NgayLapHoaDon) BETWEEN CAST(@date1 AS DATE) AND CAST(@date2 AS DATE)  " +
                "group by CONVERT(DATE, HoaDon.NgayLapHoaDon)";
                command = new SqlCommand(sql, connection);
                command.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1;
                command.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;
            }
            OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            CloseConnection();
            return dataTable;   

        }
        public DataTable ThongKeChiTietSanPhamTon() {
            DataTable tb = new DataTable();
            OpenConnection();
            command = new SqlCommand("ThongKe_ChiTietSanPhamTon", connection) { 
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand= command;
            adapter.Fill(tb);
            CloseConnection();
            return tb;

        } 
        public DataTable ThongKeChiTietSanPhamPhoBien()
        {
            DataTable tb = new DataTable();
            /*string sql = "select concat(SanPham.TenSanPham,'-',MauSac.TenMau,'-',KichCo.TenKichCo) AS SanPham,SUM(ChiTietHoaDon.SoLuong) AS SL from ChiTietSanPham join " +
                "(select TOP 3 ChiTietSanPham.MaSanPham,SUM(SoLuong) AS SL from SanPham join ChiTietSanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham join ChiTietHoaDon " +
                "on ChiTietHoaDon.MaChiTietSanPham=ChiTietSanPham.MaChiTietSanPham join HoaDon on HoaDon.MaHoaDon=ChiTietHoaDon.MaHoaDon  group by ChiTietSanPham.MaSanPham order by SL DESC) " +
                "AS PhoBien on ChiTietSanPham.MaSanPham=PhoBien.MaSanPham join ChiTietHoaDon on ChiTietHoaDon.MaChiTietSanPham=ChiTietSanPham.MaChiTietSanPham join HoaDon " +
                "on ChiTietHoaDon.MaHoaDon=HoaDon.MaHoaDon join MauSac on MauSac.MaMau=ChiTietSanPham.MaMauSac " +
                "join KichCo on KichCo.MaKichCo=ChiTietSanPham.MaKichCo join SanPham on SanPham.MaSanPham=ChiTietSanPham.MaSanPham " +
                "group by ChiTietSanPham.MaChiTietSanPham,SanPham.MaSanPham,SanPham.TenSanPham,KichCo.TenKichCo,MauSac.TenMau";*/
            command = new SqlCommand("ThongKe_ChiTietSanPhamPhoBien", connection) { 
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            SqlDataAdapter adapter=new SqlDataAdapter();
            adapter.SelectCommand= command;
            adapter.Fill(tb);
            CloseConnection();
            return tb;

        }
    }
}
