using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_QLThuoc
    {
        QuanLyPhongMachEntities db;

        public DAO_QLThuoc()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSThuoc()
        {
            var ds = db.Thuocs.Select(s => new
            {
                s.MaThuoc,
                s.TenThuoc,
                s.MoTa,
            }).ToList();
            return ds;
        }

        public void ThemThuoc(Thuoc t)
        {
            db.Thuocs.Add(t);
            db.SaveChanges();
        }

        public bool KTThuoc(Thuoc t)
        {
            Thuoc thuoc = db.Thuocs.Find(t.MaThuoc);
            if (thuoc != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaThuoc(Thuoc t)
        {
            Thuoc thuoc = db.Thuocs.Find(t.MaThuoc);

            thuoc.TenThuoc = t.TenThuoc;
            thuoc.MoTa = t.MoTa;

            db.SaveChanges();
        }

        public bool XoaThuoc(int maThuoc)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa thuoc co MaThuoc = maThuoc
                Thuoc t = db.Thuocs.Find(maThuoc);
                if (t != null)
                {
                    db.Thuocs.Remove(t);
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
