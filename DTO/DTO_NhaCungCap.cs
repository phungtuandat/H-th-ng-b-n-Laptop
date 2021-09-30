using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        private string ma_NCC;
        private string ten_NCC;
        private string dia_Chi;
        private string sdT;

        public string Ma_NCC { get => ma_NCC; set => ma_NCC = value; }
        public string Ten_NCC { get => ten_NCC; set => ten_NCC = value; }
        public string Dia_Chi { get => dia_Chi; set => dia_Chi = value; }
        public string SdT { get => sdT; set => sdT = value; }
    }
}
