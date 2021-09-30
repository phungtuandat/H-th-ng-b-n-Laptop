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
using System.IO;
using System.Drawing.Imaging;

namespace QuanLy_ChLaptop
{
    public partial class Frm_Laptop : Form
    {
        public Frm_Laptop()
        {
            InitializeComponent();
            LoadCMB();
            LoadSql();
            cmb_Ram.Items.Add("4GB");
            cmb_Ram.Items.Add("8GB");
            cmb_Ram.Items.Add("16GB");
            cmb_Ram.Items.Add("32GB");

            cmb_Rom.Items.Add("256GB (SSD)");
            cmb_Rom.Items.Add("512GB (HHD)");
            cmb_Rom.Items.Add("256GB (HHD)");
            cmb_Rom.Items.Add("512GB (SSD)");
            lbl_TinhTrangAnh.Text = "";
            lbl_GiaBan.Text = "";
            Check_Button();
        }

        void LoadTXT()
        {
            txt_MaLaptop.Text = "";
            cmb_MaLH.Text = "";
            txt_NameLaptop.Text = "";
            cmb_Ram.Text = "";
            cmb_Rom.Text = "";
            txt_CPU.Text = "";
            txt_CPU.Text = "";
            cmb_HDH.Text = "";
            lbl_GiaBan.Text = "";
            img_Laptop.Image = null;
            cmb_HDH.Text = "";
            txt_GhiChu.Text = "";
            txt_GPU.Text = "";
        }
        string namefile;
        string duongdan;
        int gianhap;
        double giaban;
        string paths;
        string path_delete;
        string path;
        string file;
        int i = 0;
        void Check_Button()
        {
            if (data_Laptop.RowCount < 1)
            {
                btn_EditLaptop.Enabled = false;
                btn_DeleteLaptop.Enabled = false;
            }
            else
            {
                btn_EditLaptop.Enabled = true;
                btn_DeleteLaptop.Enabled = true;
            }
        }
        void LoadSql()
        {
            data_Laptop.DataSource = BUS_Laptop.DS_Laptop();
        }
        void LoadCMB()
        {
            cmb_MaLH.DataSource = BUS_LoaiLaptop.DS_Loai();

            img_Laptop.BackColor = Color.Brown;
            cmb_MaLH.DisplayMember = "tenLoai";
            cmb_MaLH.ValueMember = "maLoai";

            cmb_HDH.Items.Add("Windows 10");
            cmb_HDH.Items.Add("Windows 7");
            cmb_HDH.Items.Add("Windows 8");

        }

        void Load_Image()
        {
            if (open_Image.ShowDialog() == DialogResult.OK)
            {
                namefile = open_Image.FileName;
                img_Laptop.ImageLocation = namefile;
                //img_Laptop.Image.Save(namefile);
                file = Path.GetFileName(open_Image.FileName);
                path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                paths = path + "\\Images\\" + file;
                if (File.Exists(paths))
                {
                    lbl_TinhTrangAnh.Text = "Ảnh đã tồn tại";
                    lbl_TinhTrangAnh.ForeColor = Color.Red;
                    lbl_TinhTrangAnh.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
                    i--;
                    return;
                }
                else
                {
                    lbl_TinhTrangAnh.Text = "Ảnh phù hợp";
                    lbl_TinhTrangAnh.ForeColor = Color.Black;
                    lbl_TinhTrangAnh.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
                    i++;
                }

            }
        }

