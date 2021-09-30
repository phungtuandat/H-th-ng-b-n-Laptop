
namespace QuanLy_ChLaptop
{
    partial class frm_BaoCaoKho
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCaoKho = new QuanLy_ChLaptop.BaoCaoKho();
            this.KhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhoTableAdapter = new QuanLy_ChLaptop.BaoCaoKhoTableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCaoKho";
            reportDataSource1.Value = this.KhoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy_ChLaptop.DSSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1202, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // BaoCaoKho
            // 
            this.BaoCaoKho.DataSetName = "BaoCaoKho";
            this.BaoCaoKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhoBindingSource
            // 
            this.KhoBindingSource.DataMember = "Kho";
            this.KhoBindingSource.DataSource = this.BaoCaoKho;
            // 
            // KhoTableAdapter
            // 
            this.KhoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_BaoCaoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_BaoCaoKho";
            this.Text = "frm_BaoCaoKho";
            this.Load += new System.EventHandler(this.frm_BaoCaoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KhoBindingSource;
        private BaoCaoKho BaoCaoKho;
        private BaoCaoKhoTableAdapters.KhoTableAdapter KhoTableAdapter;
    }
}