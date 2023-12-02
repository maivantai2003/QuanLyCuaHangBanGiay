using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class ChiTietPhieuTraBUS
    {
        ChiTietPhieuTraDAO chiTietPhieuTraDAO=new ChiTietPhieuTraDAO();
        public bool ThemChiTietPhieuTra(ChiTietPhieuTra chiTietPhieuTra)
        {
            return chiTietPhieuTraDAO.ThemChiTietPhieuTra(chiTietPhieuTra);
        }
        public List<string> ChiTietPhieuTra(int maphieutra)
        {
            return chiTietPhieuTraDAO.ChiTietPhieuTra(maphieutra);
        }
    }
}
