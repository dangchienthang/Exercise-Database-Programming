using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_LichKham
    {
        QuanLyPhongMachEntities db;

        public DAO_LichKham()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSBenhNhan()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.MaBN,
                s.HoTenBN,
                s.GioiTinh,
                s.NgaySinh,
                s.DienThoai,
                s.DiaChi
            }).ToList();
            return ds;
        }

        public dynamic LayDSLichKham()
        {
            var ds = db.LichKhams.Select(s => new
            {
                s.MaLK,
                s.BenhNhan.HoTenBN,
                s.YTa.HoTenYT,
                s.BacSi.HoTenBS,
                s.NgayHen,
            }).ToList();
            return ds;
        }

        public dynamic LayDSLK()
        {
            var ds = db.LichKhams.Select(s => s).ToList();
            return ds;
        }

        public dynamic LayDSTenBenhNhan()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.MaBN,
                s.HoTenBN,
            }).ToList();

            return ds;
        }

        public dynamic LayDSTenBacSi()
        {
            var ds = db.BacSis.Select(s => new
            {
                s.MaBS,
                s.HoTenBS,
            }).ToList();

            return ds;
        }

        public dynamic LayDSTenYTa()
        {
            var ds = db.YTas.Select(s => new
            {
                s.MaYT,
                s.HoTenYT,
            }).ToList();

            return ds;
        }

        public void ThemLichKham(LichKham lk)
        {
            db.LichKhams.Add(lk);
            db.SaveChanges();
        }

        public bool KTLichKham(LichKham lichkham)
        {
            LichKham lk = db.LichKhams.Find(lichkham.MaLK);
            if (lk != null)
            {
                return true;
            }
            else
                return false;
        }

        public bool KTBenhNhan(LichKham lichkham)
        {
            LichKham lk = db.LichKhams.Find(lichkham.MaBN);
            if (lk != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaLichKham(LichKham lichkham)
        {
            LichKham lk = db.LichKhams.Find(lichkham.MaLK);

            lk.MaBN = lichkham.MaBN;
            lk.MaBS = lichkham.MaBS;
            lk.MaYT = lichkham.MaYT;
            lk.NgayHen = lichkham.NgayHen;

            db.SaveChanges();
        }

        public bool XoaLichKham(int maLK)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa lich kham co MaLk = maLK
                LichKham lk = db.LichKhams.Find(maLK);
                if (lk != null)
                {
                    db.LichKhams.Remove(lk);
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

        public dynamic LayDSPXN()
        {
            var ds = db.XetNghiems.Select(s => new
            {
                s.MaXN,
                s.TenXN,
                s.LoaiXetNghiem.TenLXN,
                s.MoTa
            }).ToList();
            return ds;
        }

        public dynamic LayDSPhieuKham()
        {
            var ds = db.PhieuKhams.Select(s => new
            {
                s.MaPK,
                s.BacSi.HoTenBS,
                s.BenhNhan.HoTenBN,
                s.NgayKham,
                s.TrieuChung,
                s.ChuanDoan,
                s.NgayTaiKham
            }).ToList();
            return ds;
        }
    }
}
