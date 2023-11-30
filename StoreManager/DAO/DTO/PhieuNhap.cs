﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public int MaNhaCungCap { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TenPhieuNhap { get; set; }
        public float TongTienNhap { get; set; }
        public int TrangThai { get; set; }
    }
}
