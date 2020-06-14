using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Dữ Liệu Không Được Để Trống" + " " + label1.Text.ToUpper());
                this.txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Dữ Liệu Không Được Để Trống" + " " + label2.Text.ToUpper());
                this.txtPass.Focus();
                return;
            }
            TrangChu tc = new TrangChu();
            tc.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
