using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO=new HoaDonDAO();
        public List<HoaDon> getHoaDon()
        {
            return hoaDonDAO.getHoaDon();
        }
        public List<string> DanhSachSanPham()
        {
            return hoaDonDAO.DanhSachSanPham();
        }
        public bool ThemHoaDon(HoaDon hoaDon)
        {
            return hoaDonDAO.ThemHoaDon(hoaDon);
        }
        public bool CapNhatHoaDon(HoaDon hoaDon)
        {
            return hoaDonDAO.CapNhatHoaDon(hoaDon);
        }
        public List<string> LichSuMuaHang(int makhachhang)
        {
            return hoaDonDAO.LichSuMuaHang(makhachhang);
        }
        public int MaLonNhat()
        {
            int index = hoaDonDAO.KhoaLonNhat();
            return index;   
        }
        public List<string> DanhSachMaHoaDon()
        {
            
            return hoaDonDAO.DanhSachMaHoaDon();
        }
        public int SoHoaDon()
        {
            int index = hoaDonDAO.getHoaDon().Count;
            return index;

        }
        public float DoanhThu()
        {
            float s= 0;
            foreach(var i in hoaDonDAO.getHoaDon())
            {
                s += i.ThanhTien;
            }
            return s;
        }
        public DateTime NgayMua(int mahoadon)
        {
            return hoaDonDAO.NgayMua(mahoadon);
        }
        public HoaDon LayHoaDon(int mahoadon)
        {
            return hoaDonDAO.LayHoaDon(mahoadon);   
        }
        public List<HoaDon> TimKiemHoaDon(string text)
        {
            return hoaDonDAO.TimKiemHoaDon(text);
        }
        public bool XoaHoaDon(int mahoadon)
        {
            return hoaDonDAO.XoaHoaDon(mahoadon);
        }
        public List<string> TimKiemSanPhamBan(string text)
        {
            return hoaDonDAO.TimKiemSanPhamBan(text);
        }
    }
}
