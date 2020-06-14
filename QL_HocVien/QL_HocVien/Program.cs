using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocVien
{
    static class Program
    {
        public static TrangChu trangchuForm = null;
        public static DangNhap dnForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dnForm = new DangNhap();
            trangchuForm = new TrangChu();
            Application.Run(dnForm);
        }
    }
}
