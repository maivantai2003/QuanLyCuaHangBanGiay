using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {
        ThongKeDAO ThongKeDAO = new ThongKeDAO();  
        public DataTable ThongKeSanPhamDaBan()
        {
            return ThongKeDAO.ThongKeSanPhamDaBan();
        }
        public DataTable ThongKeChiTietSanPhamDaBan()
        {
            return ThongKeDAO.ThongKeChiTietSanPhamDaBan();
        }
        public float TongTienTra()
        {
            return ThongKeDAO.TongTienTra();
        }
        public DataTable ThongKeSoLuongNhap()
        {
            return ThongKeDAO.ThongKeSoLuongNhap();
        }
        public DataTable ThongKeSoLuongTon()
        {
            return ThongKeDAO.ThongKeSoLuongTon();
        }
        public DataTable ThongKeSanPhamPhoBien()
        {
            return ThongKeDAO.ThongKeSanPhamPhoBien();
        }
        public DataTable ThongKeChiTietSanPhamNhap()
        {
            return ThongKeDAO.ThongKeChiTietSanPhamNhap();
        }
        public DataTable ThongKeChiTietSanPhamTon()
        {
            return ThongKeDAO.ThongKeChiTietSanPhamTon();
        }
        public DataTable ThongKeDoanhThu(DateTime date1,DateTime date2)
        {
            return ThongKeDAO.ThongKeDoanhThu(date1, date2);
        }
        public DataTable ThongKeChiTietSanPhamPhoBien()
        {
            return ThongKeDAO.ThongKeChiTietSanPhamPhoBien();
        }
    }
}
