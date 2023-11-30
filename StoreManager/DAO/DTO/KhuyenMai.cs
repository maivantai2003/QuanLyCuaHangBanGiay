using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai
    {
        public int MaKhuyenMai { get; set; }
        public float MucKhuyenMai { get; set; }
        public string DieuKien { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int TinhTrang { get; set; }
    }
}
