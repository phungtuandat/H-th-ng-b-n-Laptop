using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_LoaiLaptop
    {
        static SqlConnection conn;
        public static List<DTO_LoaiLaptop> DanhSachLoaiLaptop()
        {
            string query_select = @"Select *from LoaiLaptop";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if (table.Rows.Count < 0)
            {
                return null;
            }
            List<DTO_LoaiLaptop> dsloai = new List<DTO_LoaiLaptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_LoaiLaptop loai = new DTO_LoaiLaptop();
                loai.MaLoai = table.Rows[i]["MaLH"].ToString();
                loai.MaNCC = table.Rows[i]["MaNCC"].ToString();
                loai.MaTTBH = table.Rows[i]["MaTTBH"].ToString();
                loai.TenLoai = table.Rows[i]["TenLH"].ToString();
                dsloai.Add(loai);
            }
            conn = Data_Provides.DongKetNoi();
            return dsloai;
        }

        public static DTO_LoaiLaptop TimLoaiLaptop(string MaLH)
        {
            string query = string.Format(@"Select *from LoaiLaptop where MaLH = '{0}'", MaLH);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_LoaiLaptop kq = new DTO_LoaiLaptop();
            DTO_LoaiLaptop loai = new DTO_LoaiLaptop();
            loai.MaLoai = dt.Rows[0]["MaLH"].ToString();
            loai.MaNCC = dt.Rows[0]["MaNCC"].ToString();
            loai.MaTTBH = dt.Rows[0]["MaTTBH"].ToString();
            loai.TenLoai = dt.Rows[0]["TenLH"].ToString();
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool ThemLoaiLaptop(DTO_LoaiLaptop loai)
        {
            string query = @"Insert into LoaiLaptop values ('" + loai.MaLoai + "','" + loai.MaNCC + "','"+loai.MaTTBH+"',N'" + loai.TenLoai + "')";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaLoaiLaptop(string MaLH)
        {
            string query = @"Delete from LoaiLaptop where MaLH='" + MaLH + "'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool SuaLoaiLaptop(string MaLoai , string Mancc, string mattbh, string TenLoai)
        {
            string query = string.Format(@"Update LoaiLaptop set MaNCC='{1}', MaTTBH='{2} ,TenLH =N'{3}' where MaLH = '{0}'", MaLoai,Mancc,mattbh,TenLoai);
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_LoaiLaptop> TimListLoaiLaptop_TheoMA(string MaLH)
        {
            string query = string.Format(@"Select *from LoaiLaptop where MaLH Like'{0}%'", MaLH);
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query, conn);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_LoaiLaptop> ds_search = new List<DTO_LoaiLaptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_LoaiLaptop loai = new DTO_LoaiLaptop();
                loai.MaLoai = table.Rows[i]["MaLH"].ToString();
                loai.MaNCC = table.Rows[i]["MaNCC"].ToString();
                loai.TenLoai = table.Rows[i]["TenLH"].ToString();
                ds_search.Add(loai);
            }

            return ds_search;
        }

        public static List<DTO_LoaiLaptop> TimListLoaiLaptop_NameNCC(string TenNCC)
        {
            string query = string.Format(@"Select *from LoaiLaptop where TenNCC Like'{0}%'", TenNCC);
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query, conn);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_LoaiLaptop> ds_search = new List<DTO_LoaiLaptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_LoaiLaptop loai = new DTO_LoaiLaptop();
                loai.MaLoai = table.Rows[i]["MaLH"].ToString();
                loai.MaNCC = table.Rows[i]["MaNCC"].ToString();
                loai.TenLoai = table.Rows[i]["TenLH"].ToString();
                ds_search.Add(loai);
            }

            return ds_search;
        }
    }
}
