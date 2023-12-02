using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public int MaChiTietSanPham { get; set; }
        public int MaPhieuNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public string DonVi { get; set; }
        public float TienNhap { get; set; }
        public float ThanhTien { get; set; }
    }
}
