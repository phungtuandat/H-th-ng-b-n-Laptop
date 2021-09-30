
namespace QuanLy_ChLaptop
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.data_KH = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_DeleteKH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_EditKH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemKH = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Phone = new MetroFramework.Controls.MetroTextBox();
            this.txt_Address = new MetroFramework.Controls.MetroTextBox();
            this.txt_TenKH = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaKH = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_KH
            // 
            this.data_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_KH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_KH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.data_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_KH.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_KH.Location = new System.Drawing.Point(20, 225);
            this.data_KH.Name = "data_KH";
            this.data_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_KH.Size = new System.Drawing.Size(1163, 371);
            this.data_KH.TabIndex = 4;
            this.data_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_KH_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_DeleteKH);
            this.groupControl1.Controls.Add(this.btn_EditKH);
            this.groupControl1.Controls.Add(this.btn_ThemKH);
            this.groupControl1.Controls.Add(this.txt_Phone);
            this.groupControl1.Controls.Add(this.txt_Address);
            this.groupControl1.Controls.Add(this.txt_TenKH);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_MaKH);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(107, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 219);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "KHÁCH HÀNG";
            // 
            // btn_DeleteKH
            // 
            this.btn_DeleteKH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteKH.Appearance.Options.UseFont = true;
            this.btn_DeleteKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteKH.ImageOptions.Image")));
            this.btn_DeleteKH.Location = new System.Drawing.Point(630, 155);
            this.btn_DeleteKH.Name = "btn_DeleteKH";
            this.btn_DeleteKH.Size = new System.Drawing.Size(91, 30);
            this.btn_DeleteKH.TabIndex = 2;
            this.btn_DeleteKH.Text = "Xóa bỏ";
            this.btn_DeleteKH.Click += new System.EventHandler(this.btn_DeleteKH_Click);
            // 
            // btn_EditKH
            // 
            this.btn_EditKH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditKH.Appearance.Options.UseFont = true;
            this.btn_EditKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditKH.ImageOptions.Image")));
            this.btn_EditKH.Location = new System.Drawing.Point(473, 155);
            this.btn_EditKH.Name = "btn_EditKH";
            this.btn_EditKH.Size = new System.Drawing.Size(98, 30);
            this.btn_EditKH.TabIndex = 2;
            this.btn_EditKH.Text = "Cập nhật";
            this.btn_EditKH.ToolTip = "Sửa nhà cung cấp\r\n";
            this.btn_EditKH.Click += new System.EventHandler(this.btn_EditKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemKH.Appearance.Options.UseFont = true;
            this.btn_ThemKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemKH.ImageOptions.Image")));
            this.btn_ThemKH.Location = new System.Drawing.Point(309, 155);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(105, 30);
            this.btn_ThemKH.TabIndex = 2;
            this.btn_ThemKH.Text = "Thêm mới\r\n";
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
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
            this.txt_Phone.Location = new System.Drawing.Point(595, 102);
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
            this.txt_Address.Location = new System.Drawing.Point(595, 57);
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
            // txt_TenKH
            // 
            // 
            // 
            // 
            this.txt_TenKH.CustomButton.Image = null;
            this.txt_TenKH.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_TenKH.CustomButton.Name = "";
            this.txt_TenKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_TenKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TenKH.CustomButton.TabIndex = 1;
            this.txt_TenKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TenKH.CustomButton.UseSelectable = true;
            this.txt_TenKH.CustomButton.Visible = false;
            this.txt_TenKH.Lines = new string[0];
            this.txt_TenKH.Location = new System.Drawing.Point(322, 105);
            this.txt_TenKH.MaxLength = 32767;
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.PasswordChar = '\0';
            this.txt_TenKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TenKH.SelectedText = "";
            this.txt_TenKH.SelectionLength = 0;
            this.txt_TenKH.SelectionStart = 0;
            this.txt_TenKH.ShortcutsEnabled = true;
            this.txt_TenKH.Size = new System.Drawing.Size(154, 23);
            this.txt_TenKH.TabIndex = 1;
            this.txt_TenKH.UseSelectable = true;
            this.txt_TenKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TenKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(515, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại";
            // 
            // txt_MaKH
            // 
            // 
            // 
            // 
            this.txt_MaKH.CustomButton.Image = null;
            this.txt_MaKH.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_MaKH.CustomButton.Name = "";
            this.txt_MaKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_MaKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MaKH.CustomButton.TabIndex = 1;
            this.txt_MaKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MaKH.CustomButton.UseSelectable = true;
            this.txt_MaKH.CustomButton.Visible = false;
            this.txt_MaKH.Lines = new string[0];
            this.txt_MaKH.Location = new System.Drawing.Point(322, 60);
            this.txt_MaKH.MaxLength = 32767;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.PasswordChar = '\0';
            this.txt_MaKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaKH.SelectedText = "";
            this.txt_MaKH.SelectionLength = 0;
            this.txt_MaKH.SelectionStart = 0;
            this.txt_MaKH.ShortcutsEnabled = true;
            this.txt_MaKH.Size = new System.Drawing.Size(154, 23);
            this.txt_MaKH.TabIndex = 1;
            this.txt_MaKH.UseSelectable = true;
            this.txt_MaKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MaKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(515, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(242, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(242, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_KH);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.data_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_KH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteKH;
        private DevExpress.XtraEditors.SimpleButton btn_EditKH;
        private DevExpress.XtraEditors.SimpleButton btn_ThemKH;
        private MetroFramework.Controls.MetroTextBox txt_Phone;
        private MetroFramework.Controls.MetroTextBox txt_Address;
        private MetroFramework.Controls.MetroTextBox txt_TenKH;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txt_MaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}