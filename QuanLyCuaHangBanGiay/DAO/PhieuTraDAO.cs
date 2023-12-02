using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class PhieuTraDAO:Connection
    {
        public List<PhieuTra> getPhieuTra()
        {
            List<PhieuTra> dt=new List<PhieuTra>();
            //string sql = "select * from PhieuTra where TrangThai=1";
            command = new SqlCommand("Select_PhieuTra", connection) { 
                CommandType=CommandType.StoredProcedure
            };
            OpenConnection();
            reader= command.ExecuteReader();
            while(reader.Read()) { 
                PhieuTra phieuTra = new PhieuTra();
                phieuTra.MaPhieuTra = reader.GetInt32(0);
                phieuTra.MaNhanVien=reader.GetInt32(1);
                phieuTra.MaHoaDon=reader.GetInt32(2);
                phieuTra.NgayTra=reader.GetDateTime(3);
                double tongtientra=reader.GetDouble(5);
                phieuTra.TongTienTra=Convert.ToSingle(tongtientra);
                phieuTra.TongSoLuongTra = reader.GetInt32(4);
                phieuTra.TrangThai=reader.GetInt32(6);
                dt.Add(phieuTra);
            }
            CloseConnection();
            return dt;  
        }
        public bool ThemPhieuTra(PhieuTra phieutra)
        {
            string sql="insert into PhieuTra values(@MaPhieuTra,@MaNhanVien,@MaHoaDon,@NgayTra,@TongSoLuongTra,@TongTienTra,@TrangThai)";
            command = new SqlCommand(sql,connection);
            command.Parameters.Add("@MaPhieuTra",SqlDbType.Int).Value=phieutra.MaPhieuTra;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieutra.MaNhanVien;
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = phieutra.MaHoaDon;
            command.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = phieutra.NgayTra;
            command.Parameters.Add("@TongSoLuongTra", SqlDbType.Int).Value = phieutra.TongSoLuongTra;
            command.Parameters.Add("@TongTienTra", SqlDbType.Float).Value = phieutra.TongTienTra;
            command.Parameters.Add("@TrangThai", SqlDbType.Int).Value = phieutra.TrangThai;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;

        }
        public bool SuaPhieuTra(PhieuTra phieutra)
        {
            string sql = "update PhieuTra set MaNhanVien=@MaNhanVien, MaHoaDon=@MaHoaDon, NgayTra=@NgayTra, TongSoLuongTra=@TongSoLuongTra,TongTienTra=@TongTienTra where MaPhieuTra=@MaPhieuTra";

            command = new SqlCommand(sql, connection);
            command.Parameters.Add("MaPhieuTra",SqlDbType.Int).Value=phieutra.MaPhieuTra;
            command.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieutra.MaPhieuTra;
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = phieutra.MaHoaDon;
            command.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = phieutra.NgayTra;
            command.Parameters.Add("TongSoLuongTra", SqlDbType.Int).Value = phieutra.TongSoLuongTra;
            command.Parameters.Add("TongTienTra", SqlDbType.Float).Value = phieutra.TongTienTra;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;

        }
        public bool XoaPhieuTra(int maphieutra)
        {
            string sql = "update PhieuTra set TrangThai=0 where MaPhieuTra=@MaPhieuTra";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@MaPhieuTra", SqlDbType.Int).Value=maphieutra;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;

        }
        public PhieuTra LayPhieuTra(int maphieutra)
        {
            string sql = "select * from PhieuTra where MaPhieuTra=@MaPhieuTra";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaPhieuTra", SqlDbType.Int).Value = maphieutra;
            reader=command.ExecuteReader();
            if (reader.Read())
            {
                PhieuTra phieuTra = new PhieuTra();
                phieuTra.MaPhieuTra = reader.GetInt32(0);
                phieuTra.MaNhanVien = reader.GetInt32(1);
                phieuTra.MaHoaDon = reader.GetInt32(2);
                phieuTra.NgayTra = reader.GetDateTime(3);
                double tongtientra = reader.GetDouble(5);
                phieuTra.TongTienTra = Convert.ToSingle(tongtientra);
                phieuTra.TongSoLuongTra = reader.GetInt32(4);
                phieuTra.TrangThai = reader.GetInt32(6);
                CloseConnection();
                return phieuTra;
            }
            CloseConnection();
            return null;
        }
        public bool KiemTraHoaDon(int mahoadon)
        {
            string sql = "select MaHoaDon from PhieuTra where MaHoaDon=@MaHoaDon";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Value = mahoadon;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
        public int KhoaLonNhat()
        {
            string sql = "select Max(MaPhieuTra) from PhieuTra";
            OpenConnection();
            command = new SqlCommand(sql, connection);
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
        public List<PhieuTra> TimKiemPhieuTra(string text)
        {
            string sql = "select * from PhieuTra where CONCAT(MaPhieuTra,MaNhanVien,MaHoaDon,NgayTra,TongSoLuongTra,TongTienTra,TrangThai) COLLATE Latin1_General_CI_AI like '%"+text+"%' and TrangThai=1";
            OpenConnection();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            List<PhieuTra> dt = new List<PhieuTra>();
            while (reader.Read())
            {
                PhieuTra phieuTra = new PhieuTra();
                phieuTra.MaPhieuTra = reader.GetInt32(0);
                phieuTra.MaNhanVien = reader.GetInt32(1);
                phieuTra.MaHoaDon = reader.GetInt32(2);
                phieuTra.NgayTra = reader.GetDateTime(3);
                double tongtientra = reader.GetDouble(5);
                phieuTra.TongTienTra = Convert.ToSingle(tongtientra);
                phieuTra.TongSoLuongTra = reader.GetInt32(4);
                phieuTra.TrangThai = reader.GetInt32(6);
                dt.Add(phieuTra);
            }
            CloseConnection();
            return dt;
        }
    }
}
