
namespace QuanLy_ChLaptop
{
    partial class ReportThamSo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LichSuLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LapTrinhQuanLyDataSet1 = new QuanLy_ChLaptop.LapTrinhQuanLyDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.LichSuLoginTableAdapter = new QuanLy_ChLaptop.LapTrinhQuanLyDataSet1TableAdapters.LichSuLoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LichSuLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LapTrinhQuanLyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // LichSuLoginBindingSource
            // 
            this.LichSuLoginBindingSource.DataMember = "LichSuLogin";
            this.LichSuLoginBindingSource.DataSource = this.LapTrinhQuanLyDataSet1;
            // 
            // LapTrinhQuanLyDataSet1
            // 
            this.LapTrinhQuanLyDataSet1.DataSetName = "LapTrinhQuanLyDataSet1";
            this.LapTrinhQuanLyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "LichSuDangNhapNV01";
            reportDataSource1.Value = this.LichSuLoginBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy_ChLaptop.ReportCoThamSo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1197, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_Search
            // 
            // 
            // 
            // 
            this.txt_Search.CustomButton.Image = null;
            this.txt_Search.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txt_Search.CustomButton.Name = "";
            this.txt_Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search.CustomButton.TabIndex = 1;
            this.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search.CustomButton.UseSelectable = true;
            this.txt_Search.CustomButton.Visible = false;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(960, 8);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(213, 23);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // LichSuLoginTableAdapter
            // 
            this.LichSuLoginTableAdapter.ClearBeforeFill = true;
            // 
            // ReportThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportThamSo";
            this.Text = "ReportThamSo";
            this.Load += new System.EventHandler(this.ReportThamSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LichSuLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LapTrinhQuanLyDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LichSuLoginBindingSource;
        private LapTrinhQuanLyDataSet1 LapTrinhQuanLyDataSet1;
        private LapTrinhQuanLyDataSet1TableAdapters.LichSuLoginTableAdapter LichSuLoginTableAdapter;
        private MetroFramework.Controls.MetroTextBox txt_Search;
    }
}