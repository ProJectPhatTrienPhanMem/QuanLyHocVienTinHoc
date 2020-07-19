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
    public partial class frmKetQua : Form
    {
        MonHocBLLDAL monhoc = new MonHocBLLDAL();
        LopBLLDAL lophoc = new LopBLLDAL();
        KetQuaBLLDAL ketquablldal = new KetQuaBLLDAL();
        public frmKetQua()
        {
            InitializeComponent();
            loadMaLop();
            loadMon();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ketquablldal.loadKetQua();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        public void loadMaLop()
        {
            cboLop.DataSource = lophoc.loadLop();
            cboLop.DisplayMember = "TenLH";
            cboLop.ValueMember = "MaLH";
        }
        public void loadMon()
        {
            cboMonHoc.DataSource = monhoc.loadMon();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ketquablldal.loadKetQuaFull(cboMonHoc.SelectedValue.ToString());
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemTK_TextChanged(object sender, EventArgs e)
        {
            double diemTK;
        
            if (txtDiemTK.Text == "")
                this.txtDiemTK.Text = "0";
            
            diemTK = double.Parse(this.txtDiemTK.Text);
            
            if (diemTK <5)
                this.txtGhiChu.Text = "Rớt rồi học lại nha :((";
            else
                this.txtGhiChu.Text = "Chúc mừng bạn đã đậu :)))";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboMonHoc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiemTK.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketquablldal.ThemKetQua(txtMaSV.Text, cboMonHoc.SelectedValue.ToString(), Double.Parse(txtDiemTK.Text), txtGhiChu.Text);
            MessageBox.Show("Thêm Thành Công");
            dataGridView1.DataSource = ketquablldal.loadKetQua();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtGhiChu.Clear();
            txtMaSV.Clear();
            dataGridView1.DataSource = ketquablldal.loadKetQua();
        }
    }
}
