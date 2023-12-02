using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class TaiKhoanDAO:Connection
    {
        public List<TaiKhoan> getTaiKhoan()
        {
            List<TaiKhoan> dt = null;
            try
            {
                OpenConnection();
                dt = new List<TaiKhoan>();
                //string sql = "select * from TaiKhoan where TrangThai=1";
                command = new SqlCommand("Select_TaiKhoan", connection) {
                    CommandType=CommandType.StoredProcedure
                };
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.MaTaiKhoan = reader.GetInt32(0);
                    taikhoan.MaNhomQuyen = reader.GetInt32(1);
                    taikhoan.TenTaikhoan = reader.GetString(2);
                    taikhoan.MatKhau = reader.GetString(3);
                    taikhoan.TrangThai = reader.GetInt32(4);
                    dt.Add(taikhoan);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return dt;
        }
        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            string sql = "insert into TaiKhoan values(@MaTaiKhoan,@MaNhomQuyen,@TenTaiKhoan,@MatKhau,@TrangThai)";
            command = new SqlCommand(sql,connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = taiKhoan.MaTaiKhoan;
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = taiKhoan.MaNhomQuyen;
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = taiKhoan.TenTaikhoan;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = taiKhoan.MatKhau;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = taiKhoan.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n>0;
        }
        public bool XoaTaiKhoan(int MaTaiKhoan)
        {
            string sql = "update TaiKhoan set TrangThai=0 where MaTaiKhoan=@MaTaiKhoan";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = MaTaiKhoan;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n>0;
        }
        public bool SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            string sql = "update TaiKhoan set TenTaiKhoan=@TenTaiKhoan, MaNhomQuyen=@MaNhomQuyen, MatKhau=@MatKhau where MaTaiKhoan=@MaTaiKhoan and TrangThai=1";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = taiKhoan.MaTaiKhoan;
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = taiKhoan.TenTaikhoan;
            command.Parameters.Add("@MaNhomQuyen", SqlDbType.Int).Value = taiKhoan.MaNhomQuyen;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = taiKhoan.MatKhau;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool DangNhap(string taikhoan, string matkhau)
        {
            string sql = "select * from TaiKhoan where TenTaiKhoan=@TaiKhoan and MatKhau=@MatKhau";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = taikhoan;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = matkhau;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
        public int getMaTaiKhoan(string taikhoan, string matkhau)
        {
            string sql = "select MaTaiKhoan from TaiKhoan where TenTaiKhoan=@TaiKhoan and MatKhau=@MatKhau";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = taikhoan;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = matkhau;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                int tmp = reader.GetInt32(0);
                CloseConnection();
                return tmp;

            }
            CloseConnection();
            return 0;
        }
        public int getMaNhomQuyen(int MaTaiKhoan)
        {
            string sql = "select MaNhomQuyen from TaiKhoan where MaTaiKhoan=@MaTaiKhoan";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = MaTaiKhoan;
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                int tmp = reader.GetInt32(0);
                CloseConnection();
                return tmp;
            }
            CloseConnection();
            return 0;
        }
        public List<TaiKhoan> TimKiemTaiKhoan(string text)
        {
            List<TaiKhoan> arraytaikhoan = new List<TaiKhoan>();
            string sql = "select * from TaiKhoan where concat(MaTaiKhoan, MaNhomQuyen,TenTaiKhoan,MatKhau)COLLATE Latin1_General_CI_AI like '%" + text + "%' and TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                TaiKhoan taikhoan = new TaiKhoan();
                taikhoan.MaTaiKhoan = reader.GetInt32(0);
                taikhoan.MaNhomQuyen = reader.GetInt32(1);
                taikhoan.TenTaikhoan = reader.GetString(2);
                taikhoan.MatKhau = reader.GetString(3);
                taikhoan.TrangThai=reader.GetInt32(4);
                arraytaikhoan.Add(taikhoan);
            }
            CloseConnection();
            return arraytaikhoan;

        }
        public bool KiemTraTaiKhoan(int mataikhoan)
        {
            string sql = "select * from TaiKhoan where MaTaiKhoan=@MaTaiKhoan and TrangThai=1";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaTaiKhoan", SqlDbType.Int).Value = mataikhoan;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
        public bool KiemTraTenTaiKhoan(string tentaikhoan)
        {
            string sql = "select * from TaiKhoan where TenTaiKhoan=@TenTaiKhoan and TrangThai=1";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = tentaikhoan;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
    }
}
