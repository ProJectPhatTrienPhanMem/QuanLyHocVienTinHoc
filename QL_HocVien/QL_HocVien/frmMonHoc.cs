using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace QL_HocVien
{
    public partial class frmMonHoc : Form
    {
        MonHocBLLDAL monblldal = new MonHocBLLDAL();
        GiaoVienBLLDAL gvblldal = new GiaoVienBLLDAL();
        public frmMonHoc()
        {
            InitializeComponent();

        }

  
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            drgMonHoc.DataSource = monblldal.loadMon();
            drgMonHoc.Columns[3].Visible = false;
            loadMaGV();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drgMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboGV.Text = drgMonHoc.CurrentRow.Cells[2].Value.ToString();
            txtMaMon.Text = drgMonHoc.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = drgMonHoc.CurrentRow.Cells[1].Value.ToString();
        }
        public void loadMaGV()
        {
            cboGV.DataSource = gvblldal.loadGiangVien();
            cboGV.DisplayMember = "MaGV";
            cboGV.ValueMember = "MaGV";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monblldal.ThemMon(txtMaMon.Text, txtTenMon.Text, cboGV.SelectedValue.ToString());

            MessageBox.Show("Thêm Thành Công");
            drgMonHoc.DataSource = monblldal.loadMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            monblldal.XoaMon(txtMaMon.Text);
            MessageBox.Show("Xóa Thành Công");
            drgMonHoc.DataSource = monblldal.loadMon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            monblldal.SuaMon(txtMaMon.Text, txtTenMon.Text, cboGV.SelectedValue.ToString());
            MessageBox.Show("Sửa Thành Công");
            drgMonHoc.DataSource = monblldal.loadMon();
        }
    }
}
