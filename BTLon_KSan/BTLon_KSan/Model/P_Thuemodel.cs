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
    class P_Thuemodel
    {
        private DataTable dt =new DataTable("PHIEUTHUEPHONG");
        private SqlParameter sq =new SqlParameter();
        Ketnoi kn = new Ketnoi();
        public DataTable getdataP_thue()
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("SELECT *FROM PHIEUTHUEPHONG",kn.con);
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timp_thuebymaphieu(string maphieu)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMP_THUEBYMAPHIEU",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@MAPHIEU",maphieu));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timp_thuebymakh(string makh)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMP_THUEBYMAKH",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@MAKH",makh));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timp_thuebyngaylap(DateTime ngaylap)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMP_THUEBYNGAYLAP", kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@NGAYLAP",ngaylap));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public void addP_thue(P_Thueobject phieu)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDPHIEUTHUE",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter P = new SqlParameter("@MAPHIEU", phieu.Maphieu);
            cmd.Parameters.Add(P);
            P = new SqlParameter("@MAKH", phieu.Makh);
            cmd.Parameters.Add(P);
            P = new SqlParameter("@NGAYLAP", phieu.Ngaylap);
            cmd.Parameters.Add(P);
            P = new SqlParameter("@DATCOC", phieu.Datcoc);
            cmd.Parameters.Add(P);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else MessageBox.Show("Không thể thêm mới@@@");
            kn.disconnect();
        }
        public void updateP_thue(P_Thueobject phieu)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATEPHIEUTHUE",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter P = new SqlParameter("@MAPHIEU", phieu.Maphieu);
            cmd.Parameters.Add(P);
            P = new SqlParameter("@MAKH", phieu.Makh);
            cmd.Parameters.Add(P);
            P = new SqlParameter("@NGAYLAP", phieu.Ngaylap);
            cmd.Parameters.Add(P);
            P = new SqlParameter("@DATCOC", phieu.Datcoc);
            cmd.Parameters.Add(P);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("SỬA thành công");
            }
            else MessageBox.Show("Không thể Sửa@@@");
            kn.disconnect();
        }
        public void deleteP_thue(P_Thueobject phieu)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETEPHIEUTHUE",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter P = new SqlParameter("@MAPHIEU", phieu.Maphieu);
            cmd.Parameters.Add(P);
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
