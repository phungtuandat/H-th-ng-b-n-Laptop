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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            Load_CSDL();
            Check_Button();
        }

        void Load_CSDL()
        {
            data_KH.DataSource = BUS_KhachHang.dSKH();
            Check_Button();
        }

        void Check_Button()
        {
            if (data_KH.RowCount < 1)
            {
                btn_EditKH.Enabled = false;
                btn_DeleteKH.Enabled = false;
            }
            else
            {
                btn_EditKH.Enabled = true;
                btn_DeleteKH.Enabled = true;
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text == "" || txt_TenKH.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_MaKH.Text.Length > 10)
            {
                MessageBox.Show("Mã nhà cung cấp chỉ tối đa 10 kí tự và điện thoại chỉ tối đa 11 số");
                return;
            }
            if (BUS_KhachHang.TimKH(txt_MaKH.Text) != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.Makh = txt_MaKH.Text;
            kh.Tenkh = txt_TenKH.Text;
            kh.Diachi = txt_Address.Text;
            kh.Dienthoai = txt_Phone.Text;

            if (BUS_KhachHang.ThemKH(kh) == false)
            {
                MessageBox.Show("Thêm bị lỗi");
                return;
            }

            MessageBox.Show("Thêm thành công");
            Load_CSDL();
            txt_MaKH.Text = "";
            txt_Address.Text = "";
            txt_TenKH.Text = "";
            txt_Phone.Text = "";
            txt_MaKH.Enabled = true;
            Check_Button();
        }

        private void btn_EditKH_Click(object sender, EventArgs e)
        {
            Check_Button();
            BUS_KhachHang.SuaKH(txt_MaKH.Text, txt_TenKH.Text, txt_Address.Text, txt_Phone.Text);
            MessageBox.Show("Sửa thành công");
            Load_CSDL();
            txt_MaKH.Text = "";
            txt_Address.Text = "";
            txt_TenKH.Text = "";
            txt_Phone.Text = "";
            txt_MaKH.Enabled = true;
            Check_Button();
        }

        private void data_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (data_KH.RowCount < 1)
            {
                btn_DeleteKH.Enabled = false;
                btn_EditKH.Enabled = false;
            }
            else
            {
                int n = data_KH.CurrentRow.Index;
                txt_MaKH.Text = data_KH.Rows[n].Cells[0].Value.ToString();
                txt_TenKH.Text = data_KH.Rows[n].Cells[1].Value.ToString();
                txt_Address.Text = data_KH.Rows[n].Cells[2].Value.ToString();
                txt_Phone.Text = data_KH.Rows[n].Cells[3].Value.ToString();
                txt_MaKH.Enabled = false;
            }
        }

        private void btn_DeleteKH_Click(object sender, EventArgs e)
        {
            Check_Button();
            BUS_KhachHang.XoaKH(txt_MaKH.Text);
            MessageBox.Show("Xóa thành công");
            Load_CSDL();
            txt_MaKH.Text = "";
            txt_Address.Text = "";
            txt_TenKH.Text = "";
            txt_Phone.Text = "";
            txt_MaKH.Enabled = true;
            Check_Button();
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
