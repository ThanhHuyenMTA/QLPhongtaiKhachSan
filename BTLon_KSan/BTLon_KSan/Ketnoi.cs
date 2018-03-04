using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon_KSan
{
    class Ketnoi
    {
        public SqlConnection con;
        public  void connect()
        {
            try
            {
                con = new SqlConnection(@"Data Source=THANH_HUYEN\SQLEXPRESS;Initial Catalog=PHONG_KHACHSAN;Integrated Security=True");
                con.Open();      
            }
            catch
            {
                MessageBox.Show("Khong the ket noi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
        }
        public void disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
    }
}
