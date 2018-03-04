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
    class Hoadonmodel
    {
       private DataTable dt = new DataTable("HOADON");
       private SqlDataAdapter da = new SqlDataAdapter();
       Ketnoi kn = new Ketnoi();
       public DataTable getdatahoadon()
       {
          kn.connect();
          SqlDataAdapter hd = new SqlDataAdapter("SELECT *FROM HOADON ", kn.con);
           DataTable dt = new DataTable();
           hd.Fill(dt);
           return dt;
           kn.disconnect();
       }
       public DataTable timhdbymahd(string mahd)
       {
           kn.connect();
           SqlDataAdapter hd = new SqlDataAdapter("TIMHOADONBYMAHD", kn.con);
           hd.SelectCommand.CommandType = CommandType.StoredProcedure;
           hd.SelectCommand.Parameters.Add(new SqlParameter("@MAHD",mahd));
           DataTable dt = new DataTable();
           hd.Fill(dt);
           return dt;
           kn.disconnect();
       }
       public DataTable timhdbymakh(string makh)
       {

           kn.connect();
           SqlDataAdapter hd = new SqlDataAdapter("TIMHOADONBYMAKH", kn.con);
           hd.SelectCommand.CommandType = CommandType.StoredProcedure;
           hd.SelectCommand.Parameters.Add(new SqlParameter("@MAKH",makh));
           DataTable dt = new DataTable();
           hd.Fill(dt);
           return dt;
           kn.disconnect();
       }
       public DataTable timhdbymanv(string manv)
       {

           kn.connect();
           SqlDataAdapter hd = new SqlDataAdapter("TIMHOADONBYMANV", kn.con);
           hd.SelectCommand.CommandType = CommandType.StoredProcedure;
           hd.SelectCommand.Parameters.Add(new SqlParameter("@MANV",manv));
           DataTable dt = new DataTable();
           hd.Fill(dt);
           return dt;
           kn.disconnect();
       }
       public DataTable timhdbyngaylap(DateTime ngaylap)
       {

           kn.connect();
           SqlDataAdapter hd = new SqlDataAdapter("TIMHOADONBYNGAYLAP", kn.con);
           hd.SelectCommand.CommandType = CommandType.StoredProcedure;
           hd.SelectCommand.Parameters.Add(new SqlParameter("@NGAYLAP",ngaylap));
           DataTable dt = new DataTable();
           hd.Fill(dt);
           return dt;
           kn.disconnect();
       }
       public void addhoadon(Hoadonobject hoadon)
       {
           kn.connect();
           SqlCommand cmd = new SqlCommand("ADDHOADON", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter hd = new SqlParameter("@MAHD", hoadon.Mahd);
            cmd.Parameters.Add(hd);
            hd = new SqlParameter("@MAKH", hoadon.Makh);
            cmd.Parameters.Add(hd);
            hd = new SqlParameter("@NGAYLAP", hoadon.Ngaylap);
            cmd.Parameters.Add(hd);
            hd = new SqlParameter("@MANV", hoadon.Manv);
            cmd.Parameters.Add(hd);
            hd = new SqlParameter("@GHICHU", hoadon.Ghichu);
            cmd.Parameters.Add(hd);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else MessageBox.Show("Không thể thêm mới@@@");
            kn.disconnect();
       }
       public void updatehoadon(Hoadonobject hoadon)
       {
           kn.connect();
           SqlCommand cmd = new SqlCommand("UPDATEHOADON", kn.con);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlParameter hd = new SqlParameter("@MAHD", hoadon.Mahd);
           cmd.Parameters.Add(hd);
           hd = new SqlParameter("@MAKH", hoadon.Makh);
           cmd.Parameters.Add(hd);
           hd = new SqlParameter("@NGAYLAP", hoadon.Ngaylap);
           cmd.Parameters.Add(hd);
           hd = new SqlParameter("@MANV", hoadon.Manv);
           cmd.Parameters.Add(hd);
           hd = new SqlParameter("@GHICHU", hoadon.Ghichu);
           cmd.Parameters.Add(hd);
           int count = cmd.ExecuteNonQuery();
           if (count > 0)
           {
               MessageBox.Show("Sửa thành công");
           }
           else MessageBox.Show("Không thể sửa@@@");
           kn.disconnect();
       }
       public void deletehoadon(Hoadonobject hoadon)
       {
           kn.connect();
           SqlCommand cmd = new SqlCommand("DELETEHOADON", kn.con);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlParameter hd = new SqlParameter("@MAHD", hoadon.Mahd);
           cmd.Parameters.Add(hd);
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
