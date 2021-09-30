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
    public class DAO_Kho
    {
        static SqlConnection connection;
        public static List<DTO_Kho> DanhSachLapTop()
        {
            string query = @"Select *from Kho";
            connection = Data_Provides.KetNoi();
            DataTable tb = Data_Provides.Select_Query(query, connection);
            if(tb.Rows.Count ==0)
            {
                return null;
            }
            List<DTO_Kho> ds_kho = new List<DTO_Kho>();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DTO_Kho kho = new DTO_Kho();
                kho.STT = int.Parse(tb.Rows[i]["STT"].ToString());
                kho.MaLaptop = tb.Rows[i]["MaLaptop"].ToString();
                kho.TenLaptop = tb.Rows[i]["TenLaptop"].ToString();
                kho.SoLuongTon = int.Parse(tb.Rows[i]["SoLuongTon"].ToString());
                kho.SoLuongBan = int.Parse(tb.Rows[i]["SoLuongBan"].ToString());

                ds_kho.Add(kho);
            }
            return ds_kho;
        }
    }
}
