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
    public class DAO_ByeProduct
    {
        static SqlConnection ncc;
        public static bool ThemHoaDon(DTO_HoaDonNhap hoadonnhap)
        {
            string query = @"Insert into HoaDonNhap values ('" + hoadonnhap.MaHDnhap + "' ,'" + hoadonnhap.Mancc + "',N'" + hoadonnhap.TenNCC + "','" + hoadonnhap.MaNV + "',N'" + hoadonnhap.TenNV + "','" + hoadonnhap.Tongtien+"','" + hoadonnhap.Ngaylap + "','"+hoadonnhap.TinhTrang+"')";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        // combobox
        public static List<DTO_HoaDonNhap> HoaDonNhap()
        {
            string query = @"Select *from HoaDonNhap where TinhTrang < 2";
            ncc = Data_Provides.KetNoi();
            DataTable data = Data_Provides.Select_Query(query, ncc);
            if(data.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonNhap> ds_hd = new List<DTO_HoaDonNhap>();
            for(int i = 0; i <data.Rows.Count;i++)
            {
                DTO_HoaDonNhap hoadon = new DTO_HoaDonNhap();
                hoadon.MaHDnhap = data.Rows[i]["mahd"].ToString();
                hoadon.Mancc = data.Rows[i]["mancc"].ToString();
                hoadon.TenNCC = data.Rows[i]["tenncc"].ToString();
                hoadon.MaNV = data.Rows[i]["manv"].ToString();
                hoadon.TenNV = data.Rows[i]["tennv"].ToString();
                hoadon.Tongtien = int.Parse(data.Rows[i]["Tongtien"].ToString());
                hoadon.Ngaylap = data.Rows[i]["NgayLap"].ToString();
                hoadon.TinhTrang = int.Parse(data.Rows[i]["TinhTrang"].ToString());
                ds_hd.Add(hoadon);
            }
            return ds_hd;
        }

        public static bool ThemSanPham(DTO_HoaDonNhapChiTiet DTO)
        {
            string query = string.Format(@"Insert into HoaDonnhapChiTiet values ('{0}','{1}','{2}',{3},{4},{5})", DTO.MaHD_nhap, DTO.MaLaptop_nhap, DTO.TenLaptop,DTO.Soluong, DTO.Gianhap,DTO.ThanhTien);
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            return kq;
        }

        public static string TenLaptop(string malaptop)
        {
            string query = "Select tenlaptop from Kho where MaLaptop = '" + malaptop + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if(dt.Rows.Count < 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TenLaptop"].ToString();
        }

        public static string KiemTraMaLapTop(string malaptop, string MaHD)
        {
            string query = "Select *from HoaDonnhapChiTiet where MaLaptop = '" + malaptop + "' and mahd = '" + MaHD + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string kq = dt.Rows[0]["MaLaptop"].ToString();
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }
        public static bool XoaChiTietHoaDon(int STT,string mahd)
        {
            string query = "Delete from HoaDonnhapChiTiet where STT = '" + STT + "' AND MaHD = '"+mahd+"'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_HoaDonNhapChiTiet> LoadNhapHangChiTiet(string mahd)
        {
            string query_select = @"Select *from HoaDonNhapChiTiet where MaHD = '" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonNhapChiTiet> list_DSBH = new List<DTO_HoaDonNhapChiTiet>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_HoaDonNhapChiTiet bhct = new DTO_HoaDonNhapChiTiet();
                bhct.MaHD_nhap= table.Rows[i]["maHd"].ToString();
                bhct.MaLaptop_nhap = table.Rows[i]["maLaptop"].ToString();
                bhct.TenLaptop = table.Rows[i]["tenlaptop"].ToString();
                bhct.Soluong = int.Parse(table.Rows[i]["SoLuong"].ToString());
                bhct.Gianhap = int.Parse(table.Rows[i]["giamua"].ToString());
                bhct.ThanhTien = int.Parse(table.Rows[i]["thanhtien"].ToString());
                list_DSBH.Add(bhct);
            }
            ncc = Data_Provides.DongKetNoi();
            return list_DSBH;
        }

        public static bool LuuHoaDon(string mahd)
        {
            string query = @"Update HoaDonNhap set TinhTrang = 1 where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool HoaDonNhapThanhCong(string mahd)
        {
            string query = @"Update HoaDonNhap set TinhTrang = 2 where Mahd ='" + mahd + "' and TinhTrang = 1";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static int KiemTraTinhTrang (string mahd)
        {
            string query = @"Select TinhTrang from HoaDonNhap where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TinhTrang"].ToString());
        }

        public static string LayTenNCC(string MANCC)
        {
            string query = @"Select TenNCC from NhaCungCap where MaNCC ='" + MANCC+ "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TenNCC"].ToString();
        }

        public static string KiemTraMaHD(string MAHD)
        {
            string query = @"Select MaHD from HoaDonNhap where MaHD ='" + MAHD + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["MaHD"].ToString();
        }

        public static bool CapNhatGiaChoLaptop(string gia,string malaptop)
        {
            string query = string.Format(@"Update Laptop set GiaBan = {0} where MaLaptop = '{1}'",gia,malaptop);
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaDatHangChiTiet (string MaLaptop,string Mahd)
        {
            string query = @"Delete HoaDonNhapChiTiet Where MaLaptop = '" + MaLaptop + "' and MaHD = '"+Mahd+"'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static string LayTien(string MAHD)
        {
            string query = @"Select TongTien from HoaDonNhap where MaHD ='" + MAHD + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TongTien"].ToString();
        }


        public static bool HuyHoaDon(string mahd)
        {
            string query = @"Update HoaDonNhap set TinhTrang = 3 where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaHangTrongHoaDon(string mhd)
        {
            string query = @"Delete from HoaDonNhapChiTiet where MaHD = '" + mhd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool CapNhatGiaTriTrongHoaDon(string mhd)
        {
            string query = @"Update HoaDonNhap set TongTien = 0 where MaHD = '" + mhd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static string LayTenNCCHD(string mahd)
        {
            string query = "Select TenNCC from HoaDonNhap where MaHD = '" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count < 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TenNCC"].ToString();
        }
    }
}
