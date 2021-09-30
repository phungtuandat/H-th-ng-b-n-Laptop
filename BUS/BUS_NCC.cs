using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_NCC
    {
        public static List<DTO_NhaCungCap> dSncc()
        {
            return DAO_NCC.DanhSachNCC();
        }

        public static bool ThemNCC (DTO_NhaCungCap ncc)
        {
            return DAO_NCC.ThemNCC(ncc);
        }

        public static DTO_NhaCungCap TimNCC(string Mancc)
        {
            return DAO_NCC.TimNCC(Mancc);
        }

        public static bool XoaNCC (string mancc)
        {
            return DAO_NCC.XoaNCC(mancc);
        }

        public static bool SuaNCC (string mancc, string tenncc, string diachi, string sdt)
        {
            return DAO_NCC.SuaNCC(mancc,tenncc,diachi,sdt);
        }

        public static List<DTO_NhaCungCap> dSSearch_MaNCC(string mancc)
        {
            return DAO_NCC.TimListNCC_TheoMA(mancc);
        }

        public static List<DTO_NhaCungCap> dSSearch_TenNCC(string TenNCC)
        {
            return DAO_NCC.TimListNCC_NameNCC(TenNCC);
        }
    }
}
