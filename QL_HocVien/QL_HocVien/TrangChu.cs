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
            this.hOCVIENTableAdapter.Fill(this.duLieu.HOCVIEN);
            DangNhap dn = new DangNhap();
            dn.Visible = false;
            if (quyen.Equals("user"))
            {
                this.thêmHọcSinhToolStripMenuItem.Enabled = false;
                this.hệThốngToolStripMenuItem.Enabled = false;

            }
        }
        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HocVien frmHV = new HocVien();
            frmHV.Show();
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
            MonHoc frmND = new MonHoc();
            frmND.Show();
        }

        private void khóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoaHoc frmKH = new KhoaHoc();
            frmKH.Show();
        }

        
    }
}
