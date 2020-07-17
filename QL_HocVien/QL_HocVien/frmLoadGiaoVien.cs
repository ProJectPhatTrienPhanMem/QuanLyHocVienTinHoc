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
    public partial class frmLoadGiaoVien : Form
    {
        GiaoVienBLLDAL giangvienblldal = new GiaoVienBLLDAL();
        public frmLoadGiaoVien()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtHoTen.Clear();
            mskPhone.Clear();
            txtMaGV.Clear();
            txtDiaChi.Clear();
            txtGioiTinh.Clear();
        }

        private void frmLoadGiaoVien_Load(object sender, EventArgs e)
        {
            dgrDSGV.DataSource = giangvienblldal.loadGiangVien();
        }

        private void dgrDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgrDSGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSGV.CurrentRow.Cells[1].Value.ToString();
            txtGioiTinh.Text = dgrDSGV.CurrentRow.Cells[2].Value.ToString();
            txtTime.Value = Convert.ToDateTime(dgrDSGV.CurrentRow.Cells[3].Value.ToString());
            mskPhone.Text = dgrDSGV.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgrDSGV.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = dgrDSGV.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
