using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LichSuDangNhap
    {
        private string manv;
        private string time;
        private string tinhtrang;
        private int stt;
        private string giora;

        public int Stt { get => stt; set => stt = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Giora { get => giora; set => giora = value; }
        public string Time { get => time; set => time = value; }
    }
}
