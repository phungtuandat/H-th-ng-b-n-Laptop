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
namespace QuanLy_ChLaptop
{
    public partial class ThayDoiPass : Form
    {
        public ThayDoiPass()
        {
            InitializeComponent();
            lbl_MaNv.Text = FrmLogin.TenDN;
            lbl_MaNv.BackColor = Color.Transparent;
        }

        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            if(BUS_Login.login(lbl_MaNv.Text,txt_MatKhauCu.Text) == null)
            {
                MessageBox.Show("Mật khẩu không đúng, Vui lòng kiểm tra lại");
                return;
            }
            else
            {
                if(txt_MatKhauCu.Text != txt_MatKhauMoi.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu không chính xác");
                    return;
                }
                else
                {
                    BUS_ThayDoiPass.UpdateMatKhau(BUS_NhanVien.MathoaMatKhau(txt_MatKhauMoi.Text), lbl_MaNv.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }
    }
}
