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
    public partial class HocVien : Form
    {
        public HocVien()
        {
            InitializeComponent();
        }

        private void hOCVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duLieu);

        }

        private void HocVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.HOCVIEN' table. You can move, or remove it, as needed.
            this.hOCVIENTableAdapter.Fill(this.duLieu.HOCVIEN);

        }
    }
}
