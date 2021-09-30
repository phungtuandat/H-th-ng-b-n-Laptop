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
    public class DAO_BanHang
    {
        static SqlConnection ncc;

        public static int GiaBan(string malaptop)
        {
            string query = "Select GiaBan from Laptop where MaLaptop = '"+malaptop+"'";
            ncc = Data_Provides.KetNoi();
            DataTable data_giaban = Data_Provides.Select_Query(query, ncc);
            if(data_giaban.Rows.Count == 0 )
            {
                return -1;
            }
            return int.Parse(data_giaban.Rows[0]["GiaBan"].ToString());
        }

        public static int SoLuongCon(string malaptop)
        {
            string query = "Select SoLuongTon from Kho where MaLaptop = '" + malaptop + "'";
            ncc = Data_Provides.KetNoi();
            DataTable data_giaban = Data_Provides.Select_Query(query, ncc);
            if (data_giaban.Rows.Count == 0)
            {
                return -1;
            }
            return int.Parse(data_giaban.Rows[0]["SoLuongTon"].ToString());
        }

        public static bool ThemHoaDon(DTO_HoaDonBan hoadonban)
        {
            string query = @"Insert into HoaDonBan values ('" + hoadonban.MaHDBan + "' ,'" + hoadonban.MaKH + "',N'"+hoadonban.TenKH+"','" + hoadonban.MaNV + "',N'"+hoadonban.TenNV+"','"+hoadonban.Tongtien+"','" + hoadonban.Ngaylap + "','"+hoadonban.TinhTrang+"')";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_HoaDonBanChiTiet> LoadBanHangChiTiet(string mahd)
        {
            string query_select = @"Select *from HoaDonBanChiTiet where MaHD = '" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonBanChiTiet> list_DSBH = new List<DTO_HoaDonBanChiTiet>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_HoaDonBanChiTiet bhct = new DTO_HoaDonBanChiTiet();
                bhct.MaHD = table.Rows[i]["maHd"].ToString();
                bhct.MaLaptop = table.Rows[i]["maLaptop"].ToString();
                bhct.TenLaptop = table.Rows[i]["tenLaptop"].ToString();
                bhct.Soluong = int.Parse(table.Rows[i]["SoLuong"].ToString());
                bhct.Giaban = int.Parse(table.Rows[i]["giaban"].ToString());
                bhct.ThanhTien = int.Parse(table.Rows[i]["thanhtien"].ToString());
                list_DSBH.Add(bhct);
            }
            ncc = Data_Provides.DongKetNoi();
            return list_DSBH;
        }


            public static List<DTO_HoaDonBan> LoadBanHang(string mahd)
            {
                string query_select = @"Select *from HoaDonBan where MaHD = '" + mahd + "'";
                ncc = Data_Provides.KetNoi();
                DataTable table = Data_Provides.Select_Query(query_select, ncc);
                if (table.Rows.Count == 0)
                {
                    return null;
                }
                List<DTO_HoaDonBan> list_DSBH = new List<DTO_HoaDonBan>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DTO_HoaDonBan bh = new DTO_HoaDonBan();
                    bh.MaHDBan = table.Rows[i]["mahd"].ToString();
                    bh.MaKH = table.Rows[i]["makh"].ToString();
                    bh.TenKH = table.Rows[i]["tenkh"].ToString();
                    bh.MaNV = table.Rows[i]["manv"].ToString();
                    bh.TenNV = table.Rows[i]["TenNv"].ToString();
                    bh.Tongtien = int.Parse(table.Rows[i]["tongtien"].ToString());
                    bh.Ngaylap = table.Rows[i]["ngaylap"].ToString();
                    bh.TinhTrang = int.Parse(table.Rows[i]["tinhtrang"].ToString());
                    list_DSBH.Add(bh);
                }
                ncc = Data_Provides.DongKetNoi();
                return list_DSBH;
            }

        public static List<DTO_HoaDonBan> LoadBanHangDataGridView()
        {
            string query_select = @"Select *from HoaDonBan";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonBan> list_DSBH = new List<DTO_HoaDonBan>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_HoaDonBan bh = new DTO_HoaDonBan();
                bh.MaHDBan = table.Rows[i]["mahd"].ToString();
                bh.MaKH = table.Rows[i]["makh"].ToString();
                bh.TenKH = table.Rows[i]["tenkh"].ToString();
                bh.MaNV = table.Rows[i]["manv"].ToString();
                bh.TenNV = table.Rows[i]["TenNv"].ToString();
                bh.Tongtien = int.Parse(table.Rows[i]["Tongtien"].ToString());
                bh.Ngaylap = table.Rows[i]["ngaylap"].ToString();
                bh.TinhTrang = int.Parse(table.Rows[i]["tinhtrang"].ToString());
                list_DSBH.Add(bh);
            }
            ncc = Data_Provides.DongKetNoi();
            return list_DSBH;
        }

        public static DTO_HoaDonBan LoadBanHangDataGridViewHoaDon(string mahd)
        {
            string query_select = @"Select *from HoaDonBan where MaHD = '"+mahd+"'";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
                DTO_HoaDonBan bh = new DTO_HoaDonBan();
                bh.MaHDBan = table.Rows[0]["mahd"].ToString();
                bh.MaKH = table.Rows[0]["makh"].ToString();
                bh.TenKH = table.Rows[0]["tenkh"].ToString();
                bh.MaNV = table.Rows[0]["manv"].ToString();
                bh.TenNV = table.Rows[0]["TenNv"].ToString();
                bh.Tongtien = int.Parse(table.Rows[0]["Tongtien"].ToString());
                bh.Ngaylap = table.Rows[0]["ngaylap"].ToString();
                bh.TinhTrang = int.Parse(table.Rows[0]["tinhtrang"].ToString());
            ncc = Data_Provides.DongKetNoi();
            return bh;
        }


        public static bool ThemSanPham(DTO_HoaDonBanChiTiet DTO)
        {
            string query = string.Format(@"Insert into HoaDonBanChiTiet values ('{0}','{1}','{2}',{3},{4},{5})", DTO.MaHD, DTO.MaLaptop,DTO.TenLaptop,DTO.Soluong, DTO.Giaban,DTO.ThanhTien);
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_HoaDonBan> LoadMaHoaDon()
        {
            string query_select = @"Select *from HoaDonBan where TINHTRANG < 1";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonBan> list_DSBH = new List<DTO_HoaDonBan>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_HoaDonBan dto = new DTO_HoaDonBan();
                dto.MaHDBan = table.Rows[i]["mahd"].ToString();
                list_DSBH.Add(dto);
            }
            ncc = Data_Provides.DongKetNoi();
            return list_DSBH;
        }

        public static string TenLaptop(string malaptop)
        {
            string query = "Select tenlaptop from Laptop where  MaHdBan = '" + malaptop + "'";
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
            string query = "Select *from HoaDonBanChiTiet where MaLaptop = '" + malaptop + "' and mahd = '" + MaHD + "'";
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
        public static bool XoaChiTietHoaDon(string MaLaptop,string mahd)
        {
            string query = "Delete from HoaDonBanChiTiet where MaLaptop = '" + MaLaptop + "' AND MaHD = '"+mahd+"'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }


        public static bool UpdateSoLuong (int soluong,string mahd , string malaptop)
        {
            string query = @"Update HoaDonBanChiTiet set SoLuong = SoLuong + '"+soluong+"' where malaptop ='"+malaptop+"' and mahd = '"+mahd+"'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_Kho> DanhSachLaptopLonHon5()
        {
            string query_select = @"Select *from Kho where SoLuongTon > 2";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count < 0)
            {
                return null;
            }
            List<DTO_Kho> ds_Product = new List<DTO_Kho>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_Kho lpp = new DTO_Kho();
                lpp.MaLaptop = table.Rows[i]["MaLaptop"].ToString();
                lpp.SoLuongTon = int.Parse(table.Rows[i]["SoLuongTon"].ToString());
                lpp.SoLuongBan = int.Parse(table.Rows[i]["SoLuongBan"].ToString());
                ds_Product.Add(lpp);
            }
            ncc = Data_Provides.DongKetNoi();
            return ds_Product;
        }


        public static bool CapNhatHoaDonChiTiet(DTO_HoaDonBanChiTiet chitiet)
        {
            string query = @"Update HoaDonBanChiTiet set MaLaptop = '" + chitiet.MaLaptop + "', SoLuong = '" + chitiet.Soluong + "' where MaHD = '" + chitiet.MaHD + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static string LayTongTien (string mahd)
        {
            string query = "Select TongTien from HoaDonBan where MaHD = '" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if(dt.Rows.Count == 0 )
            {
                return null;
            }
            return dt.Rows[0]["TongTien"].ToString();
        }

        public static string LayTeKH(string makh)
        {
            string query = "Select TenKH from KhachHang where  MaKH = '" + makh + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count < 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TenKH"].ToString();
        }

        public static string LayTenLaptop(string malaptop)
        {
            string query = "Select tenlaptop from Kho where  MaLaptop = '" + malaptop + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count < 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TenLaptop"].ToString();
        }

        public static string LayTenKHHD(string mahd)
        {
            string query = "Select TenKH from HoaDonBan where  MaHD = '" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count < 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["TenKH"].ToString();
        }

        public static bool XacNhan(string mahd)
        {
            string query = @"Update HoaDonBan set TinhTrang = 1 where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool DaThanhToan(string mahd)
        {
            string query = @"Update HoaDonBan set TinhTrang = 2 where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool HuyHoaDon(string mahd)
        {
            string query = @"Update HoaDonBan set TinhTrang = 3 where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static int KiemTraTinhTrangHDban(string mahd)
        {
            string query = @"Select TinhTrang from HoaDonBan where Mahd ='" + mahd + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TinhTrang"].ToString());
        }

        public static bool XoaHangTrongHoaDon(string mhd)
        {
            string query = @"Delete from HoaDonBanChiTiet where MaHD = '" + mhd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool CapNhatGiaTriTrongHoaDon(string mhd)
        {
            string query = @"Update HoaDonBan set TongTien = 0 where MaHD = '" + mhd + "'";
            ncc = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, ncc);
            ncc = Data_Provides.DongKetNoi();
            return kq;
        }

        public static string KiemTraMaHD(string MAHD)
        {
            string query = @"Select MaHD from HoaDonBan where MaHD ='" + MAHD + "'";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ncc = Data_Provides.DongKetNoi();
            return dt.Rows[0]["MaHD"].ToString();
        }

    }
}
