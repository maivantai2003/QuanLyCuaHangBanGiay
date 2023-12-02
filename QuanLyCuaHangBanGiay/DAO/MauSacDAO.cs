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
    public class MauSacDAO:Connection
    {
        public List<MauSac> getMauSac()
        {
            List<MauSac> dt = new List<MauSac>();
            try
            {
                //string sql = "select * from MauSac where TrangThai=1";
                command = new SqlCommand("Select_MauSac", connection) { 
                    CommandType=CommandType.StoredProcedure
                };
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MauSac mauSac = new MauSac();
                    mauSac.MaMau = reader.GetInt32(0);
                    mauSac.TenMau = reader.GetString(1);
                    mauSac.TrangThai = reader.GetInt32(2);
                    dt.Add(mauSac);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            CloseConnection();
            return dt;
        }
        public string TenMau(int mamau)
        {
            string sql = "select TenMau from MauSac where MaMau=@MaMau";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaMau", SqlDbType.Int).Value = mamau;
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
        public int MaMau(string tenmau)
        {
            string sql = "select MaMau from MauSac where TenMau=@TenMau";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenMau", SqlDbType.NVarChar).Value = tenmau;
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
        public bool ThemThongTinMauSac(MauSac mauSac)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO MauSac VALUES(@tenMauSac, @trangThai)";
            command.Connection = connection;
            command.Parameters.Add("@tenMauSac", SqlDbType.NVarChar).Value = mauSac.TenMau;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = mauSac.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public bool SuaThongTinMauSac(MauSac mauSac)
        {
            int ketQua;
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE MauSac SET TenMau = @tenMauSac WHERE MaMau = @maMauSac";
                command.Connection = connection;
                command.Parameters.Add("@tenMauSac", SqlDbType.NVarChar).Value = mauSac.TenMau;
                //command.Parameters.Add("@trangThai", SqlDbType.Int).Value = mauSac.TrangThai;
                command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = mauSac.MaMau;
                ketQua = command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ketQua > 0;
        }
        public bool XoaMauSac(int mamau)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update MauSac set TrangThai=0 WHERE MaMauSac = @maMauSac";
            command.Connection = connection;
            command.Parameters.Add("@maMauSac", SqlDbType.Int).Value = mamau;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public List<MauSac> TimKiemMauSac(String text)
        {
            List<MauSac> arraymausac = new List<MauSac>();
            string sql = "select * from MauSac where concat(MaMau, TenMau) COLLATE Latin1_General_CI_AI like '%" + text + "%'";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                MauSac mausac = new MauSac();
                mausac.MaMau = reader.GetInt32(0);
                mausac.TenMau = reader.GetString(1);
                mausac.TrangThai = reader.GetInt32(2);
                arraymausac.Add(mausac);
            }
            CloseConnection();
            return arraymausac;

        }
        public bool KiemTraMauSac(string tenmau)
        {
            string sql = "select * from MauSac where TenMau=@TenMau";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenMau", SqlDbType.NVarChar).Value = tenmau;
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
