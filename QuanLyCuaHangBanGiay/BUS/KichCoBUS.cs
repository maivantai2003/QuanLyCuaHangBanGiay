using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KichCoBUS
    {
        KichCoDAO kichCoDAO = new KichCoDAO();
        public List<KichCo> getKichCo()
        {
            return kichCoDAO.getKichCo();   
        }
        public string TenKichCo(int makichco)
        {
            return kichCoDAO.TenKichCo(makichco);
        }
        public int MaKichCo(string tenkichco)
        {
            return kichCoDAO.MaKichCo(tenkichco);
        }
        public bool ThemKichCo(KichCo kichCo)
        {
            return kichCoDAO.ThemThongTinKichCo(kichCo);
        }
        public bool XoaKichCO(int makichco)
        {
            return kichCoDAO.XoaKichCo(makichco);
        }
        public List<KichCo> TimKiemKichCo(string text)
        {
            return kichCoDAO.TimKiemKichCo(text);
        }
        public bool SuaKichCo(KichCo kichco)
        {
            return kichCoDAO.SuaThongTinKichCo(kichco);
        }
        public List<string> DanhSachTenKichCo()
        {
            List<string> list = new List<string>();
            foreach (var i in kichCoDAO.getKichCo())
            {
                list.Add(i.TenKichCo);
            }
            return list;
        }
        public bool KiemTraKichCo(string tenkichco)
        {
            return kichCoDAO.KiemTraKichCo(tenkichco);
        }
    }
}
