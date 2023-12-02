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
    public class KichCoDAO:Connection
    {
        public List<KichCo> getKichCo()
        {
            List<KichCo> dt = new List<KichCo>();
            try
            {
                //string sql = "select * from KichCo where TrangThai=1";
                command = new SqlCommand("Select_KichCo", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KichCo kichCo = new KichCo();
                    kichCo.MaKichCo = reader.GetInt32(0);
                    kichCo.TenKichCo = reader.GetString(1);
                    kichCo.TrangThai = reader.GetInt32(2);
                    dt.Add(kichCo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            CloseConnection();
            return dt;
        }
        public string TenKichCo(int makichco)
        {
            string sql = "select TenKichCo from KichCo where MaKichCo=@MaKichCo";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaKichCo", SqlDbType.Int).Value = makichco;
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
        public int MaKichCo(string tenkichco)
        {
            string sql = "select MaKichCo from KichCo where TenKichCo=@TenKichCo";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenKichCo", SqlDbType.NVarChar).Value = tenkichco;
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
        public bool ThemThongTinKichCo(KichCo kichCo)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KichCo VALUES(@tenKichCo, @trangThai)";
            command.Connection = connection;
            command.Parameters.Add("@tenKichCo", SqlDbType.NVarChar).Value = kichCo.TenKichCo;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = kichCo.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public bool SuaThongTinKichCo(KichCo kichCo)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KichCo SET TenKichCo = @tenKichCo WHERE MaKichCo = @maKichCo";
                command.Connection = connection;
                command.Parameters.Add("@tenKichCo", SqlDbType.NVarChar).Value = kichCo.TenKichCo;
                //command.Parameters.Add("@trangThai", SqlDbType.Int).Value = kichCo.TrangThai;
                command.Parameters.Add("@maKichCo", SqlDbType.Int).Value = kichCo.MaKichCo;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }
        public bool XoaKichCo(int makichco)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KichCo set TrangThai=0 WHERE MaKichCo = @maKichCo";
            command.Connection = connection;
            command.Parameters.Add("@maKichCo", SqlDbType.Int).Value = makichco;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;

        }
        public List<KichCo> TimKiemKichCo(string text)
        {
            List<KichCo> arraykichco = new List<KichCo>();
            string sql = "select * from KichCo where concat(MaKichCo, TenKichCo) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                KichCo kichco = new KichCo();
                kichco.MaKichCo = reader.GetInt32(0);
                kichco.TenKichCo = reader.GetString(1);
                kichco.TrangThai = reader.GetInt32(2);
                arraykichco.Add(kichco);
            }
            CloseConnection();
            return arraykichco;
        }
        public bool KiemTraKichCo(string tenkichco)
        {
            string sql = "select * from KichCo where TenKichCo=@TenKichCo";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenKichCo",SqlDbType.NVarChar).Value=tenkichco;
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
