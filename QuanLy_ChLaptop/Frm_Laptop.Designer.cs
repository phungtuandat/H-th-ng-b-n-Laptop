
namespace QuanLy_ChLaptop
{
    partial class Frm_Laptop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Laptop));
            this.open_Image = new System.Windows.Forms.OpenFileDialog();
            this.data_Laptop = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaLaptop = new MetroFramework.Controls.MetroTextBox();
            this.btn_ThemLapTop = new DevExpress.XtraEditors.SimpleButton();
            this.btn_EditLaptop = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DeleteLaptop = new DevExpress.XtraEditors.SimpleButton();
            this.txt_CPU = new MetroFramework.Controls.MetroTextBox();
            this.txt_GPU = new MetroFramework.Controls.MetroTextBox();
            this.txt_NameLaptop = new MetroFramework.Controls.MetroTextBox();
            this.txt_GhiChu = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_HDH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_GiaBan = new System.Windows.Forms.Label();
            this.cmb_HDH = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Ram = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Rom = new MetroFramework.Controls.MetroComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.img_Laptop = new System.Windows.Forms.PictureBox();
            this.cmb_MaLH = new MetroFramework.Controls.MetroComboBox();
            this.lbl_TinhTrangAnh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Laptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Laptop)).BeginInit();
            this.SuspendLayout();
            // 
            // open_Image
            // 
            this.open_Image.FileName = "openFileDialog1";
            // 
            // data_Laptop
            // 
            this.data_Laptop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Laptop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_Laptop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.data_Laptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Laptop.Location = new System.Drawing.Point(24, 263);
            this.data_Laptop.Name = "data_Laptop";
            this.data_Laptop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Laptop.Size = new System.Drawing.Size(1163, 334);
            this.data_Laptop.TabIndex = 6;
            this.data_Laptop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Laptop_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lbl_TinhTrangAnh);
            this.groupControl1.Controls.Add(this.cmb_MaLH);
            this.groupControl1.Controls.Add(this.img_Laptop);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.btn_DeleteLaptop);
            this.groupControl1.Controls.Add(this.btn_EditLaptop);
            this.groupControl1.Controls.Add(this.btn_ThemLapTop);
            this.groupControl1.Controls.Add(this.txt_MaLaptop);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(8, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1198, 258);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "LAPTOP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(318, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Laptop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(573, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã LH";
            // 
            // txt_MaLaptop
            // 
            // 
            // 
            // 
            this.txt_MaLaptop.CustomButton.Image = null;
            this.txt_MaLaptop.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_MaLaptop.CustomButton.Name = "";
            this.txt_MaLaptop.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_MaLaptop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MaLaptop.CustomButton.TabIndex = 1;
            this.txt_MaLaptop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MaLaptop.CustomButton.UseSelectable = true;
            this.txt_MaLaptop.CustomButton.Visible = false;
            this.txt_MaLaptop.Lines = new string[0];
            this.txt_MaLaptop.Location = new System.Drawing.Point(407, 201);
            this.txt_MaLaptop.MaxLength = 32767;
            this.txt_MaLaptop.Name = "txt_MaLaptop";
            this.txt_MaLaptop.PasswordChar = '\0';
            this.txt_MaLaptop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaLaptop.SelectedText = "";
            this.txt_MaLaptop.SelectionLength = 0;
            this.txt_MaLaptop.SelectionStart = 0;
            this.txt_MaLaptop.ShortcutsEnabled = true;
            this.txt_MaLaptop.Size = new System.Drawing.Size(154, 29);
            this.txt_MaLaptop.TabIndex = 1;
            this.txt_MaLaptop.UseSelectable = true;
            this.txt_MaLaptop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MaLaptop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_ThemLapTop
            // 
            this.btn_ThemLapTop.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemLapTop.Appearance.Options.UseFont = true;
            this.btn_ThemLapTop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemLapTop.ImageOptions.Image")));
            this.btn_ThemLapTop.Location = new System.Drawing.Point(816, 201);
            this.btn_ThemLapTop.Name = "btn_ThemLapTop";
            this.btn_ThemLapTop.Size = new System.Drawing.Size(105, 30);
            this.btn_ThemLapTop.TabIndex = 2;
            this.btn_ThemLapTop.Text = "Thêm mới\r\n";
            this.btn_ThemLapTop.Click += new System.EventHandler(this.btn_ThemLapTop_Click);
            // 
            // btn_EditLaptop
            // 
            this.btn_EditLaptop.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditLaptop.Appearance.Options.UseFont = true;
            this.btn_EditLaptop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditLaptop.ImageOptions.Image")));
            this.btn_EditLaptop.Location = new System.Drawing.Point(940, 201);
            this.btn_EditLaptop.Name = "btn_EditLaptop";
            this.btn_EditLaptop.Size = new System.Drawing.Size(98, 30);
            this.btn_EditLaptop.TabIndex = 2;
            this.btn_EditLaptop.Text = "Cập nhật";
            this.btn_EditLaptop.ToolTip = "Sửa nhà cung cấp\r\n";
            this.btn_EditLaptop.Click += new System.EventHandler(this.btn_EditLaptop_Click);
            // 
            // btn_DeleteLaptop
            // 
            this.btn_DeleteLaptop.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteLaptop.Appearance.Options.UseFont = true;
            this.btn_DeleteLaptop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteLaptop.ImageOptions.Image")));
            this.btn_DeleteLaptop.Location = new System.Drawing.Point(1059, 201);
            this.btn_DeleteLaptop.Name = "btn_DeleteLaptop";
            this.btn_DeleteLaptop.Size = new System.Drawing.Size(91, 30);
            this.btn_DeleteLaptop.TabIndex = 2;
            this.btn_DeleteLaptop.Text = "Xóa bỏ";
            this.btn_DeleteLaptop.Click += new System.EventHandler(this.btn_DeleteLaptop_Click);
            // 
            // txt_CPU
            // 
            // 
            // 
            // 
            this.txt_CPU.CustomButton.Image = null;
            this.txt_CPU.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txt_CPU.CustomButton.Name = "";
            this.txt_CPU.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_CPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CPU.CustomButton.TabIndex = 1;
            this.txt_CPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CPU.CustomButton.UseSelectable = true;
            this.txt_CPU.CustomButton.Visible = false;
            this.txt_CPU.Lines = new string[0];
            this.txt_CPU.Location = new System.Drawing.Point(468, 76);
            this.txt_CPU.MaxLength = 32767;
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.PasswordChar = '\0';
            this.txt_CPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CPU.SelectedText = "";
            this.txt_CPU.SelectionLength = 0;
            this.txt_CPU.SelectionStart = 0;
            this.txt_CPU.ShortcutsEnabled = true;
            this.txt_CPU.Size = new System.Drawing.Size(175, 29);
            this.txt_CPU.TabIndex = 1;
            this.txt_CPU.UseSelectable = true;
            this.txt_CPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_GPU
            // 
            // 
            // 
            // 
            this.txt_GPU.CustomButton.Image = null;
            this.txt_GPU.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txt_GPU.CustomButton.Name = "";
            this.txt_GPU.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_GPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_GPU.CustomButton.TabIndex = 1;
            this.txt_GPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_GPU.CustomButton.UseSelectable = true;
            this.txt_GPU.CustomButton.Visible = false;
            this.txt_GPU.Lines = new string[0];
            this.txt_GPU.Location = new System.Drawing.Point(700, 76);
            this.txt_GPU.MaxLength = 32767;
            this.txt_GPU.Name = "txt_GPU";
            this.txt_GPU.PasswordChar = '\0';
            this.txt_GPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_GPU.SelectedText = "";
            this.txt_GPU.SelectionLength = 0;
            this.txt_GPU.SelectionStart = 0;
            this.txt_GPU.ShortcutsEnabled = true;
            this.txt_GPU.Size = new System.Drawing.Size(171, 29);
            this.txt_GPU.TabIndex = 1;
            this.txt_GPU.UseSelectable = true;
            this.txt_GPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_GPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_NameLaptop
            // 
            // 
            // 
            // 
            this.txt_NameLaptop.CustomButton.Image = null;
            this.txt_NameLaptop.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.txt_NameLaptop.CustomButton.Name = "";
            this.txt_NameLaptop.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_NameLaptop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NameLaptop.CustomButton.TabIndex = 1;
            this.txt_NameLaptop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NameLaptop.CustomButton.UseSelectable = true;
            this.txt_NameLaptop.CustomButton.Visible = false;
            this.txt_NameLaptop.Lines = new string[0];
            this.txt_NameLaptop.Location = new System.Drawing.Point(103, 35);
            this.txt_NameLaptop.MaxLength = 32767;
            this.txt_NameLaptop.Name = "txt_NameLaptop";
            this.txt_NameLaptop.PasswordChar = '\0';
            this.txt_NameLaptop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NameLaptop.SelectedText = "";
            this.txt_NameLaptop.SelectionLength = 0;
            this.txt_NameLaptop.SelectionStart = 0;
            this.txt_NameLaptop.ShortcutsEnabled = true;
            this.txt_NameLaptop.Size = new System.Drawing.Size(343, 29);
            this.txt_NameLaptop.TabIndex = 1;
            this.txt_NameLaptop.UseSelectable = true;
            this.txt_NameLaptop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NameLaptop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_GhiChu
            // 
            // 
            // 
            // 
            this.txt_GhiChu.CustomButton.Image = null;
            this.txt_GhiChu.CustomButton.Location = new System.Drawing.Point(477, 1);
            this.txt_GhiChu.CustomButton.Name = "";
            this.txt_GhiChu.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_GhiChu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_GhiChu.CustomButton.TabIndex = 1;
            this.txt_GhiChu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_GhiChu.CustomButton.UseSelectable = true;
            this.txt_GhiChu.CustomButton.Visible = false;
            this.txt_GhiChu.Lines = new string[0];
            this.txt_GhiChu.Location = new System.Drawing.Point(103, 117);
            this.txt_GhiChu.MaxLength = 32767;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.PasswordChar = '\0';
            this.txt_GhiChu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_GhiChu.SelectedText = "";
            this.txt_GhiChu.SelectionLength = 0;
            this.txt_GhiChu.SelectionStart = 0;
            this.txt_GhiChu.ShortcutsEnabled = true;
            this.txt_GhiChu.Size = new System.Drawing.Size(505, 29);
            this.txt_GhiChu.TabIndex = 1;
            this.txt_GhiChu.UseSelectable = true;
            this.txt_GhiChu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_GhiChu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(17, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ram";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(574, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(423, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "CPU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(217, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(649, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "GPU";
            // 
            // lbl_HDH
            // 
            this.lbl_HDH.AutoSize = true;
            this.lbl_HDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HDH.Location = new System.Drawing.Point(626, 124);
            this.lbl_HDH.Name = "lbl_HDH";
            this.lbl_HDH.Size = new System.Drawing.Size(45, 19);
            this.lbl_HDH.TabIndex = 0;
            this.lbl_HDH.Text = "HĐH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Laptop";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(14, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ghi chú";
            // 
            // lbl_GiaBan
            // 
            this.lbl_GiaBan.AutoSize = true;
            this.lbl_GiaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_GiaBan.Location = new System.Drawing.Point(649, 36);
            this.lbl_GiaBan.Name = "lbl_GiaBan";
            this.lbl_GiaBan.Size = new System.Drawing.Size(62, 21);
            this.lbl_GiaBan.TabIndex = 2;
            this.lbl_GiaBan.Text = "label13";
            // 
            // cmb_HDH
            // 
            this.cmb_HDH.FormattingEnabled = true;
            this.cmb_HDH.ItemHeight = 23;
            this.cmb_HDH.Location = new System.Drawing.Point(675, 119);
            this.cmb_HDH.Name = "cmb_HDH";
            this.cmb_HDH.Size = new System.Drawing.Size(196, 29);
            this.cmb_HDH.TabIndex = 3;
            this.cmb_HDH.UseSelectable = true;
            // 
            // cmb_Ram
            // 
            this.cmb_Ram.FormattingEnabled = true;
            this.cmb_Ram.ItemHeight = 23;
            this.cmb_Ram.Location = new System.Drawing.Point(64, 76);
            this.cmb_Ram.Name = "cmb_Ram";
            this.cmb_Ram.Size = new System.Drawing.Size(121, 29);
            this.cmb_Ram.TabIndex = 4;
            this.cmb_Ram.UseSelectable = true;
            // 
            // cmb_Rom
            // 
            this.cmb_Rom.FormattingEnabled = true;
            this.cmb_Rom.ItemHeight = 23;
            this.cmb_Rom.Location = new System.Drawing.Point(276, 76);
            this.cmb_Rom.Name = "cmb_Rom";
            this.cmb_Rom.Size = new System.Drawing.Size(121, 29);
            this.cmb_Rom.TabIndex = 4;
            this.cmb_Rom.UseSelectable = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.cmb_Rom);
            this.groupControl2.Controls.Add(this.cmb_Ram);
            this.groupControl2.Controls.Add(this.cmb_HDH);
            this.groupControl2.Controls.Add(this.lbl_GiaBan);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.lbl_HDH);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_GhiChu);
            this.groupControl2.Controls.Add(this.txt_NameLaptop);
            this.groupControl2.Controls.Add(this.txt_GPU);
            this.groupControl2.Controls.Add(this.txt_CPU);
            this.groupControl2.Location = new System.Drawing.Point(290, 27);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(890, 159);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thông tin cơ bản";
            // 
            // img_Laptop
            // 
            this.img_Laptop.BackColor = System.Drawing.Color.Transparent;
            this.img_Laptop.Location = new System.Drawing.Point(17, 25);
            this.img_Laptop.Name = "img_Laptop";
            this.img_Laptop.Size = new System.Drawing.Size(248, 208);
            this.img_Laptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Laptop.TabIndex = 4;
            this.img_Laptop.TabStop = false;
            this.img_Laptop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_Laptop_MouseClick);
            this.img_Laptop.MouseLeave += new System.EventHandler(this.img_Laptop_MouseLeave);
            this.img_Laptop.MouseHover += new System.EventHandler(this.img_Laptop_MouseHover);
            // 
            // cmb_MaLH
            // 
            this.cmb_MaLH.FormattingEnabled = true;
            this.cmb_MaLH.ItemHeight = 23;
            this.cmb_MaLH.Location = new System.Drawing.Point(637, 201);
            this.cmb_MaLH.Name = "cmb_MaLH";
            this.cmb_MaLH.Size = new System.Drawing.Size(160, 29);
            this.cmb_MaLH.TabIndex = 5;
            this.cmb_MaLH.UseSelectable = true;
            // 
            // lbl_TinhTrangAnh
            // 
            this.lbl_TinhTrangAnh.AutoSize = true;
            this.lbl_TinhTrangAnh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TinhTrangAnh.Location = new System.Drawing.Point(92, 236);
            this.lbl_TinhTrangAnh.Name = "lbl_TinhTrangAnh";
            this.lbl_TinhTrangAnh.Size = new System.Drawing.Size(44, 15);
            this.lbl_TinhTrangAnh.TabIndex = 6;
            this.lbl_TinhTrangAnh.Text = "label13";
            // 
            // Frm_Laptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_Laptop);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_Laptop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Laptop";
            ((System.ComponentModel.ISupportInitialize)(this.data_Laptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Laptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog open_Image;
        private System.Windows.Forms.DataGridView data_Laptop;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lbl_TinhTrangAnh;
        private MetroFramework.Controls.MetroComboBox cmb_MaLH;
        private System.Windows.Forms.PictureBox img_Laptop;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private MetroFramework.Controls.MetroComboBox cmb_Rom;
        private MetroFramework.Controls.MetroComboBox cmb_Ram;
        private MetroFramework.Controls.MetroComboBox cmb_HDH;
        private System.Windows.Forms.Label lbl_GiaBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_HDH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txt_GhiChu;
        private MetroFramework.Controls.MetroTextBox txt_NameLaptop;
        private MetroFramework.Controls.MetroTextBox txt_GPU;
        private MetroFramework.Controls.MetroTextBox txt_CPU;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteLaptop;
        private DevExpress.XtraEditors.SimpleButton btn_EditLaptop;
        private DevExpress.XtraEditors.SimpleButton btn_ThemLapTop;
        private MetroFramework.Controls.MetroTextBox txt_MaLaptop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}