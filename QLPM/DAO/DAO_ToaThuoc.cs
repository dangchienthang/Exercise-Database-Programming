using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_ToaThuoc
    {
        QuanLyPhongMachEntities db;

        public DAO_ToaThuoc()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSToaThuoc()
        {
            var ds = db.ToaThuocs.Select(s => new
            {
                s.MaToa,
                s.NgayKeToa,
                s.BacSi.HoTenBS,
                s.BenhNhan.HoTenBN,
            }).ToList();
            return ds;
        }

        public dynamic LayDSBacSi()
        {
            var ds = db.BacSis.Select(s => new
            {
                s.MaBS,
                s.HoTenBS
            }).ToList();

            return ds;
        }

        public dynamic LayDSBenhNhan()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.MaBN,
                s.HoTenBN
            }).ToList();

            return ds;
        }

        public bool KTToaThuoc(ToaThuoc tt)
        {
            ToaThuoc toa = db.ToaThuocs.Find(tt.MaToa);
            if (toa != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaToaThuoc(ToaThuoc tt)
        {
            ToaThuoc toa = db.ToaThuocs.Find(tt.MaToa);

            toa.NgayKeToa = tt.NgayKeToa;
            toa.MaBS = tt.MaBS;
            toa.MaBN = tt.MaBN;

            db.SaveChanges();
        }

        public bool XoaToaThuoc(int maToa)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa toa thuoc co MaToa = maToa
                ToaThuoc t = db.ToaThuocs.Find(maToa);
                if (t != null)
                {
                    db.ToaThuocs.Remove(t);
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
    }
}
