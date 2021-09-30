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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
            data_Kho.DataSource = BUS_Kho.DanhSachLapTop();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
        }
    }
}
