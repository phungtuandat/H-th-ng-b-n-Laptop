using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TrungTamBaoHaanh
    {
        private string maTT;
        private string tenTT;
        private string diaChi;
        private string phone;


        public string MaTT { get => maTT; set => maTT = value; }
        public string TenTT { get => tenTT; set => tenTT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phone { get => phone; set => phone = value; }

    }
}
