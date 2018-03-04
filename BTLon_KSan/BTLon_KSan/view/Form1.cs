using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTLon_KSan.Control;
using BTLon_KSan.Object;

namespace BTLon_KSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridPHONG.DataSource = Phongcontrol.getdatap();
            dataGridView2.DataSource = Khachhangcontrol.getdataK();
            dataGridView3.DataSource = Dichvucontrol.getdatadv();
            datDOAN.DataSource = Doancontrol.getdatadoan();
            dataNCP.DataSource = NgCPcontrol.getdataNCP();
            dataNV.DataSource = Nhanviencontrol.getdatanv();
            datap_thue.DataSource = P_Thuecontrol.getdatap_thue();
            datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdatactThue();
            dathoadon.DataSource = Hoadoncontrol.getdatahd();
        }
        #endregion

        #region chương trình thoát
        //thoát khỏi phòng
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //thoát khỏi khách hàng
        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //thoát khỏi dịch vụ
        private void btnthoatdv_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();

            }
        }
        #endregion

        #region PHÒNG
        //thêm phòng
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                Phongbject pp = new Phongbject();
                pp.Map = txtMAP.Text;
                pp.Loaip = cmbLOAIP.Text;
                pp.Hangp = cmbHANGP.Text;
                pp.Giap = Int32.Parse(txtGIAP.Text);
                pp.Ttp = cmbTTP.Text;
                pp.Sdtp = Int32.Parse(txtSDTP.Text);
                Phongcontrol.addphong(pp);
                dataGridPHONG.DataSource = Phongcontrol.getdatap();
            }
            catch { }
        }
        //sửa phòng
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                Phongbject P = new Phongbject();
                P.Map = txtMAP.Text;
                P.Loaip = cmbLOAIP.Text;
                P.Hangp = cmbHANGP.Text;
                P.Giap = Int32.Parse(txtGIAP.Text);
                P.Ttp = cmbTTP.Text;
                P.Sdtp = Int32.Parse(txtSDTP.Text);
                Phongcontrol.updatephong(P);
                dataGridPHONG.DataSource = Phongcontrol.getdatap();
            }
            catch { }
        }
        //xóa phòng
        private void btnnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Phongbject P = new Phongbject();
                    P.Map = txtMAP.Text;
                    Phongcontrol.deletephong(P);
                    dataGridPHONG.DataSource = Phongcontrol.getdatap();
                }
            }
            catch { }

        }
        #endregion

        #region KHÁCH HÀNG
        //thêm khách hàng
        private void btnthemKH_Click(object sender, EventArgs e)
        {
            try
            {
                Khachhangobject kh = new Khachhangobject();
                kh.Makh = txtMAKH.Text;
                kh.Tenkh = txtTENKH.Text;
                kh.Cmt = txtCMT.Text;
                kh.Sdt = txtSDT.Text;
                if (this.radioGT.Checked == true)
                {
                    kh.Gt = radioGT.Text;
                }
                else kh.Gt = radioButton2.Text;
                kh.Madoan = txtmadoan.Text;
                kh.Diachi = txtdiachi.Text;
                Khachhangcontrol.Addkhachhang(kh);
                dataGridView2.DataSource = Khachhangcontrol.getdataK();
            }
            catch { }
        }

        //sửa khách hàng
        private void btnsuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                Khachhangobject kh = new Khachhangobject();
                kh.Makh = txtMAKH.Text;
                kh.Tenkh = txtTENKH.Text;
                kh.Cmt = txtCMT.Text;
                kh.Sdt = txtSDT.Text;
                if (this.radioGT.Checked == true)
                {
                    kh.Gt = radioGT.Text;
                }
                else kh.Gt = radioButton2.Text;
                kh.Madoan = txtmadoan.Text;
                kh.Diachi = txtdiachi.Text;
                Khachhangcontrol.Updatekhachhang(kh);
                dataGridView2.DataSource = Khachhangcontrol.getdataK();
            }
            catch { }
        }
        //xóa khách hàng
        private void btnxoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Khachhangobject kh = new Khachhangobject();
                    kh.Makh = txtMAKH.Text;
                    Khachhangcontrol.Deletekhachhang(kh);
                    dataGridView2.DataSource = Khachhangcontrol.getdataK();
                }

            }
            catch { }
        }
        #endregion

        #region DICHVU
        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = Dichvucontrol.getdatadv();
        }
        private void btnthemdv_Click(object sender, EventArgs e)
        {
            try
            {
                Dichvuobject dv = new Dichvuobject();
                dv.Madv = txtMADV.Text;
                dv.Tendv = txtTENDV.Text;
                dv.Giadv = Int32.Parse(txtGIADV.Text);
                dv.Ghichu = txtghichudv.Text;
                Dichvucontrol.adddv(dv);
                dataGridView3.DataSource = Dichvucontrol.getdatadv();
            }
            catch { }
        }

        private void btnsuadv_Click(object sender, EventArgs e)
        {
            try
            {
                Dichvuobject dv = new Dichvuobject();
                dv.Madv = txtMADV.Text;
                dv.Tendv = txtTENDV.Text;
                dv.Giadv = Int32.Parse(txtGIADV.Text);
                dv.Ghichu = txtghichudv.Text;
                Dichvucontrol.updatedv(dv);
                dataGridView3.DataSource = Dichvucontrol.getdatadv();
            }
            catch { }
        }

        private void btnxoadv_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Dichvuobject dv = new Dichvuobject();
                    dv.Madv = txtMADV.Text;
                    Dichvucontrol.deletedv(dv);
                    dataGridView3.DataSource = Dichvucontrol.getdatadv();
                }

            }
            catch { }
        }
        #endregion

        #region Tìm kiếm khách
        private void btntimkh_Click(object sender, EventArgs e)
        {
            if (txttimkhach.Text.Trim() == "")
            {
                DataTable dttatca = Khachhangcontrol.getdataK();
                if (radtatca.Checked == true)
                    dataGridView1.DataSource = dttatca;
                else
                    MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //THEO tên khách hàng
                DataTable dttenkh = Khachhangcontrol.getdatabyTenkh(txttimkhach.Text.Trim());
                if (dttenkh.Rows.Count > 0 && radtenkh.Checked == true)
                    dataGridView1.DataSource = dttenkh;
                else
                {
                    DataTable dtmadoan = Khachhangcontrol.getdatabyDOAN(txttimkhach.Text.Trim());
                    if (dtmadoan.Rows.Count > 0 && radmadoan.Checked == true)
                        dataGridView1.DataSource = dtmadoan; //theo madoan
                    else
                    {
                        DataTable dttendoan = Khachhangcontrol.getdatabyTENDOAN(txttimkhach.Text.Trim());
                        if (dttendoan.Rows.Count > 0 && radtendoan.Checked == true)
                            dataGridView1.DataSource = dttendoan;//theo ten doan
                        else
                        {
                            DataTable dtmakhach = Khachhangcontrol.getdatabyMAKH(txttimkhach.Text.Trim());
                            if (dtmakhach.Rows.Count > 0 && radioButton1.Checked == true)
                                dataGridView1.DataSource = dtmakhach;//theo ma khach
                            else
                            {
                                //THEO CMT
                                DataTable dtcmt = Khachhangcontrol.getdatabyCMT(txttimkhach.Text.Trim());
                                if (dtcmt.Rows.Count > 0 && radCMT.Checked == true)
                                    dataGridView1.DataSource = dtcmt;
                                else
                                {
                                    //THEO SDT
                                    DataTable dtsdt = Khachhangcontrol.getdatabySDT(txttimkhach.Text.Trim());
                                    if (dtsdt.Rows.Count > 0 && radSDT.Checked == true)
                                        dataGridView1.DataSource = dtsdt;
                                    else
                                    {
                                        MessageBox.Show("Không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region hiển thị
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Khachhangcontrol.getdataK();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridPHONG.DataSource = Phongcontrol.getdatap();
        }

        private void btnMoSDDV_Click(object sender, EventArgs e)
        {
            Chitietsddv CT = new Chitietsddv();
            CT.Show();
        }
        #endregion

        #region cột STT tự tăng
        private void dataGridPHONG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridPHONG.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }
        private void dataGridView3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView3.Rows[e.RowIndex].Cells["STT2"].Value = e.RowIndex + 1;

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT3"].Value = e.RowIndex + 1;

        }

        private void dataGridView4_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView4.Rows[e.RowIndex].Cells["STT4"].Value = e.RowIndex + 1;

        }
        private void dataGridView5_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            datDOAN.Rows[e.RowIndex].Cells["STT5"].Value = e.RowIndex + 1;
        }
        private void dataNCP_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataNCP.Rows[e.RowIndex].Cells["STT6"].Value = e.RowIndex + 1;
        }
        private void dataNV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataNV.Rows[e.RowIndex].Cells["STT7"].Value = e.RowIndex + 1;
        }
        private void datap_thue_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            datap_thue.Rows[e.RowIndex].Cells["STT8"].Value = e.RowIndex + 1;
        }

        private void datachitietp_thue_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            datachitietp_thue.Rows[e.RowIndex].Cells["STT9"].Value = e.RowIndex + 1;
        }

        private void dataGridView7_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dathoadon.Rows[e.RowIndex].Cells["STT10"].Value = e.RowIndex + 1;
        }
        #endregion

        #region Tìm kiếm phòng
        private void txttimkiemphong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                dataGridView4.DataSource = Phongcontrol.getdataphbymap(txttimkiemphong.Text);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridView4.DataSource = Phongcontrol.getdataphbygiap(Int32.Parse(textBox1.Text));
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridView4.DataSource = Phongcontrol.getdataphbyhangp(comboBox2.Text);
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridView4.DataSource = Phongcontrol.getdataphbyttp(comboBox3.Text);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridView4.DataSource = Phongcontrol.getdataphbyloaip(comboBox1.Text);
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridView4.DataSource = Phongcontrol.getdatap();
        }
        #endregion

        #region Đoàn

        private void btnadddoan_Click(object sender, EventArgs e)
        {
            try
            {
                Doanobject dv = new Doanobject();
                dv.Madoan = txtmadoan1.Text;
                dv.Tendoan = txttendoan.Text;
                dv.Ghichu = txtghichu.Text;
                Doancontrol.adddoan(dv);
                datDOAN.DataSource = Doancontrol.getdatadoan();
            }
            catch { }
        }

        private void btnupdatedoan_Click(object sender, EventArgs e)
        {

            try
            {
                Doanobject dv = new Doanobject();
                dv.Madoan = txtmadoan1.Text;
                dv.Tendoan = txttendoan.Text;
                dv.Ghichu = txtghichu.Text;
                Doancontrol.updatedoan(dv);
                datDOAN.DataSource = Doancontrol.getdatadoan();
            }
            catch { }
        }

        private void btndeletedoan_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Doanobject dv = new Doanobject();
                    dv.Madoan = txtmadoan1.Text;
                    Doancontrol.deletedoan(dv);
                    datDOAN.DataSource = Doancontrol.getdatadoan();
                }

            }
            catch { }
        }
        #endregion

        #region tìm kiếm đoàn
        private void txttimdoan_TextChanged(object sender, EventArgs e)
        {
            datDOAN.DataSource = Doancontrol.timnhanh_doan(txttimdoan.Text);
        }

        private void dsdoan_Click(object sender, EventArgs e)
        {
            datDOAN.DataSource = Doancontrol.getdatadoan();
        }
        #endregion

        #region Người cùng phòng
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                NgCPobject ng = new NgCPobject();
                ng.Tenngcp = textBox6.Text;
                ng.Cmt = textBox7.Text;
                ng.Makh = textBox8.Text;
                if (this.radNAM.Checked == true)
                    ng.Gt = radNAM.Text;
                else
                    ng.Gt = radNU.Text;
                NgCPcontrol.addNCP(ng);
                dataNCP.DataSource = NgCPcontrol.getdataNCP();
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                NgCPobject ng = new NgCPobject();
                ng.Tenngcp = textBox6.Text;
                ng.Cmt = textBox7.Text;
                ng.Makh = textBox8.Text;
                if (this.radNAM.Checked == true)
                    ng.Gt = radNAM.Text;
                if (this.radNU.Checked == true)
                    ng.Gt = radNU.Text;
                NgCPcontrol.updateNCP(ng);
                dataNCP.DataSource = NgCPcontrol.getdataNCP();
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    NgCPobject ng = new NgCPobject();
                    ng.Tenngcp = textBox6.Text;
                    ng.Cmt = textBox7.Text;
                    ng.Makh = textBox8.Text;
                    if (radNAM.Checked == true)
                        ng.Gt = radNAM.Text;
                    else
                        ng.Gt = radNU.Text;
                    NgCPcontrol.deleteNCP(ng);
                    dataNCP.DataSource = NgCPcontrol.getdataNCP();
                }

            }
            catch { }
        }
        #endregion

        #region Tìm kiếm dịch vụ
        private void button1_Click(object sender, EventArgs e)
        {
            if (txttimdichvu.Text.Trim() == "")
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DataTable dt = Dichvucontrol.getdatabytendv(txttimdichvu.Text);
                if (dt.Rows.Count > 0 && radtendv.Checked == true)
                    dataGridView3.DataSource = dt;
                else
                {
                    if (radgiadv.Checked == true)
                    {
                        DataTable dt1 = Dichvucontrol.getdatabygiadv(Int32.Parse(txttimdichvu.Text));
                        if(dt1.Rows.Count > 0)
                             dataGridView3.DataSource = dt1;
                        else
                            MessageBox.Show("Không có");
                    }

                       
                }

            }
        }
        private void txttimdichvu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                dataGridView3.DataSource = Dichvucontrol.getdatadv();
            }
        }
        #endregion

        #region Tìm kiếm người cùng phòng
        //dùng enter
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    dataNCP.DataSource = NgCPcontrol.TimNCP(textBox5.Text);
        }
        //Lọc nhanh
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataNCP.DataSource = NgCPcontrol.TimNCP(textBox5.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataNCP.DataSource = NgCPcontrol.getdataNCP();
        }
        #endregion

        #region Nhân viên
        private void button13_Click(object sender, EventArgs e)
        {
            dataNV.DataSource = Nhanviencontrol.getdatanv();
        }

        private void btnaddNV_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvienobject nv = new Nhanvienobject();
                nv.Manv = textBox2.Text;
                nv.Tennv = textBox3.Text;
                nv.Ngaysinh = DateTime.Parse(textBox4.Text);
                if (radBoy.Checked == true)
                    nv.Gioitinh = radBoy.Text;
                else nv.Gioitinh = radGirl.Text;
                nv.Luong = Int32.Parse(textBox10.Text);
                Nhanviencontrol.addnv(nv);
                dataNV.DataSource = Nhanviencontrol.getdatanv();
            }
            catch { }
        }

        private void btnupdateNV_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvienobject nv = new Nhanvienobject();
                nv.Manv = textBox2.Text;
                nv.Tennv = textBox3.Text;
                nv.Ngaysinh = DateTime.Parse(textBox4.Text);
                if (radBoy.Checked == true)
                    nv.Gioitinh = radBoy.Text;
                else nv.Gioitinh = radGirl.Text;
                nv.Luong = Int32.Parse(textBox10.Text);
                Nhanviencontrol.updatenv(nv);
                dataNV.DataSource = Nhanviencontrol.getdatanv();
            }
            catch { }
        }

        private void btndeleteNV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Nhanvienobject nv = new Nhanvienobject();
                    nv.Manv = textBox2.Text;
                    Nhanviencontrol.deletenv(nv);
                    dataNV.DataSource = Nhanviencontrol.getdatanv();
                }

            }
            catch { }
        }

        #endregion

        #region Tìm kiếm nhân viên
        private void txttimNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioButton7.Checked == true)
                    dataNV.DataSource = Nhanviencontrol.timnvbymanv(txttimNV.Text);
                //if (radioButton8.Checked==true)
                //dataNV.DataSource = Nhanviencontrol.timnvbytennv(txttimNV.Text);
                if (radLUONGNV.Checked == true)
                    dataNV.DataSource = Nhanviencontrol.timnvbyluong(Int32.Parse(txttimNV.Text));
            }
        }
        #endregion

        #region Phiếu thuê phòng
        private void btnthemp_thue_Click(object sender, EventArgs e)
        {
            try
            {
                P_Thueobject ph = new P_Thueobject();
                ph.Maphieu = textBox9.Text;
                ph.Makh = textBox11.Text;
                ph.Ngaylap = DateTime.Parse(dateTimePicker1.Text);
                ph.Datcoc = Int32.Parse(textBox12.Text);
                //ph.Thanhtien = Int32.Parse(textBox13.Text);
                P_Thuecontrol.addp_thue(ph);
                datap_thue.DataSource = P_Thuecontrol.getdatap_thue();
            }
            catch { }
        }

        private void btnsuap_thue_Click(object sender, EventArgs e)
        {
            try
            {
                P_Thueobject ph = new P_Thueobject();
                ph.Maphieu = textBox9.Text;
                ph.Makh = textBox11.Text;
                ph.Ngaylap = DateTime.Parse(dateTimePicker1.Text); DateTime.Parse(dateTimePicker1.Text);
                ph.Datcoc = Int32.Parse(textBox12.Text);
                //ph.Thanhtien = Int32.Parse(textBox13.Text);
                P_Thuecontrol.updatep_thue(ph);
                datap_thue.DataSource = P_Thuecontrol.getdatap_thue();
            }
            catch { }
        }

        private void btnxoap_thue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    P_Thueobject ph = new P_Thueobject();
                    ph.Maphieu = textBox9.Text;
                    ph.Ngaylap = DateTime.Now;
                    P_Thuecontrol.deletep_thue(ph);
                    datap_thue.DataSource = P_Thuecontrol.getdatap_thue();
                }

            }
            catch { }
        }

        private void btndsp_thue_Click(object sender, EventArgs e)
        {
            datap_thue.DataSource = P_Thuecontrol.getdatap_thue();
        }
        #endregion

        #region Tìm kiếm phiếu thuê
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radmaphieu.Checked == true)
                    datap_thue.DataSource = P_Thuecontrol.timp_thuebymaphieu(txttimkiem.Text);
                if (radmakh.Checked == true)
                    datap_thue.DataSource = P_Thuecontrol.timp_thuebymakh(txttimkiem.Text);
            }
        }
        private void dateTimePicker7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                datap_thue.DataSource = P_Thuecontrol.timp_thuebyngaylap(DateTime.Parse(dateTimePicker7.Text));
        }
        #endregion

        #region Hóa đơn
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Hoadonobject hd = new Hoadonobject();
                hd.Mahd = textBox18.Text;
                hd.Makh = textBox19.Text;
                hd.Ngaylap = DateTime.Now;
                hd.Manv = textBox22.Text;
                hd.Ghichu = textBox23.Text;
                Hoadoncontrol.addhoadon(hd);
                dathoadon.DataSource = Hoadoncontrol.getdatahd();
            }
            catch { }
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            try
            {
                Hoadonobject hd = new Hoadonobject();
                hd.Mahd = textBox18.Text;
                hd.Makh = textBox19.Text;
                hd.Ngaylap = DateTime.Parse(datetra.Text);
                hd.Manv = textBox22.Text;
                hd.Ghichu = textBox23.Text;
                Hoadoncontrol.updatehoadon(hd);
                dathoadon.DataSource = Hoadoncontrol.getdatahd();
            }
            catch { }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Hoadonobject hd = new Hoadonobject();
                    hd.Mahd = textBox18.Text;
                    hd.Makh = textBox19.Text;
                    hd.Ngaylap = DateTime.Now;
                    Hoadoncontrol.deletehoadon(hd);
                    dathoadon.DataSource = Hoadoncontrol.getdatahd();
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dathoadon.DataSource = Hoadoncontrol.getdatahd();
        }
        #endregion

        #region Tìm hóa đơn
        private void txttimhd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radmahd.Checked == true)
                {
                    dathoadon.DataSource = Hoadoncontrol.timhdbymahd(txttimhd.Text);
                }
                if (radhd_makh.Checked == true)
                {
                    dathoadon.DataSource = Hoadoncontrol.timhdbymakh(txttimhd.Text);
                }
                if (radhd_manv.Checked == true)
                {
                    dathoadon.DataSource = Hoadoncontrol.timhdbymanv(txttimhd.Text);
                }
            }
        }

        private void datetimhd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dathoadon.DataSource = Hoadoncontrol.timhdbyngaylap(DateTime.Parse(datetimhd.Text));
            }
        }
        #endregion

        #region tìm kiếm chi tiết thuê phòng
        private void txttimctthue_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                datachitietp_thue.DataSource = Chitietp_Thuecontrol.timctp_thue(txttimctthue.Text);
        }

        private void datengay_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    datachitietp_thue.DataSource = Chitietp_Thuecontrol.timctp_thuengay(DateTime.Parse(datengay.Text.Trim()));
            if (e.KeyCode == Keys.Enter)
            {
                if (radngaythue.Checked == true)
                    datachitietp_thue.DataSource = Chitietp_Thuecontrol.timctp_thuebyngaythue(DateTime.Parse(datengay.Text.Trim()));
                if (radngaytradk.Checked == true)
                    datachitietp_thue.DataSource = Chitietp_Thuecontrol.timctp_thuebyngaytradk(DateTime.Parse(datengay.Text.Trim()));
            }
        }
        #endregion

        #region Trỏ vào data hiện lên textbox
        private void dathoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    textBox18.Text = Convert.ToString(dathoadon.CurrentRow.Cells["MAHD"].Value);
                    textBox19.Text = Convert.ToString(dathoadon.CurrentRow.Cells["MAKH4"].Value);
                    datetra.Text = dathoadon.CurrentRow.Cells["NGAYLAP1"].Value.ToString();
                    textBox20.Text = Convert.ToString(dathoadon.CurrentRow.Cells["TIENTHUEPHONG"].Value);
                    textBox21.Text = Convert.ToString(dathoadon.CurrentRow.Cells["TIENDICHVU"].Value);
                    textBox22.Text = Convert.ToString(dathoadon.CurrentRow.Cells["MANV1"].Value);
                    textBox23.Text = Convert.ToString(dathoadon.CurrentRow.Cells["GHICHU3"].Value);
                    textBox17.Text = Convert.ToString(dathoadon.CurrentRow.Cells["TONGTIEN"].Value);
                }
            }
            catch { }

        }
        private void dataGridPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMAP.Text = dataGridPHONG.CurrentRow.Cells["MAP"].Value.ToString();
                    cmbLOAIP.Text = dataGridPHONG.CurrentRow.Cells["LOAIP"].Value.ToString();
                    cmbHANGP.Text = dataGridPHONG.CurrentRow.Cells["HANGP"].Value.ToString();
                    txtGIAP.Text = dataGridPHONG.CurrentRow.Cells["GIAP"].Value.ToString();
                    cmbTTP.Text = dataGridPHONG.CurrentRow.Cells["TTP"].Value.ToString();
                    txtSDTP.Text = dataGridPHONG.CurrentRow.Cells["SDTP"].Value.ToString();
                }
            }
            catch { }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMAKH.Text = dataGridView2.CurrentRow.Cells["MAKH"].Value.ToString();
                    txtTENKH.Text = dataGridView2.CurrentRow.Cells["TENKH"].Value.ToString();
                    txtCMT.Text = dataGridView2.CurrentRow.Cells["CMT"].Value.ToString();
                    txtSDT.Text = dataGridView2.CurrentRow.Cells["SDT"].Value.ToString();
                    if (radioGT.Text == dataGridView2.CurrentRow.Cells["GT"].Value.ToString())
                    {
                        radioButton2.Checked = false;
                        radioGT.Checked = true;
                    }
                    else
                    {
                        radioGT.Checked = false;
                        radioButton2.Checked = true;
                    }
                    txtmadoan.Text = dataGridView2.CurrentRow.Cells["MADOAN"].Value.ToString();
                    txtdiachi.Text = dataGridView2.CurrentRow.Cells["DIACHI"].Value.ToString();
                }
            }
            catch { }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMADV.Text = dataGridView3.CurrentRow.Cells["MADV"].Value.ToString();
                    txtTENDV.Text = dataGridView3.CurrentRow.Cells["TENDV"].Value.ToString();
                    txtGIADV.Text = dataGridView3.CurrentRow.Cells["GIADV"].Value.ToString();
                    txtghichudv.Text = dataGridView3.CurrentRow.Cells["GHICHU"].Value.ToString();
                }
            }
            catch { }
        }
        private void datDOAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtmadoan1.Text = datDOAN.CurrentRow.Cells["MADOAN2"].Value.ToString();
                    txttendoan.Text = datDOAN.CurrentRow.Cells["TENDOAN"].Value.ToString();
                    txtghichu.Text = datDOAN.CurrentRow.Cells["GHICHU1"].Value.ToString();
                }
            }
            catch { }
        }
        private void dataNCP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    textBox6.Text = dataNCP.CurrentRow.Cells["TENNGCUNGPHONG"].Value.ToString();
                    textBox7.Text = dataNCP.CurrentRow.Cells["CMT2"].Value.ToString();
                    textBox8.Text = dataNCP.CurrentRow.Cells["MAKH2"].Value.ToString();
                    if (radNAM.Text == dataNCP.CurrentRow.Cells["GT3"].Value.ToString())
                    {
                        radNU.Checked = false;
                        radNAM.Checked = true;
                    }
                    else
                    {
                        radNAM.Checked = false;
                        radNU.Checked = true;
                    }

                }
            }
            catch { }
        }
        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    textBox2.Text = dataNV.CurrentRow.Cells["MANV"].Value.ToString();
                    textBox3.Text = dataNV.CurrentRow.Cells["TENNV"].Value.ToString();
                    textBox4.Text = dataNV.CurrentRow.Cells["NS"].Value.ToString();
                    if (radBoy.Text == dataNV.CurrentRow.Cells["GT2"].Value.ToString())
                    {
                        radGirl.Checked = false;
                        radBoy.Checked = true;
                    }
                    else
                    {
                        radBoy.Checked = false;
                        radGirl.Checked = true;
                    }
                    textBox10.Text = dataNV.CurrentRow.Cells["LUONG"].Value.ToString();
                }
            }
            catch { }
        }

        private void datachitietp_thue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    textBox14.Text = datachitietp_thue.CurrentRow.Cells["MAPHIEU1"].Value.ToString();
                    textBox15.Text = datachitietp_thue.CurrentRow.Cells["MAP2"].Value.ToString();
                    dateTimePicker2.Text = datachitietp_thue.CurrentRow.Cells["NGAYTHUE"].Value.ToString();
                    dateTimePicker3.Text = datachitietp_thue.CurrentRow.Cells["NGAYTRADK"].Value.ToString();
                    textBox16.Text = datachitietp_thue.CurrentRow.Cells["GHICHU2"].Value.ToString();
                }
            }
            catch { }
        }

        #endregion

        #region Cách lọc nhanh
        private void txttimNV_TextChanged(object sender, EventArgs e)
        {
            dataNV.DataSource = Nhanviencontrol.timnvbytennv(txttimNV.Text);
        }

        private void txttimkhach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Khachhangcontrol.locnhanhKH(txttimkhach.Text);
        }

        #endregion


        #region Chi tiết thuê phòng
        public static string MaKH = "";

        private void datap_thue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    MaKH = datap_thue.CurrentRow.Cells["MAKH3"].Value.ToString();


                    textBox9.Text = datap_thue.CurrentRow.Cells["MAPHIEU"].Value.ToString();
                    textBox11.Text = datap_thue.CurrentRow.Cells["MAKH3"].Value.ToString();
                    dateTimePicker1.Text = datap_thue.CurrentRow.Cells["NGAYLAP"].Value.ToString();
                    textBox12.Text = datap_thue.CurrentRow.Cells["DATCOC"].Value.ToString();
                    textBox13.Text = datap_thue.CurrentRow.Cells["THANHTIEN"].Value.ToString();
                }
            }
            catch { }
        }
        private void datap_thue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MaKH != "")
            {
                datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdateloadbymakh(MaKH);
            }
        }
        private void butthemct_Click(object sender, EventArgs e)
        {
            try
            {
                Chitietp_Thueobject ct = new Chitietp_Thueobject();
                ct.Maphieu = textBox14.Text;
                ct.Map = textBox15.Text;
                ct.Ngaythue = DateTime.Parse(dateTimePicker2.Text);
                ct.Ngaytradk = DateTime.Parse(dateTimePicker3.Text);
                ct.Ghichu = textBox16.Text;
                Chitietp_Thuecontrol.addctp_thue(ct);
                datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdateloadbymakh(MaKH);
               // datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdatactThue();
            }
            catch { }
        }

        private void btndsctthue_Click(object sender, EventArgs e)
        {
            datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdatactThue();
        }

        private void btnsauctthue_Click(object sender, EventArgs e)
        {
            try
            {
                Chitietp_Thueobject ct = new Chitietp_Thueobject();
                ct.Maphieu = textBox14.Text;
                ct.Map = textBox15.Text;
                ct.Ngaythue = DateTime.Parse(dateTimePicker2.Text);
                ct.Ngaytradk = DateTime.Parse(dateTimePicker3.Text);
                ct.Ghichu = textBox16.Text;
                Chitietp_Thuecontrol.updatectp_thue(ct);
                datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdateloadbymakh(MaKH);
                //datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdatactThue();
            }
            catch { }
        }

        private void btnxoactthue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    Chitietp_Thueobject ct = new Chitietp_Thueobject();
                    ct.Maphieu = textBox14.Text;
                    //ct.Map = textBox15.Text;
                    ct.Ngaythue = DateTime.Now;
                    ct.Ngaytradk = DateTime.Now;
                    Chitietp_Thuecontrol.deletectp_thue(ct);
                    datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdateloadbymakh(MaKH);
                    //datachitietp_thue.DataSource = Chitietp_Thuecontrol.getdatactThue();
                }
            }
            catch { }
        }
        #endregion

        private void KHACHANG_Click(object sender, EventArgs e)
        {

        }

    }
}
