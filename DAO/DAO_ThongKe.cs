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
    public class DAO_ThongKe
    {
        static SqlConnection ncc;
        public static List<DTO_HoaDonBan> LoadHoaDonBanTHongKE(string ngaytruoc, string ngaysau)
        {
            string query_select = @"Select *from HoaDonBan where NgayLap between '"+ngaytruoc+"' and  '"+ngaysau+"'";
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

        public static int TongTien()
        {
            string query = @"Select Sum(TongTien) as TongTien from HoaDonBan where TinhTrang = 2";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if(dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongTien"].ToString());
        }

        public static int TongHDBan()
        {
            string query = @"Select Count(MaHD) as TongHDBan from HoaDonBan where Tinhtrang < 3";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongHDBan"].ToString());
        }

        public static int TongSLBan()
        {
            string query = @"Select SUM(SoLuong) as TongSoLuong from HoaDonBanChiTiet";
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
            string query = @"Select Count(MaHD) as TongHDHuy from HoaDonBan where Tinhtrang = 3";
            ncc = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, ncc);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            ncc = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["TongHDHuy"].ToString());
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

    }
}
