﻿using System;
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
    public partial class frmLop : Form
    {
        LopBLLDAL lopblldal = new LopBLLDAL();
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            dgrLop.DataSource = lopblldal.loadLop();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtSiSo.Clear();
            txtTenlop.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lopblldal.ThemLop(txtMaLop.Text, txtTenlop.Text, Int16.Parse(txtSiSo.Text));
            MessageBox.Show("Thêm Thành Công");
            dgrLop.DataSource = lopblldal.loadLop();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lopblldal.SuaLop(txtMaLop.Text, txtTenlop.Text, Int16.Parse(txtSiSo.Text));
            MessageBox.Show("Sửa Thành Công");
            dgrLop.DataSource = lopblldal.loadLop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lopblldal.XoaLop(txtMaLop.Text);
            MessageBox.Show("Xóa Thành Công");
            dgrLop.DataSource = lopblldal.loadLop();
        }
    }
}
