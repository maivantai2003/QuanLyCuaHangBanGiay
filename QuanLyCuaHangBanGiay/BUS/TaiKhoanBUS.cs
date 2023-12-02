using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoan = new TaiKhoanDAO();
        public List<TaiKhoan> getTaiKhoan()
        {
            return taiKhoan.getTaiKhoan();
        }
        public bool ThemTaiKhoan(TaiKhoan taikhoan)
        {
            return taiKhoan.ThemTaiKhoan(taikhoan);
        }
        public bool XoaTaiKhoan(int MaTaiKhoan)
        {
            return  taiKhoan.XoaTaiKhoan(MaTaiKhoan);
        }
        public bool SuaTaiKhoan(TaiKhoan taikhoan)
        {
            return taiKhoan.SuaTaiKhoan(taikhoan);
        }
        public bool DangNhap(string taikhoan, string matkhau)
        {
            return taiKhoan.DangNhap(taikhoan, matkhau);
        }
        public int getMaNhomQuyen(int mataikhoan)
        {
            return taiKhoan.getMaNhomQuyen(mataikhoan);
        }
        public int getMaTaiKhoan(string taikhoan, string matkhau)
        {
            return taiKhoan.getMaTaiKhoan(taikhoan, matkhau);
        }
        public List<TaiKhoan> TimKiemTaiKhoan(string text)
        {
            return taiKhoan.TimKiemTaiKhoan(text);
        }
        public bool KiemTraTaiKhoan(int MaTaiKhoan)
        {
            return taiKhoan.KiemTraTaiKhoan(MaTaiKhoan);
        }
    }
}
