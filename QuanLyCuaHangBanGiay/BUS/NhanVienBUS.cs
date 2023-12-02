using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanVien = new NhanVienDAO();
        public List<NhanVien> getNhanVien()
        {
            return nhanVien.getNhanVien();
        }
        public string TenNhanVien(int MaNhanVien)
        {
            return nhanVien.TenNhanVien(MaNhanVien);
        }
        public int MaNhanVien(string tennhanvien)
        {
            return nhanVien.MaNhanVien(tennhanvien);
        }
        public bool ThemNhanVien(NhanVien nhanvien)
        {
            return nhanVien.ThemNhanVien(nhanvien);
        }
        public bool SuaNhanVien(NhanVien nhanvien)
        {
            return nhanVien.SuaNhanVien(nhanvien);
        }
        public bool XoaNhanVien(int mannhanvien)
        {
            return nhanVien.XoaNhanVien(mannhanvien);
        }
        public List<NhanVien> TimKiemNhanVien(string text)
        {
            return nhanVien.TimKiemNhanVien(text);
        }
        public List<string> DanhSachTenNhanVien()
        {
            List<string> list=new List<string>();
            foreach(var i in nhanVien.getNhanVien())
            {
                list.Add(i.MaNhanVien+"-"+i.TenNhanVien); 
            }
            return list;    
        }
        public int SoLuongNhanVien()
        {
            return nhanVien.getNhanVien().Count;
        }
    }
}
