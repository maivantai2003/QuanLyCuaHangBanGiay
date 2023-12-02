using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPham = new SanPhamDAO();
        public List<SanPham> GetSanPham()
        {
            return sanPham.getSanPham();
        }
        public bool ThemSanPham(SanPham sanpham)
        {
            return sanPham.ThemSanPham(sanpham);
        }
        public string TenSanPham(int masanpham)
        {
            return sanPham.TenSanPham(masanpham);
        }
        public int MaSanPham(string tensanpham)
        {
            return sanPham.MaSanPham(tensanpham);
        }
        public List<SanPham> TimKiemSanPham(string text)
        {
            return sanPham.TimKiemSanPham(text);
        }
        public bool SuaSanPham(SanPham sanpham)
        {
            return sanPham.SuaSanPham(sanpham);
        }
        public bool CapNhatSoLuongNhap(int msp,int soluongnhap)
        {
            return sanPham.CapNhatSoLuongNhap(msp, soluongnhap);
        }
        public bool CapNhatSoLuongTon(int msp, int soluongton)
        {
            return sanPham.CapNhatSoLuongTon(msp, soluongton);
        }
        public List<string> DanhSachTenSanPham()
        {
            List<string> list = new List<string>();
            foreach (var i in sanPham.getSanPham())
            {
                list.Add(i.TenSanPham);
            }
            return list;
        }
        public int SoLuongNhap(int msp)
        {
            return sanPham.SoLuongNhap(msp);
        }
        public int SoLuongTon(int msp)
        {
            return sanPham.SoLuongTon(msp);
        }
        public int SoLuongSanPham()
        {
            int soluongsanpham=sanPham.getSanPham().Count;
            return soluongsanpham;
        }
        public int KhoaLonNhat()
        {
            int index = sanPham.KhoaLonNhat();
            return index;
        }
        public int SoLuongTon()
        {
            int n = 0;
            foreach(var i in sanPham.getSanPham())
            {
                n += i.SoLuongTon;
            }
            return n;
        }
        public bool XoaSanPham(int masanpham)
        {
            return sanPham.XoaSanPham(masanpham);
        }
        
    }
}
