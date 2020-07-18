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
        public IQueryable<LOPHOC> loadMaLop()
        {
            return qlhv.LOPHOCs.Select(k => k);

        }
        public void ThemLop(String malh, String tenlp, int sisio)
        {
            LOPHOC lh = new LOPHOC();
            lh.MaLH = malh;
            lh.TenLH = tenlp;
            lh.SiSo = sisio;
            qlhv.LOPHOCs.InsertOnSubmit(lh);
            qlhv.SubmitChanges();
        }
        public void XoaLop(String malh)
        {
            LOPHOC lhs = qlhv.LOPHOCs.Where(d => d.MaLH == malh).FirstOrDefault();
            if (lhs != null)
            {

                qlhv.LOPHOCs.DeleteOnSubmit(lhs);
                qlhv.SubmitChanges();
            }
        }
        public void SuaLop(String malh, String tenlp, int sisio)
        {
            LOPHOC lhs = qlhv.LOPHOCs.Where(d => d.MaLH == malh).FirstOrDefault();
            if (lhs != null)
            {
                lhs.MaLH = malh;
                lhs.TenLH = tenlp;
                lhs.SiSo = sisio;
                qlhv.SubmitChanges();
            }
        }
    }
}
