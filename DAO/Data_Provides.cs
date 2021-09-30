using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
   public class Data_Provides
    {
        public static SqlConnection KetNoi()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LapTrinhQuanLy;Integrated Security=True");
            connection.Open();
            return connection;
        }

        /// static : có kiểu trả về
        public static SqlConnection DongKetNoi ()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LapTrinhQuanLy;Integrated Security=True");
            connection.Close();
            return connection;
        }

        public static DataTable Select_Query(string struyvan, SqlConnection sqlConnections)
        {
            SqlDataAdapter run = new SqlDataAdapter(struyvan, sqlConnections);
            DataTable dt = new DataTable();
            run.Fill(dt);
            return dt;
        }

        public static bool TruyXuatThemDuLieu (string truyvan, SqlConnection coon)
        {
            try
            {
                SqlCommand coomand = new SqlCommand(truyvan, coon);
                coomand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
