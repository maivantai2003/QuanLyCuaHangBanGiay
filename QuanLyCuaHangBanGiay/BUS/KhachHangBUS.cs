using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        public List<KhachHang> getKhachHang()
        {
            return khachHangDAO.getKhachHang();
        }
        public List<KhachHang> TimKiemKhachHang(string text)
        {
            return khachHangDAO.TimKiemKhachHang(text);
        }
        public bool ThemKhachHang(KhachHang khachHang)
        {
            return khachHangDAO.ThemKhachHang(khachHang);
        }
        public int SoLuongKhachHang()
        {
            int index= khachHangDAO.getKhachHang().Count;
            return index;
        }
        public bool KiemTraSoDienThoai(string sdt)
        {
            return khachHangDAO.KiemTraSoDienThoai(sdt);
        }
        public int MaKhachHang(string sdt)
        {
            return khachHangDAO.MaKhachHang(sdt);
        }
        public KhachHang LayKhachHang(int makhachhang)
        {
            return khachHangDAO.LayKhachHang(makhachhang);
        }
        public KhachHang ThongTinKhachHang(string sodienthoai)
        {
            return khachHangDAO.ThongTinKhachHang(sodienthoai);
        }
    }
}
