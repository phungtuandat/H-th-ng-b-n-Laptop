using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_TrungTamBaoHanh
    {
        public static List<DTO_TrungTamBaoHaanh> DSTTBH()
        {
            return DAO_TTBH.DanhSachTrungTam();
        }

        public static bool ThemTTBH (DTO_TrungTamBaoHaanh ttbh)
        {
            return DAO_TTBH.ThemTTBH(ttbh);
        }

        public static string TimTTBH(string MaTTBH)
        {
            return DAO_TTBH.TimTTBH(MaTTBH);
        }

        public static bool XoaTTBH(string manTTBH)
        {
            return DAO_TTBH.XoaTTBH(manTTBH);
        }

        public static bool SuaTTBH (string manttbh,string tentt, string diachi, string sdt)
        {
            return DAO_TTBH.SuaTTBH(manttbh,tentt,diachi,sdt);
        }
    }
}
