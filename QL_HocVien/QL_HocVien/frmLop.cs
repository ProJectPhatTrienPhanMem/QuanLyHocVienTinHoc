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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duLieu);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.LOPHOC' table. You can move, or remove it, as needed.
            this.lOPHOCTableAdapter.Fill(this.duLieu.LOPHOC);

        }
    }
}
