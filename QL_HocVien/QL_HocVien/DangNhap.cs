using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocVien
{
    public partial class DangNhap : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPRR948\\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;User ID=sa;Password=sa2012");
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public DangNhap()
        {
            InitializeComponent();
        }
        private Boolean kiemtraQuyen(String tentk)
        {
            con.Open();
            string cntString = "select quyen from TAIKHOAN  where TenDangNhap='" + txtUser.Text + "'";
            SqlCommand cmd = new SqlCommand(cntString, con);
            String quyen = cmd.ExecuteScalar().ToString();
            con.Close();
            if (quyen.Trim().Equals("admin"))
                return true;
            return false;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            //{
            //    MessageBox.Show("Dữ Liệu Không Được Để Trống" + " " + label1.Text.ToUpper());
            //    this.txtUser.Focus();
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            //{
            //    MessageBox.Show("Dữ Liệu Không Được Để Trống" + " " + label2.Text.ToUpper());
            //    this.txtPass.Focus();
            //    return;
            //}
            //int kq = CauHinh.Check_Config();
            //if (kq == 0)
            //    ProcessLogin();
            //if (kq == 1)
            //{
            //    MessageBox.Show("Chuoi cau hinh khong ton tai");
            //    ProcessConfig();
            //}
            //if (kq == 2)
            //{
            //    MessageBox.Show("Chuoi cau hinh khong phu hop");
            //    ProcessConfig();
            //}
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPRR948\\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;User ID=sa;Password=sa2012");
            //try
            //{
            //    con.Open();
            //    string selsql = "select * from TAIKHOAN where TenDangNhap='" + txtUser.Text + "' and MatKhau='" + txtPass.Text + "'";
            //    SqlCommand cmd = new SqlCommand(selsql, con);
            //    SqlDataReader read = cmd.ExecuteReader();
            //    if (read.Read() == true)
            //    {
            //        String temp;
            //        if (kiemtraQuyen(txtUser.Text))
            //        {
            //            temp = "admin";
            //            TrangChu menu = new TrangChu(temp);
            //            this.Hide();
            //            menu.Show();
            //        }
            //        else
            //        {
            //            temp = "user";
            //            TrangChu menu = new TrangChu(temp);
            //            this.Hide();
            //            menu.Show();
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoảng hoặc mật khẩu không chính xác");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi kết nối");
            //}
        }
        //public void ProcessConfig()
        //{
        //    if (Program.xulyForm == null || Program.xulyForm.IsDisposed)
        //    {
        //        Program.xulyForm = new XuLyCauHinh();
        //    }
        //    String temp;
        //    if (kiemtraQuyen(txtUser.Text))
        //    {
        //        temp = "admin";
        //        //Menu menu = new Menu(temp);
        //        //this.Hide();
        //        //menu.Show();
        //        this.Visible = false;
        //        Program.xulyForm.Show();
        //    }
        //    else
        //    {
        //        temp = "user";
        //        this.Visible = false;
        //        Program.xulyForm.Show();
        //        //Menu menu = new Menu(temp);
        //        //this.Hide();
        //        //menu.Show();
        //    }
            
        //}

        //public void ProcessLogin()
        //{
        //    int result;
        //    result = CauHinh.check_User(txtUser.Text, txtPass.Text);
        //    //wrong username or password
        //    if (result == 9)
        //    {
        //        MessageBox.Show("Sai" + label1.Text + "Hoặc" + label2.Text);
        //        return;
        //    }
        //    else if (result == 10)
        //    {
        //        MessageBox.Show("Tài khoản bị khóa");
        //        return;
        //    }
        //    if (Program.trangchu == null || Program.trangchu.IsDisposed)
        //    {
        //        Program.trangchu = new TrangChu();
        //    }
        //    this.Visible = false;
        //    Program.trangchu.Show();
          
        //}

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

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDN_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPRR948\\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;User ID=sa;Password=sa2012");
            try
            {
                con.Open();
                string selsql = "select * from TAIKHOAN where TenDangNhap='" + txtUser.Text + "' and MatKhau='" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(selsql, con);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read() == true)
                {
                    String temp;
                    if (kiemtraQuyen(txtUser.Text))
                    {
                        temp = "admin";
                        TrangChu menu = new TrangChu(temp);
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        temp = "user";
                        TrangChu menu = new TrangChu(temp);
                        this.Hide();
                        menu.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoảng hoặc mật khẩu không chính xác");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
