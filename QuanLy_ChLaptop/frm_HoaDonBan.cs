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
using System.Data.SqlClient;
namespace QuanLy_ChLaptop
{
    public partial class frm_HoaDonBan : Form
    {
        int giaban;
        int soLuong;
        int T;
        int xoatien;
        public frm_HoaDonBan()
        {
            InitializeComponent();
            lbl_MaNV.Text = FrmLogin.TenDN;

            cmb_MaKH.DataSource = BUS_KhachHang.dSKH();
            cmb_MaKH.ValueMember = "makh";
            cmb_MaKH.DisplayMember = "tenkh";
           

            cmb_SanPham.DataSource = BUS_Kho.DanhSachLapTop();
            cmb_SanPham.ValueMember = "malaptop";
            cmb_SanPham.DisplayMember = "tenlaptop";

            lbl_ThanhTien1SP.Text = "";
            
            LOADCMB_HD();
            LoadCTBH();
            KiemTraButton();

            //pic_HinhAnhSanPham.ImageLocation = BUS_Laptop.LayDuongDan(cmb_SanPham.SelectedValue.ToString());
        }

        void LoadHoaDon()
        {
            data_HoaDonChiTiet.DataSource = BUS_BanHang.LoadBanHangDataGridView();
        }

        void MotHoaDon()
        {
            data_HoaDonChiTiet.DataSource = BUS_BanHang.LoadBanHangDataGridViewHoaDon(txt_HoaDon.Text);
        }
        void KiemTraButton()
        {
            if (data_HoaDonChiTiet.RowCount < 1)
            {
                btn_Delete.Enabled = false;
            }
            else
            {
                btn_Delete.Enabled = true;
            }
        }
        void LOADCMB_HD()
        {
            cmb_MaHD.DataSource = BUS_BanHang.loadmahd();
            cmb_MaHD.DisplayMember = "maHDBan";
            cmb_MaHD.ValueMember = "maHDBan";
            txt_TongTien.Enabled = false;
        }
        void LoadCTBH()
        {
            if(cmb_MaHD.SelectedValue == null)
            {
                data_HoaDonChiTiet.DataSource = null;
            }
            else
            {
                data_HoaDonChiTiet.DataSource = BUS_BanHang.LoadDataGridView(cmb_MaHD.SelectedValue.ToString());
            }
            
        }

