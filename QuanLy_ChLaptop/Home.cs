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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_ThongBaoSanPham.Text = BUS_Laptop.DemLapTOP().ToString();
            if(BUS_Laptop.LaptopSoLuongNhoHon20().Count > 0)
            {
                cmb_SanPhamHet.Visible = true;
                cmb_SanPhamHet.DataSource = BUS_Laptop.LaptopSoLuongNhoHon20();
                return;
            }
            else
            {
                cmb_SanPhamHet.Visible = false ;
                lbl_ThongBao.Text = "Không có";
            }

            lbl_TenTaiKhoan.Text = FrmLogin.TenDN;
            lbl_TimeVao.Text = DateTime.Now.ToString();
        }
    }
}
