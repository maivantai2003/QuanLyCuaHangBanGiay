using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TheLoaiBUS
    {
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();
        public List<TheLoai> getTheLoai()
        {
            return theLoaiDAO.getTheLoai();
        }
        public string TenTheLoai(int matheloai)
        {
            return theLoaiDAO.TenTheLoai(matheloai);
        }
        public int MaTheLoai(string TenTheLoai)
        {
            return theLoaiDAO.MaTheLoai(TenTheLoai);
        }
        public bool ThemTheLoai(TheLoai theLoai)
        {
            return theLoaiDAO.ThemTheLoai(theLoai);
        }
        public bool XoaTheLoai(int matheloai)
        {
            return theLoaiDAO.XoaTheLoai(matheloai);
        }
        public bool SuaTheLoai(TheLoai theLoai)
        {
            return theLoaiDAO.SuaTheLoai(theLoai);
        }
        public List<string> DanhSachTheLoai()
        {
            List<string> list = new List<string>();
            foreach (var i in theLoaiDAO.getTheLoai())
            {
                list.Add(i.TenTheLoai);
            }
            return list;
        }
        public bool KiemTraTheLoai(string tentheloai)
        {
            return theLoaiDAO.KiemTraTheLoai(tentheloai);
        }
        public List<TheLoai> TimKiemTheLoai(string text)
        {
            return theLoaiDAO.TimKiemTheLoai(text);
        }
    }
}
