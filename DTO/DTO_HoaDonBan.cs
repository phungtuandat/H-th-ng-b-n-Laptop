using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        private string maHDBan;
        private string maKH;
        private string tenKH;
        private string maNV;
        private string tenNV;
        private int tongtien;
        private string ngaylap;
        private int tinhTrang;

        public string MaHDBan { get => maHDBan; set => maHDBan = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
