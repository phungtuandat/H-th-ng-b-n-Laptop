using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Laptop
    {
        public static List<DTO_Laptop> DS_Laptop()
        {
            return DAO_Laptop.DanhSachLaptop();
        }


        public static bool ThemLaptop(DTO_Laptop dto)
        {
            return DAO_Laptop.ThemLaptop(dto);
        }

        public static bool XoaLaptop(string malaptop)
        {
            return DAO_Laptop.XoaLaptop(malaptop);
        }

        public static bool SuaLaptop(DTO_Laptop laptop)
        {
            return DAO_Laptop.SuaLaptop(laptop);
        }

        public static string LayDuongDan (string malaptop)
        {
            return DAO_Laptop.LayDuongDanLaptop(malaptop);
        }

        public static int DemLapTOP()
        {
            return DAO_Laptop.DemLaptop();
        }

        public static List<string> LaptopSoLuongNhoHon20()
        {
            return DAO_Laptop.TenLaptopSoLuongDuoi_10();
        }

        public static int DemSoLuongLaptop(string malaptop)
        {
            return DAO_Laptop.DemSoLuongLaptop(malaptop);
        }

        public static string MaLaptopTrung(string MaLaptop)
        {
            return DAO_Laptop.MaLaptopTrung(MaLaptop);
        }

        public static bool ThemVaoKho(DTO_Kho dto_kho)
        {
            return DAO_Laptop.ThemVaoKho(dto_kho);
        }

        public static int STT()
        {
            return DAO_Laptop.STT();
        }
    }
}
