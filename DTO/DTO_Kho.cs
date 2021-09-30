using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Kho
    {
        private int sTT;
        private string malaptop;
        private string tenlaptop;
        private int soLuongTon;
        private int soLuongBan;

        public int STT { get => sTT; set => sTT = value; }
        public string MaLaptop { get => malaptop; set => malaptop = value; }
        public string TenLaptop { get => tenlaptop; set => tenlaptop = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public int SoLuongBan { get => soLuongBan; set => soLuongBan = value; }

    }
}
