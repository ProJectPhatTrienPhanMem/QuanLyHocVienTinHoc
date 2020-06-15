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
    public partial class XuLyCauHinh : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public XuLyCauHinh()
        {
            InitializeComponent();
        }
        private void cbo_Server_DropDown(object sender, EventArgs e)
        {
            cbo_Server.DataSource = CauHinh.GetServerName();
            cbo_Server.DisplayMember = "ServerName";
        }

        private void cbo_DataBase_DropDown(object sender, EventArgs e)
        {
            cbo_DataBase.DataSource = CauHinh.GetDBName(cbo_Server.Text, txt_UserName.Text, txt_Password.Text);
            cbo_DataBase.DisplayMember = "Name";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbo_Server.Text, txt_UserName.Text, txt_Password.Text, cbo_DataBase.Text);
            this.Close();
        }
    }
}
