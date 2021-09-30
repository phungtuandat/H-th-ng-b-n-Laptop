using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_ThongKE
    {
        public static List<DTO_HoaDonBan> loadHoaDon(string ngaytruoc, string ngaysau)
        {
            return DAO_ThongKe.LoadHoaDonBanTHongKE(ngaytruoc, ngaysau);
        }

        public static int TongTien()
        {
            return DAO_ThongKe.TongTien();
        }

        public static int TongHDBan()
        {
            return DAO_ThongKe.TongHDBan();
        }

        public static int TongSLBan()
        {
            return DAO_ThongKe.TongSLBan();
        }

        public static int TongHDHuy()
        {
            return DAO_ThongKe.TongHDHuy();
        }

        public static List<DTO_HoaDonBan> LoadBanHangDataGridView()
        {
            return DAO_ThongKe.LoadBanHangDataGridView();
        }
    }
}
