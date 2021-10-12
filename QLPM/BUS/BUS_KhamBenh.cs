﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPM.DAO;

namespace QLPM.BUS
{
    class BUS_KhamBenh
    {
        DAO_KhamBenh dPK;

        public BUS_KhamBenh()
        {
            dPK = new DAO_KhamBenh();
        }

        private DataTable InitDGPK()
        {
            DataTable dtPK = new DataTable();

            dtPK.Columns.Add("MaPK");
            dtPK.Columns.Add("MaBS");
            dtPK.Columns.Add("MaBN");
            dtPK.Columns.Add("NgayKham");
            dtPK.Columns.Add("TrieuChung");
            dtPK.Columns.Add("ChuanDoan");
            dtPK.Columns.Add("NgayTaiKham");

            return dtPK;
        }

        public void LayDSPhieuKham(DataGridView dg, int maBenhNhan, int maBacSi)
        {
            var ds = dPK.LayDSPhieuKhamID(maBenhNhan, maBacSi);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDGPK();
            }
        }

        public void LayDSTenBS(ComboBox cb)
        {
            cb.DataSource = dPK.LayDSTenBS();
            cb.DisplayMember = "HoTenBS";
            cb.ValueMember = "MaBS";
        }

        public void LayDSTenBN(ComboBox cb)
        {
            cb.DataSource = dPK.LayDSTenBN();
            cb.DisplayMember = "HoTenBN";
            cb.ValueMember = "MaBN";
        }

        public void LayDSLoaiXN(ComboBox cb)
        {
            cb.DataSource = dPK.LayDSLoaiXN();
            cb.DisplayMember = "TenLXN";
            cb.ValueMember = "MaLXN";
        }

        public bool TaoPhieuKham(PhieuKham pk)
        {
            try
            {
                dPK.ThemPhieuKham(pk);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaPhieuKham(PhieuKham pk)
        {
            if (dPK.KTPhieuKham(pk))
            {
                try
                {
                    dPK.SuaPhieuKham(pk);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public void XoaPhieuKham(int maPK)
        {
            if (dPK.XoaPhieuKham(maPK))
            {
                MessageBox.Show("Xóa phiếu khám thành công");
            }
            else
            {
                MessageBox.Show("Không thấy phiếu khám để xóa");
            }
        }

        private DataTable InitDG()
        {
            DataTable dtXN = new DataTable();

            dtXN.Columns.Add("MaXN");
            dtXN.Columns.Add("TenXN");
            dtXN.Columns.Add("MaBS");
            dtXN.Columns.Add("MaBN");
            dtXN.Columns.Add("MaLXN");

            return dtXN;
        }

        public void LayDSPhieuXetNghiem(DataGridView dg, int maBenhNhan, int maBacSi)
        {
            var ds = dPK.LayDSPhieuXetNghiem(maBenhNhan, maBacSi);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDG();
            }
        }

        public bool TaoPhieuXetNghiem(XetNghiem xn)
        {
            try
            {
                dPK.ThemPhieuXetNghiem(xn);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaPhieuXetNghiem(XetNghiem xn)
        {
            if (dPK.KTPhieuXetNghiem(xn))
            {
                try
                {
                    dPK.SuaPhieuXetNghiem(xn);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void XoaPhieuXetNghiem(int maXN)
        {
            if (dPK.XoaPhieuXetNGhiem(maXN))
            {
                MessageBox.Show("Xóa phiếu xét nghiệm thành công");
            }
            else
            {
                MessageBox.Show("Không thấy phiếu xét nghiệm để xóa");
            }
        }

        private DataTable InitDGToa()
        {
            DataTable dtTT = new DataTable();

            dtTT.Columns.Add("MaToa");
            dtTT.Columns.Add("NgayKeToa");
            dtTT.Columns.Add("MaBS");
            dtTT.Columns.Add("MaBN");

            return dtTT;
        }

        public void LayDSToa(DataGridView dg, int maBenhNhan, int maBacSi)
        {
            var ds = dPK.LayDSToaThuoc(maBenhNhan, maBacSi);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDGToa();
            }
        }

        public bool TaoToa(ToaThuoc t)
        {
            try
            {
                dPK.ThemToa(t);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaToa(ToaThuoc t)
        {
            if (dPK.KTToa(t))
            {
                try
                {
                    dPK.SuaToa(t);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void XoaToa(int maToa)
        {
            if (dPK.XoaToa(maToa))
            {
                MessageBox.Show("Xóa toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Không thấy toa thuốc để xóa");
            }
        }

        
    }
}