using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietQuyenBUS
    {
        ChiTietQuyenDAO chiTietQuyen = new ChiTietQuyenDAO();
        public List<ChiTietQuyen> getChiTietQuyen()
        {
            return chiTietQuyen.getChiTietQuyen();
        }
        public string ChucNang(int MaNhomQuyen)
        {
            return chiTietQuyen.ChucNang(MaNhomQuyen);
        }
        public string HanhDong(int MaNhomQuyen, int MaChucNang)
        {
            return chiTietQuyen.HanhDong(MaNhomQuyen, MaChucNang);
        }
        public bool kiemTraHanhDong(int manhomquyen, int machucnang, string HanhDong)
        {
            return chiTietQuyen.kiemTraHanhDong(manhomquyen, machucnang, HanhDong);
        }
        public bool ThemChiTietQuyen(ChiTietQuyen chitietquyen)
        {
            return chiTietQuyen.ThemChiTietQuyen(chitietquyen);
        }
        public List<ChiTietQuyen> TimKiemChiTietQuyen(string text)
        {
            return chiTietQuyen.TimKiemChiTietQuyen(text);
        }
        public bool XoaChiTietQuyen(int MaNhomQuyen, int MaChucNang, string HanhDong)
        {
            return chiTietQuyen.XoaChiTietQuyen(MaNhomQuyen,MaChucNang,HanhDong);
        }
    }
}
