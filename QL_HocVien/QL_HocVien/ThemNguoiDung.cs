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
    public partial class ThemNguoiDung : Form
    {
        public ThemNguoiDung()
        {
            InitializeComponent();
        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duLieu);

        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.TAIKHOAN' table. You can move, or remove it, as needed.
           
            this.tAIKHOANTableAdapter.Fill(this.duLieu.TAIKHOAN);

        }
    }
}
