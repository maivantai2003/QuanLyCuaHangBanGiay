using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public string SoDienThoai { get; set; }
        public byte[] HinhAnh { get; set; }
        public int TrangThai { get; set; }
    }
}