        private void cmb_MaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_HoaDonChiTiet.DataSource = BUS_BanHang.LoadDataGridView(cmb_MaHD.SelectedValue.ToString());
            KiemTraButton();
            //MessageBox.Show(tongtien.ToString());
        }
        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            
        }


        private void cmb_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_SanPham.ValueMember == "")
            {
                pic_HinhAnhSanPham.Image = null;
                pic_HinhAnhSanPham.BackColor = Color.Transparent;
            }
            else
            {
                pic_HinhAnhSanPham.ImageLocation = BUS_Laptop.LayDuongDan(cmb_SanPham.SelectedValue.ToString());
                pic_HinhAnhSanPham.BackColor = Color.Transparent;
                giaban = BUS_BanHang.GiaBan(cmb_SanPham.SelectedValue.ToString());
                lbl_GiaBan.Text = giaban.ToString();
            }
            
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Hóa đơn đã được xác nhận");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 2)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy không được thêm thông tin");
                return;
            }
            if (BUS_BanHang.malaptop(cmb_SanPham.SelectedValue.ToString(),cmb_MaHD.SelectedValue.ToString()) != null)
            {
                 MessageBox.Show("Sản phẩm đã tồn tại, Bạn vui lòng xóa và thêm lại sản phẩm mới","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                return;
            }
            //MessageBox.Show(BUS_BanHang.TenLaptop(cmb_SanPham.SelectedValue.ToString()));

            DTO_HoaDonBanChiTiet sanpham = new DTO_HoaDonBanChiTiet();
            sanpham.MaHD = cmb_MaHD.SelectedValue.ToString();
            sanpham.MaLaptop = cmb_SanPham.SelectedValue.ToString();
            sanpham.TenLaptop = BUS_BanHang.LayTenLaptop(cmb_SanPham.SelectedValue.ToString());
            if(int.Parse(txt_SoLuongMuonMua.Text) > BUS_BanHang.SoLuong(cmb_SanPham.SelectedValue.ToString()))
            {
                MessageBox.Show("Số lượng không còn đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sanpham.Soluong = int.Parse(txt_SoLuongMuonMua.Text);
            }
            sanpham.Giaban = int.Parse(lbl_GiaBan.Text);
            sanpham.ThanhTien = int.Parse(lbl_ThanhTien1SP.Text);
            if (BUS_BanHang.ThemVaoHoaDonChiTiet(sanpham) == false)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                LoadCTBH();
                //data_HoaDonChiTiet.Enabled = true
                txt_SoLuongMuonMua.Text = "";
                lbl_ThanhTien1SP.Text = "";
            }
            KiemTraButton();
        }

        private void data_HoaDonChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btn_XemHoaDon_Click(object sender, EventArgs e)
        {
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            cmb_MaKH.Text = "";
            txt_TongTien.Text = "";
            if (BUS_BanHang.LayTongTien(cmb_MaHD.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            else
            {
                data_HoaDonChiTiet.DataSource = BUS_BanHang.LoadDataGridView(cmb_MaHD.SelectedValue.ToString());
            }

            data_HoaDonChiTiet.Enabled = true;
        }

        private void data_HoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_HoaDonChiTiet.RowCount < 1)
            {
                btn_Delete.Enabled = false;
            }
            else
            {
                int n = data_HoaDonChiTiet.CurrentRow.Index;
               if(BUS_BanHang.LoadDataGridView(cmb_MaHD.SelectedValue.ToString()) != null)
                {
                    cmb_MaHD.SelectedItem = data_HoaDonChiTiet.Rows[n].Cells[0].Value.ToString();
                    cmb_SanPham.Text = data_HoaDonChiTiet.Rows[n].Cells[1].Value.ToString();
                    txt_SoLuongMuonMua.Text = int.Parse(data_HoaDonChiTiet.Rows[n].Cells[3].Value.ToString()).ToString();
                    lbl_GiaBan.Text = data_HoaDonChiTiet.Rows[n].Cells[4].Value.ToString();
                    lbl_ThanhTien1SP.Text = data_HoaDonChiTiet.Rows[n].Cells[5].Value.ToString();
                    // LẤY STT
                    
                    xoatien = int.Parse(data_HoaDonChiTiet.Rows[n].Cells[5].Value.ToString());
                    txt_HoaDon.Text = cmb_MaHD.SelectedValue.ToString();
                }
                else
                {
                    MessageBox.Show("Hóa đơn chi tiết không tồn tại");
                }
            }
                
        }

        private void txt_SoLuongMuonMua_TextChanged(object sender, EventArgs e)
        {
            if(txt_SoLuongMuonMua.Text == "")
            {
                lbl_ThanhTien1SP.Text = int.Parse("0").ToString();
            }
            else
            {
                lbl_ThanhTien1SP.Text = (int.Parse(txt_SoLuongMuonMua.Text) * int.Parse(lbl_GiaBan.Text)).ToString();
            }
        }

        private void txt_SoLuongMuonMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Hóa đơn đã được xác nhận");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 2)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy ");
                return;
            }
            if (data_HoaDonChiTiet.RowCount < 2)
            {
                MessageBox.Show("Hóa đơn phải tồn tại ít nhất một sản phẩm");
                return;
            }
            else
            {
                //MessageBox.Show(tongtien.ToString());
                if (data_HoaDonChiTiet.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa");
                    return;
                }
                if(BUS_BanHang.XoaSanPham(cmb_SanPham.SelectedValue.ToString(),cmb_MaHD.SelectedValue.ToString())==false)
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công");
                    LoadCTBH();
                }
            }

        }

        private void btn_SaveThanhTien_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
        }

        private void btn_XemHoaDon_Click_1(object sender, EventArgs e)
        {
            if (BUS_BanHang.KiemTraTinhTrangHDban(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy ");
                return;
            }
            
            LoadHoaDon();
            txt_HoaDon.Text = cmb_MaHD.SelectedValue.ToString();
            if (txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            cmb_MaKH.Text = BUS_BanHang.LayTenKHHD(cmb_MaHD.SelectedValue.ToString());
            txt_HoaDon.Enabled = false;
            data_HoaDonChiTiet.Enabled = false;
            txt_TongTien.Text = BUS_BanHang.LayTongTien(txt_HoaDon.Text);
        }

        private void btn_ThemHDBH_Click(object sender, EventArgs e)
        {
            if(txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                return;
            }
            if(BUS_BanHang.KiemTraMaHD(txt_HoaDon.Text) != null)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn khác");
                return;
            }
            DTO_HoaDonBan hoadon = new DTO_HoaDonBan();
            hoadon.MaHDBan = txt_HoaDon.Text;
            hoadon.MaKH = cmb_MaKH.SelectedValue.ToString();
            hoadon.TenKH = BUS_BanHang.LayTenKH(cmb_MaKH.SelectedValue.ToString());
            hoadon.MaNV = lbl_MaNV.Text;
            hoadon.TenNV = BUS_Login.LayTenNV(lbl_MaNV.Text);
            hoadon.Tongtien = 0;
            hoadon.Ngaylap = DateTime.Now.Date.ToString();
            hoadon.TinhTrang = 0;
            if (BUS_BanHang.ThemHoaDonBan(hoadon) == false)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            MessageBox.Show("Thêm hóa đơn thành công");
            LOADCMB_HD();
            txt_HoaDon.Text = "";
        }

        private void btn_HuyThaoTacThemHoaDonMoi_Click(object sender, EventArgs e)
        {
            lbl_MaNV.Text = FrmLogin.TenDN;
        }

        private void btn_CheckThanhToan_Click(object sender, EventArgs e)
        {
            if(txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            if (data_HoaDonChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất một sản phẩm để lưu hóa đơn");
                return;
            }
            if(BUS_BanHang.LoadDataGridView(txt_HoaDon.Text) == null)
            {
                MessageBox.Show("Vui lòng thêm một sản phẩm vào hóa đơn");
                return;
            }
            if(BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 1)
            {
                MessageBox.Show("Hóa đơn đã được xác nhận");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 2)
            {
                MessageBox.Show("Hóa đơn đã đã thanh toán");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            if(BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 0)
            {
                if (BUS_BanHang.XacNhan(txt_HoaDon.Text) == false)
                {
                    MessageBox.Show("Xác nhận không thành công");
                }
                MessageBox.Show("Xác nhận thành công");
                LoadHoaDon();
                data_HoaDonChiTiet.Enabled = false;
                txt_HoaDon.Enabled = true;
                
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            if (data_HoaDonChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất một sản phẩm để xác nhận");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 0)
            {
                MessageBox.Show("Phải xác nhận thông tin trước");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 2)
            {
                MessageBox.Show("Hóa đơn đã đã thanh toán");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            if(BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 1)
            {
                if(BUS_BanHang.ThanhToan(txt_HoaDon.Text) == false)
                {
                    MessageBox.Show("Thanh toán không thành cônng");
                }
                MessageBox.Show("Thanh toán thành công");
                LoadHoaDon();
                data_HoaDonChiTiet.Enabled = false;
                txt_HoaDon.Enabled = true;
            }
            
        }

        private void btn_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if (txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 1)
            {
                MessageBox.Show("Hóa đơn đã được xác nhận");
                return;
            }
            if (BUS_BanHang.KiemTraTinhTrangHDban(txt_HoaDon.Text) == 2)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");
                return;
            }
            if (BUS_BanHang.HuyHoaDon(txt_HoaDon.Text)== false)
            {
                MessageBox.Show("Hủy hóa đơn không thành công");
                return;
            }
            MessageBox.Show("Hủy hóa đơn thành công");
            if(BUS_BanHang.XoaHangTrongHoaDon(txt_HoaDon.Text) == false)
            {
                MessageBox.Show("Xóa không thành công");
            }
            MessageBox.Show("Xóa thông tin hóa đơn thành công");
            if (BUS_BanHang.UpdateSauXoa(txt_HoaDon.Text) == false)
            {
                MessageBox.Show("Cập nhật giá không thành công");
            }
            else
                MessageBox.Show("Cập nhật giá thành công");
            LoadHoaDon();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_TongTien.Text = "";
            txt_HoaDon.Text = "";
            txt_HoaDon.Enabled = true;
        }
    }
}
