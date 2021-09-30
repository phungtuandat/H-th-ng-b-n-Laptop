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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
            ShowDL();
            KiemTraButton();
        }

        void KiemTraButton()
        {
            if (data_NCC.RowCount < 1)
            {
                btn_DeleteNCC.Enabled = false;
                btn_EditNCC.Enabled = false;
            }
            else
            {
                btn_DeleteNCC.Enabled = true;
                btn_EditNCC.Enabled = true;
            }
        }


        void ShowDL()
        {
            data_NCC.DataSource = BUS.BUS_NCC.dSncc();
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            if(txt_MaNCC.Text == "" || txt_TenNCC.Text =="" || txt_Address.Text =="" || txt_Phone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thiếu thông tin",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(txt_MaNCC.Text.Length > 10)
            {
                MessageBox.Show("Mã nhà cung cấp chỉ tối đa 10 kí tự và điện thoại chỉ tối đa 11 số");
                return;
            }
            if(BUS_NCC.TimNCC(txt_MaNCC.Text) != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            DTO_NhaCungCap nhacungcap = new DTO_NhaCungCap();
            nhacungcap.Ma_NCC = txt_MaNCC.Text;
            nhacungcap.Ten_NCC = txt_TenNCC.Text;
            nhacungcap.Dia_Chi = txt_Address.Text;
            nhacungcap.SdT = txt_Phone.Text;
            
            if(BUS_NCC.ThemNCC(nhacungcap) == false)
            {
                MessageBox.Show("Thêm bị lỗi");
                return;
            }

            MessageBox.Show("Thêm thành công");
            ShowDL();
            txt_MaNCC.Text = "";
            txt_Address.Text = "";
            txt_TenNCC.Text = "";
            txt_Phone.Text = "";
            txt_MaNCC.Enabled = true;
            KiemTraButton();
        }

        private void btn_DeleteNCC_Click(object sender, EventArgs e)
        {
                KiemTraButton();
                BUS_NCC.XoaNCC(txt_MaNCC.Text);
                MessageBox.Show("Xóa thành công");
                ShowDL();
                txt_MaNCC.Text = "";
                txt_Address.Text = "";
                txt_TenNCC.Text = "";
                txt_Phone.Text = "";
                txt_MaNCC.Enabled = true;
                KiemTraButton();
        }

        private void btn_EditNCC_Click(object sender, EventArgs e)
        {
            KiemTraButton();
            BUS_NCC.SuaNCC(txt_MaNCC.Text, txt_TenNCC.Text, txt_Address.Text, txt_Phone.Text);
            MessageBox.Show("Sửa thành công");
            ShowDL();
            txt_MaNCC.Text = "";
            txt_Address.Text = "";
            txt_TenNCC.Text = "";
            txt_Phone.Text = "";
            txt_MaNCC.Enabled = true;
            KiemTraButton();
        }

        private void rad_SearchName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rad_SearchName.Checked == true)
            {
                if (BUS_NCC.dSSearch_TenNCC(txt_SearchNCC.Text) != null)
                {
                    data_NCC.DataSource = BUS_NCC.dSSearch_TenNCC(txt_SearchNCC.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
                
        }

        private void rad_SearchMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_SearchMa.Checked == true)
            {
                if(BUS_NCC.dSSearch_MaNCC(txt_SearchNCC.Text) != null)
                {
                    data_NCC.DataSource = BUS_NCC.dSSearch_MaNCC(txt_SearchNCC.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
            
        }

        private void txt_SearchNCC_TextChanged(object sender, EventArgs e)
        {
            if (txt_SearchNCC.Text == "")
            {
                ShowDL();
                rad_SearchMa.Checked = false;
                rad_SearchName.Checked = false;
            }
        }

        private void data_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_NCC.RowCount < 1)
            {
                btn_DeleteNCC.Enabled = false;
                btn_EditNCC.Enabled = false;
            }
            else
            {
                int n = data_NCC.CurrentRow.Index;
                txt_MaNCC.Text = data_NCC.Rows[n].Cells[0].Value.ToString();
                txt_TenNCC.Text = data_NCC.Rows[n].Cells[1].Value.ToString();
                txt_Address.Text = data_NCC.Rows[n].Cells[2].Value.ToString();
                txt_Phone.Text = data_NCC.Rows[n].Cells[3].Value.ToString();
                txt_MaNCC.Enabled = false;
            }
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
