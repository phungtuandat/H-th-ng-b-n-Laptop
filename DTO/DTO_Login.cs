using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        private int stt;
        private string maNV;
        private string matKhau;
        private int quyen;

        public string MaNV { get => maNV; set => maNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
        public int Stt { get => stt; set => stt = value; }
    }
}
