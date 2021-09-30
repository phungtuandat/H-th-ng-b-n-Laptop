using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_TraCuu
    {
        public static List<DTO_Laptop> DanhSachLaptop2Den5()
        {
            return DAO_TraCuuProduct.DanhSachLaptop2Den5();
        }

        public static List<DTO_Laptop> DanhSachLaptop5Den7()
        {
            return DAO_TraCuuProduct.DanhSachLaptop5Den7();
        }

        public static List<DTO_Laptop> DanhSachLaptop7Den15()
        {
            return DAO_TraCuuProduct.DanhSachLaptop7Den15();
        }

        public static List<DTO_Laptop> DanhSachLaptop15TroLen()
        {
            return DAO_TraCuuProduct.DanhSachLaptop15TroLen();
        }

        public static List<DTO_Laptop> TimTheoCauHinh(string Ram, string Rom)
        {
            return DAO_TraCuuProduct.TimTheoCauHinh(Ram, Rom);
        }
    }
}
