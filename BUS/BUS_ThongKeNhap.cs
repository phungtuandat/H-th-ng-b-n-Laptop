using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_ThongKeNhap
    {
        public static List<DTO_HoaDonNhap> loadHoaDon(string ngaytruoc, string ngaysau)
        {
            return DAO_ThongKeNhap.LoadHoaDonNhapTHongKENhap (ngaytruoc, ngaysau);
        }

        public static int TongTien()
        {
            return DAO_ThongKeNhap.TongTien();
        }

        public static int TongHDNhap()
        {
            return DAO_ThongKeNhap.TongHDNhap();
        }

        public static int TongSLNhap()
        {
            return DAO_ThongKeNhap.TongSLNhap();
        }

        public static int TongHDHuy()
        {
            return DAO_ThongKe.TongHDHuy();
        }

        public static List<DTO_HoaDonNhap> LoadNhapHangDataGridView()
        {
            return DAO_ThongKeNhap.LoadNhapHangDataGridView();
        }
    }
}
