using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace QuanLy_ChLaptop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static int quyen;// stactic go5i thang public phai tao moi
        public static string TenDN;
        public static int STT;
        private void txt_Pass_Click(object sender, EventArgs e)
        {
            txt_Pass.Text = "";
        }

        private void txt_User_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == "" || txt_Pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản mật khẩu");
            }
            //
            if (BUS_Login.login(txt_User.Text,txt_Pass.Text) != null)
            {
                STT = BUS_LichSuDangNhap.STT();
                quyen = BUS_Login.QuyenTaiKhoan(txt_User.Text);
                TenDN = BUS_Login.TenDN(txt_User.Text);
                DTO_LichSuDangNhap ls = new DTO_LichSuDangNhap();
                ls.Stt = STT;
                ls.Manv = txt_User.Text;
                ls.Time = DateTime.Today.ToString();
                ls.Tinhtrang = "Thành công";
                ls.Giora = DateTime.Today.ToString();
                // THÊM LỊCH SỬ VÀO CSDL
                BUS_LichSuDangNhap.ThemLS(ls);
                MessageBox.Show("Đăng nhập thành công");
                Main_Home main = new Main_Home();
                main.Show();
                this.Hide();
            }
            else
            {
                DTO_LichSuDangNhap ls = new DTO_LichSuDangNhap();
                STT = BUS_LichSuDangNhap.STT();
                ls.Stt = STT;
                ls.Manv = txt_User.Text;
                ls.Time = DateTime.Today.ToString();
                ls.Tinhtrang = "Thất bại";
                ls.Time = DateTime.Today.ToString();
                BUS_LichSuDangNhap.ThemLS(ls);
                MessageBox.Show("Đăng nhập thất bại");
                txt_Pass.Text = "";
                txt_User.Text = "";
                txt_User.Focus();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Pass.Text = "";
            txt_User.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
