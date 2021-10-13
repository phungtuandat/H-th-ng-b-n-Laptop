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
namespace QuanLy_ChLaptop
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();

            cmb_SanPham.DataSource = BUS_Kho.DanhSachLapTop();
            cmb_SanPham.DisplayMember = "tenLaptop";
            cmb_SanPham.ValueMember = "maLaptop";
            LoadCMB();
            LoadNCC();
            lbl_MaNV.Text = FrmLogin.TenDN;
            txt_TongTien.Enabled = false;
            LoadData();
            LoadHoaDonNhapChiTiet();
        }

        void LoadCMB()
        {
            cmb_MaHD.DataSource = BUS_NhapHang.HoaDonNhap();
            cmb_MaHD.ValueMember = "maHDnhap";
            cmb_MaHD.DisplayMember = "maHDnhap";
        }

        void LoadNCC()
        {
            cmb_NhaCungCap.DataSource = BUS_NCC.dSncc();
            cmb_NhaCungCap.ValueMember = "ma_NCC";
            cmb_NhaCungCap.DisplayMember = "ten_NCC";
        }

        void LoadData()
        {
            if(cmb_MaHD.SelectedValue == null)
            {
                MessageBox.Show("Hóa đơn không tồn tại sản phẩm");
                return;
            }
            else
            {
                data_HoaDonChiTiet.DataSource = BUS_NhapHang.HoaDonNhap();
            }
           
        }

        void LoadHoaDonNhapChiTiet()
        {
            if(cmb_MaHD.SelectedValue == null)
            {
                data_HoaDonChiTiet.DataSource = null;
                return;
            }
            data_HoaDonChiTiet.DataSource = BUS_NhapHang.LoadNhapHangChiTiet(cmb_MaHD.SelectedValue.ToString());
        }

        private void cmb_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SanPham.ValueMember == "")
            {
                pic_HinhAnhSanPham.Image = null;
                pic_HinhAnhSanPham.BackColor = Color.Transparent;
            }
            else
            {
                pic_HinhAnhSanPham.ImageLocation = BUS_Laptop.LayDuongDan(cmb_SanPham.SelectedValue.ToString());
                pic_HinhAnhSanPham.BackColor = Color.Transparent;
            }
        }

        private void btn_ThemHDBH_Click(object sender, EventArgs e)
        {
            if (txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                return;
            }
            if (BUS_NhapHang.KiemTraMaHD(txt_HoaDon.Text) != null)
            {
                MessageBox.Show("Hóa đơn đã tồn tại vui lòng nhập mã khác");
                return;
            }
            DTO_HoaDonNhap nhapHang = new DTO_HoaDonNhap();
            nhapHang.MaHDnhap = txt_HoaDon.Text;
            nhapHang.Mancc = cmb_NhaCungCap.SelectedValue.ToString();
            nhapHang.TenNCC = BUS_NhapHang.LayTenNCC(cmb_NhaCungCap.SelectedValue.ToString());
            nhapHang.MaNV = lbl_MaNV.Text;
            nhapHang.TenNV = BUS_Login.LayTenNV(lbl_MaNV.Text);
            nhapHang.Tongtien = 0;
            nhapHang.Ngaylap = DateTime.Now.ToString();
            nhapHang.TinhTrang = 0;
            if (BUS_NhapHang.ThemHoaDon(nhapHang) == false)
            {
                MessageBox.Show("Thêm hóa đơn thất bại");
                return;
            }
            MessageBox.Show("Thêm hóa đơn thành công");
            txt_HoaDon.Text = "";
            LoadCMB();
        }

        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoLuongMuonMua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng để tính tiền");
                return;
            }
            else
            {
                if(txt_GiaNhap.Text == "")
                {
                    return;
                }
                else
                {
                    lbl_ThanhTien1SP.Text = (int.Parse(txt_SoLuongMuonMua.Text) * int.Parse(txt_GiaNhap.Text)).ToString();
                }
            }
        }
        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 1 )
            {
                MessageBox.Show("Hóa đơn đang xét duyệt không thể thao tác");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 2)
            {
                MessageBox.Show("Hóa đơn đã nhập thành công không thể thao tác");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            else
            {
                txt_GiaNhap.Enabled = true;
                txt_SoLuongMuonMua.Enabled = true;
                if (txt_SoLuongMuonMua.Text == "" || txt_GiaNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (BUS_NhapHang.MaLaptopTrung(cmb_SanPham.SelectedValue.ToString(), cmb_MaHD.SelectedValue.ToString()) != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại");
                    return;
                }

                DTO_HoaDonNhapChiTiet detalis = new DTO_HoaDonNhapChiTiet();
                detalis.MaHD_nhap = cmb_MaHD.SelectedValue.ToString();
                detalis.MaLaptop_nhap = cmb_SanPham.SelectedValue.ToString();
                detalis.TenLaptop = BUS_NhapHang.TenSanPham(cmb_SanPham.SelectedValue.ToString());
                detalis.Soluong = int.Parse(txt_SoLuongMuonMua.Text);
                detalis.Gianhap = int.Parse(txt_GiaNhap.Text);
                detalis.ThanhTien = int.Parse(lbl_ThanhTien1SP.Text);
                if (BUS_NhapHang.ThemSanPham(detalis) == false)
                {
                    MessageBox.Show("Thêm không thành công");
                    return;
                }
                MessageBox.Show("Thêm thành công sản phẩm");
                LoadHoaDonNhapChiTiet();
                string money = (int.Parse(txt_GiaNhap.Text) + 1000000).ToString();
                var MESS = MessageBox.Show("Bạn có muốn cập nhật giá mới", "Cập nhật", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (DialogResult.OK == MESS)
                {
                    if (BUS_NhapHang.CapNhatGiaChoLaptop(money, cmb_SanPham.SelectedValue.ToString()) == false)
                    {
                        MessageBox.Show("Cập nhật giá cho sản phẩm không thành công");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật giá thành công");
                        txt_SoLuongMuonMua.Text = "";
                        txt_GiaNhap.Text = "";
                        return;
                    }
                }
                else
                {
                    return;
                }
               
            }

        }

        private void txt_SoLuongMuonMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmb_MaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDonNhapChiTiet();
        }

        private void btn_ViewDitalies_Click(object sender, EventArgs e)
        {
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            txt_HoaDon.Text = "";
            txt_HoaDon.Enabled = true;
            txt_TongTien.Text = "";
            LoadHoaDonNhapChiTiet();
            if(data_HoaDonChiTiet.RowCount == 0)
            {
                MessageBox.Show("Hóa đơn không tồn tại dữ liệu");
                return;
            }
            data_HoaDonChiTiet.Enabled = true;
        }

        private void btn_XemHoaDon_Click(object sender, EventArgs e)
        {
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            LoadData();
            txt_HoaDon.Text = cmb_MaHD.SelectedValue.ToString();
            txt_TongTien.Text = BUS_NhapHang.LayTien(cmb_MaHD.SelectedValue.ToString());
            cmb_NhaCungCap.Text = BUS_NhapHang.LayTenNCCHD(txt_HoaDon.Text);
            txt_HoaDon.Enabled = false;
            data_HoaDonChiTiet.Enabled = false;
        }

        private void btn_LuuHoaDon(object sender, EventArgs e)
        {
            if (data_HoaDonChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất một sản phẩm để lưu hóa đơn");
                return;
            }
            else
            {
                if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 1)
                {
                    MessageBox.Show("Hóa đơn đã được lưu và đang chờ xét duyệt");
                    return;
                }
                if (BUS_NhapHang.LoadNhapHangChiTiet(txt_HoaDon.Text) == null)
                {
                    MessageBox.Show("Hóa đơn không có dữ liệu không được thực thi");
                    return;
                }
                if (BUS_NhapHang.LuuHoaDon(txt_HoaDon.Text) == false)
                {
                    MessageBox.Show("Lưu không thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu thành công");
                    LoadData();
                    LoadCMB();
                    data_HoaDonChiTiet.Enabled = false;
                    txt_HoaDon.Enabled = true;
                    return;
                }
                
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("Hóa đơn đang xét duyệt không thể thao tác");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 2)
            {
                MessageBox.Show("Hóa đơn đã nhập thành công không thể thao tác");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(cmb_MaHD.SelectedValue.ToString()) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            if (data_HoaDonChiTiet.RowCount < 2)
            {
                MessageBox.Show("Hóa đơn phải tồn tại ít nhất một sản phẩm");
                return;
            }
            else
            {
                if(data_HoaDonChiTiet.SelectedRows == null)
                {
                    MessageBox.Show("Vui lòng chọn dòng muốn xóa");
                }
                else
                {
                    if(BUS_NhapHang.XoaDatHangChiTiet(cmb_SanPham.SelectedValue.ToString(),cmb_MaHD.SelectedValue.ToString()) == false)
                    {
                        MessageBox.Show("Xóa không thành công");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadHoaDonNhapChiTiet();
                    }
                }
            }
        }

        private void btn_XacNhanThanhCong_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadHoaDonNhapChiTiet();
        }

        private void data_HoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_HoaDonChiTiet.SelectedRows == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu");
                return;
            }
            else
            {
                int n = data_HoaDonChiTiet.CurrentRow.Index;
                cmb_MaHD.SelectedValue = data_HoaDonChiTiet.Rows[n].Cells[0].Value.ToString();
                cmb_SanPham.SelectedValue = data_HoaDonChiTiet.Rows[n].Cells[1].Value.ToString();
                txt_SoLuongMuonMua.Text = int.Parse(data_HoaDonChiTiet.Rows[n].Cells[3].Value.ToString()).ToString();
                txt_GiaNhap.Text = int.Parse(data_HoaDonChiTiet.Rows[n].Cells[4].Value.ToString()).ToString();
                lbl_ThanhTien1SP.Text = int.Parse(data_HoaDonChiTiet.Rows[n].Cells[5].Value.ToString()).ToString();
            }
        }

        private void btn_Checck_Click(object sender, EventArgs e)
        {
            if(txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn kiểm tra");
                return;
            }
            if(BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 0 )
            {
                MessageBox.Show("Hóa đơn chưa được xét duyệt");
                return;
            }
            if (BUS_NhapHang.HoaDonNhapThanhCong(txt_HoaDon.Text) == false)
            {
                MessageBox.Show("Nhập không hàng thành công");
                return;
            }
            MessageBox.Show("Nhập hàng thành công");
            LoadData();
            LoadCMB();
            data_HoaDonChiTiet.Enabled = false;
            txt_HoaDon.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn lưu");
                return;
            }
            if (data_HoaDonChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất một sản phẩm để lưu hóa đơn");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 1)
            {
                MessageBox.Show("Hóa đơn đã được xác nhận");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 2)
            {
                MessageBox.Show("Hóa đơn đã đã nhập thành công");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 3)
            {
                MessageBox.Show("Hóa đơn đã bị hủy");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 0)
            {
                if (BUS_NhapHang.LuuHoaDon(txt_HoaDon.Text) == false)
                {
                    MessageBox.Show("Lưu không thành công");
                }
                MessageBox.Show("Lưu thành công");
                LoadData();
                data_HoaDonChiTiet.Enabled = false;
                txt_HoaDon.Enabled = true;

            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TongTien.Text = "";
            txt_HoaDon.Text = "";
            txt_HoaDon.Enabled = true;
        }

        private void btn_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if(txt_HoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn hủy");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 1)
            {
                MessageBox.Show("Hóa đơn đã được xác nhận");
                return;
            }
            if (BUS_NhapHang.KiemTraTinhTrang(txt_HoaDon.Text) == 2)
            {
                MessageBox.Show("Hóa đơn đã nhập thành công");
                return;
            }
            if (BUS_NhapHang.HuyHoaDon(txt_HoaDon.Text) == false)
            {
                MessageBox.Show("Hủy hóa đơn không thành công");
                return;
            }
            MessageBox.Show("Hủy hóa đơn thành công");
            if (BUS_NhapHang.XoaHangTrongHoaDon(txt_HoaDon.Text) == false)
            {
                MessageBox.Show("Xóa không thành công");
            }
            MessageBox.Show("Xóa thông tin hóa đơn thành công");
            if (BUS_NhapHang.UpdateSauXoa(txt_HoaDon.Text) == false)
            {
                MessageBox.Show("Cập nhật giá không thành công");
            }
            else
                MessageBox.Show("Cập nhật giá thành công");
            LoadData();
            txt_HoaDon.Text = "";
        }
    }
}
