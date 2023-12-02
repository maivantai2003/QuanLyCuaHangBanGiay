using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public int MaThue { get; set; }
        public int MaKhuyenMai { get; set; }
        public string TenHoaDon { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public float TongTien { get; set; }
        public float TongTienKhuyenMai { get; set; }
        public float TongTienThue { get; set; }
        public int TrangThai { get; set; }
        public string HinhThucThanhToan { get; set; }
        public float ThanhTien { get; set; }
    }
}
