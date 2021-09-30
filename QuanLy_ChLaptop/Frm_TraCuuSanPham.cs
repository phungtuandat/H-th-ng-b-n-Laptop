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
    public partial class Frm_TraCuuSanPham : Form
    {
        public Frm_TraCuuSanPham()
        {
            InitializeComponent();
            
        }
        string duongdan;
        void Load()
        {
            data_TraCuu.DataSource = BUS_Laptop.DS_Laptop();
        }

        private void data_TraCuu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = data_TraCuu.CurrentRow.Index;
            img_Product.ImageLocation = data_TraCuu.Rows[n].Cells[9].Value.ToString();
        }
        private void rad_Tu2Den5Trieu_Click(object sender, EventArgs e)
        {
            if (BUS_TraCuu.DanhSachLaptop2Den5() == null)
            {
                img_Product.Image = null;
                data_TraCuu.DataSource = null;
                MessageBox.Show("Không có sản phẩm");
                return;
            }
            else
            {
                data_TraCuu.DataSource = BUS_TraCuu.DanhSachLaptop2Den5();
            }

        }

        private void rad_Tu5den7_Click(object sender, EventArgs e)
        {

            if (BUS_TraCuu.DanhSachLaptop5Den7() == null)
            {
                img_Product.Image = null;
                data_TraCuu.DataSource = null;
                MessageBox.Show("Không có sản phẩm");
                return;
            }
            else
            {
                data_TraCuu.DataSource = BUS_TraCuu.DanhSachLaptop5Den7();
            }
        }

        private void rad_7den15_Click(object sender, EventArgs e)
        {
            if (BUS_TraCuu.DanhSachLaptop7Den15() == null)
            {
                img_Product.Image = null;
                data_TraCuu.DataSource = null;
                MessageBox.Show("Không có sản phẩm");
                return;
            }
            else
            {
                data_TraCuu.DataSource = BUS_TraCuu.DanhSachLaptop7Den15();
            }
        }

        private void rad_Hon15_Click(object sender, EventArgs e)
        {
            if (BUS_TraCuu.DanhSachLaptop15TroLen() == null)
            {
                img_Product.Image = null;
                data_TraCuu.DataSource = null;
                MessageBox.Show("Không có sản phẩm");
                return;
            }
            else
            {
                data_TraCuu.DataSource = BUS_TraCuu.DanhSachLaptop15TroLen();
            }
        }

        void Reset()
        {
            foreach (CheckBox item in gr_TraCuu.Controls)
            {
                if (item.Checked == true)
                {
                    item.Checked = false;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(check_4GB.Checked == true && check_256GBSSD.Checked == true)
            {
                if(BUS_TraCuu.TimTheoCauHinh(check_4GB.Text , check_256GBSSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }

            }
            if (check_4GB.Checked == true && check_512SSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_512SSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }
            if (check_4GB.Checked == true && check_256HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_256HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;  
                }
            }

            if (check_4GB.Checked == true && check_512HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_512HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_4GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }

            // 8GB


            if (check_8GB.Checked == true && check_256GBSSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_256GBSSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }

            }
            if (check_8GB.Checked == true && check_512SSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_512SSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }
            if (check_8GB.Checked == true && check_256HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_256HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }

            if (check_8GB.Checked == true && check_512HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_512HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_8GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }

            // 16


            if (check_16GB.Checked == true && check_256GBSSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_256GBSSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }

            }
            if (check_16GB.Checked == true && check_512SSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_512SSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }
            if (check_16GB.Checked == true && check_256HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_256HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }

            if (check_16GB.Checked == true && check_512HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_512HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_16GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }


            // 32


            if (check_32GB.Checked == true && check_256GBSSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_256GBSSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }

            }
            if (check_32GB.Checked == true && check_512SSD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_512SSD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }
            if (check_32GB.Checked == true && check_256HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_256HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }

            if (check_32GB.Checked == true && check_512HHD.Checked == true)
            {
                if (BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_512HHD.Text) != null)
                {
                    data_TraCuu.DataSource = BUS_TraCuu.TimTheoCauHinh(check_32GB.Text, check_256GBSSD.Text);
                    Reset();
                }
                else
                {
                    data_TraCuu.DataSource = null;
                    img_Product.Image = null;
                    MessageBox.Show("Không có sản phẩm");
                    Reset();
                    return;
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
