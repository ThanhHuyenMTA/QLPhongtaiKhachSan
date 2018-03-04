using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTLon_KSan.Object;
namespace BTLon_KSan.Model
{
    class Nhanvienmodel
    {
        private DataTable nv =new DataTable("NHANVIEN");
        private SqlParameter dt = new SqlParameter();
        Ketnoi kn = new Ketnoi();
        public DataTable getdatanv()
        {
           kn.connect();
            SqlDataAdapter nv = new SqlDataAdapter("SELECT *FROM NHANVIEN", kn.con);
            DataTable dt = new DataTable();
            nv.Fill(dt);
            return dt;
           kn.disconnect();
        }
        public DataTable timnvbymanv(string manv)
        {
           kn.connect();
            SqlDataAdapter nv = new SqlDataAdapter("TIMNVBYMANV",kn.con);
            nv.SelectCommand.CommandType = CommandType.StoredProcedure;
            nv.SelectCommand.Parameters.Add(new SqlParameter("@MANV",manv));
            DataTable dt = new DataTable();
            nv.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public DataTable timnvbytennv(string tennv)
        {
            kn.connect();
            SqlDataAdapter nv = new SqlDataAdapter("TIMNVBYTENNV",kn.con);
            nv.SelectCommand.CommandType = CommandType.StoredProcedure;
            nv.SelectCommand.Parameters.Add(new SqlParameter("@TENNV",tennv));
            DataTable dt = new DataTable();
            nv.Fill(dt);
            return dt;
           kn.disconnect();
        }
        public DataTable timnvbyluong(int luong)
        {
            kn.connect();
            SqlDataAdapter nv = new SqlDataAdapter("TIMNVBYLUONG", kn.con);
            nv.SelectCommand.CommandType = CommandType.StoredProcedure;
            nv.SelectCommand.Parameters.Add(new SqlParameter("@LUONG",luong));
            DataTable dt = new DataTable();
            nv.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public void addNV(Nhanvienobject nhanvien)
        {
           kn.connect();
            SqlCommand cmd = new SqlCommand("ADDNHANVIEN", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter nv = new SqlParameter("@MANV", nhanvien.Manv);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@TENNV", nhanvien.Tennv);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@NS", nhanvien.Ngaysinh);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@GT", nhanvien.Gioitinh);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@LUONG", nhanvien.Luong);
            cmd.Parameters.Add(nv);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else MessageBox.Show("Không thể thêm mới@@@");

            kn.disconnect();
        }
        public void updateNV(Nhanvienobject nhanvien)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATENHANVIEN",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter nv = new SqlParameter("@MANV", nhanvien.Manv);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@TENNV", nhanvien.Tennv);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@NS", nhanvien.Ngaysinh);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@GT", nhanvien.Gioitinh);
            cmd.Parameters.Add(nv);
            nv = new SqlParameter("@LUONG", nhanvien.Luong);
            cmd.Parameters.Add(nv);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Không thể sửa@@@");

            kn.disconnect();
        }
        public void deleteNV(Nhanvienobject nhanvien)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETENHANVIEN",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter nv = new SqlParameter("@MANV", nhanvien.Manv);
            cmd.Parameters.Add(nv);
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
