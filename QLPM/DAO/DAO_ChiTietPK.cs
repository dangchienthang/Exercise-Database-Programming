using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_ChiTietPK
    {
        QuanLyPhongMachEntities db;

        public DAO_ChiTietPK()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSCTPK(int maPK)
        {
            var ds = db.XetNghiem_PhieuKham.Where(s => s.MaPK == maPK)
                .Select(s => new
                {
                    s.MaPK,
                    s.MaXN,
                    s.NgayXN,
                    s.NgayHenLayKQ,
                    s.YeuCauXN,
                    s.KetQuaXN,
                }).ToList();

            return ds;
        }

        public bool SuaCTPK(XetNghiem_PhieuKham x)
        {
            bool tinhTrang = false;
            try
            {
                XetNghiem_PhieuKham xn = db.XetNghiem_PhieuKham.First(s => s.MaPK == x.MaPK && s.MaXN == x.MaXN);

                xn.NgayXN = x.NgayXN;
                xn.NgayHenLayKQ = x.NgayHenLayKQ;
                xn.YeuCauXN = x.YeuCauXN;
                xn.KetQuaXN = x.KetQuaXN;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool XoaCTPK(int maPK, int maXN)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa chi tiet phieu kham co MaPK = maPK va MaXN = maXN
                XetNghiem_PhieuKham x = db.XetNghiem_PhieuKham.Single(s => s.MaPK == maPK && s.MaXN == maXN);
                db.XetNghiem_PhieuKham.Remove(x);
                db.SaveChanges();

                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool ThemDanhSachCTPK(List<XetNghiem_PhieuKham> ds)
        {
            bool tinhTrang = true;
            try
            {
                db.XetNghiem_PhieuKham.AddRange(ds);
                db.SaveChanges();

                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
                throw;
            }

            return tinhTrang;
        }

        public dynamic LayDSXN()
        {
            var ds = db.XetNghiems.Select(s => s
            ).ToList();
            return ds;
        }

        public XetNghiem LayThongTinXetNghiem(int maXN)
        {
            XetNghiem xetNghiem = db.XetNghiems.FirstOrDefault(s => s.MaXN == maXN);

            return xetNghiem;
        }

        public bool KiemTraXetNghiem(XetNghiem_PhieuKham xn)
        {
            int? sl;
            sl = db.KiemTraXetNghiem(xn.MaPK, xn.MaXN).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;
        }

        public void ThemChiTietPhieuKham(XetNghiem_PhieuKham x)
        {
            db.XetNghiem_PhieuKham.Add(x);
            db.SaveChanges();
        }
    }
}
