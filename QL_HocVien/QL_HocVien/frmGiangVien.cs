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
    public partial class frmGiangVien : Form
    {
        GiaoVienBLLDAL giangvienblldal = new GiaoVienBLLDAL();
        
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //giangvienblldal.ThemGiaoVien(txtMaGV.Text,txtHoTen.Text,cboGioiTinh.SelectedValue.ToString(),txtTime.Value,mskPhone.Text,txtEmail.Text,txtDiaChi.Text);

            MessageBox.Show("Thêm Thành Công!! "+cboGioiTinh.SelectedValue.ToString());
            dgrDSGV.DataSource = giangvienblldal.loadGiangVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dgrDSGV.DataSource = giangvienblldal.loadGiangVien();
        }

        private void dgrDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaGV.Text = dgrDSGV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSGV.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgrDSGV.CurrentRow.Cells[2].Value.ToString();
            txtTime.Value = Convert.ToDateTime(dgrDSGV.CurrentRow.Cells[3].Value.ToString());
            mskPhone.Text = dgrDSGV.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgrDSGV.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = dgrDSGV.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtHoTen.Clear();
            mskPhone.Clear();          
            txtMaGV.Clear();
        }
    }
}
