using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_ChiTIetToa
    {
        QuanLyPhongMachEntities db;

        public DAO_ChiTIetToa()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSCTT(int maToa)
        {
            var ds = db.ChiTietToaThuocs.Where(s => s.MaToa == maToa)
                .Select(s => new
                {
                    s.MaToa,
                    s.MaThuoc,
                    s.SoLuong,
                    s.LieuDung
                }).ToList();

            return ds;
        }

        public bool SuaCTT(ChiTietToaThuoc c)
        {
            bool tinhTrang = false;
            try
            {
                ChiTietToaThuoc ct = db.ChiTietToaThuocs.First(s => s.MaToa == c.MaToa && s.MaThuoc == c.MaThuoc);

                ct.SoLuong = c.SoLuong;
                ct.LieuDung = c.LieuDung;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool XoaCTT(int maToa, int maThuoc)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa chi tiet toa thuoc co MaToa = maToa va MaThuoc = maThuoc
                ChiTietToaThuoc c = db.ChiTietToaThuocs.Single(s => s.MaToa == maToa && s.MaThuoc == maThuoc);
                db.ChiTietToaThuocs.Remove(c);
                db.SaveChanges();

                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool ThemDanhSachCTT(List<ChiTietToaThuoc> ds)
        {
            bool tinhTrang = true;
            try
            {
                db.ChiTietToaThuocs.AddRange(ds);
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

        public dynamic LayDSThuoc()
        {
            var ds = db.Thuocs.Select(s => new
            {
                s.MaThuoc,
                s.TenThuoc,
                s.MoTa
            }).ToList();
            return ds;
        }

        public Thuoc LayThongTinThuoc(int maThuoc)
        {
            Thuoc thuoc = db.Thuocs.FirstOrDefault(s => s.MaThuoc == maThuoc);

            return thuoc;
        }

        public bool KiemTraThuoc(ChiTietToaThuoc c)
        {
            int? sl;
            sl = db.sp_KiemTraThuoc(c.MaToa, c.MaThuoc).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;
        }

        public void ThemToa(ChiTietToaThuoc c)
        {
            db.ChiTietToaThuocs.Add(c);
            db.SaveChanges();
        }
    }
}
