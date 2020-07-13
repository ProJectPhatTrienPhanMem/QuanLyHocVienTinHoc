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
    public partial class KhoaHoc : Form
    {
        public KhoaHoc()
        {
            InitializeComponent();
        }

        private void kHOAHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOAHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duLieu);

        }

        private void KhoaHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.KHOAHOC' table. You can move, or remove it, as needed.
            this.kHOAHOCTableAdapter.Fill(this.duLieu.KHOAHOC);

        }

        private void kHOAHOCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
