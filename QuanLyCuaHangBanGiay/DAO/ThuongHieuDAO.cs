using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class ThuongHieuDAO:Connection
    {
        public List<ThuongHieu> getThuongHieu()
        {
            List<ThuongHieu> dt = new List<ThuongHieu>();
            try
            {
                //string sql = "select * from ThuongHieu where TrangThai=1";
                command = new SqlCommand("Select_ThuongHieu", connection) { 
                    CommandType = CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ThuongHieu thuongHieu = new ThuongHieu();
                    thuongHieu.MaThuongHieu = reader.GetInt32(0);
                    thuongHieu.TenThuongHieu = reader.GetString(1);
                    thuongHieu.TrangThai = reader.GetInt32(2);
                    dt.Add(thuongHieu);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            CloseConnection();
            return dt;
        }
        public string TenThuongHieu(int mathuonghieu)
        {
            try
            {
                string sql = "select TenThuongHieu from ThuongHieu where MaThuongHieu=@mathuonghieu";
                command = new SqlCommand(sql, connection);
                OpenConnection();
                command.Parameters.Add("@mathuonghieu", SqlDbType.Int).Value = mathuonghieu;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string tmp = reader.GetString(0);
                    CloseConnection();
                    return tmp;
                }
                CloseConnection();
                return "";
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int MaThuongHieu(string tenthuonghieu)
        {
            try
            {
                string sql = "select MaThuongHieu from ThuongHieu where TenThuongHieu=@tenthuonghieu";
                command = new SqlCommand(sql, connection);
                OpenConnection();
                command.Parameters.Add("@tenthuonghieu", SqlDbType.NVarChar).Value = tenthuonghieu;
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
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool ThemThongTinThuongHieu(ThuongHieu thuongHieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO ThuongHieu VALUES(@tenThuongHieu, @trangThai)";
            command.Connection = connection;
            command.Parameters.Add("@tenThuongHieu", SqlDbType.NVarChar).Value = thuongHieu.TenThuongHieu;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = thuongHieu.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }

        public bool SuaThongTinThuongHieu(ThuongHieu thuongHieu)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ThuongHieu SET TenThuongHieu = @tenThuongHieu WHERE MaThuongHieu = @maThuongHieu and TrangThai=1";
                command.Connection = connection;
                command.Parameters.Add("@tenThuongHieu", SqlDbType.NVarChar).Value = thuongHieu.TenThuongHieu;
                command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = thuongHieu.MaThuongHieu;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }

        public bool XoaThuongHieu(int maThuongHieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE ThuongHieu set TrangThai=0 WHERE MaThuongHieu = @maThuongHieu";
            command.Connection = connection;
            command.Parameters.Add("@maThuongHieu", SqlDbType.Int).Value = maThuongHieu;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }
        public List<ThuongHieu> TimKiemThuongHieu(string text)
        {
            List<ThuongHieu> ArrayThuongHieu = new List<ThuongHieu>();
            string sql = "select * from ThuongHieu where concat(MaThuongHieu,TenThuongHieu) COLLATE Latin1_General_CI_AI like '%" + text + "%' and TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ThuongHieu thuonghieu = new ThuongHieu();
                thuonghieu.MaThuongHieu = reader.GetInt32(0);
                thuonghieu.TenThuongHieu = reader.GetString(1);
                thuonghieu.TrangThai = reader.GetInt32(2);
                ArrayThuongHieu.Add(thuonghieu);
            }
            CloseConnection();
            return ArrayThuongHieu;
        }
        public bool KiemTraThuongHieu(string tenthuonghieu)
        {
            string sql = "select MaThuongHieu from ThuongHieu where TenThuongHieu=@TenThuongHieu";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenThuongHieu",SqlDbType.NVarChar).Value=tenthuonghieu;
            OpenConnection();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                CloseConnection();
                return true;    
            }
            CloseConnection();
            return false;   
        }
    }
}
