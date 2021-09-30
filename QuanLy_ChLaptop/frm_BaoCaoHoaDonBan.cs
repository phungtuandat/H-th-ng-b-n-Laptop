using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_ChLaptop
{
    public partial class frm_BaoCaoHoaDonBan : Form
    {
        public frm_BaoCaoHoaDonBan()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoHoaDonBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HoaDonBan.HoaDonBan' table. You can move, or remove it, as needed.
            
        }

        private void txt_NhapHoaDon_TextChanged(object sender, EventArgs e)
        {
            this.HoaDonBanTableAdapter.Fill(this.HoaDonBan._HoaDonBan,txt_NhapHoaDon.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
