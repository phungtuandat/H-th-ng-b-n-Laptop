using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_LichSuDangNhap
    {
        public static bool ThemLS(DTO_LichSuDangNhap DTO)
        {
            return DAO_LSDN.ThemLichSu(DTO);
        }

        public static int STT()
        {
            return DAO_LSDN.STT();
        }

        public static bool CapNhatGioRa(int stt, string time)
        {
            return DAO_LSDN.CapNhatGioRa(stt, time);
        }

        public static List<DTO_LichSuDangNhap> ds() {
            return DAO_LSDN.ds();
        }
    }
}
