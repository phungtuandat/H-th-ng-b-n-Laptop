
namespace QuanLy_ChLaptop
{
    partial class TTBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTBH));
            this.data_TTBH = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_DeleteTTBH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_EditTTBH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemTTBH = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Phone = new MetroFramework.Controls.MetroTextBox();
            this.txt_Address = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenTTBH = new MetroFramework.Controls.MetroTextBox();
            this.txt_MaTTBH = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_TTBH
            // 
            this.data_TTBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TTBH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_TTBH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.data_TTBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTBH.Location = new System.Drawing.Point(20, 224);
            this.data_TTBH.Name = "data_TTBH";
            this.data_TTBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_TTBH.Size = new System.Drawing.Size(1163, 371);
            this.data_TTBH.TabIndex = 4;
            this.data_TTBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTBH_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_DeleteTTBH);
            this.groupControl1.Controls.Add(this.btn_EditTTBH);
            this.groupControl1.Controls.Add(this.btn_ThemTTBH);
            this.groupControl1.Controls.Add(this.txt_Phone);
            this.groupControl1.Controls.Add(this.txt_Address);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_TenTTBH);
            this.groupControl1.Controls.Add(this.txt_MaTTBH);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(96, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 219);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "TRUNG TÂM BẢO HÀNH";
            // 
            // btn_DeleteTTBH
            // 
            this.btn_DeleteTTBH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteTTBH.Appearance.Options.UseFont = true;
            this.btn_DeleteTTBH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteTTBH.ImageOptions.Image")));
            this.btn_DeleteTTBH.Location = new System.Drawing.Point(586, 158);
            this.btn_DeleteTTBH.Name = "btn_DeleteTTBH";
            this.btn_DeleteTTBH.Size = new System.Drawing.Size(91, 30);
            this.btn_DeleteTTBH.TabIndex = 2;
            this.btn_DeleteTTBH.Text = "Xóa bỏ";
            this.btn_DeleteTTBH.Click += new System.EventHandler(this.btn_DeleteTTBH_Click);
            // 
            // btn_EditTTBH
            // 
            this.btn_EditTTBH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditTTBH.Appearance.Options.UseFont = true;
            this.btn_EditTTBH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditTTBH.ImageOptions.Image")));
            this.btn_EditTTBH.Location = new System.Drawing.Point(429, 158);
            this.btn_EditTTBH.Name = "btn_EditTTBH";
            this.btn_EditTTBH.Size = new System.Drawing.Size(98, 30);
            this.btn_EditTTBH.TabIndex = 2;
            this.btn_EditTTBH.Text = "Cập nhật";
            this.btn_EditTTBH.ToolTip = "Sửa nhà cung cấp\r\n";
            this.btn_EditTTBH.Click += new System.EventHandler(this.btn_EditTTBH_Click);
            // 
            // btn_ThemTTBH
            // 
            this.btn_ThemTTBH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemTTBH.Appearance.Options.UseFont = true;
            this.btn_ThemTTBH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemTTBH.ImageOptions.Image")));
            this.btn_ThemTTBH.Location = new System.Drawing.Point(265, 158);
            this.btn_ThemTTBH.Name = "btn_ThemTTBH";
            this.btn_ThemTTBH.Size = new System.Drawing.Size(105, 30);
            this.btn_ThemTTBH.TabIndex = 2;
            this.btn_ThemTTBH.Text = "Thêm mới\r\n";
            this.btn_ThemTTBH.Click += new System.EventHandler(this.btn_ThemTTBH_Click);
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
            this.txt_Phone.Location = new System.Drawing.Point(551, 105);
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
            this.txt_Address.Location = new System.Drawing.Point(551, 60);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(471, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại";
            // 
            // txt_TenTTBH
            // 
            // 
            // 
            // 
            this.txt_TenTTBH.CustomButton.Image = null;
            this.txt_TenTTBH.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_TenTTBH.CustomButton.Name = "";
            this.txt_TenTTBH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_TenTTBH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TenTTBH.CustomButton.TabIndex = 1;
            this.txt_TenTTBH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TenTTBH.CustomButton.UseSelectable = true;
            this.txt_TenTTBH.CustomButton.Visible = false;
            this.txt_TenTTBH.Lines = new string[0];
            this.txt_TenTTBH.Location = new System.Drawing.Point(274, 106);
            this.txt_TenTTBH.MaxLength = 32767;
            this.txt_TenTTBH.Name = "txt_TenTTBH";
            this.txt_TenTTBH.PasswordChar = '\0';
            this.txt_TenTTBH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TenTTBH.SelectedText = "";
            this.txt_TenTTBH.SelectionLength = 0;
            this.txt_TenTTBH.SelectionStart = 0;
            this.txt_TenTTBH.ShortcutsEnabled = true;
            this.txt_TenTTBH.Size = new System.Drawing.Size(154, 23);
            this.txt_TenTTBH.TabIndex = 1;
            this.txt_TenTTBH.UseSelectable = true;
            this.txt_TenTTBH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TenTTBH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_MaTTBH
            // 
            // 
            // 
            // 
            this.txt_MaTTBH.CustomButton.Image = null;
            this.txt_MaTTBH.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_MaTTBH.CustomButton.Name = "";
            this.txt_MaTTBH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_MaTTBH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MaTTBH.CustomButton.TabIndex = 1;
            this.txt_MaTTBH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MaTTBH.CustomButton.UseSelectable = true;
            this.txt_MaTTBH.CustomButton.Visible = false;
            this.txt_MaTTBH.Lines = new string[0];
            this.txt_MaTTBH.Location = new System.Drawing.Point(274, 60);
            this.txt_MaTTBH.MaxLength = 32767;
            this.txt_MaTTBH.Name = "txt_MaTTBH";
            this.txt_MaTTBH.PasswordChar = '\0';
            this.txt_MaTTBH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MaTTBH.SelectedText = "";
            this.txt_MaTTBH.SelectionLength = 0;
            this.txt_MaTTBH.SelectionStart = 0;
            this.txt_MaTTBH.ShortcutsEnabled = true;
            this.txt_MaTTBH.Size = new System.Drawing.Size(154, 23);
            this.txt_MaTTBH.TabIndex = 1;
            this.txt_MaTTBH.UseSelectable = true;
            this.txt_MaTTBH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MaTTBH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(194, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên TTBH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(471, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(194, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã TTBH";
            // 
            // TTBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_TTBH);
            this.Controls.Add(this.groupControl1);
            this.Name = "TTBH";
            this.Text = "TTBH";
            ((System.ComponentModel.ISupportInitialize)(this.data_TTBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTBH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteTTBH;
        private DevExpress.XtraEditors.SimpleButton btn_EditTTBH;
        private DevExpress.XtraEditors.SimpleButton btn_ThemTTBH;
        private MetroFramework.Controls.MetroTextBox txt_Phone;
        private MetroFramework.Controls.MetroTextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txt_MaTTBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_TenTTBH;
        private System.Windows.Forms.Label label2;
    }
}