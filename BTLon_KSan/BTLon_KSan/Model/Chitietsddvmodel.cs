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
    class Chitietsddvmodel
    {
        private DataTable dt = new DataTable("CHITIETSDDV");
        private SqlDataAdapter da = new SqlDataAdapter();
        Ketnoi kn = new Ketnoi();
        public DataTable getdatachitietdv()
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETSDDV", kn.con);
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
            kn.disconnect();
        }
        public void themchitietsddv(ChitietsddvObject chitiet)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("ADDChiTietSDDV", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAKH",chitiet.Makh);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MADV",chitiet.Madv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NGAYSD", chitiet.Ngaysd);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SLDV",chitiet.Sldv);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");

            }
            else MessageBox.Show("Không thể thêm mới");
            kn.disconnect();
        }
        public void suachitietsddv(ChitietsddvObject chitiet)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATEchitietSDDV", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAKH", chitiet.Makh);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MADV", chitiet.Madv);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NGAYSD", chitiet.Ngaysd);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SLDV", chitiet.Sldv);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");

            }
            else MessageBox.Show("Không thể sửa!!!");
            kn.disconnect();
        }
        public void xoachitietsddv(ChitietsddvObject chitiet)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETEchitietSDDV", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAKH",chitiet.Makh);
            cmd.Parameters.Add(p);
             p = new SqlParameter("@MADV", chitiet.Madv);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công");

            }
            else MessageBox.Show("Không thể xóa!!!");
            kn.disconnect();
        }

        #region tìm kiếm

        public DataTable timbymakh(string makh)
        {
            kn.connect();
            SqlDataAdapter Tim = new SqlDataAdapter("TIMCTBYMAKH", kn.con);
            Tim.SelectCommand.CommandType = CommandType.StoredProcedure;
            Tim.SelectCommand.Parameters.Add(new SqlParameter("@MAKH",makh));
            DataTable dt = new DataTable();
            Tim.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timbytendv(string tendv)
        {
            kn.connect();
            SqlDataAdapter Tim = new SqlDataAdapter("TIMCTBYTENDV", kn.con);
            Tim.SelectCommand.CommandType = CommandType.StoredProcedure;
            Tim.SelectCommand.Parameters.Add(new SqlParameter("@TENDV", tendv));
            DataTable dt = new DataTable();
            Tim.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timbytenkh(string tenkh)
        {
            kn.connect();
            SqlDataAdapter Tim = new SqlDataAdapter("TIMCTBYTENKH", kn.con);
            Tim.SelectCommand.CommandType = CommandType.StoredProcedure;
            Tim.SelectCommand.Parameters.Add(new SqlParameter("@TENKH",tenkh));
            DataTable dt = new DataTable();
            Tim.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timbysoluongdv(int soluongdv)
        {
            kn.connect();
            SqlDataAdapter Tim = new SqlDataAdapter("TIMCTBYSLDV", kn.con);
            Tim.SelectCommand.CommandType = CommandType.StoredProcedure;
            Tim.SelectCommand.Parameters.Add(new SqlParameter("@SLDV",soluongdv));
            DataTable dt = new DataTable();
            Tim.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public  DataTable timbymadv(string madv)
        {
            kn.connect();
            SqlDataAdapter Tim = new SqlDataAdapter("TIMCTBYMADV", kn.con);
            Tim.SelectCommand.CommandType = CommandType.StoredProcedure;
            Tim.SelectCommand.Parameters.Add(new SqlParameter("@MADV",madv ));
            DataTable dt = new DataTable();
            Tim.Fill(dt);
            return dt;
            kn.disconnect();
        }
        #endregion



    }
}
