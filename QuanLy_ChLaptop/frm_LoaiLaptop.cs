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
    public partial class frm_LoaiLaptop : Form
    {
        public frm_LoaiLaptop()
        {
            InitializeComponent();
            cmb_NCC.DataSource = BUS_NCC.dSncc();
            cmb_NCC.ValueMember = "ma_NCC";
            cmb_NCC.DisplayMember = "ten_NCC";

            cmb_TTBH.DataSource = BUS_TrungTamBaoHanh.DSTTBH();
            cmb_TTBH.ValueMember = "maTT";
            cmb_TTBH.DisplayMember = "tenTT";
            ShowDL();
            KiemTraButton();
        }
        void KiemTraButton()
        {
            if (data_LoaiLaptop.RowCount < 1)
            {
                btn_DeleteLoai.Enabled = false;
                btn_EditLoai.Enabled = false;
            }
            else
            {
                btn_DeleteLoai.Enabled = true;
                btn_EditLoai.Enabled = true;
            }
        }
        void ShowDL()
        {
            data_LoaiLaptop.DataSource = BUS_LoaiLaptop.DS_Loai();
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            if (txt_MaLoai.Text == "" || cmb_NCC.Text == "" || txt_TenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txt_MaLoai.Text.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập mã loại dưới 10 kí tự");
                return;
            }
            if(BUS_LoaiLaptop.TimLoai(txt_MaLoai.Text) != null)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            DTO_LoaiLaptop loai = new DTO_LoaiLaptop();
            loai.MaLoai = txt_MaLoai.Text;
            loai.MaNCC = cmb_NCC.SelectedValue.ToString();
            loai.MaTTBH = cmb_TTBH.SelectedValue.ToString();
            loai.TenLoai = txt_TenLoai.Text;

            if (BUS_LoaiLaptop.ThemLoai(loai) == false)
            {
                MessageBox.Show("Thêm bị lỗi");
                return;
            }
            MessageBox.Show("Thêm thành công");
            ShowDL();
            txt_MaLoai.Text = "";
            txt_TenLoai.Text = "";
            KiemTraButton();
        }

        private void btn_DeleteLoai_Click(object sender, EventArgs e)
        {
            KiemTraButton();
            BUS_LoaiLaptop.XoaLoai(txt_MaLoai.Text);
            MessageBox.Show("Xóa thành công");
            txt_MaLoai.Enabled = true;
            ShowDL();
            txt_MaLoai.Text = "";
            cmb_NCC.Text = "";
            txt_TenLoai.Text = "";
            KiemTraButton();
        }

        private void btn_EditLoai_Click(object sender, EventArgs e)
        {
            KiemTraButton();
            BUS_LoaiLaptop.SuaLoai(txt_MaLoai.Text,cmb_NCC.SelectedValue.ToString(),cmb_TTBH.SelectedValue.ToString(),txt_TenLoai.Text);
            MessageBox.Show("Sửa thành công");
            txt_MaLoai.Enabled = true;
            ShowDL();
            txt_MaLoai.Text = "";
            cmb_NCC.Text = "";
            txt_TenLoai.Text = "";
            KiemTraButton();
        }

        private void data_LoaiLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_LoaiLaptop.RowCount < 1)
            {
                btn_DeleteLoai.Enabled = false;
                btn_EditLoai.Enabled = false;
            }
            else
            {
                int n = data_LoaiLaptop.CurrentRow.Index;
                txt_MaLoai.Text = data_LoaiLaptop.Rows[n].Cells[0].Value.ToString();
                cmb_NCC.Text = data_LoaiLaptop.Rows[n].Cells[1].Value.ToString();
                cmb_TTBH.Text = data_LoaiLaptop.Rows[n].Cells[2].Value.ToString();
                txt_TenLoai.Text = data_LoaiLaptop.Rows[n].Cells[3].Value.ToString();
                txt_MaLoai.Enabled = false;
                btn_DeleteLoai.Enabled = true;
                btn_EditLoai.Enabled = true;
            }
        }
    }
}
