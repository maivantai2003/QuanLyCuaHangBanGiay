using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();  
        public List<NhaCungCap> getNhaCungCap()
        {
            return nhaCungCapDAO.getNhaCungCap();   
        }
        public bool ThemNhaCungCap(NhaCungCap nhacungcap)
        {
            return nhaCungCapDAO.ThemNhaCungCap(nhacungcap);
        }
        public bool SuaNhaCungCap(NhaCungCap nhacungcap)
        {
            return nhaCungCapDAO.SuaThongTinNhaCungCap(nhacungcap);
        }
        public bool XoaNhaCungCap(int manhacungcap)
        {
            return nhaCungCapDAO.XoaNhaCungCap(manhacungcap);
        }
        public string TenNhaCungCap(int manhacungcap)
        {
            return nhaCungCapDAO.TenNhaCungCap(manhacungcap);
        }
        public int MaNhaCungCap(string tennhacungcap)
        {
            return nhaCungCapDAO.MaNhaCungCap(tennhacungcap);
        }
        public List<NhaCungCap> TimKiemNhaCungCap(string text)
        {
            return nhaCungCapDAO.TimKiemNhaCungCap(text);
        }
        public List<string> DanhSachTenNhaCungCap()
        {
            List<string> list=new List<string>();
            foreach(var i in nhaCungCapDAO.getNhaCungCap())
            {
                list.Add(i.TenNhaCungCap);
            }
            return list;
        }
        public bool KiemTraNhaCungCap(string tennhacungcap, string sodienthoai)
        {
            return nhaCungCapDAO.KiemTraNhaCungCap(tennhacungcap,sodienthoai);
        }
    }
}
