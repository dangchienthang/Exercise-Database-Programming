using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.BUS
{
    class DAO_QLBenhNhan
    {
        QuanLyPhongMachEntities db;

        public DAO_QLBenhNhan()
        {
            db = new QuanLyPhongMachEntities();
        }

        public dynamic LayDSBenhNhan()
        {
            var ds = db.BenhNhans.Select(s => new
            {
                s.MaBN,
                s.HoTenBN,
                s.NgaySinh,
                s.LoaiGioiTinh.TenLoaiGT,
                s.DienThoai,
                s.DiaChi
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

        public void ThemBenhNhan(BenhNhan bn)
        {
            db.BenhNhans.Add(bn);
            db.SaveChanges();
        }

        public bool KTBenhNhan(BenhNhan benhnhan)
        {
            BenhNhan bn = db.BenhNhans.Find(benhnhan.MaBN);
            if (bn != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaBenhNhan(BenhNhan benhnhan)
        {
            BenhNhan bn = db.BenhNhans.Find(benhnhan.MaBN);

            bn.HoTenBN = benhnhan.HoTenBN;
            bn.NgaySinh = benhnhan.NgaySinh;
            bn.MaLGT = benhnhan.MaLGT;
            bn.DienThoai = benhnhan.DienThoai;
            bn.DiaChi = benhnhan.DiaChi;

            db.SaveChanges();
        }

        public bool XoaBenhNhan(int maBN)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa bac si co MaBS = maBS
                BenhNhan bn = db.BenhNhans.Find(maBN);
                if (bn != null)
                {
                    db.BenhNhans.Remove(bn);
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
