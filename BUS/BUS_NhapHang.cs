using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_NhapHang
    {
        public static bool ThemHoaDon(DTO_HoaDonNhap nhaphang)
        {
            return DAO_ByeProduct.ThemHoaDon(nhaphang);
        }

        public static List<DTO_HoaDonNhap> HoaDonNhap()
        {
            return DAO_ByeProduct.HoaDonNhap();
        }

        public static bool ThemSanPham(DTO_HoaDonNhapChiTiet DTO)
        {
            return DAO_ByeProduct.ThemSanPham(DTO);
        }

        public static string TenSanPham(string masp)
        {
            return DAO_ByeProduct.TenLaptop(masp);
        }

        public static string MaLaptopTrung(string masp,string mahd)
        {
            return DAO_ByeProduct.KiemTraMaLapTop(masp, mahd);
        }

        public static List<DTO_HoaDonNhapChiTiet> LoadNhapHangChiTiet(string mahd)
        {
            return DAO_ByeProduct.LoadNhapHangChiTiet(mahd);
        }

        public static bool LuuHoaDon(string mahd)
        {
            return DAO_ByeProduct.LuuHoaDon(mahd);
        }

        public static int KiemTraTinhTrang(string mahd)
        {
            return DAO_ByeProduct.KiemTraTinhTrang(mahd);
        }

        public static string LayTenNCC(string MANCC)
        {
            return DAO_ByeProduct.LayTenNCC(MANCC);
        }

        public static bool CapNhatGiaChoLaptop(int gia, string malaptop)
        {
            return DAO_ByeProduct.CapNhatGiaChoLaptop(gia, malaptop);
        }

        public static bool XoaDatHangChiTiet(string MaLaptop,string mahd)
        {
            return DAO_ByeProduct.XoaDatHangChiTiet(MaLaptop,mahd);
        }

        public static string KiemTraMaHD(string MAHD)
        {
            return DAO_ByeProduct.KiemTraMaHD(MAHD);
        }

        public static string LayTien(string MAHD)
        {
            return DAO_ByeProduct.LayTien(MAHD);
        }


        public static bool HoaDonNhapThanhCong(string mahd)
        {
            return DAO_ByeProduct.HoaDonNhapThanhCong(mahd);
        }
        public static bool HuyHoaDon(string mahd)
        {
            return DAO_ByeProduct.HuyHoaDon(mahd);
        }
        public static bool XoaHangTrongHoaDon(string mhd)
        {
            return DAO_ByeProduct.XoaHangTrongHoaDon(mhd);
        }

        public static bool UpdateSauXoa(string mhd)
        {
            return DAO_ByeProduct.CapNhatGiaTriTrongHoaDon(mhd);
        }

        public static string LayTenNCCHD(string mahd)
        {
            return DAO_ByeProduct.LayTenNCCHD(mahd);
        }
    }
}
