using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBanChiTiet
    {
        private string maHD;
        private string maLaptop;
        private string tenLaptop;
        private int soluong;
        private int giaban;
        private int thanhTien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaLaptop { get => maLaptop; set => maLaptop = value; }
        public string TenLaptop { get => tenLaptop; set => tenLaptop = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

    }
}
