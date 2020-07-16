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
    public partial class frmLoadSinhVien : Form
    {
        LopBLLDAL lopblldal = new LopBLLDAL();
        HocVienBLLDAL hvblldal = new HocVienBLLDAL();
        public frmLoadSinhVien()
        {
            InitializeComponent();
        }

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            drgHocVien.DataSource = hvblldal.loadSVFull();
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtGioiTinh.Clear();
            mskPhone.Clear();
            txtDiaChi.Clear();
        }

        private void frmLoadSinhVien_Load(object sender, EventArgs e)
        {
            loadLop();
            loadMaLop();
            drgHocVien.DataSource = hvblldal.loadSVFull();
            drgHocVien.Columns[7].Visible = false;
        }
        public void loadMaLop()
        {
            cboMalop.DataSource = lopblldal.loadLop();
            cboMalop.DisplayMember = "MaLH";
            cboMalop.ValueMember = "MaLH";
        }
        public void loadLop()
        {
            cboLop.DataSource = lopblldal.loadLop();
            cboLop.DisplayMember = "TenLH";
            cboLop.ValueMember = "MaLH";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            drgHocVien.DataSource = hvblldal.loadSV(cboLop.SelectedValue.ToString());
        }

        private void drgHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = drgHocVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = drgHocVien.CurrentRow.Cells[1].Value.ToString();
            txtDay.Value = Convert.ToDateTime(drgHocVien.CurrentRow.Cells[3].Value.ToString());
            txtGioiTinh.Text = drgHocVien.CurrentRow.Cells[2].Value.ToString();
            mskPhone.Text = drgHocVien.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = drgHocVien.CurrentRow.Cells[5].Value.ToString();
            cboMalop.Text = drgHocVien.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
