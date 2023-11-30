using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuTraBUS
    {
        PhieuTraDAO phieuTraDAO=new PhieuTraDAO();
        public List<PhieuTra> getPhieuTra()
        {
            return phieuTraDAO.getPhieuTra();
        }
        public bool ThemPhieuTra(PhieuTra phieuTra)
        {
            return phieuTraDAO.ThemPhieuTra(phieuTra);
        }
        public bool XoaPhieuTra(int maphieutra)
        {
            return phieuTraDAO.XoaPhieuTra(maphieutra);
        }
        public bool SuaPhieuTra(PhieuTra phieutra)
        {
            return phieuTraDAO.SuaPhieuTra(phieutra);
        }
        public int MaLonNhat()
        {
            int index = phieuTraDAO.KhoaLonNhat();
            return index;
        }
        public int SoLuongPhieuTra()
        {
            int n = phieuTraDAO.getPhieuTra().Count;
            return n;
        }
        public bool KiemTraHoaDon(int mahoadon)
        {
            return phieuTraDAO.KiemTraHoaDon(mahoadon);
        }
        public PhieuTra LayPhieuTra(int maphieutra)
        {
            return phieuTraDAO.LayPhieuTra(maphieutra);
        }
        public List<PhieuTra> TimKiemPhieuTra(string text)
        {
            return phieuTraDAO.TimKiemPhieuTra(text);
        }
    }
}
