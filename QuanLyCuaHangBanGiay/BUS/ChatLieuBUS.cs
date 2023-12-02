using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChatLieuBUS
    {
        ChatLieuDAO chatLieuDAO = new ChatLieuDAO();
        public List<ChatLieu> getChatLieu()
        {
            return chatLieuDAO.getChatLieu();
        }
        public string TenChatLieu(int machatlieu)
        {
            return chatLieuDAO.TenChatLieu(machatlieu);
        }
        public int MaChatLieu(string machatlieu)
        {
            return chatLieuDAO.MaChatLieu(machatlieu);
        }
        public bool ThemChatLieu(ChatLieu chatLieu)
        {
            return chatLieuDAO.ThemChatLieu(chatLieu);
        }
        public bool XoaChatLieu(int machatlieu)
        {
            return chatLieuDAO.XoaChatLieu(machatlieu);
        }
        public bool SuaChatLieu(ChatLieu chatLieu)
        {
            return chatLieuDAO.SuaChatLieu(chatLieu);
        }
        public List<ChatLieu> TimKiemChatLieu(string text)
        {
            return chatLieuDAO.TimKiemChatLieu(text);
        }
        public bool KiemTraChatLieu(string tenchatlieu)
        {
            return chatLieuDAO.KiemTraChatLieu(tenchatlieu);
        }
        public List<string> DanhSachChatLieu()
        {
            List<string> list = new List<string>();
            foreach (var i in chatLieuDAO.getChatLieu())
            {
                list.Add(i.TenChatLieu);
            }
            return list;
        }
    }
}
