using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MauSacBUS
    {
        MauSacDAO mauSacDAO = new MauSacDAO();
        public List<MauSac> getMauSac()
        {
            return mauSacDAO.getMauSac();
        }
        public string TenMau(int mamau)
        {
            return mauSacDAO.TenMau(mamau);
        }
        public int MaMau(string tenmau)
        {
            return mauSacDAO.MaMau(tenmau);
        }
        public List<MauSac> TimKiemMauSac(string text)
        {
            return mauSacDAO.TimKiemMauSac(text);
        }
        public bool ThemMau(MauSac mausac)
        {
            return mauSacDAO.ThemThongTinMauSac(mausac);    
        }
        public bool SuaMau(MauSac mausac)
        {
            return mauSacDAO.SuaThongTinMauSac(mausac);
        }
        public bool XoaMau(int mamau)
        {
            return mauSacDAO.XoaMauSac(mamau);
        }
        public List<string> DanhSachTenMauSac()
        {
            List<string> list = new List<string>();
            foreach (var i in mauSacDAO.getMauSac())
            {
                list.Add(i.TenMau);
            }
            return list;
        }
        public bool KiemTraMauSac(string tenmau)
        {
            return mauSacDAO.KiemTraMauSac(tenmau);
        }
    }
}
