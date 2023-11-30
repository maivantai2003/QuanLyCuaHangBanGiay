using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietSanPham
    {
        public int MaChiTietSanPham { get; set; }
        public int MaSanPham { get; set; }
        public int MaMauSac { get; set; }
        public int MaKichCo { get; set; }
        public byte[] HinhAnh { get; set; }
        public int SoLuongTon { get; set; }
        public int SoLuongNhap { get; set; }
        public int TrangThai {  get; set; } 
    }
}
