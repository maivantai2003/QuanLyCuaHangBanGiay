using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTra
    {
        public int MaPhieuTra { get; set; }
        public int MaNhanVien { get; set; }
        public int MaHoaDon { get; set; }
        public DateTime NgayTra { get; set; }
        public int TongSoLuongTra { get; set; }
        public float TongTienTra { get; set; }
        public int TrangThai { get; set; }
    }
}
