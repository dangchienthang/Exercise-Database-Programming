using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_XetNghiem
    {
        QuanLyPhongMachEntities db;

        public DAO_XetNghiem()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSXetNghiem()
        {
            var ds = db.XetNghiems.Select(s => new
            {
                s.MaXN,
                s.TenXN,
                s.LoaiXetNghiem.TenLXN,
                s.MoTa,
            }).ToList();
            return ds;
        }

        public dynamic LayDSLoaiXN()
        {
            var ds = db.LoaiXetNghiems.Select(s => new
            {
                s.MaLXN,
                s.TenLXN
            }).ToList();

            return ds;
        }

        public bool KTXetNghiem(XetNghiem xn)
        {
            XetNghiem x = db.XetNghiems.Find(xn.MaXN);
            if (x != null)
            {
                return true;
            }
            else
                return false;
        }

        public void ThemXN(XetNghiem x)
        {
            db.XetNghiems.Add(x);
            db.SaveChanges();
        }

        public void SuaXN(XetNghiem xn)
        {
            XetNghiem x = db.XetNghiems.Find(xn.MaXN);

            x.TenXN = xn.TenXN;
            x.MaLXN = xn.MaLXN;
            x.MoTa = xn.MoTa;

            db.SaveChanges();
        }

        public bool XoaXN(int maXN)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa xet nghiem co MaXN = maXN
                XetNghiem x = db.XetNghiems.Find(maXN);
                if (x != null)
                {
                    db.XetNghiems.Remove(x);
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

        public dynamic LayDSLoaiXetNghiem()
        {
            var ds = db.LoaiXetNghiems.Select(s => new
            {
                s.MaLXN,
                s.TenLXN,
            }).ToList();
            return ds;
        }

        public bool KTLoaiXetNghiem(LoaiXetNghiem lxn)
        {
            LoaiXetNghiem x = db.LoaiXetNghiems.Find(lxn.MaLXN);
            if (x != null)
            {
                return true;
            }
            else
                return false;
        }

        public void ThemLXN(LoaiXetNghiem x)
        {
            db.LoaiXetNghiems.Add(x);
            db.SaveChanges();
        }

        public void SuaLXN(LoaiXetNghiem xn)
        {
            LoaiXetNghiem x = db.LoaiXetNghiems.Find(xn.MaLXN);

            x.TenLXN = xn.TenLXN;

            db.SaveChanges();
        }

        public bool XoaLXN(int maLXN)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa loai xet nghiem co MaLXN = maLXN
                LoaiXetNghiem x = db.LoaiXetNghiems.Find(maLXN);
                if (x != null)
                {
                    db.LoaiXetNghiems.Remove(x);
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
