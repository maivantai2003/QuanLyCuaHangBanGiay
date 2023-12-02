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
    public class ChatLieuDAO:Connection
    {
        public List<ChatLieu> getChatLieu()
        {
            List<ChatLieu> dt = new List<ChatLieu>();
            try
            {
                //string sql = "select * from ChatLieu where TrangThai=1";
                command = new SqlCommand("Select_ChatLieu", connection) { CommandType=CommandType.StoredProcedure};
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChatLieu chatLieu = new ChatLieu();
                    chatLieu.MaChatLieu = reader.GetInt32(0);
                    chatLieu.TenChatLieu = reader.GetString(1);
                    chatLieu.TrangThai = reader.GetInt32(2);
                    dt.Add(chatLieu);
                }
                CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string TenChatLieu(int machatlieu)
        {
            try
            {
                string sql = "select TenChatLieu from ChatLieu where MaChatLieu=@machatlieu";
                command = new SqlCommand(sql, connection);
                command.Parameters.Add("@machatlieu", SqlDbType.Int).Value = machatlieu;
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int MaChatLieu(string tenchatlieu)
        {
            try
            {
                string sql = "select MaChatLieu from ChatLieu where TenChatLieu=@tenchatlieu";
                command = new SqlCommand(sql,connection);
                command.Parameters.Add("@tenchatlieu", SqlDbType.NVarChar).Value = tenchatlieu;
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ThemChatLieu(ChatLieu chatLieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO ChatLieu VALUES(@tenChatLieu, @trangThai)";
            command.Connection = connection;
            command.Parameters.Add("@tenChatLieu", SqlDbType.NVarChar).Value = chatLieu.TenChatLieu;
            command.Parameters.Add("@trangThai", SqlDbType.Int).Value = chatLieu.TrangThai;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public bool SuaChatLieu(ChatLieu chatLieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE ChatLieu SET TenChatLieu = @tenChatLieu WHERE MaChatLieu = @maChatLieu";
            command.Connection = connection;
            command.Parameters.Add("@tenChatLieu", SqlDbType.NVarChar).Value = chatLieu.TenChatLieu;
            command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = chatLieu.MaChatLieu;
            OpenConnection();
            int n = command.ExecuteNonQuery();
            CloseConnection();
            return n > 0;
        }
        public bool XoaChatLieu(int machatLieu)
        {
            OpenConnection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update ChatLieu set TrangThai=0 WHERE MaChatLieu = @maChatLieu";
            command.Connection = connection;
            command.Parameters.Add("@maChatLieu", SqlDbType.Int).Value = machatLieu;
            int ketQua = command.ExecuteNonQuery();
            CloseConnection();
            return ketQua > 0;
        }
        public List<ChatLieu> TimKiemChatLieu(string text)
        {
            List<ChatLieu> dt = new List<ChatLieu>();
            string sql = "SELECT * FROM ChatLieu WHERE UPPER(CONCAT(MaChatLieu, TenChatLieu, TrangThai)) COLLATE Latin1_General_CI_AI like '%" + text + "%' and TrangThai=1";
            command = new SqlCommand(sql, connection);
            OpenConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChatLieu chatLieu=new ChatLieu();
                chatLieu.MaChatLieu = reader.GetInt32(0);
                chatLieu.TenChatLieu=reader.GetString(1);
                chatLieu.TrangThai=reader.GetInt32(2);
                dt.Add(chatLieu);
            }
            CloseConnection();
            return dt;
        }
        public bool KiemTraChatLieu(string tenchatlieu)
        {
            string sql = "select * from ChatLieu where TenChatLieu=@TenChatLieu and TrangThai=1";
            command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TenChatLieu",SqlDbType.NVarChar).Value=tenchatlieu;
            OpenConnection();
            reader = command.ExecuteReader();
            if(reader.Read()) { 
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
    }
}
