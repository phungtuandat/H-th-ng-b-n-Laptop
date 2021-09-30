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
    public class DAO_KhachHang
    {
        static SqlConnection conn;
        public static List<DTO_KhachHang> DanhSachKH()
        {
            string query_select = @"Select *from KhachHang";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if(table.Rows.Count < 0 )
            {
                return null;
            }
            List<DTO_KhachHang> ds_kh = new List<DTO_KhachHang>();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.Makh = table.Rows[i]["MaKH"].ToString();
                kh.Tenkh = table.Rows[i]["TenKh"].ToString();
                kh.Diachi = table.Rows[i]["DiaChi"].ToString();
                kh.Dienthoai = table.Rows[i]["DienThoai"].ToString();
                ds_kh.Add(kh);
            }
            conn = Data_Provides.DongKetNoi();
            return ds_kh;        
        }

        public static DTO_KhachHang TimKH(string MaKH)
        {
            string query = string.Format(@"Select *from KhachHang where MaKH = '{0}'",MaKH);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.Makh = dt.Rows[0]["MaKH"].ToString();
            kh.Tenkh = dt.Rows[0]["TenKh"].ToString();
            kh.Diachi = dt.Rows[0]["DiaChi"].ToString();
            kh.Dienthoai = dt.Rows[0]["DienThoai"].ToString();
            conn = Data_Provides.DongKetNoi();
            return kh;
        }

        public static bool ThemKH(DTO_KhachHang kh)
        {
            string query = @"Insert into KhachHang values ('" + kh.Makh + "',N'" + kh.Tenkh + "',N'" + kh.Diachi + "','" + kh.Dienthoai + "')";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaKH(string maKH)
        {
            string query = @"Delete FROM KhachHang where MaKH='"+maKH+"'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool SuaKH(string maKH, string tenKH, string diachi,string sdt)
        {
            string query = string.Format(@"Update KhachHang set TenKH=N'{1}', DiaChi =N'{2}',DienThoai='{3}' where MaKH = '{0}'",maKH,tenKH,diachi,sdt);
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_KhachHang> TimListKH_TheoMA(string MaKH)
        {
            string query = string.Format(@"Select *from NhaCungCap where MaKH Like'{0}%'", MaKH);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_KhachHang> ds_search = new List<DTO_KhachHang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.Makh = dt.Rows[i]["MaKH"].ToString();
                kh.Tenkh = dt.Rows[i]["TenKh"].ToString();
                kh.Diachi = dt.Rows[i]["DiaChi"].ToString();
                kh.Dienthoai = dt.Rows[i]["DienThoai"].ToString();
                ds_search.Add(kh);
            }

            return ds_search;
        }

        public static List<DTO_KhachHang> TimListKH_Name(string tenKH)
        {
            string query = string.Format(@"Select *from NhaCungCap where TenKH Like'{0}%'", tenKH);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_KhachHang> ds_search_name = new List<DTO_KhachHang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.Makh = dt.Rows[i]["MaKH"].ToString();
                kh.Tenkh = dt.Rows[i]["TenKh"].ToString();
                kh.Diachi = dt.Rows[i]["DiaChi"].ToString();
                kh.Dienthoai = dt.Rows[i]["DienThoai"].ToString();
                ds_search_name.Add(kh);
            }

            return ds_search_name;
        }
    }
}
