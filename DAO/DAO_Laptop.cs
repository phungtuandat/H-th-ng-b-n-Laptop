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
    public class DAO_Laptop
    {
        static SqlConnection conn;
        public static List<DTO_Laptop> DanhSachLaptop()
        {
            string query_select = @"Select *from Laptop";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if(table.Rows.Count == 0 )
            {
                return null;
            }
            List<DTO_Laptop> ds_Product = new List<DTO_Laptop>();
            for(int i = 0; i < table.Rows.Count; i++)
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
            conn = Data_Provides.DongKetNoi();
            return ds_Product;        
        }

        public static DTO_Laptop TimMaLaptop(string MaLaptop)
        {
            string query = string.Format(@"Select *from Laptop where MaLaptop = '{0}'",MaLaptop);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_Laptop laptop = new DTO_Laptop();
            laptop.MaLaptop = dt.Rows[0]["malaptop"].ToString();
            laptop.MaLH = dt.Rows[0]["malh"].ToString();
            laptop.TenLaptop = dt.Rows[0]["tenlaptop"].ToString();
            laptop.Ram = dt.Rows[0]["ram"].ToString();
            laptop.Ocung = dt.Rows[0]["ocung"].ToString();
            laptop.Cpu = dt.Rows[0]["Cpu"].ToString();
            laptop.Gpu = dt.Rows[0]["gpu"].ToString();
            laptop.HDH1 = dt.Rows[0]["HDH"].ToString();
            laptop.Giaban = int.Parse(dt.Rows[0]["Giaban"].ToString());
            laptop.Duongdan = dt.Rows[0]["Image_Product"].ToString();
            laptop.Ghichu = dt.Rows[0]["ghichu"].ToString();
            conn = Data_Provides.DongKetNoi();
            return laptop;
        }

        public static bool ThemLaptop(DTO_Laptop laptop)
        {
            string query = @"Insert into laptop values ('" + laptop.MaLaptop + "','"+laptop.MaLH+"',N'" + laptop.TenLaptop + "','" + laptop.Ram + "','" + laptop.Ocung + "','" + laptop.Cpu + "',N'" + laptop.Gpu + "','" + laptop.HDH1 + "','" + laptop.Giaban + "','" + laptop.Duongdan + "',N'" + laptop.Ghichu + "')";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaLaptop(string malaptop)
        {
            string query = @"Delete FROM Laptop where MaLaptop='"+malaptop+"'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool SuaLaptop(DTO_Laptop laptop)
        {
            string query = @"Update Laptop set MaLH = '" + laptop.MaLH + "', TenLaptop = '" + laptop.TenLaptop + "', Ram = '" + laptop.Ram + "', OCung = '" + laptop.Ocung + "', CPU = '" + laptop.Cpu + "',GPU = N'" + laptop.Gpu + "',HDH = '" + laptop.HDH1 + "',Giaban = '" + laptop.Giaban + "', Image_Product = '" + laptop.Duongdan + "',Ghichu = N'" + laptop.Ghichu + "' where MaLaptop = '" + laptop.MaLaptop + "'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static string LayDuongDanLaptop(string malaptop)
        {
            string query = "Select Image_Product from Laptop where MaLaptop ='"+malaptop+"'";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query, conn);
            if(table.Rows.Count < 0)
            {
                return null;
            }
            return table.Rows[0]["Image_Product"].ToString();
        }

        public static int DemLaptop()
        {
            string query = @"Select COUNT(malaptop) as SoLuongLaptop from Laptop";
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count < 0)
            {
                return -1;
            }
            conn = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["SoLuongLaptop"].ToString());
        }

        public static int DemSoLuongLaptop(string malaptop)
        {
            string query = @"Select SoLuongTon from Kho where malaptop = '"+malaptop+"'";
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count < 0)
            {
                return -1;
            }
            conn = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["soluong"].ToString());
        }

        public static List<string> TenLaptopSoLuongDuoi_10()
        {
            string query = @"Select TenLaptop from Kho where SoLuongTon <  2";
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count < 0)
            {
                return null;
            }
            List<string> tenlaptop = new List<string>();
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                tenlaptop.Add(dt.Rows[i]["tenlaptop"].ToString());
            }
            conn = Data_Provides.DongKetNoi();
            return tenlaptop;
        }

        public static string MaLaptopTrung(string MaLaptop)
        {
            string query = @"Select MaLaptop from Laptop where MaLaptop = '" + MaLaptop + "'";
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count ==0 )
            {
                return null;
            }
            conn = Data_Provides.DongKetNoi();
            return dt.Rows[0]["MaLaptop"].ToString();
        }

        public static bool ThemVaoKho(DTO_Kho dto_kho)
        {
            string querys = string.Format(@"Insert into Kho Values ('{0}', '{1}' ,'{2}',{3} ,{4})",dto_kho.STT,dto_kho.MaLaptop,dto_kho.TenLaptop,dto_kho.SoLuongTon,dto_kho.SoLuongBan);
            conn = Data_Provides.KetNoi();
            bool result = Data_Provides.TruyXuatThemDuLieu(querys, conn);
            conn = Data_Provides.DongKetNoi();
            return result;
        }

        public static int STT()
        {
            string query = @"Select count(STT)+1  as STT from Kho";
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count == 0)
            {
                return -1;
            }
            conn = Data_Provides.DongKetNoi();
            return int.Parse(dt.Rows[0]["STT"].ToString());
        }
    }
}
