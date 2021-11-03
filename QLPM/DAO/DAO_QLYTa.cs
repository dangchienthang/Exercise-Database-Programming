using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAO
{
    class DAO_QLYTa
    {
        QuanLyPhongMachEntities db;

        public DAO_QLYTa()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSYTa()
        {
            var ds = db.YTas.Select(s => new
            {
                s.MaYT,
                s.HoTenYT,
                s.NgaySinh,
                s.LoaiGioiTinh.TenLoaiGT,
                s.DienThoai
            }).ToList();
            return ds;
        }

        public dynamic LayDSLoaiGioiTinh()
        {
            var ds = db.LoaiGioiTinhs.Select(s => new
            {
                s.MaLGT,
                s.TenLoaiGT
            }).ToList();

            return ds;
        }

        public void ThemYTa(YTa yta)
        {
            db.YTas.Add(yta);
            db.SaveChanges();
        }

        public bool KTYTa(YTa yta)
        {
            YTa yt = db.YTas.Find(yta.MaYT);
            if (yt != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaYTa(YTa yta)
        {
            YTa yt = db.YTas.Find(yta.MaYT);

            yt.HoTenYT = yta.HoTenYT;
            yt.NgaySinh = yta.NgaySinh;
            yt.MaLGT = yta.MaLGT;
            yt.DienThoai = yta.DienThoai;
            yt.MaLNV = yta.MaLNV;

            db.SaveChanges();
        }

        public bool XoaYTa(int maYT)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa y ta co MaYT = maYT
                YTa yt = db.YTas.Find(maYT);
                if (yt != null)
                {
                    db.YTas.Remove(yt);
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

        public dynamic TimKiemYTa(string chuoi)
        {
            var ds = db.timKiemYTa(chuoi).Select(s => s).ToList();
            return ds;
        }

        public dynamic LayDSYT()
        {
            var ds = db.YTas.Select(s => s).ToList();

            return ds;
        }
    }
}