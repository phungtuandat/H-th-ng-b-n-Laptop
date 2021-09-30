using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DAO_ThongKeNhap
    {
        static SqlConnection ncc;
        public static List<DTO_HoaDonNhap> LoadHoaDonNhapTHongKENhap(string ngaytruoc, string ngaysau)
        {
            string query_select = @"Select *from HoaDonNhap where NgayLap between '"+ngaytruoc+"' and  '"+ngaysau+"'";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonNhap> list_DSBH = new List<DTO_HoaDonNhap>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_HoaDonNhap bh = new DTO_HoaDonNhap();
                bh.MaHDnhap = table.Rows[i]["mahd"].ToString();
                bh.Mancc= table.Rows[i]["mancc"].ToString();
                bh.TenNCC = table.Rows[i]["tenncc"].ToString();
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

        public static int TongTien()
        {
            string query = @"Select Sum(TongTien) as TongTien from HoaDonNhap where TinhTrang = 2";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if(dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongTien"].ToString());
        }

        public static int TongHDNhap()
        {
            string query = @"Select Count(MaHD) as TongHDNhap from HoaDonNhap where Tinhtrang < 3";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongHDNhap"].ToString());
        }

        public static int TongSLNhap()
        {
            string query = @"Select SUM(SoLuong) as TongSoLuong from HoaDonNhapChiTiet";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongSoLuong"].ToString());
        }

        public static int TongHDHuy()
        {
            string query = @"Select Count(MaHD) as TongHDHuy from HoaDonNhap where Tinhtrang = 3";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongHDHuy"].ToString());
        }

        public static List<DTO_HoaDonNhap> LoadNhapHangDataGridView()
        {
            string query_select = @"Select *from HoaDonNhap";
            ncc = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, ncc);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDonNhap> list_DSBH = new List<DTO_HoaDonNhap>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_HoaDonNhap bh = new DTO_HoaDonNhap();
                bh.MaHDnhap = table.Rows[i]["mahd"].ToString();
                bh.Mancc = table.Rows[i]["mancc"].ToString();
                bh.TenNCC = table.Rows[i]["tenncc"].ToString();
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

    }
}
