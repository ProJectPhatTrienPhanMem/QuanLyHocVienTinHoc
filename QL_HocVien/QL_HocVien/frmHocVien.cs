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
    public partial class frmHocVien : Form
    {
        LopBLLDAL lopblldal = new LopBLLDAL();
        HocVienBLLDAL hvblldal = new HocVienBLLDAL();
        public frmHocVien()
        {
            InitializeComponent();
        }

        private void frmHocVien_Load(object sender, EventArgs e)
        {
            loadLop();
            drgHocVien.DataSource = hvblldal.loadSVFull();
            
        }
        public void loadLop()
        {
            cboLop.DataSource = lopblldal.loadLop();
            cboLop.DisplayMember = "TenLH";
            cboLop.ValueMember = "MaLH";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            drgHocVien.DataSource = hvblldal.loadSV(cboLop.SelectedValue.ToString());
        }
    }
}
