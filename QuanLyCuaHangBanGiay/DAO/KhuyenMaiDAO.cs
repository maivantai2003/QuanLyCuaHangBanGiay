using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class KhuyenMaiDAO:Connection
    {
        public List<KhuyenMai> getKhuyenMai()
        {
            List<KhuyenMai> dt=new List<KhuyenMai>();
            OpenConnection();
            //string sql = "select * from KhuyenMai where TinhTrang=1";
            command = new SqlCommand("Select_KhuyenMai", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            reader = command.ExecuteReader();   
                while (reader.Read())
                {
                    KhuyenMai km = new KhuyenMai();
                    km.MaKhuyenMai = reader.GetInt32(0);
                    km.MucKhuyenMai = Convert.ToSingle(reader.GetDouble(1));
                    km.DieuKien = reader.GetString(2);
                    km.ThoiGianBatDau = reader.GetDateTime(3);
                    km.ThoiGianKetThuc = reader.GetDateTime(4);
                    km.TinhTrang = reader.GetInt32(5);
                    dt.Add(km);
                }
            CloseConnection();
            return dt;
        }
        public bool ThemKhuyenMai(KhuyenMai khuyenmai)
        {
            string sql = "insert into KhuyenMai values(@MucKhuyenMai,@DieuKien,@ThoiGianBatDau,@ThoiGianKetThuc,@TinhTrang)";
            command=new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MucKhuyenMai", SqlDbType.Float).Value = khuyenmai.MucKhuyenMai;
            command.Parameters.Add("@DieuKien", SqlDbType.NVarChar).Value = khuyenmai.DieuKien;
            command.Parameters.Add("@ThoiGianBatDau", SqlDbType.DateTime).Value = khuyenmai.ThoiGianBatDau;
            command.Parameters.Add("@ThoiGianKetThuc", SqlDbType.DateTime).Value = khuyenmai.ThoiGianKetThuc;
            command.Parameters.Add("@TinhTrang", SqlDbType.Int).Value = khuyenmai.TinhTrang;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool SuaKhuyenMai(KhuyenMai khuyenmai)
        {
            string sql = "update KhuyenMai set MucKhuyenMai=@MucKhuyenMai,DieuKien=@DieuKien,ThoiGianBatDau=@ThoiGianBatDau,ThoiGianKetThuc=@ThoiGianKetThuc where MaKhuyenMai=@MaKhuyenMai";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.Int).Value = khuyenmai.MaKhuyenMai;
            command.Parameters.Add("@MucKhuyenMai", SqlDbType.Float).Value = khuyenmai.MucKhuyenMai;
            command.Parameters.Add("@DieuKien", SqlDbType.NVarChar).Value = khuyenmai.DieuKien;
            command.Parameters.Add("@ThoiGianBatDau", SqlDbType.DateTime).Value = khuyenmai.ThoiGianBatDau;
            command.Parameters.Add("@ThoiGianKetThuc", SqlDbType.DateTime).Value = khuyenmai.ThoiGianKetThuc;
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool XoaKhuyenMai(int MaKhuyenMai)
        {
            string sql = "update KhuyenMai set TinhTrang=0 where MaKhuyenMai=@MaKhuyenMai";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaKhuyenMai",SqlDbType.Int).Value = MaKhuyenMai;
            int n=command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;   
        }
        public float TienKhuyenMai(int makhuyenmai)
        {
            string sql = "select MucKhuyenMai from KhuyenMai where MaKhuyenMai=@MaKhuyenMai";
            OpenConnection();
            command=new SqlCommand(sql, connection);
            command.Parameters.Add("@MaKhuyenMai",SqlDbType.Int).Value= makhuyenmai;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                double tmp = reader.GetDouble(0);
                float s=Convert.ToSingle(tmp);
                CloseConnection();
                return s;
            }
            CloseConnection();
            return 0f;
        }
    }
}
