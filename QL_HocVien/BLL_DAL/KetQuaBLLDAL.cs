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
        public void ThemKetQua(String mahv, String mamh, double diem, String trangthai)
        {
            KetQua kq = new KetQua();
            kq.MaHV = mahv;
            kq.MaMH = mamh;
            kq.Diem = diem;
            kq.TrangThai = trangthai;
            qlhv.KetQuas.InsertOnSubmit(kq);
            qlhv.SubmitChanges();
        }
        public void XoaKetQua(String mahv)
        {
            KetQua kqs = qlhv.KetQuas.Where(d => d.MaHV == mahv).FirstOrDefault();
            if (kqs != null)
            {

                qlhv.KetQuas.DeleteOnSubmit(kqs);
                qlhv.SubmitChanges();
            }
        }
        public void SuaKetQua(String mahv, String mamh, double diem, String trangthai)
        {
            KetQua kqs = qlhv.KetQuas.Where(d => d.MaHV == mahv).FirstOrDefault();
            if (kqs != null)
            {
                kqs.MaHV = mahv;
                kqs.MaMH = mamh;
                kqs.Diem = diem;
                kqs.TrangThai = trangthai;
                qlhv.SubmitChanges();
            }
        }
    }
}
