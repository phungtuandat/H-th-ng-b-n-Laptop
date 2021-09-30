using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_NhanVien
    {
        public static List<DTO_NhanVien> dSNV()
        {
            return DAO_NhanVien.DanhSachNV();
        }

        public static bool ThemNhanVien (DTO_NhanVien NhanVien)
        {
            return DAO_NhanVien.ThemNV(NhanVien);
        }

        public static DTO_NhanVien TimNhanVien(string MaNhanVien)
        {
            return DAO_NhanVien.TimNV(MaNhanVien);
        }

        public static bool XoaNhanVien (string maNhanVien)
        {
            return DAO_NhanVien.XoaNV(maNhanVien);
        }

        public static bool SuaNhanVien (string maNhanVien, string tenNhanVien, string diachi, string sdt, string matkhau, int quyen)
        {
            return DAO_NhanVien.SuaNV(maNhanVien, tenNhanVien, diachi, sdt, matkhau, quyen);
        }

        public static List<DTO_NhanVien> dSSearch_MaNhanVien(string maNhanVien)
        {
            return DAO_NhanVien.TimListNV_TheoMA(maNhanVien);
        }

        public static List<DTO_NhanVien> dSSearch_TenNhanVien(string TenNhanVien)
        {
            return DAO_NhanVien.TimListNV_NameNV(TenNhanVien);
        }

        public static string MathoaMatKhau(string pass)
        {
            return DAO_NhanVien.GetMD5(pass);
        }

        public static DTO_NhanVien KiemTraMK(string manv)
        {
            return DAO_NhanVien.KiemTraMatKhauCu(manv);
        }
    }
}
