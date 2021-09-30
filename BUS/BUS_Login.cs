using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_Login
    {
        public static DTO_Login login(string TaiKhoan, string MatKhau)
        {
            return Dao_Login.TaiKhoan(TaiKhoan, MatKhau);
        }

        public static int QuyenTaiKhoan(string TaiKhoan)
        {
            return Dao_Login.TaiKhoanQuyen(TaiKhoan);
        }

        public static string TenDN (string TenDN)
        {
            return Dao_Login.TenTK(TenDN);
        }

        public static string LayTenNV(string manv)
        {
            return Dao_Login.LayTenNV(manv);
        }
    }
}
