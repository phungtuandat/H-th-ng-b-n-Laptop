using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Kho
    {
        public static List<DTO_Kho> DanhSachLapTop()
        {
            return DAO_Kho.DanhSachLapTop();
        }
    }
}
