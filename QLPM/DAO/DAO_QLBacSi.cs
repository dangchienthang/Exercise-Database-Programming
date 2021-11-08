using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_QLBacSi
    {
        QuanLyPhongMachEntities db;

        public DAO_QLBacSi()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSBacSi()
        {
            var ds = db.BacSis.Select(s => new
            {
                s.MaBS,
                s.HoTenBS,
                s.GioiTinh,
                s.NgaySinh,
                s.DienThoai
            }).ToList();
            return ds;
        }

        public void ThemBacSi(BacSi bs)
        {
            db.BacSis.Add(bs);
            db.SaveChanges();
        }

        public bool KTBacSi(BacSi bacsi)
        {
            BacSi bs = db.BacSis.Find(bacsi.MaBS);
            if (bs != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaBacSi(BacSi bacsi)
        {
            BacSi bs = db.BacSis.Find(bacsi.MaBS);

            bs.HoTenBS = bacsi.HoTenBS;
            bs.GioiTinh = bacsi.GioiTinh;
            bs.NgaySinh = bacsi.NgaySinh;
            bs.DienThoai = bacsi.DienThoai;
            bs.MaLNV = bacsi.MaLNV;

            db.SaveChanges();
        }

        public bool XoaBacSi(int maBS)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa bac si co MaBS = maBS
                BacSi bs = db.BacSis.Find(maBS);
                if (bs != null)
                {
                    db.BacSis.Remove(bs);
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

        public dynamic TimKiemBacSi(string chuoi)
        {
            var ds = db.timKiemBacSi(chuoi).Select(s => s).ToList();
            return ds;
        }

        public dynamic LayDSBS()
        {
            var ds = db.BacSis.Select(s => s).ToList();

            return ds;
        }
    }
}