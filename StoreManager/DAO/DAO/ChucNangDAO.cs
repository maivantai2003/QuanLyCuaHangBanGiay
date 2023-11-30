using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChucNangDAO:Connection
    {
        public List<ChucNang> getChucNang()
        {
            List<ChucNang> dt = new List<ChucNang>();
            try
            {
                OpenConnection();
                //string sql = "select * from ChucNang where MaChucNang=1";
                command = new SqlCommand("Select_ChucNang", connection) { 
                    CommandType = CommandType.StoredProcedure
                };
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChucNang chucNang = new ChucNang();
                    chucNang.MaChucNang = reader.GetInt32(0);
                    chucNang.TenChucNang =reader.GetString(1);
                    chucNang.TrangThai = reader.GetInt32(2);
                    dt.Add(chucNang);
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }
            return dt;
        }
        public List<ChucNang> TimKiemChucNang(string text)
        {
            List<ChucNang> chucNang = new List<ChucNang>();
            string sql = "select * from ChucNang where concat(MaChucNang,TenChucNang) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader =command.ExecuteReader();
            while (reader.Read())
            {
                ChucNang chucnang = new ChucNang();
                chucnang.MaChucNang = reader.GetInt32(0);
                chucnang.TenChucNang = reader.GetString(1);
                chucnang.TrangThai = reader.GetInt32(2);
                chucNang.Add(chucnang);
            }
            CloseConnection();
            return chucNang;
        }
        public bool ThemChucNang(ChucNang chucnang)
        {
            string sql = "insert into ChucNang values(@TenChucNang,@TrangThai)";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = chucnang.TenChucNang;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = chucnang.TrangThai;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n>0;
        }
        public bool SuaChucNang(ChucNang chucnang)
        {
            string sql = "update ChucNang set TenChucNang=@TenChucNang where MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = chucnang.MaChucNang;
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = chucnang.TenChucNang;
            OpenConnection();
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n>0;
        }
        public string getTenChucNang(int maChucNang)
        {
            string sql = "select TenChucNang from ChucNang where MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = maChucNang;
            OpenConnection();
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
        public int getMaChucNang(string tenChucNang)
        {
            string sql = "select MaChucNang from ChucNang where TenChucNang=@TenChucNang";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenChucNang", SqlDbType.NVarChar).Value = tenChucNang;
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
        public bool XoaChucNang(int MaChucNang)
        {
            string sql = "update ChucNang set TrangThai=0 where MaChucNang=@MaChucNang";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = MaChucNang;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool KiemTraChucNang(string tenchucnang)
        {
            string sql = "select * from ChucNang where TenChucNang=@TenChucNang and TrangThai=1";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenChucNang",SqlDbType.NVarChar).Value=tenchucnang;
            OpenConnection();
            reader= command.ExecuteReader();
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
