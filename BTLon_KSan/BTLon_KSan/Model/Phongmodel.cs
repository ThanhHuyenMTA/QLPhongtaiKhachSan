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
    class Phongmodel
    {
      // private SqlConnection con;
        private DataTable dt = new DataTable("PHONG");// khởi tạo đối tượng datatable
        private SqlDataAdapter da = new SqlDataAdapter(); // khởi tạo một đối tượng 
        Ketnoi kn = new Ketnoi();
        //Lấy dữ liệu
        //public void connect()
        //{
        //    string cn = @"Data Source=THANH_HUYEN\SQLEXPRESS;Initial Catalog=PHONG_KHACHSAN;Integrated Security=True";
        //    try
        //    {
        //        con = new SqlConnection(cn);
        //        con.Open();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Khong the ket noi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //public void disconnect()
        //{
        //    con.Close();
        //    con.Dispose();
        //    con = null;
        //}
        public DataTable getdatap()
        {
            kn.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONG",kn.con);
            DataTable dtp = new DataTable();
            da.Fill(dtp);
            return dtp;
           kn.disconnect();
        }
        public DataTable timphbymap(string map)
        {
           kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMPHBYMAP",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@MAP",map));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
           kn.disconnect();
        }
        public DataTable timphbyloaip(string loaip)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMPHBYLOAIP",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@LOAIP",loaip));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
           kn.disconnect();
        }
        public DataTable timphbyhangp(string hangp)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMPHBYHANGP",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@HANGP",hangp));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
           kn.disconnect();
        }
        public DataTable timphbyttp(string ttp)
        {
           kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMPHBYTTP",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@TTP", ttp));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
           kn.disconnect();
        }
        public DataTable timphbygiap(int giap)
        {
            kn.connect();
            SqlDataAdapter p = new SqlDataAdapter("TIMPHBYGIAP",kn.con);
            p.SelectCommand.CommandType = CommandType.StoredProcedure;
            p.SelectCommand.Parameters.Add(new SqlParameter("@GIAP",giap));
            DataTable dt = new DataTable();
            p.Fill(dt);
            return dt;
            kn.disconnect();
        }
        public void insertphong(Phongbject phong)
        {
           kn.connect();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("ADDPHONG",kn.con);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo và gán giá trị cho các tham số đầu vào của thủ tục
            // Khai báo tham số thứ nhất @Name - là tên tham số được tạo trong thủ tục
            SqlParameter p = new SqlParameter("@MAP", phong.Map);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@LOAIP", phong.Loaip);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@HANGP",phong.Hangp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GIAP",phong.Giap);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@TTP",phong.Ttp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SDTP",phong.Sdtp);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");

            }
            else MessageBox.Show("Không thể thêm mới");
            kn.disconnect();
        }
        public void suaphong(Phongbject phong)
        {

           kn.connect();
            SqlCommand cmd = new SqlCommand("UPDATEPHONG", kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@ID", phong.Map);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@MAP", phong.Map);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@LOAIP", phong.Loaip);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@HANGP", phong.Hangp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GIAP", phong.Giap);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@TTP", phong.Ttp);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SDTP", phong.Sdtp);
            cmd.Parameters.Add(p);
            int flag = cmd.ExecuteNonQuery();
            if (flag > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
                MessageBox.Show("Không sửa được!!!");
           kn.disconnect();
        }
        public void Xoaphong(Phongbject phong)
        {
            kn.connect();
            SqlCommand cmd = new SqlCommand("DELETEPHONG",kn.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MAP", phong.Map);
            cmd.Parameters.Add(p);
            int flag = cmd.ExecuteNonQuery();
            if (flag > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
                MessageBox.Show("Không xóa được!!!");
            kn.disconnect();
        }   

        
    }
}
