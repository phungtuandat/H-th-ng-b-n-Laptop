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
    public class DAO_LSDN
    {
        static SqlConnection cn;
        public static bool ThemLichSu(DTO_LichSuDangNhap ls)
        {
            string query = string.Format(@"Insert into LichSuLogin values ({0},'{1}','{2}','{3}',N'{4}')",ls.Stt,ls.Manv,ls.Time,ls.Giora,ls.Tinhtrang);
            cn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, cn);
            cn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static int STT()
        {
            string query = @"select COUNT(STT) + 1 as STT from LichSuLogin";
            cn = Data_Provides.KetNoi();
            DataTable tb = Data_Provides.Select_Query(query, cn);
            if(tb.Rows.Count < 0)
            {
                return -1;
            }
            return int.Parse(tb.Rows[0]["STT"].ToString());
        }

        public static bool CapNhatGioRa(int stt, string time)
        {
            string query = string.Format(@"Update LichSuLogin set Giora = '{1}' where stt = {0}",stt,time);
            cn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, cn);
            cn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_LichSuDangNhap> ds()
        {
            string query = @"Select *from LichSuLogin";
            cn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, cn);
            if(dt.Rows.Count ==0)
            {
                return null;
            }
            List<DTO_LichSuDangNhap> dsls = new List<DTO_LichSuDangNhap>();
            for(int i = 0; i< dt.Rows.Count;i++)
            {
                DTO_LichSuDangNhap LS = new DTO_LichSuDangNhap();
                LS.Stt = int.Parse(dt.Rows[i]["Stt"].ToString());
                LS.Manv = dt.Rows[i]["manv"].ToString();
                LS.Time = dt.Rows[i]["giovao"].ToString();
                LS.Giora = dt.Rows[i]["giora"].ToString();
                LS.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dsls.Add(LS);
            }
            return dsls;
            
        }
    }
}
