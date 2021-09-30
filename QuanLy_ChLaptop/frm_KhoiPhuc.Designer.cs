
namespace QuanLy_ChLaptop
{
    partial class frm_KhoiPhuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KhoiPhuc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NameData = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NameSever = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Retores = new DevExpress.XtraEditors.SimpleButton();
            this.openFile = new DevExpress.XtraEditors.SimpleButton();
            this.txt_NameFile = new MetroFramework.Controls.MetroTextBox();
            this.open_Backup = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_NameData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_NameSever);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.btn_Retores);
            this.groupBox1.Controls.Add(this.openFile);
            this.groupBox1.Controls.Add(this.txt_NameFile);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KHÔI PHỤC ";
            // 
            // txt_NameData
            // 
            // 
            // 
            // 
            this.txt_NameData.CustomButton.Image = null;
            this.txt_NameData.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txt_NameData.CustomButton.Name = "";
            this.txt_NameData.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_NameData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NameData.CustomButton.TabIndex = 1;
            this.txt_NameData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NameData.CustomButton.UseSelectable = true;
            this.txt_NameData.CustomButton.Visible = false;
            this.txt_NameData.Lines = new string[] {
        "LapTrinhQuanLy"};
            this.txt_NameData.Location = new System.Drawing.Point(373, 206);
            this.txt_NameData.MaxLength = 32767;
            this.txt_NameData.Name = "txt_NameData";
            this.txt_NameData.PasswordChar = '\0';
            this.txt_NameData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NameData.SelectedText = "";
            this.txt_NameData.SelectionLength = 0;
            this.txt_NameData.SelectionStart = 0;
            this.txt_NameData.ShortcutsEnabled = true;
            this.txt_NameData.Size = new System.Drawing.Size(188, 29);
            this.txt_NameData.TabIndex = 6;
            this.txt_NameData.Text = "LapTrinhQuanLy";
            this.txt_NameData.UseSelectable = true;
            this.txt_NameData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NameData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_NameData.Click += new System.EventHandler(this.txt_NameData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataBase Name";
            // 
            // lbl_NameSever
            // 
            this.lbl_NameSever.AutoSize = true;
            this.lbl_NameSever.Location = new System.Drawing.Point(369, 153);
            this.lbl_NameSever.Name = "lbl_NameSever";
            this.lbl_NameSever.Size = new System.Drawing.Size(145, 22);
            this.lbl_NameSever.TabIndex = 4;
            this.lbl_NameSever.Text = ".\\SQLEXPRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sever Name: ";
            // 
            // btn_Reset
            // 
            this.btn_Reset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reset.ImageOptions.SvgImage")));
            this.btn_Reset.Location = new System.Drawing.Point(373, 262);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(150, 29);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Làm mới đường dẩn";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Retores
            // 
            this.btn_Retores.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Retores.ImageOptions.SvgImage")));
            this.btn_Retores.Location = new System.Drawing.Point(202, 262);
            this.btn_Retores.Name = "btn_Retores";
            this.btn_Retores.Size = new System.Drawing.Size(115, 29);
            this.btn_Retores.TabIndex = 1;
            this.btn_Retores.Text = "Khôi Phục";
            this.btn_Retores.Click += new System.EventHandler(this.btn_Retores_Click);
            // 
            // openFile
            // 
            this.openFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("openFile.ImageOptions.SvgImage")));
            this.openFile.Location = new System.Drawing.Point(567, 92);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(85, 29);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Mở file";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // txt_NameFile
            // 
            // 
            // 
            // 
            this.txt_NameFile.CustomButton.Image = null;
            this.txt_NameFile.CustomButton.Location = new System.Drawing.Point(337, 1);
            this.txt_NameFile.CustomButton.Name = "";
            this.txt_NameFile.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_NameFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NameFile.CustomButton.TabIndex = 1;
            this.txt_NameFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NameFile.CustomButton.UseSelectable = true;
            this.txt_NameFile.CustomButton.Visible = false;
            this.txt_NameFile.Lines = new string[0];
            this.txt_NameFile.Location = new System.Drawing.Point(196, 92);
            this.txt_NameFile.MaxLength = 32767;
            this.txt_NameFile.Name = "txt_NameFile";
            this.txt_NameFile.PasswordChar = '\0';
            this.txt_NameFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NameFile.SelectedText = "";
            this.txt_NameFile.SelectionLength = 0;
            this.txt_NameFile.SelectionStart = 0;
            this.txt_NameFile.ShortcutsEnabled = true;
            this.txt_NameFile.Size = new System.Drawing.Size(365, 29);
            this.txt_NameFile.TabIndex = 0;
            this.txt_NameFile.UseSelectable = true;
            this.txt_NameFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NameFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // open_Backup
            // 
            this.open_Backup.FileName = "openFileDialog1";
            // 
            // frm_KhoiPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_KhoiPhuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_KhoiPhuc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_NameFile;
        private DevExpress.XtraEditors.SimpleButton openFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NameSever;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Retores;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private System.Windows.Forms.OpenFileDialog open_Backup;
        private MetroFramework.Controls.MetroTextBox txt_NameData;
    }
}