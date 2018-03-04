using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLon_KSan.Control;
using BTLon_KSan.Object;
using BTLon_KSan.Model;

namespace BTLon_KSan
{
    public partial class Chitietsddv : Form
    {
        public Chitietsddv()
        {
            InitializeComponent();
        }

        private void Chitietsddv_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chitietsddvcontrol.getdatachitietdv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ChitietsddvObject ct = new ChitietsddvObject();
                ct.Makh = txtchitietmakh.Text;
                ct.Madv = txtchitietmadv.Text;
               // ct.Ngaysd = DateTime.Parse(datime1.Text);
                ct.Ngaysd = DateTime.Now;
                ct.Sldv = Int32.Parse(txtsldv.Text);
                Chitietsddvcontrol.ADDchitietsddv(ct);
                dataGridView1.DataSource = Chitietsddvcontrol.getdatachitietdv();
            }
            catch { }
        }

        private void btnsuachitietdv_Click(object sender, EventArgs e)
        {
            try
            {
                ChitietsddvObject ct = new ChitietsddvObject();
                ct.Makh = txtchitietmakh.Text;
                ct.Madv = txtchitietmadv.Text;
                //ct.Ngaysd = DateTime.Parse(datime1.Text);
                ct.Ngaysd = DateTime.Now;
                ct.Sldv = Int32.Parse(txtsldv.Text);
                Chitietsddvcontrol.updatechitietsddv(ct);
                dataGridView1.DataSource = Chitietsddvcontrol.getdatachitietdv();
            }
            catch { }
        }

        private void btnxoachitietdv_Click(object sender, EventArgs e)
        {
            try
            {
                ChitietsddvObject ct = new ChitietsddvObject();
                ct.Makh = txtchitietmakh.Text;
                ct.Madv = txtchitietmadv.Text;
                Chitietsddvcontrol.deletechitietsddv(ct);
                dataGridView1.DataSource = Chitietsddvcontrol.getdatachitietdv();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //cách hiển thị cột stt tự động tăng
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        //hiển thị dữ liệu vào bảng
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chitietsddvcontrol.getdatachitietdv();
        }

        #region Tìm kiếm
        private void button2_Click(object sender, EventArgs e)
        {
           if (txttimctdv.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DataTable ctdv2 = Chitietsddvcontrol.timctdvbytenkh(txttimctdv.Text.Trim());
                if (ctdv2.Rows.Count > 0 && radtenkh.Checked==true)
                    dataGridView1.DataSource = ctdv2;
                else
                {
                    DataTable ctdv3 = Chitietsddvcontrol.timctdvbymakh(txttimctdv.Text.Trim());
                    if (ctdv3.Rows.Count > 0 && radMakh.Checked==true)
                        dataGridView1.DataSource = ctdv3;
                    else
                    {
                        DataTable ctdv4 = Chitietsddvcontrol.timctdvbymadv(txttimctdv.Text.Trim());
                        if (ctdv4.Rows.Count > 0 && radmadv.Checked== true)
                            dataGridView1.DataSource = ctdv4;
                        else
                        {
                            DataTable ctdv1 = Chitietsddvcontrol.timctdvbytendv(txttimctdv.Text.Trim());
                            if (ctdv1.Rows.Count > 0 && radtendv.Checked == true)
                                dataGridView1.DataSource = ctdv1;
                              else
                                   MessageBox.Show("Không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);  
                        }
                    }
                }
            }

        }
        private void txttimctdv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                dataGridView1.DataSource = Chitietsddvcontrol.timctdvbysldv(Int32.Parse(txttimctdv.Text));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtchitietmakh.Text = dataGridView1.CurrentRow.Cells["MAKH"].Value.ToString();
                    txtchitietmadv.Text = dataGridView1.CurrentRow.Cells["MADV"].Value.ToString();
                    datime1.Text = dataGridView1.CurrentRow.Cells["NGAYSD"].Value.ToString();
                    txtsldv.Text = dataGridView1.CurrentRow.Cells["SLDV"].Value.ToString();
                    txttongtien.Text = dataGridView1.CurrentRow.Cells["TONGTIEN"].Value.ToString();
                }
            }
            catch { }
        }
    }
        #endregion
}

