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
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO km = new KhuyenMaiDAO();
        public List<KhuyenMai> getAllList()
        {
            return km.getKhuyenMai();
        }
        public List<string> DanhSachMaKhuyenMai()
        {
            List<string> list = new List<string>();
            foreach(var i in km.getKhuyenMai())
            {
                if (i.ThoiGianKetThuc>=DateTime.Now)
                {
                    list.Add(i.MaKhuyenMai.ToString() + "-" + i.DieuKien);
                }
            }
            return list;
        }
        public float TienKhuyenMai(int makhuyenmai)
        {
            return km.TienKhuyenMai(makhuyenmai);
        }
        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            return km.ThemKhuyenMai(khuyenMai);
        }
        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            return km.SuaKhuyenMai(khuyenMai);
        }
        public bool XoaKhuyenMai(int makhuyenmai)
        {
            return km.XoaKhuyenMai(makhuyenmai);
        }
    }
}
