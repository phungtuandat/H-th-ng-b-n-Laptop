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
    public partial class ReportThamSo : Form
    {
        public ReportThamSo()
        {
            InitializeComponent();
        }

        private void ReportThamSo_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LapTrinhQuanLyDataSet1.LichSuLogin' table. You can move, or remove it, as needed.
          
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != null)
            {
                this.LichSuLoginTableAdapter.Fill(this.LapTrinhQuanLyDataSet1.LichSuLogin, int.Parse(txt_Search.Text));

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
