using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLy_ChLaptop
{
    public partial class Version : Form
    {
        public Version()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Loading.Value = start += 2;//
            Loading.Maximum = 102;
            Loading.Minimum = 0;
            label3.Text = "Loading " + start + " %";
            //progressBar1.Value = 0;
            if (Loading.Value == 102)
            {
                timer1.Stop();
                
                FrmLogin lg = new FrmLogin();
                lg.Show();
                this.Hide();
            }


        }

        private void Version_Load(object sender, EventArgs e)
        {
            timer1.Start();// bat dau
        }
    }
}
