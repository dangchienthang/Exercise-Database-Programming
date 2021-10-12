using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_CTPhieuXetNghiem
    {
        QuanLyPhongMachEntities db;

        public DAO_CTPhieuXetNghiem()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSCTPhieu()
        {
            var ds = db.XetNghiem_PhieuKham.Select(s => new
            {
                s.MaPK,
                s.MaXN,
                s.NgayXN,
                s.YeuCauXN,
                s.KetQuaXN,
                s.NgayHenLayKQ
            }).ToList();
            return ds;
        }

        public dynamic LayDSTenBS()
        {
            var ds = db.BacSis.Select(s => new
            {
                s.MaBS,
                s.HoTenBS
            }).ToList();

            return ds;
        }

        public dynamic LayDSTenBN()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.MaBN,
                s.HoTenBN
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

        public dynamic LayDSPhieuXetNghiem()
        {
            var ds = db.XetNghiems.Select(s => new
            {
                s.MaXN,
                s.TenXN,
                s.BacSi.HoTenBS,
                s.BenhNhan.HoTenBN,
                s.LoaiXetNghiem.MaLXN
            }).ToList();
            return ds;
        }
    }
}
