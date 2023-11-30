using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
   public class ChucNangBUS
   {
        ChucNangDAO chucNangDAO = new ChucNangDAO();
        public List<ChucNang> getChucNang()
        {
            return chucNangDAO.getChucNang();
        }
        public bool ThemChucNang(ChucNang chucnang)
        {
            return chucNangDAO.ThemChucNang(chucnang);
        }
        public string TenChucNang(int machucnang)
        {
            return chucNangDAO.getTenChucNang(machucnang);
        }
        public int getMaChucNang(string tenChucNang)
        {
            return chucNangDAO.getMaChucNang(tenChucNang);
        }
        public bool SuaChucNang(ChucNang chucnang)
        {
            return chucNangDAO.SuaChucNang(chucnang);
        }
        public bool XoaChucNang(int machucnang)
        {
            return chucNangDAO.XoaChucNang(machucnang);
        }
        public List<string> MaChucNang()
        {
            List<string> list = new List<string>();
            foreach (var i in chucNangDAO.getChucNang())
            {
                list.Add(i.MaChucNang + "-" + i.TenChucNang);
            }
            return list;
        }
        public bool KiemTraChucNang(string tenchucnang)
        {
            return chucNangDAO.KiemTraChucNang(tenchucnang);
        }
        public List<ChucNang> TimKiemChucNang(string text)
        {
            return chucNangDAO.TimKiemChucNang(text);
        }
    }
}
