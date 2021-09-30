using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace DAO
{
    public class DAO_NhanVien
    {
        static SqlConnection conn;
        public static List<DTO_NhanVien> DanhSachNV()
        {
            string query_select = @"Select *from NhanVien";
            conn = Data_Provides.KetNoi();
            DataTable table = Data_Provides.Select_Query(query_select, conn);
            if(table.Rows.Count < 0 )
            {
                return null;
            }
            List<DTO_NhanVien> ds_nhanvien = new List<DTO_NhanVien>();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                DTO_NhanVien nhanvien = new DTO_NhanVien();
                nhanvien.Manv = table.Rows[i]["MaNV"].ToString();
                nhanvien.Tennv = table.Rows[i]["TenNV"].ToString();
                nhanvien.Diachi = table.Rows[i]["DiaChi"].ToString();
                nhanvien.Dienthoai = table.Rows[i]["DienThoai"].ToString();
                nhanvien.Matkhau = table.Rows[i]["MatKhau"].ToString();
                nhanvien.Quyen = int.Parse(table.Rows[i]["Quyen"].ToString());
                ds_nhanvien.Add(nhanvien);
            }
            conn = Data_Provides.DongKetNoi();
            return ds_nhanvien;        
        }

        public static DTO_NhanVien TimNV(string MaNV)
        {
            string query = string.Format(@"Select *from NhanVien where MaNV = '{0}'",MaNV);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DTO_NhanVien nhanvien = new DTO_NhanVien();
            nhanvien.Manv = dt.Rows[0]["MaNV"].ToString();
            nhanvien.Tennv = dt.Rows[0]["TenNV"].ToString();
            nhanvien.Diachi = dt.Rows[0]["DiaChi"].ToString();
            nhanvien.Dienthoai = dt.Rows[0]["DienThoai"].ToString();
            nhanvien.Matkhau = dt.Rows[0]["MatKhau"].ToString();
            nhanvien.Quyen = int.Parse(dt.Rows[0]["Quyen"].ToString());
            conn = Data_Provides.DongKetNoi();
            return nhanvien;
        }

        public static bool ThemNV(DTO_NhanVien nv)
        {
            string query = @"Insert into NhanVien values ('" + nv.Manv + "',N'" + nv.Tennv + "',N'" + nv.Diachi + "','" + nv.Dienthoai + "','" + nv.Matkhau + "','" + nv.Quyen + "')";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool XoaNV(string manv)
        {
            string query = @"Delete from NhanVien where MaNV='"+manv+"'";
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static bool SuaNV(string maNV, string tenNV, string diachi,string sdt,string matkhau, int quyen)
        {
            string query = string.Format(@"Update NhanVien set TenNV=N'{1}', DiaChi =N'{2}',DienThoai='{3}',MatKhau ='{4}',Quyen = {5} where MaNV = '{0}'",maNV,tenNV,diachi,sdt,matkhau,quyen);
            conn = Data_Provides.KetNoi();
            bool kq = Data_Provides.TruyXuatThemDuLieu(query, conn);
            conn = Data_Provides.DongKetNoi();
            return kq;
        }

        public static List<DTO_NhanVien> TimListNV_TheoMA(string MaNV)
        {
            string query = string.Format(@"Select *from NhanVien where MaNV Like'{0}%'", MaNV);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanVien> ds_search = new List<DTO_NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhanVien nhanvien = new DTO_NhanVien();
                nhanvien.Manv = dt.Rows[i]["MaNV"].ToString();
                nhanvien.Tennv = dt.Rows[i]["TenNV"].ToString();
                nhanvien.Diachi = dt.Rows[i]["DiaChi"].ToString();
                nhanvien.Dienthoai = dt.Rows[i]["DienThoai"].ToString();
                nhanvien.Matkhau = dt.Rows[i]["MatKhau"].ToString();
                nhanvien.Quyen = int.Parse(dt.Rows[i]["Quyen"].ToString());
                ds_search.Add(nhanvien);
            }
            return ds_search;
        }

        public static List<DTO_NhanVien> TimListNV_NameNV(string TenNV)
        {
            string query = string.Format(@"Select *from NhanVien where TenNV Like'{0}%'", TenNV);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanVien> ds_search = new List<DTO_NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhanVien nhanvien = new DTO_NhanVien();
                nhanvien.Manv = dt.Rows[i]["MaNV"].ToString();
                nhanvien.Tennv = dt.Rows[i]["TenNV"].ToString();
                nhanvien.Diachi = dt.Rows[i]["DiaChi"].ToString();
                nhanvien.Dienthoai = dt.Rows[i]["DienThoai"].ToString();
                nhanvien.Matkhau = dt.Rows[i]["MatKhau"].ToString();
                nhanvien.Quyen = int.Parse(dt.Rows[i]["Quyen"].ToString());
                ds_search.Add(nhanvien);
            }

            return ds_search;
        }

       public static string GetMD5(string matkhau)
        {
            string str = "";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(matkhau);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        public static DTO_NhanVien KiemTraMatKhauCu(string manv)
        {
            string query = string.Format(@"Select MatKhau from NhanVien where MaNV = '{0}'", manv);
            conn = Data_Provides.KetNoi();
            DataTable dt = Data_Provides.Select_Query(query, conn);
            if(dt.Rows.Count < 0)
            {
                return null;
            }
            DTO_NhanVien dto = new DTO_NhanVien();
            dto.Matkhau = dt.Rows[0]["MatKhau"].ToString();
            conn = Data_Provides.DongKetNoi();
            return dto;
        }
    }
}
