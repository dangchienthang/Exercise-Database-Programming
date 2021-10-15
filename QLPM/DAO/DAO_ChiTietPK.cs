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

        public void ThemCT(XetNghiem_PhieuKham x)
        {
            db.XetNghiem_PhieuKham.Add(x);
            db.SaveChanges();
        }

        public bool KT(XetNghiem_PhieuKham x)
        {
            XetNghiem_PhieuKham xn = db.XetNghiem_PhieuKham.Find(x.MaPK);
            if (xn != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaCT(XetNghiem_PhieuKham xetNghiem)
        {
            XetNghiem_PhieuKham x = db.XetNghiem_PhieuKham.Find(xetNghiem.MaPK);

            x.MaXN = xetNghiem.MaXN;
            x.NgayXN = xetNghiem.NgayXN;
            x.NgayHenLayKQ = xetNghiem.NgayHenLayKQ;
            x.YeuCauXN = xetNghiem.YeuCauXN;
            x.KetQuaXN = xetNghiem.KetQuaXN;

            db.SaveChanges();
        }

        public bool XoaCT(int maPK)
        {
            bool tinhTrang = true;
            try
            {
                XetNghiem_PhieuKham x = db.XetNghiem_PhieuKham.Find(maPK);
                if (x != null)
                {
                    db.XetNghiem_PhieuKham.Remove(x);
                    db.SaveChanges();

                    tinhTrang = true;
                }
                else
                    tinhTrang = false;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public dynamic LayDSXN()
        {
            var ds = db.XetNghiems.Select(s => new
            {
                s.MaXN,
                s.TenXN,
                s.MoTa
            }).ToList();
            return ds;
        }

        public XetNghiem LayThongTinXN(int maXN)
        {
            XetNghiem xetNghiem = db.XetNghiems.FirstOrDefault(s => s.MaXN == maXN);

            return xetNghiem;
        }
    }
}
