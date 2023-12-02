using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GUI.KIEMTRA
{
    public class KiemTraLoi
    {
        public static bool KiemTraRong(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }
            return false;
        }
        public static bool KiemTraEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        public static bool KiemTraSoNguyen(string text)
        {
            try
            {
                int n = Convert.ToInt32(text);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public static bool KiemTraSoThuc(string text)
        {
            try
            {
                float n = Convert.ToSingle(text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool KiemTraSoDienThoai(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }

            string pattern = @"^(\+?\d{1,3}[- ]?)?\d{10}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
    }
}
