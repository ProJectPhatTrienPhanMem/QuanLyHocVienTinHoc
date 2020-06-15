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
        QL_NguoiDung CauHinh = new QL_NguoiDung();
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
            int kq = CauHinh.Check_Config();
            if (kq == 0)
                ProcessLogin();
            if (kq == 1)
            {
                MessageBox.Show("Chuoi cau hinh khong ton tai");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuoi cau hinh khong phu hop");
                ProcessConfig();
            }
        }
        public void ProcessConfig()
        {
            if (Program.xulyForm == null || Program.xulyForm.IsDisposed)
            {
                Program.xulyForm = new XuLyCauHinh();
            }
            this.Visible = false;
            Program.xulyForm.Show();
        }

        public void ProcessLogin()
        {
            int result;
            result = CauHinh.check_User(txtUser.Text, txtPass.Text);
            //wrong username or password
            if (result == 9)
            {
                MessageBox.Show("Sai" + label1.Text + "Hoặc" + label2.Text);
                return;
            }
            else if (result == 10)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.trangchu == null || Program.trangchu.IsDisposed)
            {
                Program.trangchu = new TrangChu();
            }
            this.Visible = false;
            Program.trangchu.Show();
          
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
