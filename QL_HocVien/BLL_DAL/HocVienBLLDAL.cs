using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HocVienBLLDAL
    {
        QLHVDataContext qlhv = new QLHVDataContext();
        public HocVienBLLDAL()
        {

        }
        public IQueryable<HOCVIEN> loadSVFull()
        {
            return qlhv.HOCVIENs.Select(k => k);

        }
        public IQueryable<HOCVIEN> loadSV(String malop)
        {
            return qlhv.HOCVIENs.Where(l => l.MaLH == malop).Select(k => k);

        }
    }
}
