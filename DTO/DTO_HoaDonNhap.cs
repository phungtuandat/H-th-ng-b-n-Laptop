using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        private string maHDnhap;
        private string mancc;
        private string tenNCC;
        private string maNV;
        private string tenNV;
        private int tongtien;
        private string ngaylap;
        private int tinhTrang;

        public string MaHDnhap { get => maHDnhap; set => maHDnhap = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }

    }
}
