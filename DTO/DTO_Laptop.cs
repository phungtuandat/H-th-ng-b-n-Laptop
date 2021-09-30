using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Laptop
    {
        private string maLaptop;
        private string maLH;
        private string tenLaptop;
        private string ram;
        private string ocung;
        private string cpu;
        private string gpu;
        private string HDH;
        private int giaban;
        private string duongdan;
        private string ghichu;

        public string MaLaptop { get => maLaptop; set => maLaptop = value; }
        public string MaLH { get => maLH; set => maLH = value; }
        public string TenLaptop { get => tenLaptop; set => tenLaptop = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Ocung { get => ocung; set => ocung = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Gpu { get => gpu; set => gpu = value; }
        public string HDH1 { get => HDH; set => HDH = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public string Duongdan { get => duongdan; set => duongdan = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

    }
}
