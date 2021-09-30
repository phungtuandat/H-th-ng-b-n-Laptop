
namespace QuanLy_ChLaptop
{
    partial class frm_SaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SaoLuu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NameFile = new MetroFramework.Controls.MetroTextBox();
            this.btn_SaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_NameData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NameSever = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.lapTrinhQuanLyDataSet1 = new QuanLy_ChLaptop.LapTrinhQuanLyDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapTrinhQuanLyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_NameFile);
            this.groupBox1.Controls.Add(this.btn_SaoLuu);
            this.groupBox1.Controls.Add(this.lbl_NameData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_NameSever);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu";
            // 
            // txt_NameFile
            // 
            // 
            // 
            // 
            this.txt_NameFile.CustomButton.Image = null;
            this.txt_NameFile.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_NameFile.CustomButton.Name = "";
            this.txt_NameFile.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_NameFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NameFile.CustomButton.TabIndex = 1;
            this.txt_NameFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NameFile.CustomButton.UseSelectable = true;
            this.txt_NameFile.CustomButton.Visible = false;
            this.txt_NameFile.Lines = new string[0];
            this.txt_NameFile.Location = new System.Drawing.Point(415, 142);
            this.txt_NameFile.MaxLength = 32767;
            this.txt_NameFile.Name = "txt_NameFile";
            this.txt_NameFile.PasswordChar = '\0';
            this.txt_NameFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NameFile.SelectedText = "";
            this.txt_NameFile.SelectionLength = 0;
            this.txt_NameFile.SelectionStart = 0;
            this.txt_NameFile.ShortcutsEnabled = true;
            this.txt_NameFile.Size = new System.Drawing.Size(141, 29);
            this.txt_NameFile.TabIndex = 2;
            this.txt_NameFile.UseSelectable = true;
            this.txt_NameFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NameFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Location = new System.Drawing.Point(316, 195);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(125, 30);
            this.btn_SaoLuu.TabIndex = 1;
            this.btn_SaoLuu.Text = "Sao Lưu";
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // lbl_NameData
            // 
            this.lbl_NameData.AutoSize = true;
            this.lbl_NameData.Location = new System.Drawing.Point(413, 95);
            this.lbl_NameData.Name = "lbl_NameData";
            this.lbl_NameData.Size = new System.Drawing.Size(152, 22);
            this.lbl_NameData.TabIndex = 0;
            this.lbl_NameData.Text = "LapTrinhQuanLy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "DataBase Name";
            // 
            // lbl_NameSever
            // 
            this.lbl_NameSever.AutoSize = true;
            this.lbl_NameSever.Location = new System.Drawing.Point(411, 42);
            this.lbl_NameSever.Name = "lbl_NameSever";
            this.lbl_NameSever.Size = new System.Drawing.Size(145, 22);
            this.lbl_NameSever.TabIndex = 0;
            this.lbl_NameSever.Text = ".\\SQLEXPRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever Name: ";
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // lapTrinhQuanLyDataSet1
            // 
            this.lapTrinhQuanLyDataSet1.DataSetName = "LapTrinhQuanLyDataSet";
            this.lapTrinhQuanLyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_SaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(779, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SaoLuu";
            this.Text = "frm_SaoLuu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapTrinhQuanLyDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private DevExpress.XtraEditors.SimpleButton btn_SaoLuu;
        private System.Windows.Forms.Label lbl_NameData;
        private System.Windows.Forms.Label lbl_NameSever;
        private LapTrinhQuanLyDataSet lapTrinhQuanLyDataSet1;
        private MetroFramework.Controls.MetroTextBox txt_NameFile;
        private System.Windows.Forms.Label label3;
    }
}