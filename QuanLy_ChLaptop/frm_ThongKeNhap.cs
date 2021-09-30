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
    public partial class frm_ThongKeNhap : Form
    {
        public frm_ThongKeNhap()
        {
            InitializeComponent();
            data_ThongKe.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }
        void LoadThongKE()
        {
            data_ThongKe.DataSource = BUS_ThongKeNhap.loadHoaDon(date_Truoc.Value.ToString(), date_Sau.Value.ToString());
        }   
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (BUS_ThongKeNhap.loadHoaDon(date_Truoc.Value.ToString(), date_Sau.Value.ToString()) == null)
            {
                MessageBox.Show("Không có hóa đơn nào được tạo trong khoảng thời gian này");
                return;
            }
            lbl_TongTien.Text = "Tổng chi phí là: " + BUS_ThongKeNhap.TongTien().ToString();
            lbl_TongHoaDon.Text = "Tổng hóa đơn là: " + BUS_ThongKeNhap.TongHDNhap().ToString();
            lbl_TongSoLuong.Text = "Tổng số lượng đã nhập: " + BUS_ThongKeNhap.TongSLNhap().ToString();
            lbl_Huy.Text = "Tổng hóa đơn đã hủy: " + BUS_ThongKE.TongHDHuy();
            LoadThongKE();
        }
    }
}
