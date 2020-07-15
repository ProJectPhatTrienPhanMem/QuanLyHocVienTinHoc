using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class GiaoVienBLLDAL
    {
        QLHVDataContext qlhv = new QLHVDataContext();
        public GiaoVienBLLDAL()
        {
        }

        public IQueryable<GiangVien> loadGiangVien()
        {
            return qlhv.GiangViens.Select(k => k);

        }
    }
}
