using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLy_ChLaptop
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
            cmb_QuyenNV.Items.Add("Admin");
            cmb_QuyenNV.Items.Add("User");
            Load_CSDL();
            Check_Button();
        }
        string t;
        void Load_CSDL()
        {
            data_NV.DataSource = BUS_NhanVien.dSNV();
        }

        void loadbefore()
        {
            txt_MaNV.Text = "";
            txt_Address.Text = "";
            txt_TenNV.Text = "";
            txt_Phone.Text = "";
            txt_PassWord.Text = "";
            cmb_QuyenNV.Text = null;
            txt_MaNV.Enabled = true;
        }
        void Check_Button()
        {
            if (data_NV.RowCount < 1)
            {
                btn_EditNV.Enabled = false;
                btn_DeleteNV.Enabled = false;
            }
            else
            {
                btn_EditNV.Enabled = true;
                btn_DeleteNV.Enabled = true;
            }
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string t = BUS_NhanVien.MathoaMatKhau(txt_PassWord.Text);
            if (txt_MaNV.Text == "" || txt_TenNV.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "" || txt_PassWord.Text == "" || cmb_QuyenNV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_MaNV.Text.Length > 10)
            {
                MessageBox.Show("Mã nhân viên chỉ tối đa 10 kí tự");
                return;
            }
            if (BUS_NhanVien.TimNhanVien(txt_MaNV.Text) != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            DTO_NhanVien NV = new DTO_NhanVien();
            NV.Manv = txt_MaNV.Text;
            NV.Tennv = txt_TenNV.Text;
            NV.Diachi = txt_Address.Text;
            NV.Dienthoai = txt_Phone.Text;
            NV.Matkhau = t; 
            if(cmb_QuyenNV.SelectedText == "Admin")
            {
                NV.Quyen = 1;
            }
            else
            {
                NV.Quyen = 0;
            }
            if (BUS_NhanVien.ThemNhanVien(NV) == false)
            {
                MessageBox.Show("Thêm bị lỗi");
                return;
            }

            MessageBox.Show("Thêm thành công");
            Load_CSDL();
            loadbefore();
            Check_Button();
        }

        private void btn_EditNV_Click(object sender, EventArgs e)
        {
            int n;
            if(cmb_QuyenNV.Text == "Admin")
            {
                n = 1;
            }
            else
            {
                n = 0;
            }

            string kt;
            if(txt_PassWord.Text == t)
            {
                kt = txt_PassWord.Text;
            }
            else
            {
                kt = BUS_NhanVien.MathoaMatKhau(txt_PassWord.Text);
            }
            Check_Button();
            BUS_NhanVien.SuaNhanVien(txt_MaNV.Text, txt_TenNV.Text, txt_Address.Text, txt_Phone.Text,kt,n);
            MessageBox.Show("Sửa thành công");
            Load_CSDL();
            loadbefore();
            Check_Button();
        }

        private void data_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_NV.RowCount < 1)
            {
                btn_DeleteNV.Enabled = false;
                btn_EditNV.Enabled = false;
            }
            else
            {
                int n = data_NV.CurrentRow.Index;
                txt_MaNV.Text = data_NV.Rows[n].Cells[0].Value.ToString();
                txt_TenNV.Text = data_NV.Rows[n].Cells[1].Value.ToString();
                txt_Address.Text = data_NV.Rows[n].Cells[2].Value.ToString();
                txt_Phone.Text = data_NV.Rows[n].Cells[3].Value.ToString();
                txt_PassWord.Text = data_NV.Rows[n].Cells[4].Value.ToString();
                if(data_NV.Rows[n].Cells[5].Value.ToString() == "1")
                {
                    cmb_QuyenNV.Text = "Admin";
                }
                else
                {
                    cmb_QuyenNV.Text = "User";
                }
                txt_MaNV.Enabled = false;
                // lấy mật khẩu mới đưa lên từ sql
                t = data_NV.Rows[n].Cells[4].Value.ToString();
            }
        }

        private void btn_DeleteNV_Click(object sender, EventArgs e)
        {
            Check_Button();
            BUS_NhanVien.XoaNhanVien(txt_MaNV.Text);
            MessageBox.Show("Xóa thành công");
            Load_CSDL();
            loadbefore();
            Check_Button();
        }
    }
}
