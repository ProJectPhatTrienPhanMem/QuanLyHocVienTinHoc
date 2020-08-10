using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocVien
{
    public partial class frmDangKyHocVien : Form
    {
        public frmDangKyHocVien()
        {
            InitializeComponent();
        }
        public void loadCBND()
        {
            string[] gioitinh = { "Nam", "Nữ" };


            foreach (string x in gioitinh)
            {
                cboGioiTinh.Items.Add(x);
                cboGioiTinh.SelectedIndex = 0;

            }

        }

        private void frmDangKyHocVien_Load(object sender, EventArgs e)
        {
            loadCBND();
        }
    }
}
