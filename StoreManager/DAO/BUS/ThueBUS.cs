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
    public class ThueBUS
    {
        ThueDAO thueDAO=new ThueDAO();
        public List<Thue> getThue()
        {
            return thueDAO.getThue();   
        }
        public List<string> DanhSachMaThue()
        {
            List<string> list = new List<string>();
            foreach(var i in thueDAO.getThue())
            {
                list.Add(i.MaThue+"-"+i.TenThue.ToString());
            }
            return list;
        }
        public bool ThemThue(Thue thue)
        {
            return thueDAO.ThemThue(thue);
        }
        public bool SuaThue(Thue thue)
        {
            return thueDAO.Sua(thue);
        }
        public bool XoaThue(int mathue)
        {
            return thueDAO.XoaThue(mathue);
        }
        public float TienThue(string tenthue)
        {
            return thueDAO.TienThue(tenthue);
        }
    }
}
