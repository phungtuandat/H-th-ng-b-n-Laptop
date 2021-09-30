using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapHang
    {
        private string maHDnhap;
        private string maNCC;
        private int tongtien;
        private DateTime ngaynhap;

        public string MaHDnhap { get => maHDnhap; set => maHDnhap = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
    }
}
