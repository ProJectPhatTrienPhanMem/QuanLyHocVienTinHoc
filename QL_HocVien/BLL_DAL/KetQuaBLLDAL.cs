using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KetQuaBLLDAL
    {
        QLHVDataContext qlhv = new QLHVDataContext();
        public KetQuaBLLDAL()
        {

        }
        public IQueryable<KetQua> loadKetQua()
        {
            return qlhv.KetQuas.Select(k => k);

        }
        public IQueryable<KetQua> loadKetQuaFull(String mamon)
        {
            return qlhv.KetQuas.Where(l => l.MaMH == mamon).Select(k => k);

        }
    }
}
