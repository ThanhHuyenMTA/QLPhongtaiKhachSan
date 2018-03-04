using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLon_KSan.view
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "admin")
            {
                BTLon_KSan.Form1 fm = new BTLon_KSan.Form1();
                fm.FormClosing += fm_FormClosing;
                fm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "admin")
                {
                    BTLon_KSan.Form1 fm = new BTLon_KSan.Form1();
                    fm.FormClosing += fm_FormClosing;
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            
        }


       
    }
}
