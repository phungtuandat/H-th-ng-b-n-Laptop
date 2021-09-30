using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string manv;
        private string tennv;
        private string diachi;
        private string dienthoai;
        private string matkhau;
        private int quyen;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
    }
}
