using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_KhamBenh
    {
        QuanLyPhongMachEntities db;

        public DAO_KhamBenh()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSPhieuKhamID(int maBenhNhan, int maBacSi)
        {
            var ds = db.PhieuKhams.Where(s => s.MaBN == maBenhNhan && s.MaBS == maBacSi).Select(s => new
            {
                s.MaPK,
                s.MaBS,
                s.MaBN,
                s.NgayKham,
                s.TrieuChung,
                s.ChuanDoan,
                s.NgayTaiKham
            }).ToList();
            return ds;
        }

        public void ThemPhieuKham(PhieuKham pk)
        {
            db.PhieuKhams.Add(pk);
            db.SaveChanges();
        }

        public bool KTPhieuKham(PhieuKham phieukham)
        {
            PhieuKham pk = db.PhieuKhams.Find(phieukham.MaPK);
            if (pk != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaPhieuKham(PhieuKham phieukham)
        {
            PhieuKham pk = db.PhieuKhams.Find(phieukham.MaPK);

            pk.MaBS = phieukham.MaBS;
            pk.MaBN = phieukham.MaBN;
            pk.NgayKham = phieukham.NgayKham;
            pk.TrieuChung = phieukham.TrieuChung;
            pk.ChuanDoan = phieukham.ChuanDoan;
            pk.NgayTaiKham = phieukham.NgayTaiKham;

            db.SaveChanges();
        }

        public bool XoaPhieuKham(int maPK)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa phieu kham co MaPK = maPK
                PhieuKham pk = db.PhieuKhams.Find(maPK);
                if (pk != null)
                {
                    db.PhieuKhams.Remove(pk);
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

        public dynamic LayDSToaThuoc(int maBenhNhan, int maBacSi)
        {
            var ds = db.ToaThuocs.Where(s => s.MaBS == maBacSi && s.MaBN == maBenhNhan).Select(s => new
            {
                s.MaToa,
                s.NgayKeToa,
                s.MaBS,
                s.MaBN
            }).ToList();
            return ds;
        }

        public void ThemToa(ToaThuoc t)
        {
            db.ToaThuocs.Add(t);
            db.SaveChanges();
        }

        public bool KTToa(ToaThuoc toa)
        {
            ToaThuoc t = db.ToaThuocs.Find(toa.MaToa);
            if (t != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaToa(ToaThuoc toa)
        {
            ToaThuoc t = db.ToaThuocs.Find(toa.MaToa);

            t.MaBS = toa.MaBS;
            t.MaBN = toa.MaBN;
            t.NgayKeToa = toa.NgayKeToa;

            db.SaveChanges();
        }

        public bool XoaToa(int maToa)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa phieu kham co MaPK = maPK
                ToaThuoc toa = db.ToaThuocs.Find(maToa);
                if (toa != null)
                {
                    db.ToaThuocs.Remove(toa);
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

        public dynamic LayDSPK()
        {
            var ds = db.PhieuKhams.Select(s => s).ToList();
            return ds;
        }

        public dynamic LayDSBS()
        {
            var ds = db.BacSis.Select(s => new
            {
                s.MaBS,
                s.HoTenBS
            }).ToList();

            return ds;
        }

        public dynamic LayDSBN()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.MaBN,
                s.HoTenBN
            }).ToList();

            return ds;
        }
    }
}
