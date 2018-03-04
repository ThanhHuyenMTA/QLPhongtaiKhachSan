using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTLon_KSan.Object;
using System.Windows.Forms;

namespace BTLon_KSan.Model
{
    class Doanmodel
    {
        private DataTable dt = new DataTable("DOAN");
        private SqlDataAdapter da = new SqlDataAdapter();
        Ketnoi kn = new Ketnoi();
        public DataTable getdatadoan()
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM DOAN", kn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            kn.disconnect();
        }

        #region tìm kiếm đoàn
        public DataTable timnhanhdoan(string key)
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("TIMNHANH_DOAN", kn.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@KEY",key));
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            kn.disconnect();
        }
        #endregion

        #region Thêm_sửa_xóa

        public void adddoan(Doanobject doan)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDDOAN", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MADOAN",doan.Madoan);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@TENDOAN",doan.Tendoan);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GHICHU", doan.Ghichu);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else MessageBox.Show("Không thể thêm mới@@@");
            kn.disconnect();
        }
        public void updatedoan(Doanobject doan)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATEDOAN", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MADOAN", doan.Madoan);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@TENDOAN", doan.Tendoan);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GHICHU", doan.Ghichu);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Không thể sửa@@@");
            kn.disconnect();
        }
        public void deletedoan(Doanobject doan)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETEDOAN", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MADOAN", doan.Madoan);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Không thể xóa@@@");
            kn.disconnect();
        }
        #endregion
    }
}
