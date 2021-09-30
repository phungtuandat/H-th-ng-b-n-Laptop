using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
namespace QuanLy_ChLaptop
{
    public partial class Main_Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string MaNV = FrmLogin.TenDN;
        public int quyen_taikhoan = FrmLogin.quyen;
        public int CapNhatLS = FrmLogin.STT;
        public Main_Home()
        {
            InitializeComponent();
            Show();
            CenterToScreen();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadForm_Panel();
            NameTaiKhoan.Caption = "Xin chào " + BUS_Login.LayTenNV(FrmLogin.TenDN);
            Time.Start();
        }

        void Show()
        {
            MaNV = FrmLogin.TenDN;
            quyen_taikhoan = FrmLogin.quyen;
            // 0 : nhân viên 1 : admin nv01: 1234, nv02: 12345, nv03:123
            if (quyen_taikhoan == 0)
            {
                btn_ThayDoiMatKhau.Visibility = BarItemVisibility.OnlyInCustomizing;
                btn_ThongKeHoaDonMua.Visibility = BarItemVisibility.OnlyInCustomizing;
                btn_ThongKeBan.Visibility = BarItemVisibility.OnlyInCustomizing;
                btn_LSDN.Visibility = BarItemVisibility.OnlyInCustomizing;
                btn_QuanLyNhanVien.Visibility = BarItemVisibility.OnlyInCustomizing;
                Page_Report.Visible = false;
            }
            else if (quyen_taikhoan == 1)
            {
                Page_Backup.Visible = true;
                Page_Help.Visible = true;
                Page_ChucNang.Visible = true;
                Page_Report.Visible = true;
                btn_ThayDoiMatKhau.Visibility = BarItemVisibility.Always;
                btn_ThongKeHoaDonMua.Visibility = BarItemVisibility.Always;
                btn_ThongKeBan.Visibility = BarItemVisibility.Always;
                btn_LSDN.Visibility = BarItemVisibility.Always;
                btn_QuanLyNhanVien.Visibility = BarItemVisibility.Always;
                Page_Report.Visible = true;
            }
        }
        void LoadForm_Panel()
        {
            Panel_Show.Controls.Clear();
            Home home = new Home()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(home);
            home.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            
            frm_NhanVien nv = new frm_NhanVien()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(nv);
            nv.Show();
        }

        private void Main_Home_Load(object sender, EventArgs e)
        {
        }

        private void btn_Logins_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btn_Logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_LichSuDangNhap.CapNhatGioRa(CapNhatLS, DateTime.Now.ToString());
            this.Close();
            FrmLogin lg = new FrmLogin();
            lg.ShowDialog();
            lg.StartPosition = FormStartPosition.CenterScreen;
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();

            NhaCungCap ncc = new NhaCungCap
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(ncc);
            ncc.Show();

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_LoaiLaptop loai_lp = new frm_LoaiLaptop()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(loai_lp);
            loai_lp.Show();
        }

        private void K_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            KhachHang frm_kh = new KhachHang()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(frm_kh);
            frm_kh.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            Frm_Laptop frm_product = new Frm_Laptop()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(frm_product);
            frm_product.Show();
        }

        private void btn_TTBH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            TTBH frm_ttbh = new TTBH()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(frm_ttbh);
            frm_ttbh.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_HoaDonBan frm_hdb = new frm_HoaDonBan()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(frm_hdb);
            frm_hdb.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            NameTaiKhoan.Caption = "Tài khoản: " + BUS_Login.LayTenNV(FrmLogin.TenDN);
        }

        private void btn_Report_DSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            Report report = new Report()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(report);
            report.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            ReportThamSo reportThamSo = new ReportThamSo()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(reportThamSo);
            reportThamSo.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_BaoCaoKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_BaoCaoKho reportKho = new frm_BaoCaoKho()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(reportKho);
            reportKho.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {

            Panel_Show.Controls.Clear();
            frm_BaoCaoHoaDonBan reportHDB = new frm_BaoCaoHoaDonBan()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(reportHDB);
            reportHDB.Show();
        }

        private void btn_ThayDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            ThayDoiPass newpass = new ThayDoiPass()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(newpass);
            newpass.Show();
        }

        private void btn_UseCoBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "C:/Users/ADMIN/source/repos/QuanLy_ChLaptop_LTQL/Help.pdf"));
        }

        private void btn_LuuY_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "C:/Users/ADMIN/source/repos/QuanLy_ChLaptop_LTQL/Help2.pdf"));
        }

        private void btn_GioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            Home home = new Home()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(home);
            home.Show();

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frmNhapHang nhaphang = new frmNhapHang()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(nhaphang);
            nhaphang.Show();
        }

        private void btn_TraCuuSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            Frm_TraCuuSanPham tracuu = new Frm_TraCuuSanPham()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(tracuu);
            tracuu.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_ThongKeHDBan thongke = new frm_ThongKeHDBan()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(thongke);
            thongke.Show();
        }

        private void btn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {

            Panel_Show.Controls.Clear();
            frm_SaoLuu saoluu = new frm_SaoLuu()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
                StartPosition = FormStartPosition.CenterParent
            };
            Panel_Show.Controls.Add(saoluu);
            saoluu.Show();
        }

        private void btn_Backup_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_KhoiPhuc khoiphuc = new frm_KhoiPhuc()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(khoiphuc);
            khoiphuc.Show();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lbl_Time.Caption = "Ngày giờ: " + DateTime.Now + 1;
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            Kho kho = new Kho()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(kho);
            kho.Show();
        }

        private void btn_ThongKeHoaDonMua_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_ThongKeNhap nhap = new frm_ThongKeNhap()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(nhap);
            nhap.Show();
        }

        private void btn_TroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help.ShowHelp(this, Path.Combine(Application.StartupPath, "HSSDPM.chm"));
        }

        private void btn_LSDN_ItemClick(object sender, ItemClickEventArgs e)
        {
            Panel_Show.Controls.Clear();
            frm_LichSuDangNhap dangnhap = new frm_LichSuDangNhap()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true,
            };

            Panel_Show.Controls.Add(dangnhap);
            dangnhap.Show();
        }
    }
}