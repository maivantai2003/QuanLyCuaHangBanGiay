using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhomQuyenBUS
    {
        NhomQuyenDAO nhomQuyen = new NhomQuyenDAO();
        public List<NhomQuyen> getNhomQuyen()
        {
            return nhomQuyen.getNhomQuyen();
        }
        public bool ThemNhomQuyen(NhomQuyen bus)
        {
            return nhomQuyen.ThemNhomQuyen(bus);
        }
        public List<string> DanhSachTenNhomQuyen()
        {
            List<string> list = new List<string>();
            foreach (var i in nhomQuyen.getNhomQuyen())
            {
                list.Add(i.MaNhomQuyen + "-" + i.TenNhomQuyen);
            }
            return list;
        }
        public bool SuaNhomQuyen(NhomQuyen nhomquyen)
        {
            return nhomQuyen.SuaNhomQuyen(nhomquyen);
        }
        public bool XoaNhomQuyen(int MaNhomQuyen)
        {
            return nhomQuyen.XoaNhomQuyen(MaNhomQuyen);
        }
        public List<NhomQuyen> TimKiemNhomQuyen(string text)
        {
            return nhomQuyen.TimKiemNhomQuyen(text);
        }
        public bool KiemTraNhomQuyen(string tennhomquyen)
        {
            return nhomQuyen.KiemTraNhomQuyen(tennhomquyen);
        }
        public int MaNhomQuyen(string TenNhomQuyen)
        {
            return nhomQuyen.MaNhomQuyen(TenNhomQuyen);
        }
        public string TenNhomQuyen(int MaNhomQuyen)
        {
            return nhomQuyen.TenNhomQuyen(MaNhomQuyen);
        }
    }
}
