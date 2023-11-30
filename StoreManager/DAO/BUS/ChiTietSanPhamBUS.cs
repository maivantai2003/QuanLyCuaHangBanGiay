using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        ChiTietSanPhamDAO chiTietSanPham = new ChiTietSanPhamDAO();
        public List<ChiTietSanPham> GetChiTietSanPham()
        {
            return chiTietSanPham.getChiTietSanPham();
        }
        public bool ThemChiTietSanPham(ChiTietSanPham chitietsanpham)
        {
            return chiTietSanPham.ThemChiTietSanPham(chitietsanpham);
        }
        public int MaChiTietSanPham(int MaSanPham, int MaKichCo, int MaMauSac)
        {
            return chiTietSanPham.MaChiTietSanPham(MaSanPham, MaKichCo, MaMauSac);
        }
        public List<string> DanhSachChiTietSanPham(int masanpham)
        {
            return chiTietSanPham.DanhSachChiTietSanPham(masanpham);
        }
        public bool CapNhatCTSoLuongNhap(int machitietsp,int soluongnhap)
        {
            return chiTietSanPham.CapNhatCTSoLuongNhap(machitietsp, soluongnhap);
        }
        public bool CapNhatCTSoLuongTon(int machitietsp, int soluongton)
        {
            return chiTietSanPham.CapNhatCTSoLuongTon(machitietsp, soluongton);
        }
        public int SoLuongCTTon(int machitietsp)
        {
            return chiTietSanPham.SoLuongCTTon(machitietsp);
        }
        public int SoLuongCTNhap(int machitietsp)
        {
            return chiTietSanPham.SoLuongCTNhap(machitietsp);
        }
        public int MaSanPham(int machitietsanpham)
        {
            return chiTietSanPham.MaSanPham(machitietsanpham);
        }
        public int SoLuongSanPham()
        {
            return chiTietSanPham.getChiTietSanPham().Count;
        }
        public byte[] HinhAnh(int machitietsp)
        {
            return chiTietSanPham.HinhAnh(machitietsp);
        }
    }
}