        private void btn_ThemLapTop_Click(object sender, EventArgs e)
        {
            if (img_Laptop.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh");
                return;
            }
            if (txt_MaLaptop.Text == "" || txt_NameLaptop.Text == "" || txt_GPU.Text == "" || txt_GPU.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(BUS_Laptop.MaLaptopTrung(txt_MaLaptop.Text) !=null )
            {
                MessageBox.Show("Mã laptop đã tồn tại");
                return;
            }
            DTO_Laptop laptop = new DTO_Laptop();
            laptop.MaLaptop = txt_MaLaptop.Text;
            laptop.MaLH = cmb_MaLH.SelectedValue.ToString();
            laptop.TenLaptop = txt_NameLaptop.Text;
            laptop.Ram = cmb_Ram.Text;
            laptop.Ocung = cmb_Rom.Text;
            laptop.Cpu = txt_CPU.Text;
            laptop.Gpu = txt_GPU.Text;
            laptop.HDH1 = cmb_HDH.Text;
            laptop.Giaban = 0;
            if (i < 0)
            {
                lbl_TinhTrangAnh.Text = "Vui lòng chọn ảnh khác";
                lbl_TinhTrangAnh.ForeColor = Color.Red;
                lbl_TinhTrangAnh.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
                return;
            }
            else
            {
                File.Copy(namefile, path + "\\Images\\" + file, true);
                laptop.Duongdan = paths;
            }
            laptop.Ghichu = txt_GhiChu.Text;

            if(BUS_Laptop.ThemLaptop(laptop) == true)
            {
                MessageBox.Show("Nhập thành công");
                DTO_Kho kho = new DTO_Kho();
                kho.STT = BUS_Laptop.STT();
                kho.MaLaptop = txt_MaLaptop.Text;
                kho.TenLaptop = txt_NameLaptop.Text;
                kho.SoLuongBan = 0;
                kho.SoLuongTon = 0;
                if(BUS_Laptop.ThemVaoKho(kho) == false)
                {
                    MessageBox.Show("Thêm vào kho không thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm vào kho thành công");
                }
                LoadSql();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            lbl_TinhTrangAnh.Visible = false;
            LoadTXT();
            Check_Button();
        }

        private void data_Laptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Laptop.RowCount < 1)
            {
                btn_DeleteLaptop.Enabled = false;
                btn_EditLaptop.Enabled = false;
            }
            else
            {
                int n = data_Laptop.CurrentRow.Index;
                txt_MaLaptop.Text = data_Laptop.Rows[n].Cells[0].Value.ToString();
                cmb_MaLH.Text = data_Laptop.Rows[n].Cells[1].Value.ToString();
                txt_NameLaptop.Text = data_Laptop.Rows[n].Cells[2].Value.ToString();
                cmb_Ram.Text = data_Laptop.Rows[n].Cells[3].Value.ToString();
                cmb_Rom.Text = data_Laptop.Rows[n].Cells[4].Value.ToString();
                txt_CPU.Text = data_Laptop.Rows[n].Cells[5].Value.ToString();
                txt_GPU.Text = data_Laptop.Rows[n].Cells[6].Value.ToString();
                cmb_HDH.Text = data_Laptop.Rows[n].Cells[7].Value.ToString();
                lbl_GiaBan.Text = data_Laptop.Rows[n].Cells[8].Value.ToString();
                img_Laptop.ImageLocation = data_Laptop.Rows[n].Cells[9].Value.ToString();// địa chỉ ảnh
                txt_GhiChu.Text = data_Laptop.Rows[n].Cells[10].Value.ToString();
                // đường dẫn xóa ảnh
                path_delete = data_Laptop.Rows[n].Cells[9].Value.ToString();
                txt_MaLaptop.Enabled = false;
                btn_DeleteLaptop.Enabled = true;
                btn_EditLaptop.Enabled = true;
                lbl_TinhTrangAnh.Visible = false;
            }
        }

        private void img_Laptop_MouseClick(object sender, MouseEventArgs e)
        {
            Load_Image();
        }

        private void img_Laptop_MouseHover(object sender, EventArgs e)
        {
            img_Laptop.SizeMode = PictureBoxSizeMode.CenterImage;
            img_Laptop.BackColor = Color.White;
        }

        private void img_Laptop_MouseLeave(object sender, EventArgs e)
        {
            img_Laptop.SizeMode = PictureBoxSizeMode.Zoom;
            img_Laptop.BackColor = Color.Brown;
        }

        private void btn_DeleteLaptop_Click(object sender, EventArgs e)
        {
            Check_Button();
            BUS_Laptop.XoaLaptop(txt_MaLaptop.Text);
                // xóa ảnh theo đường dẫn
            File.Delete(path_delete);
            MessageBox.Show("Xóa thành công");
            LoadSql();
            LoadTXT();
            lbl_TinhTrangAnh.Visible = false;
            Check_Button();
        }

        private void btn_EditLaptop_Click(object sender, EventArgs e)
        {
            Check_Button();
            DTO_Laptop laptop = new DTO_Laptop();
            laptop.MaLaptop = txt_MaLaptop.Text;
            laptop.MaLH = cmb_MaLH.SelectedValue.ToString();
            laptop.TenLaptop = txt_NameLaptop.Text;
            laptop.Ram = cmb_Ram.Text;
            laptop.Ocung = cmb_Rom.Text;
            laptop.Cpu = txt_CPU.Text;
            laptop.Gpu = txt_GPU.Text;
            laptop.HDH1 = cmb_HDH.Text;
            laptop.Giaban = Convert.ToInt32(lbl_GiaBan.Text);
            if (open_Image.FileName == "openFileDialog1")
            {
                laptop.Duongdan = path_delete;
            }
            else
            {
                laptop.Duongdan = "";
                File.Delete(BUS_Laptop.LayDuongDan(txt_MaLaptop.Text));
                File.Copy(namefile, path + "\\Images\\" + file, true);
                laptop.Duongdan = paths;
            }
            laptop.Ghichu = txt_GhiChu.Text;

            if (BUS_Laptop.SuaLaptop(laptop) == true)
            {
                MessageBox.Show("Sửa thành công");
                LoadSql();
            }
            else
            {
                MessageBox.Show("Sữa thất bại");
            }
            LoadTXT();
            Check_Button();
        }

        private void txt_priceNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
