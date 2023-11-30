using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class ThuongHieuBUS
    {
        ThuongHieuDAO thuongHieuDAO = new ThuongHieuDAO();
        public List<ThuongHieu> getThuongHieuList()
        {
            return thuongHieuDAO.getThuongHieu();
        }
        public string TenThuongHieu(int mathuonghieu)
        {
            return thuongHieuDAO.TenThuongHieu(mathuonghieu);
        }
        public int MaThuongHieu(string tenthuonghieu)
        {
            return thuongHieuDAO.MaThuongHieu(tenthuonghieu);
        }
        public bool ThemThuongHieu(ThuongHieu thuongHieu)
        {
            return thuongHieuDAO.ThemThongTinThuongHieu(thuongHieu);
        }
        public bool SuaThuongHieu(ThuongHieu thuongHieu)
        {
            return thuongHieuDAO.SuaThongTinThuongHieu(thuongHieu);
        }
        public bool XoaThuongHieu(int mathuonghieu)
        {
            return thuongHieuDAO.XoaThuongHieu(mathuonghieu);
        }
        public List<string> DanhSachThuongHieu()
        {
            List<string> list = new List<string>();
            foreach (var i in thuongHieuDAO.getThuongHieu())
            {
                list.Add(i.TenThuongHieu);
            }
            return list;
        }
        public List<ThuongHieu> TimKiemThuongHieu(string text)
        {
            return thuongHieuDAO.TimKiemThuongHieu(text);
        }
        public bool KiemTraThuongHieu(string text)
        {
            return thuongHieuDAO.KiemTraThuongHieu(text);
        }
    }
}
