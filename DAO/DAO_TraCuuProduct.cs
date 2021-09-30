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
    public class DAO_TraCuuProduct
    {
        static SqlConnection connection;
        public static List<DTO_Laptop> DanhSachLaptop2Den5()
        {
            string query_select = @"Select *from Laptop Where GiaBan between 2000000  and 5000000";
            connection = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, connection);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Laptop> ds_Product = new List<DTO_Laptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_Laptop lpp = new DTO_Laptop();
                lpp.MaLaptop = table.Rows[i]["malaptop"].ToString();
                lpp.MaLH = table.Rows[i]["malh"].ToString();
                lpp.TenLaptop = table.Rows[i]["tenlaptop"].ToString();
                lpp.Ram = table.Rows[i]["ram"].ToString();
                lpp.Ocung = table.Rows[i]["ocung"].ToString();
                lpp.Cpu = table.Rows[i]["Cpu"].ToString();
                lpp.Gpu = table.Rows[i]["gpu"].ToString();
                lpp.HDH1 = table.Rows[i]["HDH"].ToString();
                lpp.Giaban = int.Parse(table.Rows[i]["Giaban"].ToString());
                lpp.Duongdan = table.Rows[i]["Image_Product"].ToString();
                lpp.Ghichu = table.Rows[i]["ghichu"].ToString();

                ds_Product.Add(lpp);
            }
            connection = Data_Provides.DongKetNoi();
            return ds_Product;
        }

        public static List<DTO_Laptop> DanhSachLaptop5Den7()
        {
            string query_select = @"Select *from Laptop Where GiaBan between 5000000  and 7000000";
            connection = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, connection);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Laptop> ds_Product = new List<DTO_Laptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_Laptop lpp = new DTO_Laptop();
                lpp.MaLaptop = table.Rows[i]["malaptop"].ToString();
                lpp.MaLH = table.Rows[i]["malh"].ToString();
                lpp.TenLaptop = table.Rows[i]["tenlaptop"].ToString();
                lpp.Ram = table.Rows[i]["ram"].ToString();
                lpp.Ocung = table.Rows[i]["ocung"].ToString();
                lpp.Cpu = table.Rows[i]["Cpu"].ToString();
                lpp.Gpu = table.Rows[i]["gpu"].ToString();
                lpp.HDH1 = table.Rows[i]["HDH"].ToString();
                lpp.Giaban = int.Parse(table.Rows[i]["Giaban"].ToString());
                lpp.Duongdan = table.Rows[i]["Image_Product"].ToString();
                lpp.Ghichu = table.Rows[i]["ghichu"].ToString();

                ds_Product.Add(lpp);
            }
            connection = Data_Provides.DongKetNoi();
            return ds_Product;
        }

        public static List<DTO_Laptop> DanhSachLaptop7Den15()
        {
            string query_select = @"Select *from Laptop Where GiaBan between 7000000  and 15000000";
            connection = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, connection);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Laptop> ds_Product = new List<DTO_Laptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_Laptop lpp = new DTO_Laptop();
                lpp.MaLaptop = table.Rows[i]["malaptop"].ToString();
                lpp.MaLH = table.Rows[i]["malh"].ToString();
                lpp.TenLaptop = table.Rows[i]["tenlaptop"].ToString();
                lpp.Ram = table.Rows[i]["ram"].ToString();
                lpp.Ocung = table.Rows[i]["ocung"].ToString();
                lpp.Cpu = table.Rows[i]["Cpu"].ToString();
                lpp.Gpu = table.Rows[i]["gpu"].ToString();
                lpp.HDH1 = table.Rows[i]["HDH"].ToString();
                lpp.Giaban = int.Parse(table.Rows[i]["Giaban"].ToString());
                lpp.Duongdan = table.Rows[i]["Image_Product"].ToString();
                lpp.Ghichu = table.Rows[i]["ghichu"].ToString();

                ds_Product.Add(lpp);
            }
            connection = Data_Provides.DongKetNoi();
            return ds_Product;
        }

        public static List<DTO_Laptop> DanhSachLaptop15TroLen()
        {
            string query_select = @"Select *from Laptop Where GiaBan > 15000000";
            connection = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, connection);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Laptop> ds_Product = new List<DTO_Laptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_Laptop lpp = new DTO_Laptop();
                lpp.MaLaptop = table.Rows[i]["malaptop"].ToString();
                lpp.MaLH = table.Rows[i]["malh"].ToString();
                lpp.TenLaptop = table.Rows[i]["tenlaptop"].ToString();
                lpp.Ram = table.Rows[i]["ram"].ToString();
                lpp.Ocung = table.Rows[i]["ocung"].ToString();
                lpp.Cpu = table.Rows[i]["Cpu"].ToString();
                lpp.Gpu = table.Rows[i]["gpu"].ToString();
                lpp.HDH1 = table.Rows[i]["HDH"].ToString();
                lpp.Giaban = int.Parse(table.Rows[i]["Giaban"].ToString());
                lpp.Duongdan = table.Rows[i]["Image_Product"].ToString();
                lpp.Ghichu = table.Rows[i]["ghichu"].ToString();

                ds_Product.Add(lpp);
            }
            connection = Data_Provides.DongKetNoi();
            return ds_Product;
        }

        public static List<DTO_Laptop> TimTheoCauHinh(string Ram,string Rom)
        {
            string query_select = @"Select *from Laptop Where Ram = '"+Ram+"' and OCung = '"+Rom+"'";
            connection = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, connection);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_Laptop> ds_Product = new List<DTO_Laptop>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DTO_Laptop lpp = new DTO_Laptop();
                lpp.MaLaptop = table.Rows[i]["malaptop"].ToString();
                lpp.MaLH = table.Rows[i]["malh"].ToString();
                lpp.TenLaptop = table.Rows[i]["tenlaptop"].ToString();
                lpp.Ram = table.Rows[i]["ram"].ToString();
                lpp.Ocung = table.Rows[i]["ocung"].ToString();
                lpp.Cpu = table.Rows[i]["Cpu"].ToString();
                lpp.Gpu = table.Rows[i]["gpu"].ToString();
                lpp.HDH1 = table.Rows[i]["HDH"].ToString();
                lpp.Giaban = int.Parse(table.Rows[i]["Giaban"].ToString());
                lpp.Duongdan = table.Rows[i]["Image_Product"].ToString();
                lpp.Ghichu = table.Rows[i]["ghichu"].ToString();

                ds_Product.Add(lpp);
            }
            connection = Data_Provides.DongKetNoi();
            return ds_Product;
        }
    }
}
