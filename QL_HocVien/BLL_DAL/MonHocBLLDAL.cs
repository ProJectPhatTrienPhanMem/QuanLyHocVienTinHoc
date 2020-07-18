using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class MonHocBLLDAL
    {
       QLHVDataContext qlhv = new QLHVDataContext();
       public MonHocBLLDAL()
       {

       }
       public IQueryable<MONHOC> loadMon()
       {
           return qlhv.MONHOCs.Select(k => k);

       }
       public void ThemMon(String mamh, String tenmh, String magv)
       {
           MONHOC mh = new MONHOC();
           mh.MaMH = mamh;
           mh.TenMH = tenmh;
           mh.MaGV = magv;
           qlhv.MONHOCs.InsertOnSubmit(mh);
           qlhv.SubmitChanges();
       }
       public void XoaMon(String mamh)
       {
           MONHOC mhs = qlhv.MONHOCs.Where(d => d.MaMH == mamh).FirstOrDefault();
           if (mhs != null)
           {

               qlhv.MONHOCs.DeleteOnSubmit(mhs);
               qlhv.SubmitChanges();
           }
       }
       public void SuaMon(String mamh, String tenmh, String magv)
       {
           MONHOC mhs = qlhv.MONHOCs.Where(d => d.MaMH == mamh).FirstOrDefault();
           if (mhs != null)
           {
               mhs.MaMH = mamh;
               mhs.TenMH = tenmh;
               mhs.MaGV = magv;
               qlhv.SubmitChanges();
           }
       }
    }
}
