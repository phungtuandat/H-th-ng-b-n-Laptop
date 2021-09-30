
namespace QuanLy_ChLaptop
{
    partial class frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVien));
            this.data_NV = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_QuyenNV = new MetroFramework.Controls.MetroComboBox();
            this.btn_DeleteNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_EditNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Phone = new MetroFramework.Controls.MetroTextBox();
            this.txt_Address = new MetroFramework.Controls.MetroTextBox();
            this.txt_TenNV = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PassWord = new MetroFramework.Controls.MetroTextBox();
            this.txt_MaNV = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_NV
            // 
            this.data_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_NV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_NV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.data_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_NV.Location = new System.Drawing.Point(20, 224);
            this.data_NV.Name = "data_NV";
            this.data_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_NV.Size = new System.Drawing.Size(1163, 371);
            this.data_NV.TabIndex = 6;
            this.data_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_NV_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cmb_QuyenNV);
            this.groupControl1.Controls.Add(this.btn_DeleteNV);
            this.groupControl1.Controls.Add(this.btn_EditNV);
            this.groupControl1.Controls.Add(this.btn_ThemNV);
            this.groupControl1.Controls.Add(this.txt_Phone);
            this.groupControl1.Controls.Add(this.txt_Address);
            this.groupControl1.Controls.Add(this.txt_TenNV);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_PassWord);
            this.groupControl1.Controls.Add(this.txt_MaNV);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(79, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1069, 219);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "NHÂN VIÊN";
            // 
            // cmb_QuyenNV
            // 
            this.cmb_QuyenNV.FormattingEnabled = true;
            this.cmb_QuyenNV.ItemHeight = 23;
            this.cmb_QuyenNV.Location = new System.Drawing.Point(762, 109);
            this.cmb_QuyenNV.Name = "cmb_QuyenNV";
            this.cmb_QuyenNV.Size = new System.Drawing.Size(154, 29);
            this.cmb_QuyenNV.TabIndex = 3;
            this.cmb_QuyenNV.UseSelectable = true;
            // 
            // btn_DeleteNV
            // 
            this.btn_DeleteNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteNV.Appearance.Options.UseFont = true;
            this.btn_DeleteNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNV.ImageOptions.Image")));
            this.btn_DeleteNV.Location = new System.Drawing.Point(628, 169);
            this.btn_DeleteNV.Name = "btn_DeleteNV";
            this.btn_DeleteNV.Size = new System.Drawing.Size(91, 30);
            this.btn_DeleteNV.TabIndex = 2;
            this.btn_DeleteNV.Text = "Xóa bỏ";
            this.btn_DeleteNV.Click += new System.EventHandler(this.btn_DeleteNV_Click);
            // 
            // btn_EditNV
            // 
            this.btn_EditNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditNV.Appearance.Options.UseFont = true;
            this.btn_EditNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditNV.ImageOptions.Image")));
            this.btn_EditNV.Location = new System.Drawing.Point(471, 169);
            this.btn_EditNV.Name = "btn_EditNV";
            this.btn_EditNV.Size = new System.Drawing.Size(98, 30);
            this.btn_EditNV.TabIndex = 2;
            this.btn_EditNV.Text = "Cập nhật";
            this.btn_EditNV.ToolTip = "Sửa nhà cung cấp\r\n";
            this.btn_EditNV.Click += new System.EventHandler(this.btn_EditNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemNV.Appearance.Options.UseFont = true;
            this.btn_ThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.ImageOptions.Image")));
            this.btn_ThemNV.Location = new System.Drawing.Point(307, 169);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(105, 30);
            this.btn_ThemNV.TabIndex = 2;
            this.btn_ThemNV.Text = "Thêm mới\r\n";
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // txt_Phone
            // 
            // 
            // 
            // 
            this.txt_Phone.CustomButton.Image = null;
            this.txt_Phone.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_Phone.CustomButton.Name = "";
            this.txt_Phone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Phone.CustomButton.TabIndex = 1;
            this.txt_Phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Phone.CustomButton.UseSelectable = true;
            this.txt_Phone.CustomButton.Visible = false;
            this.txt_Phone.Lines = new string[0];
            this.txt_Phone.Location = new System.Drawing.Point(469, 109);
            this.txt_Phone.MaxLength = 32767;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.SelectionLength = 0;
            this.txt_Phone.SelectionStart = 0;
            this.txt_Phone.ShortcutsEnabled = true;
            this.txt_Phone.Size = new System.Drawing.Size(154, 29);
            this.txt_Phone.TabIndex = 1;
            this.txt_Phone.UseSelectable = true;
            this.txt_Phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Address
            // 
            // 
            // 
            // 
            this.txt_Address.CustomButton.Image = null;
            this.txt_Address.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_Address.CustomButton.Name = "";
            this.txt_Address.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Address.CustomButton.TabIndex = 1;
            this.txt_Address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Address.CustomButton.UseSelectable = true;
            this.txt_Address.CustomButton.Visible = false;
            this.txt_Address.Lines = new string[0];
            this.txt_Address.Location = new System.Drawing.Point(469, 64);
            this.txt_Address.MaxLength = 32767;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Address.SelectedText = "";
            this.txt_Address.SelectionLength = 0;
            this.txt_Address.SelectionStart = 0;
            this.txt_Address.ShortcutsEnabled = true;
            this.txt_Address.Size = new System.Drawing.Size(154, 29);
            this.txt_Address.TabIndex = 1;
            this.txt_Address.UseSelectable = true;
            this.txt_Address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_TenNV
            // 
            // 
            // 
            // 
            this.txt_TenNV.CustomButton.Image = null;
            this.txt_TenNV.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_TenNV.CustomButton.Name = "";
            this.txt_TenNV.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_TenNV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TenNV.CustomButton.TabIndex = 1;
            this.txt_TenNV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TenNV.CustomButton.UseSelectable = true;
            this.txt_TenNV.CustomButton.Visible = false;
            this.txt_TenNV.Lines = new string[0];
            this.txt_TenNV.Location = new System.Drawing.Point(196, 112);
            this.txt_TenNV.MaxLength = 32767;
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.PasswordChar = '\0';
            this.txt_TenNV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TenNV.SelectedText = "";
            this.txt_TenNV.SelectionLength = 0;
            this.txt_TenNV.SelectionStart = 0;
            this.txt_TenNV.ShortcutsEnabled = true;
            this.txt_TenNV.Size = new System.Drawing.Size(154, 29);
            this.txt_TenNV.TabIndex = 1;
            this.txt_TenNV.UseSelectable = true;
            this.txt_TenNV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TenNV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(389, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại";
            // 
            // txt_PassWord
            // 
            // 
            // 
            // 
            this.txt_PassWord.CustomButton.Image = null;
            this.txt_PassWord.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_PassWord.CustomButton.Name = "";
            this.txt_PassWord.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_PassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PassWord.CustomButton.TabIndex = 1;
            this.txt_PassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PassWord.CustomButton.UseSelectable = true;
            this.txt_PassWord.CustomButton.Visible = false;
            this.txt_PassWord.Lines = new string[0];
            this.txt_PassWord.Location = new System.Drawing.Point(762, 65);
            this.txt_PassWord.MaxLength = 32767;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '●';
            this.txt_PassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PassWord.SelectedText = "";
            this.txt_PassWord.SelectionLength = 0;
            this.txt_PassWord.SelectionStart = 0;
            this.txt_PassWord.ShortcutsEnabled = true;
            this.txt_PassWord.Size = new System.Drawing.Size(154, 29);
            this.txt_PassWord.TabIndex = 1;
            this.txt_PassWord.UseSelectable = true;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_MaNV
            // 
            // 
            // 
            // 
            this.txt_MaNV.CustomButton.Image = null;
            this.txt_MaNV.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_MaNV.CustomButton.Name = "";
            this.txt_MaNV.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_MaNV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MaNV.CustomButton.TabIndex = 1;
            this.txt_MaNV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MaNV.CustomButton.UseSelectable = true;
            this.txt_MaNV.CustomButton.Visible = false;
            this.txt_MaNV.Lines = new string[0];
            this.txt_MaNV.Location = new System.Drawing.Point(196, 67);
            this.txt_MaNV.MaxLength = 32767;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.PasswordChar = '\0';
            this.txt_MaNV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaNV.SelectedText = "";
            this.txt_MaNV.SelectionLength = 0;
            this.txt_MaNV.SelectionStart = 0;
            this.txt_MaNV.ShortcutsEnabled = true;
            this.txt_MaNV.Size = new System.Drawing.Size(154, 29);
            this.txt_MaNV.TabIndex = 1;
            this.txt_MaNV.UseSelectable = true;
            this.txt_MaNV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MaNV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(389, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(700, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(682, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(116, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(116, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_NV);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_NhanVien";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.data_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_NV;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteNV;
        private DevExpress.XtraEditors.SimpleButton btn_EditNV;
        private DevExpress.XtraEditors.SimpleButton btn_ThemNV;
        private MetroFramework.Controls.MetroTextBox txt_Phone;
        private MetroFramework.Controls.MetroTextBox txt_Address;
        private MetroFramework.Controls.MetroTextBox txt_TenNV;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txt_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_PassWord;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cmb_QuyenNV;
        private System.Windows.Forms.Label label6;
    }
}