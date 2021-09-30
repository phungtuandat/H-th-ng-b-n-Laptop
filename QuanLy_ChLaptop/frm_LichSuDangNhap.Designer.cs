
namespace QuanLy_ChLaptop
{
    partial class frm_LichSuDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LichSuDangNhap));
            this.data_ls = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_ls)).BeginInit();
            this.SuspendLayout();
            // 
            // data_ls
            // 
            this.data_ls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ls.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_ls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_ls.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.data_ls.Location = new System.Drawing.Point(0, 0);
            this.data_ls.Name = "data_ls";
            this.data_ls.Size = new System.Drawing.Size(1202, 599);
            this.data_ls.TabIndex = 0;
            // 
            // frm_LichSuDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 599);
            this.Controls.Add(this.data_ls);
            this.Name = "frm_LichSuDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_LichSuDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.data_ls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_ls;
    }
}