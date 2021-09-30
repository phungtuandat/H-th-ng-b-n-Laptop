using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_LoaiLaptop
    {
        public static List<DTO_LoaiLaptop> DS_Loai()
        {
            return DAO_LoaiLaptop.DanhSachLoaiLaptop();
        }

        public static bool ThemLoai(DTO_LoaiLaptop loaiLaptop)
        {
            return DAO_LoaiLaptop.ThemLoaiLaptop(loaiLaptop);
        }

        public static DTO_LoaiLaptop TimLoai(string Maloai)
        {
            return DAO_LoaiLaptop.TimLoaiLaptop(Maloai);
        }

        public static bool XoaLoai(string maloai)
        {
            return DAO_LoaiLaptop.XoaLoaiLaptop(maloai);
        }

        public static bool SuaLoai(string MaLoai,string MaNCC, string maTTbh, string TenLoai)
        {
            return DAO_LoaiLaptop.SuaLoaiLaptop(MaLoai,MaNCC,maTTbh,TenLoai);
        }

        public static List<DTO_LoaiLaptop> dSSearch_MaLoai(string maloai)
        {
            return DAO_LoaiLaptop.TimListLoaiLaptop_TheoMA(maloai);
        }

        public static List<DTO_LoaiLaptop> dSSearch_TenNCC(string tenloai)
        {
            return DAO_LoaiLaptop.TimListLoaiLaptop_NameNCC(tenloai);
        }
    }
}
