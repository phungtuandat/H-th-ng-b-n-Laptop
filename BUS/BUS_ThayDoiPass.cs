using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_ThayDoiPass
    {
        public static bool UpdateMatKhau(string mk, string tendn)
        {
            return DAO_CheckPass.UpdateMatKhau(mk,tendn);
        }
    }
}
