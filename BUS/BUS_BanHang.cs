using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_BanHang
    {
        public static int GiaBan(string malaptop)
        {
            return DAO_BanHang.GiaBan(malaptop);
        }

        public static int SoLuong (string malaptop)
        {
            return DAO_BanHang.SoLuongCon(malaptop);
        }

        public static bool ThemHoaDonBan (DTO_HoaDonBan dto)
        {
            return DAO_BanHang.ThemHoaDon(dto);
        }

        public static List<DTO_HoaDonBanChiTiet> LoadDataGridView(string mahd)
        {
            return DAO_BanHang.LoadBanHangChiTiet(mahd);
        }

        public static bool ThemVaoHoaDonChiTiet(DTO_HoaDonBanChiTiet dto)
        {
            return DAO_BanHang.ThemSanPham(dto);
        }

        public static List<DTO_HoaDonBan> loadmahd()
        {
            return DAO_BanHang.LoadMaHoaDon();
        }

        public static string malaptop (string malaptop,string MaHD)
        {
            return DAO_BanHang.KiemTraMaLapTop(malaptop,MaHD);
        }

        public static bool XoaSanPham(string n,string mahd)
        {
            return DAO_BanHang.XoaChiTietHoaDon(n,mahd);
        }

        public static bool UpdateSoLuong(int soluong, string mahd, string malaptop)
        {
            return DAO_BanHang.UpdateSoLuong(soluong, mahd, malaptop);
        }

        public static List<DTO_Kho> DanhSachLaptopLonHon5()
        {
            return DAO_BanHang.DanhSachLaptopLonHon5();
        }

        public static bool CapNhatHoaDonChiTiet(DTO_HoaDonBanChiTiet chitiet)
        {
            return DAO_BanHang.CapNhatHoaDonChiTiet(chitiet);
        }

        public static List<DTO_HoaDonBan> LoadBanHang(string mahd)
        {
            return DAO_BanHang.LoadBanHang(mahd);
        }

        public static string LayTongTien(string makh)
        {
            return DAO_BanHang.LayTongTien(makh);
        }

        public static string LayTenKH(string makh)
        {
            return DAO_BanHang.LayTeKH(makh);
        }

        public static string LayTenLaptop(string malaptop)
        {
            return DAO_BanHang.LayTenLaptop(malaptop);
        }

        public static bool XacNhan(string MaHd)
        {
            return DAO_BanHang.XacNhan(MaHd);
        }

        public static bool ThanhToan(string mahd)
        {
            return DAO_BanHang.DaThanhToan(mahd);
        }

        public static bool HuyHoaDon(string mahd)
        {
            return DAO_BanHang.HuyHoaDon(mahd);
        }

        public static List<DTO_HoaDonBan> LoadBanHangDataGridView()
        {
            return DAO_BanHang.LoadBanHangDataGridView();
        }

        public static int KiemTraTinhTrangHDban(string mahd)
        {
            return DAO_BanHang.KiemTraTinhTrangHDban(mahd);
        }

        public static bool XoaHangTrongHoaDon(string mhd)
        {
            return DAO_BanHang.XoaHangTrongHoaDon(mhd);
        }

        public static bool UpdateSauXoa(string mhd)
        {
            return DAO_BanHang.CapNhatGiaTriTrongHoaDon(mhd);
        }

        public static DTO_HoaDonBan LoadBanHangDataGridViewHoaDon(string mahd)
        {
            return DAO_BanHang.LoadBanHangDataGridViewHoaDon(mahd);
        }

        public static string LayTenKHHD(string mahd)
        {
            return DAO_BanHang.LayTenKHHD(mahd);
        }

        public static string KiemTraMaHD(string MAHD)
        {
            return DAO_BanHang.KiemTraMaHD(MAHD);
        }
    }
}
