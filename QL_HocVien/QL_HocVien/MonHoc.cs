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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duLieu);

        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.duLieu.MONHOC);

        }
    }
}
