using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class LopBLLDAL
    {
        QLHVDataContext qlhv = new QLHVDataContext();
        public LopBLLDAL()
        {
        }
        public IQueryable<LOPHOC> loadLop()
        {
            return qlhv.LOPHOCs.Select(k => k);
            
        }
    }
}
