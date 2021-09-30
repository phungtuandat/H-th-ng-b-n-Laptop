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
    public class DAO_NCC
    {
        static SqlConnection conn;
        public static List<DTO_NhaCungCap> DanhSachNCC()
        {
            string query_select = @"Select *from NhaCungCap";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if(table.Rows.Count < 0 )
            {
                return null;
            }
            List<DTO_NhaCungCap> ncc = new List<DTO_NhaCungCap>();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                DTO_NhaCungCap cungCap = new DTO_NhaCungCap();
                cungCap.Ma_NCC = table.Rows[i]["MaNCC"].ToString();
                cungCap.Ten_NCC = table.Rows[i]["TenNCC"].ToString();
                cungCap.Dia_Chi = table.Rows[i]["DiaChi"].ToString();
                cungCap.SdT = table.Rows[i]["DienThoai"].ToString();

                ncc.Add(cungCap);
            }
            conn = Data_Provides.DongKetNoi();
            return ncc;        
        }

        public static DTO_NhaCungCap TimNCC(string MaNCC)
        {
            string query = string.Format(@"Select *from NhaCungCap where MaNCC = '{0}'",MaNCC);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NhaCungCap kq = new DTO_NhaCungCap();
            kq.Ma_NCC = dt.Rows[0]["MaNCC"].ToString();
            kq.Ten_NCC = dt.Rows[0]["TenNCC"].ToString();
            kq.Dia_Chi = dt.Rows[0]["DiaChi"].ToString();
            kq.SdT = dt.Rows[0]["DienThoai"].ToString();
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool ThemNCC(DTO_NhaCungCap ncc)
        {
            string query = @"Insert into NhaCungCap values ('" + ncc.Ma_NCC + "',N'" + ncc.Ten_NCC + "',N'" + ncc.Dia_Chi + "','" + ncc.SdT + "')";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaNCC(string mancc)
        {
            string query = @"Delete FROM NhaCungCap where MaNCC='"+mancc+"'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool SuaNCC(string mancc, string tenncc, string diachi,string sdt)
        {
            string query = string.Format(@"Update NhaCungCap set TenNCC=N'{1}', DiaChi =N'{2}',DienThoai='{3}' where MaNCC = '{0}'",mancc,tenncc,diachi,sdt);
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_NhaCungCap> TimListNCC_TheoMA(string MaNCC)
        {
            string query = string.Format(@"Select *from NhaCungCap where MaNCC Like'{0}%'", MaNCC);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhaCungCap> ds_search = new List<DTO_NhaCungCap>();
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                DTO_NhaCungCap kq = new DTO_NhaCungCap();
                kq.Ma_NCC = dt.Rows[i]["MaNCC"].ToString();
                kq.Ten_NCC = dt.Rows[i]["TenNCC"].ToString();
                kq.Dia_Chi = dt.Rows[i]["DiaChi"].ToString();
                kq.SdT = dt.Rows[i]["DienThoai"].ToString();
                conn = Data_Provides.DongKetNoi();
                ds_search.Add(kq);
            }

            return ds_search;
        }

        public static List<DTO_NhaCungCap> TimListNCC_NameNCC(string TenNCC)
        {
            string query = string.Format(@"Select *from NhaCungCap where TenNCC Like'{0}%'", TenNCC);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhaCungCap> ds_search = new List<DTO_NhaCungCap>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhaCungCap kq = new DTO_NhaCungCap();
                kq.Ma_NCC = dt.Rows[i]["MaNCC"].ToString();
                kq.Ten_NCC = dt.Rows[i]["TenNCC"].ToString();
                kq.Dia_Chi = dt.Rows[i]["DiaChi"].ToString();
                kq.SdT = dt.Rows[i]["DienThoai"].ToString();
                conn = Data_Provides.DongKetNoi();
                ds_search.Add(kq);
            }

            return ds_search;
        }
    }
}
