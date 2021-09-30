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
    public partial class TTBH : Form
    {
        public TTBH()
        {
            InitializeComponent();
            ShowDL();
        }
        void KiemTraButton()
        {
            if (data_TTBH.RowCount < 1)
            {
                btn_DeleteTTBH.Enabled = false;
                btn_EditTTBH.Enabled = false;
            }
            else
            {
                btn_DeleteTTBH.Enabled = true;
                btn_EditTTBH.Enabled = true;
            }
        }


        void ShowDL()
        {
            data_TTBH.DataSource = BUS_TrungTamBaoHanh.DSTTBH();
        }

        private void btn_ThemTTBH_Click(object sender, EventArgs e)
        {
            if (txt_MaTTBH.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_MaTTBH.Text.Length > 10)
            {
                MessageBox.Show("Mã nhà cung cấp chỉ tối đa 10 kí tự và điện thoại chỉ tối đa 11 số");
                return;
            }
            if(BUS_TrungTamBaoHanh.TimTTBH(txt_MaTTBH.Text) != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            DTO_TrungTamBaoHaanh ttbh = new DTO_TrungTamBaoHaanh();
            ttbh.MaTT = txt_MaTTBH.Text;
            ttbh.TenTT = txt_TenTTBH.Text;
            ttbh.DiaChi = txt_Address.Text;
            ttbh.Phone = txt_Phone.Text;

            if (BUS_TrungTamBaoHanh.ThemTTBH(ttbh) == false)
            {
                MessageBox.Show("Thêm bị lỗi");
                return;
            }

            MessageBox.Show("Thêm thành công");
            ShowDL();
            txt_MaTTBH.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            txt_TenTTBH.Text = "";
            txt_MaTTBH.Enabled = true;
            KiemTraButton();
        }

        private void btn_EditTTBH_Click(object sender, EventArgs e)
        {
            KiemTraButton();
            BUS_TrungTamBaoHanh.SuaTTBH(txt_MaTTBH.Text,txt_TenTTBH.Text, txt_Address.Text, txt_Phone.Text);
            MessageBox.Show("Sửa thành công");
            ShowDL();
            txt_MaTTBH.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            txt_TenTTBH.Text = "";
            txt_MaTTBH.Enabled = true;
            KiemTraButton();
        }

        private void data_TTBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_TTBH.RowCount < 1)
            {
                btn_DeleteTTBH.Enabled = false;
                btn_EditTTBH.Enabled = false;
            }
            else
            {
                int n = data_TTBH.CurrentRow.Index;
                txt_MaTTBH.Text = data_TTBH.Rows[n].Cells[0].Value.ToString();
                txt_TenTTBH.Text = data_TTBH.Rows[n].Cells[1].Value.ToString();
                txt_Address.Text = data_TTBH.Rows[n].Cells[2].Value.ToString();
                txt_Phone.Text = data_TTBH.Rows[n].Cells[3].Value.ToString();
                txt_MaTTBH.Enabled = false;
            }
        }

        private void btn_DeleteTTBH_Click(object sender, EventArgs e)
        {
            KiemTraButton();
            BUS_TrungTamBaoHanh.XoaTTBH(txt_MaTTBH.Text);
            MessageBox.Show("Xóa thành công");
            ShowDL();
            txt_MaTTBH.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            txt_TenTTBH.Text = "";
            txt_MaTTBH.Enabled = true;
            KiemTraButton();
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
