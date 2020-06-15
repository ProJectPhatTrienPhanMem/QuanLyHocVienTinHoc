using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QL_HocVien
{
    public class QL_NguoiDung
    {
        public int Check_Config()
        {

            //if (Properties.Settings.Default.QL_HOCVIEN == string.Empty)
            if(Properties.Settings.Default.QL_HocVienConn==string.Empty)
            {
                return 1;//chuoi cau hinh phu hop
            }
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.QL_HocVienConn);
            try
            {
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                    sqlcon.Open();
                return 0; //Ket noi thanh cong chuoi cau hinh hop le
            }
            catch
            {
                return 2; //chuoi cau hinh khong dung
            }
        }
        public int check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("Select * from TAIKHOAN Where TenDangNhap ='" + pUser + "' and MatKhau = '" + pPass + "'",
                Properties.Settings.Default.QL_HocVienConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 9;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 10;

            }
            return 11;
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select name from sys.Databases", "Data Source=" + pServer +
                ";Initial Catalog = master;User ID = " + pUser + ";Password=" + pPass + "");
            da.Fill(dt);
            return dt;

        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            QL_HocVien.Properties.Settings.Default.QL_HocVienConn = "Data Source =" + pServer + ";Initial Catalog="
                + pDBName + ";User ID = " + pUser + ";Password = " + pPass + "";
            QL_HocVien.Properties.Settings.Default.Save();
        }
    }
}
