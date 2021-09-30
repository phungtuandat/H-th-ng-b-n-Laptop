using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class Dao_Login
    {
        static SqlConnection ketnoi;
        public static DTO_Login TaiKhoan(string taikhoan, string matkhau)
        {
            string query = string.Format(@"Select *from NhanVien where MaNv = '{0}' and MatKhau = '{1}'",taikhoan,matkhau);
            ketnoi = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ketnoi);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_Login lg = new DTO_Login();
            lg.MaNV = dt.Rows[0]["MaNV"].ToString();
            lg.MatKhau = dt.Rows[0]["MatKhau"].ToString();
            ketnoi = Data_Provides.DongKetNoi();
            return lg;
        }

        public static int TaiKhoanQuyen (string taikhoan)
        {
            string query = string.Format(@"Select Quyen from NhanVien where MaNV ='{0}'", taikhoan);
            ketnoi = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ketnoi);
            ketnoi = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["Quyen"].ToString());
        }

        public static string TenTK (string ten)
        {
            string query = string.Format(@"Select MaNV from NhanVien where MaNV ='{0}'",ten);
            ketnoi = Data_Provides.KetNoi();
            SqlCommand cm = new SqlCommand(query,ketnoi);
            string kq = cm.ExecuteScalar().ToString();
            ketnoi = Data_Provides.DongKetNoi();
            return kq;
        }

        public static string LayTenNV (string manv)
        {
            string query = string.Format(@"Select TenNV from NhanVien where MaNV ='{0}'", manv);
            ketnoi = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ketnoi);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                ketnoi = Data_Provides.DongKetNoi();
                return dt.Rows[0]["tennv"].ToString();
            }
            
        }
    }
}
