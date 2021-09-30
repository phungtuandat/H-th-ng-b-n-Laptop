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
    public class DAO_TTBH
    {
        static SqlConnection conn;
        public static List<DTO_TrungTamBaoHaanh> DanhSachTrungTam()
        {
            string query_select = @"Select *from TrungTamBaoHanh";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if(table.Rows.Count < 0 )
            {
                return null;
            }
            List<DTO_TrungTamBaoHaanh> ds_ttbh = new List<DTO_TrungTamBaoHaanh>();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                DTO_TrungTamBaoHaanh dto = new DTO_TrungTamBaoHaanh();
                dto.MaTT = table.Rows[i]["MaTTBH"].ToString();
                dto.TenTT = table.Rows[i]["TenTT"].ToString();
                dto.DiaChi = table.Rows[i]["DiaChi"].ToString();
                dto.Phone = table.Rows[i]["DienThoai"].ToString();
                ds_ttbh.Add(dto);
            }
            conn = Data_Provides.DongKetNoi();
            return ds_ttbh;        
        }

        public static string TimTTBH(string ma)
        {
            string query_select = @"Select MaTTBH from TrungTamBaoHanh where MaTTBH = '"+ma+"'";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return table.Rows[0]["MaTTBH"].ToString();
        }

        public static bool ThemTTBH(DTO_TrungTamBaoHaanh ttbh)
        {
            string query = @"Insert into TrungTamBaoHanh values ('" + ttbh.MaTT + "',N'"+ttbh.TenTT+"',N'" + ttbh.DiaChi + "','" + ttbh.Phone + "')";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaTTBH(string maTTBH)
        {
            string query = @"Delete From TrungTamBaoHanh where MaTTBH='"+maTTBH+"'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool SuaTTBH(string matt, string tentt, string diachi,string sdt)
        {
            string query = string.Format(@"Update TrungTamBaoHanh set TenTT =N'{1}'DiaChi =N'{2}',DienThoai='{3}' where MaTTBH = '{0}'",matt,tentt,diachi,sdt);
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }
    }
}
