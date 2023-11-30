using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuTra
    {
        public int MaPhieuTra { get; set; }
        public int MaChiTietSanPham { get; set; }
        public string LyDoTra {  get; set; }
        public float GiaSanPham { get; set; }
        public int SoLuong {  get; set; }  
        public float ThanhTien {  get; set; }   
    }
}
