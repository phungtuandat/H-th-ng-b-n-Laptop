
namespace QuanLy_ChLaptop
{
    partial class NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCap));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rad_SearchMa = new System.Windows.Forms.RadioButton();
            this.rad_SearchName = new System.Windows.Forms.RadioButton();
            this.btn_DeleteNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btn_EditNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemNCC = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Phone = new MetroFramework.Controls.MetroTextBox();
            this.txt_Address = new MetroFramework.Controls.MetroTextBox();
            this.txt_TenNCC = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SearchNCC = new MetroFramework.Controls.MetroTextBox();
            this.txt_MaNCC = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_NCC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.rad_SearchMa);
            this.groupControl1.Controls.Add(this.rad_SearchName);
            this.groupControl1.Controls.Add(this.btn_DeleteNCC);
            this.groupControl1.Controls.Add(this.btn_EditNCC);
            this.groupControl1.Controls.Add(this.btn_ThemNCC);
            this.groupControl1.Controls.Add(this.txt_Phone);
            this.groupControl1.Controls.Add(this.txt_Address);
            this.groupControl1.Controls.Add(this.txt_TenNCC);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_SearchNCC);
            this.groupControl1.Controls.Add(this.txt_MaNCC);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(103, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 219);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "NHÀ CUNG CẤP";
            // 
            // rad_SearchMa
            // 
            this.rad_SearchMa.AutoSize = true;
            this.rad_SearchMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_SearchMa.Location = new System.Drawing.Point(720, 129);
            this.rad_SearchMa.Name = "rad_SearchMa";
            this.rad_SearchMa.Size = new System.Drawing.Size(110, 23);
            this.rad_SearchMa.TabIndex = 3;
            this.rad_SearchMa.TabStop = true;
            this.rad_SearchMa.Text = "Tìm theo mã";
            this.rad_SearchMa.UseVisualStyleBackColor = true;
            this.rad_SearchMa.CheckedChanged += new System.EventHandler(this.rad_SearchMa_CheckedChanged);
            // 
            // rad_SearchName
            // 
            this.rad_SearchName.AutoSize = true;
            this.rad_SearchName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_SearchName.Location = new System.Drawing.Point(718, 92);
            this.rad_SearchName.Name = "rad_SearchName";
            this.rad_SearchName.Size = new System.Drawing.Size(111, 23);
            this.rad_SearchName.TabIndex = 3;
            this.rad_SearchName.TabStop = true;
            this.rad_SearchName.Text = "Tìm theo tên";
            this.rad_SearchName.UseVisualStyleBackColor = true;
            this.rad_SearchName.CheckedChanged += new System.EventHandler(this.rad_SearchName_CheckedChanged_1);
            // 
            // btn_DeleteNCC
            // 
            this.btn_DeleteNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteNCC.Appearance.Options.UseFont = true;
            this.btn_DeleteNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNCC.ImageOptions.Image")));
            this.btn_DeleteNCC.Location = new System.Drawing.Point(430, 154);
            this.btn_DeleteNCC.Name = "btn_DeleteNCC";
            this.btn_DeleteNCC.Size = new System.Drawing.Size(91, 30);
            this.btn_DeleteNCC.TabIndex = 2;
            this.btn_DeleteNCC.Text = "Xóa bỏ";
            this.btn_DeleteNCC.Click += new System.EventHandler(this.btn_DeleteNCC_Click);
            // 
            // btn_EditNCC
            // 
            this.btn_EditNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditNCC.Appearance.Options.UseFont = true;
            this.btn_EditNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditNCC.ImageOptions.Image")));
            this.btn_EditNCC.Location = new System.Drawing.Point(273, 154);
            this.btn_EditNCC.Name = "btn_EditNCC";
            this.btn_EditNCC.Size = new System.Drawing.Size(98, 30);
            this.btn_EditNCC.TabIndex = 2;
            this.btn_EditNCC.Text = "Cập nhật";
            this.btn_EditNCC.ToolTip = "Sửa nhà cung cấp\r\n";
            this.btn_EditNCC.Click += new System.EventHandler(this.btn_EditNCC_Click);
            // 
            // btn_ThemNCC
            // 
            this.btn_ThemNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemNCC.Appearance.Options.UseFont = true;
            this.btn_ThemNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNCC.ImageOptions.Image")));
            this.btn_ThemNCC.Location = new System.Drawing.Point(109, 154);
            this.btn_ThemNCC.Name = "btn_ThemNCC";
            this.btn_ThemNCC.Size = new System.Drawing.Size(105, 30);
            this.btn_ThemNCC.TabIndex = 2;
            this.btn_ThemNCC.Text = "Thêm mới\r\n";
            this.btn_ThemNCC.Click += new System.EventHandler(this.btn_ThemNCC_Click);
            // 
            // txt_Phone
            // 
            // 
            // 
            // 
            this.txt_Phone.CustomButton.Image = null;
            this.txt_Phone.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_Phone.CustomButton.Name = "";
            this.txt_Phone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Phone.CustomButton.TabIndex = 1;
            this.txt_Phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Phone.CustomButton.UseSelectable = true;
            this.txt_Phone.CustomButton.Visible = false;
            this.txt_Phone.Lines = new string[0];
            this.txt_Phone.Location = new System.Drawing.Point(395, 101);
            this.txt_Phone.MaxLength = 32767;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.SelectionLength = 0;
            this.txt_Phone.SelectionStart = 0;
            this.txt_Phone.ShortcutsEnabled = true;
            this.txt_Phone.Size = new System.Drawing.Size(154, 23);
            this.txt_Phone.TabIndex = 1;
            this.txt_Phone.UseSelectable = true;
            this.txt_Phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            // 
            // txt_Address
            // 
            // 
            // 
            // 
            this.txt_Address.CustomButton.Image = null;
            this.txt_Address.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_Address.CustomButton.Name = "";
            this.txt_Address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Address.CustomButton.TabIndex = 1;
            this.txt_Address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Address.CustomButton.UseSelectable = true;
            this.txt_Address.CustomButton.Visible = false;
            this.txt_Address.Lines = new string[0];
            this.txt_Address.Location = new System.Drawing.Point(395, 56);
            this.txt_Address.MaxLength = 32767;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Address.SelectedText = "";
            this.txt_Address.SelectionLength = 0;
            this.txt_Address.SelectionStart = 0;
            this.txt_Address.ShortcutsEnabled = true;
            this.txt_Address.Size = new System.Drawing.Size(154, 23);
            this.txt_Address.TabIndex = 1;
            this.txt_Address.UseSelectable = true;
            this.txt_Address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_TenNCC
            // 
            // 
            // 
            // 
            this.txt_TenNCC.CustomButton.Image = null;
            this.txt_TenNCC.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_TenNCC.CustomButton.Name = "";
            this.txt_TenNCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_TenNCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TenNCC.CustomButton.TabIndex = 1;
            this.txt_TenNCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TenNCC.CustomButton.UseSelectable = true;
            this.txt_TenNCC.CustomButton.Visible = false;
            this.txt_TenNCC.Lines = new string[0];
            this.txt_TenNCC.Location = new System.Drawing.Point(122, 104);
            this.txt_TenNCC.MaxLength = 32767;
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.PasswordChar = '\0';
            this.txt_TenNCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TenNCC.SelectedText = "";
            this.txt_TenNCC.SelectionLength = 0;
            this.txt_TenNCC.SelectionStart = 0;
            this.txt_TenNCC.ShortcutsEnabled = true;
            this.txt_TenNCC.Size = new System.Drawing.Size(154, 23);
            this.txt_TenNCC.TabIndex = 1;
            this.txt_TenNCC.UseSelectable = true;
            this.txt_TenNCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TenNCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(315, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại";
            // 
            // txt_SearchNCC
            // 
            // 
            // 
            // 
            this.txt_SearchNCC.CustomButton.Image = null;
            this.txt_SearchNCC.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txt_SearchNCC.CustomButton.Name = "";
            this.txt_SearchNCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_SearchNCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_SearchNCC.CustomButton.TabIndex = 1;
            this.txt_SearchNCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_SearchNCC.CustomButton.UseSelectable = true;
            this.txt_SearchNCC.CustomButton.Visible = false;
            this.txt_SearchNCC.Lines = new string[0];
            this.txt_SearchNCC.Location = new System.Drawing.Point(715, 54);
            this.txt_SearchNCC.MaxLength = 32767;
            this.txt_SearchNCC.Name = "txt_SearchNCC";
            this.txt_SearchNCC.PasswordChar = '\0';
            this.txt_SearchNCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_SearchNCC.SelectedText = "";
            this.txt_SearchNCC.SelectionLength = 0;
            this.txt_SearchNCC.SelectionStart = 0;
            this.txt_SearchNCC.ShortcutsEnabled = true;
            this.txt_SearchNCC.Size = new System.Drawing.Size(235, 23);
            this.txt_SearchNCC.TabIndex = 1;
            this.txt_SearchNCC.UseSelectable = true;
            this.txt_SearchNCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_SearchNCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_SearchNCC.TextChanged += new System.EventHandler(this.txt_SearchNCC_TextChanged);
            // 
            // txt_MaNCC
            // 
            // 
            // 
            // 
            this.txt_MaNCC.CustomButton.Image = null;
            this.txt_MaNCC.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_MaNCC.CustomButton.Name = "";
            this.txt_MaNCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_MaNCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MaNCC.CustomButton.TabIndex = 1;
            this.txt_MaNCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MaNCC.CustomButton.UseSelectable = true;
            this.txt_MaNCC.CustomButton.Visible = false;
            this.txt_MaNCC.Lines = new string[0];
            this.txt_MaNCC.Location = new System.Drawing.Point(122, 59);
            this.txt_MaNCC.MaxLength = 32767;
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.PasswordChar = '\0';
            this.txt_MaNCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaNCC.SelectedText = "";
            this.txt_MaNCC.SelectionLength = 0;
            this.txt_MaNCC.SelectionStart = 0;
            this.txt_MaNCC.ShortcutsEnabled = true;
            this.txt_MaNCC.Size = new System.Drawing.Size(154, 23);
            this.txt_MaNCC.TabIndex = 1;
            this.txt_MaNCC.UseSelectable = true;
            this.txt_MaNCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MaNCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(315, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(635, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // data_NCC
            // 
            this.data_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_NCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_NCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.data_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_NCC.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_NCC.Location = new System.Drawing.Point(27, 225);
            this.data_NCC.Name = "data_NCC";
            this.data_NCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_NCC.Size = new System.Drawing.Size(1163, 371);
            this.data_NCC.TabIndex = 2;
            this.data_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_NCC_CellClick);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_NCC);
            this.Controls.Add(this.groupControl1);
            this.Name = "NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_NCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private MetroFramework.Controls.MetroTextBox txt_TenNCC;
        private MetroFramework.Controls.MetroTextBox txt_MaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_Phone;
        private MetroFramework.Controls.MetroTextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_ThemNCC;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteNCC;
        private DevExpress.XtraEditors.SimpleButton btn_EditNCC;
        private System.Windows.Forms.DataGridView data_NCC;
        private MetroFramework.Controls.MetroTextBox txt_SearchNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_SearchMa;
        private System.Windows.Forms.RadioButton rad_SearchName;
    }
}