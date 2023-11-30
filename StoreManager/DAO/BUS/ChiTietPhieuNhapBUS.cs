using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO chiTietPhieuNhap = new ChiTietPhieuNhapDAO();
        public List<ChiTietPhieuNhap> getChiTietPhieuNhap()
        {
            return chiTietPhieuNhap.getchiTietPhieuNhap();
        }
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chitietphieunhap)
        {
            return chiTietPhieuNhap.ThemChiTietPhieuNhap(chitietphieunhap);
        }
        public List<string> DanhSachChiTietPhieuNhap(int maphieunhap)
        {
            return chiTietPhieuNhap.DanhSachChiTietPhieuNhap(maphieunhap);
        }
        public int SoLuongNhap()
        {
            int soluongnhap = chiTietPhieuNhap.getchiTietPhieuNhap().Count;
            return soluongnhap;
        }
    }
}
