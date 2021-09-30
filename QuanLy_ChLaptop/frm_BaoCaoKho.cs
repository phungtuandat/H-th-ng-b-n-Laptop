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
    public partial class frm_BaoCaoKho : Form
    {
        public frm_BaoCaoKho()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoCaoKho.Kho' table. You can move, or remove it, as needed.
            this.KhoTableAdapter.Fill(this.BaoCaoKho.Kho);

            this.reportViewer1.RefreshReport();
        }
    }
}
