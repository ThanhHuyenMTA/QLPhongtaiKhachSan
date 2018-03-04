using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLon_KSan.Object;

namespace BTLon_KSan.Model
{
    class Khachhangmodel
    {
        private DataTable dt = new DataTable("KHACHHANG");// khởi tạo đối tượng datatable
        private SqlDataAdapter da = new SqlDataAdapter(); // khởi tạo một đối tượng 
        Ketnoi kn = new Ketnoi();
        //hiển thị ra bảng
        public DataTable getdatak()
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", kn.con);
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        #region tìm kiếm

        public DataTable getdatabytendoan(string tendoan)
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("KHACHBYDOAN", kn.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@TENDOAN", tendoan));
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        public DataTable getdatabymadoan(string madoan)
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("KHACHBYMADOAN", kn.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@MADOAN",madoan));
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        public DataTable getdatabymaKH(string makhach)
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("TIMKHACHBYMAKH", kn.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@MAKH", makhach));
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        public DataTable getdatabyCMT(string cmt)
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("TIMKHACHBYCMT", kn.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@CMT", cmt));
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        public DataTable getdatabySDT(string sdt)
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("TIMKHACHBYSDT", kn.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(new SqlParameter("@SDT", sdt));
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        public DataTable TimbytenKH(string tenkh)
        {
            kn.connect();
             DataTable dt = new DataTable();
             SqlCommand cmd = new SqlCommand("TIMKHACHBYTEN", kn.con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add(new SqlParameter("@TENKH", SqlDbType.NVarChar)).Value = tenkh;
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             return dt;
             kn.disconnect();
        }
        public DataTable locnhanhKH(string key)
        {
            kn.connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("LOCNHANH_KH", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@key", SqlDbType.NVarChar)).Value =key;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            kn.disconnect();
        }


        #endregion

        #region Thêm khách hàng
        public void addkhachhang(Khachhangobject khach)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDKHACHHANG", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter kh = new SqlParameter("@MAKH", khach.Makh);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@TENKH", khach.Tenkh);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@CMT", khach.Cmt);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@SDT", khach.Sdt);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@GT", khach.Gt);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@MADOAN", khach.Madoan);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@DIACHI", khach.Diachi);
            cmd.Parameters.Add(kh);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");

            }
            else MessageBox.Show("Không thể thêm mới");
            kn.disconnect();
        }

        #endregion

        #region sửa khách hàng
        public void suakhachhang(Khachhangobject khach)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("SUAKHACH", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter kh = new SqlParameter("@ID",khach.Makh);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@MAKH", khach.Makh);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@TENKH", khach.Tenkh);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@CMT", khach.Cmt);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@SDT", khach.Sdt);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@GT", khach.Gt);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@MADOAN", khach.Madoan);
            cmd.Parameters.Add(kh);
            kh = new SqlParameter("@DIACHI", khach.Diachi);
            cmd.Parameters.Add(kh);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa mới thành công");

            }
            else MessageBox.Show("Không thể sửa");
            kn.disconnect();
        }
        #endregion

        #region xóa khách hàng
        public void xoakhachhang(Khachhangobject khach)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("XOAKHACH", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter kh = new SqlParameter("@ID", khach.Makh);
            cmd.Parameters.Add(kh);
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
