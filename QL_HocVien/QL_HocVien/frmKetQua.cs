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
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
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

            if (diemTK < 5)
                this.txtGhiChu.Text = "Rớt rồi học lại nha :((";
            else
                this.txtGhiChu.Text = "Chúc mừng bạn đã đậu :)))";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboMonHoc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiemLan1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDiemLan2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDiemTK.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketquablldal.ThemKetQua(txtMaSV.Text, cboMonHoc.SelectedValue.ToString(), Double.Parse(txtDiemLan1.Text), Double.Parse(txtDiemLan2.Text), Double.Parse(txtDiemTK.Text), txtGhiChu.Text);
            MessageBox.Show("Thêm Thành Công");
            dataGridView1.DataSource = ketquablldal.loadKetQua();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtGhiChu.Clear();
            txtMaSV.Clear();
            txtDiemLan1.Clear();
            txtDiemLan2.Clear();
            txtDiemTK.Clear();
            dataGridView1.DataSource = ketquablldal.loadKetQua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketquablldal.XoaKetQua(txtMaSV.Text);
            MessageBox.Show("Xóa Thành Công");
            dataGridView1.DataSource = ketquablldal.loadKetQua();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ketquablldal.SuaKetQua(txtMaSV.Text, cboMonHoc.SelectedValue.ToString(), Double.Parse(txtDiemLan1.Text), Double.Parse(txtDiemLan2.Text), Double.Parse(txtDiemTK.Text), txtGhiChu.Text);
            MessageBox.Show("Sửa Thành Công");
            dataGridView1.DataSource = ketquablldal.loadKetQua();

        }

        private void txtDiemLan1_TextChanged(object sender, EventArgs e)
        {
            double DIEMTHI, DIEMTB, DIEMTK;

            if (txtDiemLan1.Text == "")
            {
                this.txtDiemLan1.Text = "0";
                DIEMTB = double.Parse(this.txtDiemLan2.Text);

                //Tính điểm TK
                DIEMTK = (0.3 * DIEMTB + 0.7 * 0);
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            else if (txtDiemLan2.Text == "")
            {
                this.txtDiemLan2.Text = "0";
                DIEMTHI = double.Parse(this.txtDiemLan1.Text);

                //Tính điểm TK
                DIEMTK = (0.3 * 0 + 0.7 * DIEMTHI);
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }

            else
            {
                DIEMTHI = double.Parse(this.txtDiemLan1.Text);
                DIEMTB = double.Parse(this.txtDiemLan2.Text);
                //Tính điểm TK
                DIEMTK = (0.3 * DIEMTB + 0.7 * DIEMTHI);
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            DIEMTK = double.Parse(this.txtDiemTK.Text);
            if (DIEMTK < 5)
            {
                this.txtGhiChu.Text = "Thi lại";
            }
            else
            {
                this.txtGhiChu.Text = "Đã Đậu";
            }
        }

        private void txtDiemLan2_TextChanged(object sender, EventArgs e)
        {
            double DIEMTHI, DIEMTB, DIEMTK;

            if (txtDiemLan2.Text == "")
            {
                this.txtDiemLan2.Text = "0";
                DIEMTHI = double.Parse(this.txtDiemLan1.Text);

                //Tính điểm TK
                DIEMTK = (0.3 * 0 + 0.7 * DIEMTHI);
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            else if (txtDiemLan1.Text == "")
            {
                this.txtDiemLan1.Text = "0";
                DIEMTB = double.Parse(this.txtDiemLan2.Text);

                //Tính điểm TK
                DIEMTK = (0.3 * DIEMTB + 0.7 * 0);
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }

            else
            {
                DIEMTHI = double.Parse(this.txtDiemLan1.Text);
                DIEMTB = double.Parse(this.txtDiemLan2.Text);
                //Tính điểm TK
                DIEMTK = (0.3 * DIEMTB + 0.7 * DIEMTHI);
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            DIEMTK = double.Parse(this.txtDiemTK.Text);
            if (DIEMTK < 5)
            {
                this.txtGhiChu.Text = "Thi lại";
            }
            else
            {
                this.txtGhiChu.Text = "Đã Đậu";
            }
        }
    }
}
