using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO phieuNhap = new PhieuNhapDAO();
        public List<PhieuNhap> GetPhieuNhap()
        {
            return phieuNhap.getPhieuNhap();
        }
        public bool ThemPhieuNhap(PhieuNhap phieunhap)
        {
            return phieuNhap.ThemPhieuNhap(phieunhap);
        }
        public List<string> DanhSachSanPhamNhap()
        {
            return phieuNhap.DanhSachSanPhamNhap();
        }
        public bool XoaPhieuNhap(int maphieunhap)
        {
            return phieuNhap.XoaPhieuNhap(maphieunhap);
        }
        public bool SuaPhieuNhap(PhieuNhap phieunhap)
        {
            return phieuNhap.SuaPhieuNhap(phieunhap);
        }
        public List<PhieuNhap> TimKiemPhieuNhap(string text)
        {
            return phieuNhap.TimKiemPhieuNhap(text);
        }
        public int MaLonNhat()
        {
            int index= phieuNhap.KhoaLonNhat();
            return index;
        }
        public PhieuNhap LayPhieuNhap(int maphieunhap)
        {
            return phieuNhap.LayPhieuNhap(maphieunhap);
        }
    }
}
