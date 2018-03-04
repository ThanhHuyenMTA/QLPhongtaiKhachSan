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
    class NgCPmodel
    {
        DataTable dt = new DataTable("NGCUNGPHONG");
        SqlDataAdapter da = new SqlDataAdapter();
        Ketnoi kn = new Ketnoi();
        public DataTable getdataNCP()
        {
           kn.connect();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT *FROM NGCUNGPHONG",kn.con);
            DataTable da = new DataTable();
            dt.Fill(da);
            return da;
            kn.disconnect();
        }
        public DataTable timkiemNCP(string makh)
        {
          kn.connect();
            SqlDataAdapter dt = new SqlDataAdapter("TIMNCPBYMAKH",kn.con);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.Add(new SqlParameter("@MAKH",makh));
            DataTable da = new DataTable();
            dt.Fill(da);
            return da;
            kn.disconnect();
        }
        public void addNCP(NgCPobject nguoi)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDNGCCP",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@TENNCP",nguoi.Tenngcp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@CMT", nguoi.Cmt);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MAKH", nguoi.Makh);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GT", nguoi.Gt);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");

            }
            else MessageBox.Show("Không thể thêm mới");
           kn.disconnect();
        }
        public void updateNCP(NgCPobject nguoi)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATENCP",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@TENNCP", nguoi.Tenngcp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@CMT", nguoi.Cmt);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MAKH", nguoi.Makh);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GT", nguoi.Gt);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");

            }
            else MessageBox.Show("Không thể sửa @@@");
          kn.disconnect();
        }
        public void deleteNCP(NgCPobject nguoi)
        {
           kn.connect();
            SqlCommand cmd = new SqlCommand("DELETENCP",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
           SqlParameter p = new SqlParameter("@CMT", nguoi.Cmt);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công");

            }
            else MessageBox.Show("Không thể Xóa!!!");
          kn.disconnect();
        }
    }
}
