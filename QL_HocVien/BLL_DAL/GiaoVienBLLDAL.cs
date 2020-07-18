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
        public void ThemGiaoVien(String magv,String tengv,String gioitinh, DateTime ngaysinh, String dienthoai,String email,String diachi)
        {
            GiangVien gv = new GiangVien();
            gv.MaGV = magv;
            gv.TenGV = tengv;
            gv.GioiTinh = gioitinh;
            gv.NgaySinh = ngaysinh;
            gv.SoDienThoai = dienthoai;
            gv.Email = email;
            gv.DiaChi = diachi;
            qlhv.GiangViens.InsertOnSubmit(gv);
            qlhv.SubmitChanges();
        }
        public void XoaGiaoVien(String magv)
        {
            GiangVien gvs = qlhv.GiangViens.Where(d => d.MaGV == magv).FirstOrDefault();
            if (gvs != null)
            {

                qlhv.GiangViens.DeleteOnSubmit(gvs);
                qlhv.SubmitChanges();
            }
        }
        public void SuaGiaoVien(String magv, String tengv, String gioitinh, DateTime ngaysinh, String dienthoai, String email, String diachi)
        {
            GiangVien gvs = qlhv.GiangViens.Where(d => d.MaGV == magv).FirstOrDefault();
            if (gvs != null)
            {
                gvs.TenGV = tengv;
                gvs.GioiTinh = gioitinh;
                gvs.NgaySinh = ngaysinh;
                gvs.SoDienThoai = dienthoai;
                gvs.Email = email;
                gvs.DiaChi = diachi;
                qlhv.SubmitChanges();
            }
        }
        public bool kiemTraKhoaChinh(string chuoi)
        {
            GiangVien gv = qlhv.GiangViens.Where(t => t.MaGV == chuoi).FirstOrDefault();
            if (gv != null)
                return false;
            return true;
        }
    }
}
