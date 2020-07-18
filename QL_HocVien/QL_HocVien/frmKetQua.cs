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
    }
}
