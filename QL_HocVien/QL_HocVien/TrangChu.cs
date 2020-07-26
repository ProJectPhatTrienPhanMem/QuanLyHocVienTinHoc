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
    public partial class TrangChu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPRR948\\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;User ID=sa;Password=sa2012");
        String quyen;
        public TrangChu()
        {
            InitializeComponent();
        }
        public TrangChu(String Quyen)
        {
            InitializeComponent();
            this.quyen = Quyen;

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.HOCVIEN' table. You can move, or remove it, as needed.
            //this.hOCVIENTableAdapter.Fill(this.duLieu.HOCVIEN);
            DangNhap dn = new DangNhap();
            dn.Visible = false;
            if (quyen.Equals("user"))
            {
                this.quảnLíToolStripMenuItem.Enabled = false;
                this.hệThốngToolStripMenuItem.Enabled = false;
                this.danhMụcToolStripMenuItem.Enabled = false;
                

            }
           
        }
        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNguoiDung frmND = new ThemNguoiDung();
            frmND.Show();
        }

        private void hOCVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duLieu);

        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void khóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiangVien frmGV = new frmGiangVien();
            frmGV.Show();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMonHoc frmMH = new frmMonHoc();
            frmMH.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocVien frmHV = new frmHocVien();
            frmHV.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop frmL = new frmLop();
            frmL.Show();
        }

        private void btnHV_Click(object sender, EventArgs e)
        {
            frmLoadSinhVien frmSV = new frmLoadSinhVien();
            this.Hide();
            frmSV.ShowDialog();
            this.Show();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQua frmkq = new frmKetQua();
            frmkq.Show();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            frmLoadGiaoVien frmGV = new frmLoadGiaoVien();
            frmGV.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroGiup frmTG = new frmTroGiup();
            frmTG.Show();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {

        }

        
    }
}
