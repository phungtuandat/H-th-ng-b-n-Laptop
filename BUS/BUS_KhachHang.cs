using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_KhachHang
    {
        public static List<DTO_KhachHang> dSKH()
        {
            return DAO_KhachHang.DanhSachKH();
        }

        public static bool ThemKH (DTO_KhachHang khachhang)
        {
            return DAO_KhachHang.ThemKH(khachhang);
        }

        public static DTO_KhachHang TimKH(string Makh)
        {
            return DAO_KhachHang.TimKH(Makh) ;
        }

        public static bool XoaKH (string makh)
        {
            return DAO_KhachHang.XoaKH(makh);
        }

        public static bool SuaKH (string makh, string tenkh, string diachi, string sdt)
        {
            return DAO_KhachHang.SuaKH(makh, tenkh, diachi, sdt);
        }

        public static List<DTO_KhachHang> dSSearch_MaKH(string makh)
        {
            return DAO_KhachHang.TimListKH_TheoMA(makh);
        }

        public static List<DTO_KhachHang> dSSearch_TenKH(string TenKH)
        {
            return DAO_KhachHang.TimListKH_Name(TenKH);
        }
    }
}
