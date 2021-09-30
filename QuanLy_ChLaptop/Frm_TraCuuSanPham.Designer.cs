
namespace QuanLy_ChLaptop
{
    partial class Frm_TraCuuSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TraCuuSanPham));
            this.gr_TraCuu = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new XanderUI.XUIButton();
            this.btn_Search = new XanderUI.XUISuperButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_512HHD = new System.Windows.Forms.CheckBox();
            this.check_32GB = new System.Windows.Forms.CheckBox();
            this.check_512SSD = new System.Windows.Forms.CheckBox();
            this.check_256HHD = new System.Windows.Forms.CheckBox();
            this.check_8GB = new System.Windows.Forms.CheckBox();
            this.check_16GB = new System.Windows.Forms.CheckBox();
            this.check_256GBSSD = new System.Windows.Forms.CheckBox();
            this.check_4GB = new System.Windows.Forms.CheckBox();
            this.img_Product = new System.Windows.Forms.PictureBox();
            this.rad_Hon15 = new System.Windows.Forms.RadioButton();
            this.rad_7den15 = new System.Windows.Forms.RadioButton();
            this.rad_Tu5den7 = new System.Windows.Forms.RadioButton();
            this.rad_Tu2Den5Trieu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.data_TraCuu = new System.Windows.Forms.DataGridView();
            this.gr_TraCuu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_TraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_TraCuu
            // 
            this.gr_TraCuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gr_TraCuu.BackgroundImage")));
            this.gr_TraCuu.Controls.Add(this.btn_Reset);
            this.gr_TraCuu.Controls.Add(this.btn_Search);
            this.gr_TraCuu.Controls.Add(this.groupBox2);
            this.gr_TraCuu.Controls.Add(this.img_Product);
            this.gr_TraCuu.Controls.Add(this.rad_Hon15);
            this.gr_TraCuu.Controls.Add(this.rad_7den15);
            this.gr_TraCuu.Controls.Add(this.rad_Tu5den7);
            this.gr_TraCuu.Controls.Add(this.rad_Tu2Den5Trieu);
            this.gr_TraCuu.Controls.Add(this.label1);
            this.gr_TraCuu.Controls.Add(this.data_TraCuu);
            this.gr_TraCuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr_TraCuu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gr_TraCuu.Location = new System.Drawing.Point(11, 1);
            this.gr_TraCuu.Name = "gr_TraCuu";
            this.gr_TraCuu.Size = new System.Drawing.Size(1196, 596);
            this.gr_TraCuu.TabIndex = 0;
            this.gr_TraCuu.TabStop = false;
            this.gr_TraCuu.Text = "Tra cứu sản phẩm";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Reset.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Reset.ButtonImage")));
            this.btn_Reset.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Reset.ButtonText = "Reset";
            this.btn_Reset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_Reset.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Reset.CornerRadius = 5;
            this.btn_Reset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Reset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_Reset.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Reset.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Reset.Location = new System.Drawing.Point(1024, 212);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(127, 36);
            this.btn_Reset.TabIndex = 28;
            this.btn_Reset.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Reset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btn_Search.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.ButtonImage")));
            this.btn_Search.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_Search.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_Search.ButtonText = "Tìm kiếm";
            this.btn_Search.CornerRadius = 5;
            this.btn_Search.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Search.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btn_Search.HoverTextColor = System.Drawing.Color.White;
            this.btn_Search.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_Search.Location = new System.Drawing.Point(856, 214);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btn_Search.SelectedTextColor = System.Drawing.Color.White;
            this.btn_Search.Size = new System.Drawing.Size(149, 35);
            this.btn_Search.SuperSelected = false;
            this.btn_Search.TabIndex = 27;
            this.btn_Search.TextColor = System.Drawing.Color.White;
            this.btn_Search.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.check_512HHD);
            this.groupBox2.Controls.Add(this.check_32GB);
            this.groupBox2.Controls.Add(this.check_512SSD);
            this.groupBox2.Controls.Add(this.check_256HHD);
            this.groupBox2.Controls.Add(this.check_8GB);
            this.groupBox2.Controls.Add(this.check_16GB);
            this.groupBox2.Controls.Add(this.check_256GBSSD);
            this.groupBox2.Controls.Add(this.check_4GB);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(742, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 192);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn cấu hình";
            // 
            // check_512HHD
            // 
            this.check_512HHD.AutoSize = true;
            this.check_512HHD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_512HHD.Location = new System.Drawing.Point(243, 161);
            this.check_512HHD.Name = "check_512HHD";
            this.check_512HHD.Size = new System.Drawing.Size(178, 30);
            this.check_512HHD.TabIndex = 7;
            this.check_512HHD.Text = "512GB (HHD)";
            this.check_512HHD.UseVisualStyleBackColor = true;
            // 
            // check_32GB
            // 
            this.check_32GB.AutoSize = true;
            this.check_32GB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_32GB.Location = new System.Drawing.Point(109, 161);
            this.check_32GB.Name = "check_32GB";
            this.check_32GB.Size = new System.Drawing.Size(89, 30);
            this.check_32GB.TabIndex = 8;
            this.check_32GB.Text = "32GB";
            this.check_32GB.UseVisualStyleBackColor = true;
            // 
            // check_512SSD
            // 
            this.check_512SSD.AutoSize = true;
            this.check_512SSD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_512SSD.Location = new System.Drawing.Point(243, 62);
            this.check_512SSD.Name = "check_512SSD";
            this.check_512SSD.Size = new System.Drawing.Size(167, 30);
            this.check_512SSD.TabIndex = 9;
            this.check_512SSD.Text = "512GD (SSD)";
            this.check_512SSD.UseVisualStyleBackColor = true;
            // 
            // check_256HHD
            // 
            this.check_256HHD.AutoSize = true;
            this.check_256HHD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_256HHD.Location = new System.Drawing.Point(243, 112);
            this.check_256HHD.Name = "check_256HHD";
            this.check_256HHD.Size = new System.Drawing.Size(178, 30);
            this.check_256HHD.TabIndex = 10;
            this.check_256HHD.Text = "256GB (HHD)";
            this.check_256HHD.UseVisualStyleBackColor = true;
            // 
            // check_8GB
            // 
            this.check_8GB.AutoSize = true;
            this.check_8GB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_8GB.Location = new System.Drawing.Point(109, 62);
            this.check_8GB.Name = "check_8GB";
            this.check_8GB.Size = new System.Drawing.Size(77, 30);
            this.check_8GB.TabIndex = 11;
            this.check_8GB.Text = "8GB";
            this.check_8GB.UseVisualStyleBackColor = true;
            // 
            // check_16GB
            // 
            this.check_16GB.AutoSize = true;
            this.check_16GB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_16GB.Location = new System.Drawing.Point(109, 112);
            this.check_16GB.Name = "check_16GB";
            this.check_16GB.Size = new System.Drawing.Size(89, 30);
            this.check_16GB.TabIndex = 12;
            this.check_16GB.Text = "16GB";
            this.check_16GB.UseVisualStyleBackColor = true;
            // 
            // check_256GBSSD
            // 
            this.check_256GBSSD.AutoSize = true;
            this.check_256GBSSD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_256GBSSD.Location = new System.Drawing.Point(243, 15);
            this.check_256GBSSD.Name = "check_256GBSSD";
            this.check_256GBSSD.Size = new System.Drawing.Size(166, 30);
            this.check_256GBSSD.TabIndex = 13;
            this.check_256GBSSD.Text = "256GB (SSD)";
            this.check_256GBSSD.UseVisualStyleBackColor = true;
            // 
            // check_4GB
            // 
            this.check_4GB.AutoSize = true;
            this.check_4GB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_4GB.Location = new System.Drawing.Point(109, 15);
            this.check_4GB.Name = "check_4GB";
            this.check_4GB.Size = new System.Drawing.Size(77, 30);
            this.check_4GB.TabIndex = 14;
            this.check_4GB.Text = "4GB";
            this.check_4GB.UseVisualStyleBackColor = true;
            // 
            // img_Product
            // 
            this.img_Product.BackColor = System.Drawing.SystemColors.Window;
            this.img_Product.Location = new System.Drawing.Point(483, 19);
            this.img_Product.Name = "img_Product";
            this.img_Product.Size = new System.Drawing.Size(226, 226);
            this.img_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Product.TabIndex = 25;
            this.img_Product.TabStop = false;
            // 
            // rad_Hon15
            // 
            this.rad_Hon15.AutoSize = true;
            this.rad_Hon15.BackColor = System.Drawing.Color.Transparent;
            this.rad_Hon15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_Hon15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rad_Hon15.Location = new System.Drawing.Point(134, 187);
            this.rad_Hon15.Name = "rad_Hon15";
            this.rad_Hon15.Size = new System.Drawing.Size(198, 31);
            this.rad_Hon15.TabIndex = 21;
            this.rad_Hon15.TabStop = true;
            this.rad_Hon15.Text = "Hơn 15.000.000đ";
            this.rad_Hon15.UseVisualStyleBackColor = false;
            this.rad_Hon15.Click += new System.EventHandler(this.rad_Hon15_Click);
            // 
            // rad_7den15
            // 
            this.rad_7den15.AutoSize = true;
            this.rad_7den15.BackColor = System.Drawing.Color.Transparent;
            this.rad_7den15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_7den15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rad_7den15.Location = new System.Drawing.Point(134, 136);
            this.rad_7den15.Name = "rad_7den15";
            this.rad_7den15.Size = new System.Drawing.Size(326, 31);
            this.rad_7den15.TabIndex = 22;
            this.rad_7den15.TabStop = true;
            this.rad_7den15.Text = "Từ 7.000.000 đến 15.000.000đ";
            this.rad_7den15.UseVisualStyleBackColor = false;
            this.rad_7den15.Click += new System.EventHandler(this.rad_7den15_Click);
            // 
            // rad_Tu5den7
            // 
            this.rad_Tu5den7.AutoSize = true;
            this.rad_Tu5den7.BackColor = System.Drawing.Color.Transparent;
            this.rad_Tu5den7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_Tu5den7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rad_Tu5den7.Location = new System.Drawing.Point(134, 80);
            this.rad_Tu5den7.Name = "rad_Tu5den7";
            this.rad_Tu5den7.Size = new System.Drawing.Size(314, 31);
            this.rad_Tu5den7.TabIndex = 23;
            this.rad_Tu5den7.TabStop = true;
            this.rad_Tu5den7.Text = "Từ 5.000.000 đến 7.000.000đ";
            this.rad_Tu5den7.UseVisualStyleBackColor = false;
            this.rad_Tu5den7.Click += new System.EventHandler(this.rad_Tu5den7_Click);
            // 
            // rad_Tu2Den5Trieu
            // 
            this.rad_Tu2Den5Trieu.AutoSize = true;
            this.rad_Tu2Den5Trieu.BackColor = System.Drawing.Color.Transparent;
            this.rad_Tu2Den5Trieu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_Tu2Den5Trieu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rad_Tu2Den5Trieu.Location = new System.Drawing.Point(134, 27);
            this.rad_Tu2Den5Trieu.Name = "rad_Tu2Den5Trieu";
            this.rad_Tu2Den5Trieu.Size = new System.Drawing.Size(314, 31);
            this.rad_Tu2Den5Trieu.TabIndex = 24;
            this.rad_Tu2Den5Trieu.TabStop = true;
            this.rad_Tu2Den5Trieu.Text = "Từ 2.000.000 đến 5.000.000đ";
            this.rad_Tu2Den5Trieu.UseVisualStyleBackColor = false;
            this.rad_Tu2Den5Trieu.Click += new System.EventHandler(this.rad_Tu2Den5Trieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chọn giá";
            // 
            // data_TraCuu
            // 
            this.data_TraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TraCuu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_TraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TraCuu.Location = new System.Drawing.Point(9, 249);
            this.data_TraCuu.Name = "data_TraCuu";
            this.data_TraCuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_TraCuu.Size = new System.Drawing.Size(1178, 343);
            this.data_TraCuu.TabIndex = 19;
            this.data_TraCuu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TraCuu_CellContentClick);
            // 
            // Frm_TraCuuSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.gr_TraCuu);
            this.Name = "Frm_TraCuuSanPham";
            this.Text = "Frm_TraCuuSanPham";
            this.gr_TraCuu.ResumeLayout(false);
            this.gr_TraCuu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_TraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_TraCuu;
        private XanderUI.XUIButton btn_Reset;
        private XanderUI.XUISuperButton btn_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_512HHD;
        private System.Windows.Forms.CheckBox check_32GB;
        private System.Windows.Forms.CheckBox check_512SSD;
        private System.Windows.Forms.CheckBox check_256HHD;
        private System.Windows.Forms.CheckBox check_8GB;
        private System.Windows.Forms.CheckBox check_16GB;
        private System.Windows.Forms.CheckBox check_256GBSSD;
        private System.Windows.Forms.CheckBox check_4GB;
        private System.Windows.Forms.PictureBox img_Product;
        private System.Windows.Forms.RadioButton rad_Hon15;
        private System.Windows.Forms.RadioButton rad_7den15;
        private System.Windows.Forms.RadioButton rad_Tu5den7;
        private System.Windows.Forms.RadioButton rad_Tu2Den5Trieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_TraCuu;
    }
}