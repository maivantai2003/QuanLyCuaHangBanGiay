using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        public bool ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            return chiTietHoaDonDAO.ThemChiTietHoaDon(cthd);
        }
        public List<string> ChiTietHoaDon(int mahoadon)
        {
            return chiTietHoaDonDAO.ChiTietHoaDon(mahoadon);
        }
        public int SoLuongHangDaBan()
        {
            return chiTietHoaDonDAO.SoLuongSanPhamDaBan();
        }
    }
}
