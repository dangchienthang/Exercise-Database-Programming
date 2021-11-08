using QLPM.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPM.BUS
{
    class BUS_LichKham
    {
        DAO_LichKham dLK;

        public BUS_LichKham()
        {
            dLK = new DAO_LichKham();
        }

        public void LayDSBenhNhan(DataGridView dg)
        {
            dg.DataSource = dLK.LayDSBenhNhan();
        }

        public void LayDSLichKham(DataGridView dg)
        {
            dg.DataSource = dLK.LayDSLichKham();
        }

        public void LayDSLK(DataGridView dg)
        {
            dg.DataSource = dLK.LayDSLK();
        }

        public void LayDSTenBenhNhan(ComboBox cb)
        {
            cb.DataSource = dLK.LayDSTenBenhNhan();
            cb.DisplayMember = "HoTenBN";
            cb.ValueMember = "MaBN";
        }

        public void LayDSTenBacSi(ComboBox cb)
        {
            cb.DataSource = dLK.LayDSTenBacSi();
            cb.DisplayMember = "HoTenBS";
            cb.ValueMember = "MaBS";
        }

        public void LayDSTenYTa(ComboBox cb)
        {
            cb.DataSource = dLK.LayDSTenYTa();
            cb.DisplayMember = "HoTenYT";
            cb.ValueMember = "MaYT";
        }

        public bool TaoLichKham(LichKham lk)
        {
            try
            {
                dLK.ThemLichKham(lk);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaLichKham(LichKham lichkham)
        {
            if (dLK.KTLichKham(lichkham))
            {
                try
                {
                    dLK.SuaLichKham(lichkham);
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

        public void XoaLichKham(int maLK)
        {
            if (dLK.XoaLichKham(maLK))
            {
                MessageBox.Show("Xóa lịch khám thành công");
            }
            else
            {
                MessageBox.Show("Không thấy lịch khám để xóa");
            }
        }

        public void LayDSPXN(DataGridView dg)
        {
            dg.DataSource = dLK.LayDSPXN();
        }

        public void LayDSPhieuKham(DataGridView dg)
        {
            dg.DataSource = dLK.LayDSPhieuKham();
        }
    }
}
