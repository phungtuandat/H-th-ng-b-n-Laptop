using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace QuanLy_ChLaptop
{
    public partial class frm_SaoLuu : Form
    {
        public frm_SaoLuu()
        {
            InitializeComponent();
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            string t = DateTime.Now.ToString();
            string duongdan = "Data Source= " + lbl_NameSever.Text + ";Initial Catalog=" + lbl_NameData.Text + ";Integrated Security=True";
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
            SqlConnection coon = new SqlConnection(duongdan);
            string path_full = path + "\\SaoLuu\\";
            string Fullpath = path + "\\SaoLuu\\" + txt_NameFile.Text + "_" + t + ".bak'";


            if (File.Exists(Fullpath) == true)
            {
                MessageBox.Show("File đã tồn tại");
                return;
            }
            else
            {
                coon.Open();

                string use = "USE " + lbl_NameData.Text + ";";
                string backup = "BACKUP DATABASE " + lbl_NameData.Text + " TO DISK = '" + path_full + txt_NameFile.Text +".bak'";
                SqlCommand cmd1 = new SqlCommand(use, coon);
                SqlCommand cmd2 = new SqlCommand(backup, coon);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Sao lưu thành công");
                coon.Close();
                return;
            }
        }
    }
}
