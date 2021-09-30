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

namespace QuanLy_ChLaptop
{
    public partial class frm_KhoiPhuc : Form
    {
        public frm_KhoiPhuc()
        {
            InitializeComponent();
            txt_NameData.Enabled = false;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
            string fullPath = path + "\\SaoLuu\\";
            open_Backup = new OpenFileDialog();
            open_Backup.InitialDirectory = path;
            open_Backup.Title = "Mở file";
            open_Backup.CheckFileExists = true;
            open_Backup.CheckPathExists = true;
            open_Backup.DefaultExt = "Bak";
            open_Backup.Filter = "Text File (*.bak)|*.bak";
            open_Backup.FilterIndex = 2;
            open_Backup.ReadOnlyChecked = true;
            open_Backup.ShowReadOnly = true;
            

            if(open_Backup.ShowDialog()== DialogResult.OK)
            {
                txt_NameFile.Text = open_Backup.FileName;
            }
        }

        private void btn_Retores_Click(object sender, EventArgs e)
        {
            string duongdan = @"Data Source=" + lbl_NameSever.Text + ";Initial Catalog=" + txt_NameData.Text + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(duongdan);
            con.Open();
            string use = "USE master;";
            string query1 = "ALTER DATABASE " + txt_NameData.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            string query_resotre = "RESTORE DATABASE " + txt_NameData.Text + " FROM DISK = '"+txt_NameFile.Text+"' WITH REPLACE";

            SqlCommand command = new SqlCommand(use, con);
            SqlCommand command_1 = new SqlCommand(query1, con);
            SqlCommand command_restore = new SqlCommand(query_resotre, con);

            command.ExecuteNonQuery();
            command_1.ExecuteNonQuery();
            command_restore.ExecuteNonQuery();

            MessageBox.Show("Khôi phục thành công");
            con.Close();

            txt_NameFile.Text = "";
        }

        private void txt_NameData_Click(object sender, EventArgs e)
        {
            txt_NameData.Text = "";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_NameFile.Text = "";
        }
    }
}
