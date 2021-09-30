using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhapChiTiet
    {
        private string maHD_nhap;
        private string maLaptop_nhap;
        private string tenLaptop;
        private int soluong;
        private int gianhap;
        private int thanhTien;

        public string MaHD_nhap { get => maHD_nhap; set => maHD_nhap = value; }
        public string MaLaptop_nhap { get => maLaptop_nhap; set => maLaptop_nhap = value; }
        public string TenLaptop { get => tenLaptop; set => tenLaptop = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }
    }
}
