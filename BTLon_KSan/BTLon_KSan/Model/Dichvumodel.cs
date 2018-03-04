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
    class Dichvumodel
    {
        private DataTable dt = new DataTable("DICHVU");
        private SqlDataAdapter da = new SqlDataAdapter();
        Ketnoi kn = new Ketnoi();
        public DataTable getdatadv()
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DICHVU", kn.con);
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }

        #region Tìm dịch vụ
        public DataTable timdvbytendv(string tendv)
        {
            kn.connect();
            SqlDataAdapter dv = new SqlDataAdapter("TIMDVBYTEN", kn.con);
            dv.SelectCommand.CommandType = CommandType.StoredProcedure;
            dv.SelectCommand.Parameters.Add(new SqlParameter("@TENDV", tendv));
            DataTable dt = new DataTable();
            dv.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timdvbygiadv(int giadv)
        {
            kn.connect();
            SqlDataAdapter dv = new SqlDataAdapter("TIMDVBYGIADV", kn.con);
            dv.SelectCommand.CommandType = CommandType.StoredProcedure;
            dv.SelectCommand.Parameters.Add(new SqlParameter("@GIADV", giadv));
            DataTable dt = new DataTable();
            dv.Fill(dt);
            return dt;
            kn.disconnect();
        }
        #endregion

        public void themdichvu(Dichvuobject dichvu)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDDICHVU", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MADV", dichvu.Madv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@TENDV", dichvu.Tendv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GIADV", dichvu.Giadv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GHICHU", dichvu.Ghichu);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");

            }
            else MessageBox.Show("Không thể thêm mới");
            kn.disconnect();
        }
        public void suadichvu(Dichvuobject dichvu)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATEDV", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MADV", dichvu.Madv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@TENDV", dichvu.Tendv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GIADV", dichvu.Giadv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GHICHU", dichvu.Ghichu);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");

            }
            else MessageBox.Show("Không thể sửa!!!");
            kn.disconnect();
        }
        public void xoadichvu(Dichvuobject dichvu)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETEDV", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MADV", dichvu.Madv);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công");

            }
            else MessageBox.Show("Không thể xóa!!!");
            kn.disconnect();
        }

    }
}