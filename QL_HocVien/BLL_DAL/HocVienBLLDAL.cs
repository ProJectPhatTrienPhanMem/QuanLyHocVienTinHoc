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
        public void ThemHocVien(String mahv, String tenhv, String gioitinh, DateTime ngaysinh, String dienthoai, String diachi, String malh)
        {
            HOCVIEN hv = new HOCVIEN();
            hv.MaHV = mahv;
            hv.TenHV = tenhv;
            hv.GioiTinh = gioitinh;
            hv.NgaySinh = ngaysinh;
            hv.DienThoai = dienthoai;
            hv.DiaChi = diachi;
            hv.MaLH = malh;
            qlhv.HOCVIENs.InsertOnSubmit(hv);
            qlhv.SubmitChanges();
        }
        public void XoaHocVien(String mahv)
        {
            HOCVIEN hvs = qlhv.HOCVIENs.Where(d => d.MaHV == mahv).FirstOrDefault();
            if (hvs != null)
            {

                qlhv.HOCVIENs.DeleteOnSubmit(hvs);
                qlhv.SubmitChanges();
            }
        }
        public void SuaHocVien(String mahv, String tenhv, String gioitinh, DateTime ngaysinh, String dienthoai, String diachi, String malh)
        {
            HOCVIEN hvs = qlhv.HOCVIENs.Where(d => d.MaHV == mahv).FirstOrDefault();
            if (hvs != null)
            {
                hvs.TenHV = tenhv;
                hvs.GioiTinh = gioitinh;
                hvs.NgaySinh = ngaysinh;
                hvs.DienThoai = dienthoai;
                hvs.DiaChi = diachi;
                hvs.MaLH = malh;
                qlhv.SubmitChanges();
            }
        }

    }
}
