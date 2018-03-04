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
    class Chitietp_Thuemodel
    {
        private DataTable dt = new DataTable("CHITIETPHIEUTHUEPHONG");
        private SqlParameter sq = new SqlParameter();
        Ketnoi kn = new Ketnoi();
      
        public DataTable getdatactThue()
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("SELECT *FROM CHITIETPHIEUTHUEPHONG", kn.con);
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }

        public DataTable getdataloadbymakh(string makh)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("SELECT_CTPTHUEP", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@MAKH", makh));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timctP_thuebymaphieu(string maphieu)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMCTP_THUEBYMAPHIEU", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@MAPHIEU", maphieu));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timctP_thuebymap(string map)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMCTP_THUEBYMAP", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@MAP",map));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timctP_thuebyngaythue(DateTime ngaythue)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMCTP_THUEBYNGAYTHUE", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@NGAYTHUE",ngaythue));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timctP_thuebyngaytradk(DateTime ngaytradk)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMCTP_THUEBYNGAYTRADK", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@NGAYTRADK",ngaytradk));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
       //chú ý
        public DataTable timctP_thue(string b)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMKIEMNHANH", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@KEY",b));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timctP_thuengay(DateTime b)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMKIEMNHANHNGAY", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@KEY", b));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        //
        public void addctp_thue(Chitietp_Thueobject ct)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDCHITIET_PTHUE", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAPHIEU",ct.Maphieu);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MAP", ct.Map);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NGAYTHUE",ct.Ngaythue);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NGAYTRA", ct.Ngaytradk);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GHICHU", ct.Ghichu);
            cmd.Parameters.Add(p);
             int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else MessageBox.Show("Không thể thêm mới@@@");
            kn.disconnect();
        }
        public void updatep_thue(Chitietp_Thueobject ct)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATECHITIET_PTHUE", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAPHIEU", ct.Maphieu);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MAP", ct.Map);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NGAYTHUE", ct.Ngaythue);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NGAYTRADK", ct.Ngaytradk);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GHICHU", ct.Ghichu);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Không thể sửa@@@");
            kn.disconnect();
        }
        public void deletep_thue(Chitietp_Thueobject ct)
        {

            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETECHITIET_PTHUE", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAPHIEU", ct.Maphieu);
            cmd.Parameters.Add(p);
            //p = new SqlParameter("@MAP", ct.Map);
            //cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Không thể xóa@@@");
            kn.disconnect();
        }
    }
}
