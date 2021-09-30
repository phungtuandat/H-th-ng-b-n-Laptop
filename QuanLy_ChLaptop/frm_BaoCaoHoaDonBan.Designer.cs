
namespace QuanLy_ChLaptop
{
    partial class frm_BaoCaoHoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonBan = new QuanLy_ChLaptop.HoaDonBan();
            this.HoaDonBanTableAdapter = new QuanLy_ChLaptop.HoaDonBanTableAdapters.HoaDonBanTableAdapter();
            this.txt_NhapHoaDon = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBan)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "HoaDonBan";
            reportDataSource3.Value = this.HoaDonBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy_ChLaptop.DanhSachHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDonBanBindingSource
            // 
            this.HoaDonBanBindingSource.DataMember = "HoaDonBan";
            this.HoaDonBanBindingSource.DataSource = this.HoaDonBan;
            // 
            // HoaDonBan
            // 
            this.HoaDonBan.DataSetName = "HoaDonBan";
            this.HoaDonBan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBanTableAdapter
            // 
            this.HoaDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // txt_NhapHoaDon
            // 
            // 
            // 
            // 
            this.txt_NhapHoaDon.CustomButton.Image = null;
            this.txt_NhapHoaDon.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.txt_NhapHoaDon.CustomButton.Name = "";
            this.txt_NhapHoaDon.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_NhapHoaDon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NhapHoaDon.CustomButton.TabIndex = 1;
            this.txt_NhapHoaDon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NhapHoaDon.CustomButton.UseSelectable = true;
            this.txt_NhapHoaDon.CustomButton.Visible = false;
            this.txt_NhapHoaDon.Lines = new string[0];
            this.txt_NhapHoaDon.Location = new System.Drawing.Point(886, 13);
            this.txt_NhapHoaDon.MaxLength = 32767;
            this.txt_NhapHoaDon.Name = "txt_NhapHoaDon";
            this.txt_NhapHoaDon.PasswordChar = '\0';
            this.txt_NhapHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NhapHoaDon.SelectedText = "";
            this.txt_NhapHoaDon.SelectionLength = 0;
            this.txt_NhapHoaDon.SelectionStart = 0;
            this.txt_NhapHoaDon.ShortcutsEnabled = true;
            this.txt_NhapHoaDon.Size = new System.Drawing.Size(316, 29);
            this.txt_NhapHoaDon.TabIndex = 1;
            this.txt_NhapHoaDon.UseSelectable = true;
            this.txt_NhapHoaDon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NhapHoaDon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_NhapHoaDon.TextChanged += new System.EventHandler(this.txt_NhapHoaDon_TextChanged);
            // 
            // frm_BaoCaoHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.txt_NhapHoaDon);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_BaoCaoHoaDonBan";
            this.Text = "frm_BaoCaoHoaDonBan";
            this.Load += new System.EventHandler(this.frm_BaoCaoHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBanBindingSource;
        private HoaDonBan HoaDonBan;
        private HoaDonBanTableAdapters.HoaDonBanTableAdapter HoaDonBanTableAdapter;
        private MetroFramework.Controls.MetroTextBox txt_NhapHoaDon;
    }
}