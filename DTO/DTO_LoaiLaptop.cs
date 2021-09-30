using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiLaptop
    {
        private string maLoai;
        private string maNCC;
        private string maTTBH;
        private string tenLoai;

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaTTBH { get => maTTBH; set => maTTBH = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }

    }
}
