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
    public partial class frm_ThongKeHDBan : Form
    {
        public frm_ThongKeHDBan()
        {
            InitializeComponent();
            lbl_TongHoaDon.Text = "";
            lbl_TongSoLuong.Text = "";
            lbl_TongTien.Text = "";
            lbl_Huy.Text = "";
            data_ThongKe.Enabled = false;
            data_ThongKe.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }
        void LoadThongKE()
        {
            data_ThongKe.DataSource = BUS_ThongKE.loadHoaDon(date_Truoc.Value.ToString(),date_Sau.Value.ToString());
        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if(BUS_ThongKE.loadHoaDon(date_Truoc.Value.ToString(), date_Sau.Value.ToString()) == null)
            {
                MessageBox.Show("Không có hóa đơn nào được tạo trong khoảng thời gian này");
                return;
            }
            lbl_TongTien.Text = "Tổng doanh thu là: " + BUS_ThongKE.TongTien().ToString();
            lbl_TongHoaDon.Text = "Tổng hóa đơn là: " + BUS_ThongKE.TongHDBan().ToString();
            lbl_TongSoLuong.Text = "Tổng số lượng đã bán: " + BUS_ThongKE.TongSLBan().ToString();
            lbl_Huy.Text = "Tổng hóa đơn đã hủy: " + BUS_ThongKE.TongHDHuy();
            LoadThongKE();
        }

        private void btn_XemToanBoHd_Click(object sender, EventArgs e)
        {
           data_ThongKe.DataSource = BUS_BanHang.LoadBanHangDataGridView();
            lbl_TongHoaDon.Text = "";
            lbl_TongSoLuong.Text = "";
            lbl_TongTien.Text = "";
            lbl_Huy.Text = "";
        }
    }
}
