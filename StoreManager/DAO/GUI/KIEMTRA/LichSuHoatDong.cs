using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.KIEMTRA
{
    public class LichSuHoatDong
    {
        
        public static void LichSu(int MaNhanVien,string text)
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            string t = Path.GetDirectoryName(Application.ExecutablePath);
            int index = t.LastIndexOf('\\');
            string sub = t.Substring(0, index - 4);
            
            string path = sub+@"\PHANHOI\lichsu.txt";
            
            string tmp = DateTime.Now + "-"+"Mã Nhân Viên "+MaNhanVien+":"+nhanVienBUS.TenNhanVien(MaNhanVien)+"-Lịch sử Hoạt Động: "+text;
            using (StreamWriter sw = File.AppendText(path))
            {
                
                string[] texts = tmp.Split('-');
                int maxLength = texts.Max(s => s.Length);
                string line = new string('-', maxLength + 2);
                sw.WriteLine(line);
                foreach (string i in texts)
                {
                    sw.WriteLine($"| {i.PadRight(maxLength)} |");
                }
                sw.WriteLine(line);
            }
            

        }
    }
}
