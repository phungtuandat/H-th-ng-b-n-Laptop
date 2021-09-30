using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_CheckPass
    {
        static SqlConnection con;
        public static bool UpdateMatKhau(string mk, string tendn)
        {
            string query = @"Update NhanVien set MatKhau = '" + mk + "' where MaNV = '"+tendn+"'";
            con = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query,con);
            con = Data_Provides.DongKetNoi();
            return kq;
        }
    }
}
