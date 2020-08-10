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
    public partial class frmTimKiem : Form
    {
        MonHocBLLDAL monhoc = new MonHocBLLDAL();
        LopBLLDAL lophoc = new LopBLLDAL();
        KetQuaBLLDAL ketquablldal = new KetQuaBLLDAL();
        public frmTimKiem()
        {
            InitializeComponent();
        }
        public void loadCboMonHoc()
        {
            cboMonHoc.DataSource = monhoc.loadMon();
            cboMonHoc.DisplayMember = "MaMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ketquablldal.loadKetQuaFull2(txtMaSV.Text,cboMonHoc.SelectedValue.ToString());
           dataGridView1.Columns[7].Visible = false;
           dataGridView1.Columns[6].Visible = false;
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ketquablldal.loadKetQua();
            loadCboMonHoc();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
    }
}
