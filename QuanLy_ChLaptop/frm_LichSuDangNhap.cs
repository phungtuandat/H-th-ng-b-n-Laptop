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
    public partial class frm_LichSuDangNhap : Form
    {
        public frm_LichSuDangNhap()
        {
            InitializeComponent();
            data_ls.DataSource = BUS_LichSuDangNhap.ds();
        }
    }
}
