
namespace QuanLy_ChLaptop
{
    partial class frm_LoaiLaptop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoaiLaptop));
            this.data_LoaiLaptop = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_TTBH = new MetroFramework.Controls.MetroComboBox();
            this.cmb_NCC = new MetroFramework.Controls.MetroComboBox();
            this.btn_DeleteLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_EditLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemLoai = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenLoai = new MetroFramework.Controls.MetroTextBox();
            this.txt_MaLoai = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_LoaiLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_LoaiLaptop
            // 
            this.data_LoaiLaptop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_LoaiLaptop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_LoaiLaptop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.data_LoaiLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_LoaiLaptop.Location = new System.Drawing.Point(20, 224);
            this.data_LoaiLaptop.Name = "data_LoaiLaptop";
            this.data_LoaiLaptop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_LoaiLaptop.Size = new System.Drawing.Size(1163, 371);
            this.data_LoaiLaptop.TabIndex = 4;
            this.data_LoaiLaptop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_LoaiLaptop_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cmb_TTBH);
            this.groupControl1.Controls.Add(this.cmb_NCC);
            this.groupControl1.Controls.Add(this.btn_DeleteLoai);
            this.groupControl1.Controls.Add(this.btn_EditLoai);
            this.groupControl1.Controls.Add(this.btn_ThemLoai);
            this.groupControl1.Controls.Add(this.txt_TenLoai);
            this.groupControl1.Controls.Add(this.txt_MaLoai);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(96, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 219);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "LOẠI LAPTOP";
            // 
            // cmb_TTBH
            // 
            this.cmb_TTBH.FormattingEnabled = true;
            this.cmb_TTBH.ItemHeight = 23;
            this.cmb_TTBH.Location = new System.Drawing.Point(576, 103);
            this.cmb_TTBH.Name = "cmb_TTBH";
            this.cmb_TTBH.Size = new System.Drawing.Size(153, 29);
            this.cmb_TTBH.TabIndex = 4;
            this.cmb_TTBH.UseSelectable = true;
            // 
            // cmb_NCC
            // 
            this.cmb_NCC.FormattingEnabled = true;
            this.cmb_NCC.ItemHeight = 23;
            this.cmb_NCC.Location = new System.Drawing.Point(310, 103);
            this.cmb_NCC.Name = "cmb_NCC";
            this.cmb_NCC.Size = new System.Drawing.Size(153, 29);
            this.cmb_NCC.TabIndex = 4;
            this.cmb_NCC.UseSelectable = true;
            // 
            // btn_DeleteLoai
            // 
            this.btn_DeleteLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteLoai.Appearance.Options.UseFont = true;
            this.btn_DeleteLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteLoai.ImageOptions.Image")));
            this.btn_DeleteLoai.Location = new System.Drawing.Point(617, 156);
            this.btn_DeleteLoai.Name = "btn_DeleteLoai";
            this.btn_DeleteLoai.Size = new System.Drawing.Size(91, 30);
            this.btn_DeleteLoai.TabIndex = 2;
            this.btn_DeleteLoai.Text = "Xóa bỏ";
            this.btn_DeleteLoai.Click += new System.EventHandler(this.btn_DeleteLoai_Click);
            // 
            // btn_EditLoai
            // 
            this.btn_EditLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditLoai.Appearance.Options.UseFont = true;
            this.btn_EditLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditLoai.ImageOptions.Image")));
            this.btn_EditLoai.Location = new System.Drawing.Point(460, 156);
            this.btn_EditLoai.Name = "btn_EditLoai";
            this.btn_EditLoai.Size = new System.Drawing.Size(98, 30);
            this.btn_EditLoai.TabIndex = 2;
            this.btn_EditLoai.Text = "Cập nhật";
            this.btn_EditLoai.ToolTip = "Sửa nhà cung cấp\r\n";
            this.btn_EditLoai.Click += new System.EventHandler(this.btn_EditLoai_Click);
            // 
            // btn_ThemLoai
            // 
            this.btn_ThemLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemLoai.Appearance.Options.UseFont = true;
            this.btn_ThemLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemLoai.ImageOptions.Image")));
            this.btn_ThemLoai.Location = new System.Drawing.Point(296, 156);
            this.btn_ThemLoai.Name = "btn_ThemLoai";
            this.btn_ThemLoai.Size = new System.Drawing.Size(105, 30);
            this.btn_ThemLoai.TabIndex = 2;
            this.btn_ThemLoai.Text = "Thêm mới\r\n";
            this.btn_ThemLoai.Click += new System.EventHandler(this.btn_ThemLoai_Click);
            // 
            // txt_TenLoai
            // 
            // 
            // 
            // 
            this.txt_TenLoai.CustomButton.Image = null;
            this.txt_TenLoai.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_TenLoai.CustomButton.Name = "";
            this.txt_TenLoai.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_TenLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TenLoai.CustomButton.TabIndex = 1;
            this.txt_TenLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TenLoai.CustomButton.UseSelectable = true;
            this.txt_TenLoai.CustomButton.Visible = false;
            this.txt_TenLoai.Lines = new string[0];
            this.txt_TenLoai.Location = new System.Drawing.Point(575, 61);
            this.txt_TenLoai.MaxLength = 32767;
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.PasswordChar = '\0';
            this.txt_TenLoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TenLoai.SelectedText = "";
            this.txt_TenLoai.SelectionLength = 0;
            this.txt_TenLoai.SelectionStart = 0;
            this.txt_TenLoai.ShortcutsEnabled = true;
            this.txt_TenLoai.Size = new System.Drawing.Size(154, 29);
            this.txt_TenLoai.TabIndex = 1;
            this.txt_TenLoai.UseSelectable = true;
            this.txt_TenLoai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TenLoai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_MaLoai
            // 
            // 
            // 
            // 
            this.txt_MaLoai.CustomButton.Image = null;
            this.txt_MaLoai.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_MaLoai.CustomButton.Name = "";
            this.txt_MaLoai.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_MaLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MaLoai.CustomButton.TabIndex = 1;
            this.txt_MaLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MaLoai.CustomButton.UseSelectable = true;
            this.txt_MaLoai.CustomButton.Visible = false;
            this.txt_MaLoai.Lines = new string[0];
            this.txt_MaLoai.Location = new System.Drawing.Point(309, 61);
            this.txt_MaLoai.MaxLength = 32767;
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.PasswordChar = '\0';
            this.txt_MaLoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaLoai.SelectedText = "";
            this.txt_MaLoai.SelectionLength = 0;
            this.txt_MaLoai.SelectionStart = 0;
            this.txt_MaLoai.ShortcutsEnabled = true;
            this.txt_MaLoai.Size = new System.Drawing.Size(154, 29);
            this.txt_MaLoai.TabIndex = 1;
            this.txt_MaLoai.UseSelectable = true;
            this.txt_MaLoai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MaLoai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(495, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(495, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên TTBH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(229, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(229, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại";
            // 
            // frm_LoaiLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_LoaiLaptop);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_LoaiLaptop";
            this.Text = "frm_LoaiLaptop";
            ((System.ComponentModel.ISupportInitialize)(this.data_LoaiLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_LoaiLaptop;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteLoai;
        private DevExpress.XtraEditors.SimpleButton btn_EditLoai;
        private DevExpress.XtraEditors.SimpleButton btn_ThemLoai;
        private MetroFramework.Controls.MetroTextBox txt_TenLoai;
        private MetroFramework.Controls.MetroTextBox txt_MaLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmb_NCC;
        private MetroFramework.Controls.MetroComboBox cmb_TTBH;
        private System.Windows.Forms.Label label4;
    }
}