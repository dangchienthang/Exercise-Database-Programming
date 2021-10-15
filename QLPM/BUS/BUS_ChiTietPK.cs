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
    class BUS_ChiTietPK
    {
        DAO_ChiTietPK dCTPK;

        public BUS_ChiTietPK()
        {
            dCTPK = new DAO_ChiTietPK();
        }

        public void HienThiDSCTPK(DataGridView dg, int maPK)
        {
            dg.DataSource = dCTPK.LayDSCTPK(maPK);
        }

        public bool TaoCT(XetNghiem_PhieuKham x)
        {
            try
            {
                dCTPK.ThemCT(x);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaCT(XetNghiem_PhieuKham x)
        {
            if (dCTPK.KT(x))
            {
                try
                {
                    dCTPK.SuaCT(x);
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

        public void XoaCT(int maPK)
        {
            if (dCTPK.XoaCT(maPK))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không thấy phiếu để xóa");
            }
        }

        public void LayDSXN(ComboBox cb)
        {
            cb.DataSource = dCTPK.LayDSXN();
            cb.DisplayMember = "TenXN";
            cb.ValueMember = "MaXN";
        }

        public XetNghiem HienThiDSXN(int maXN)
        {
            var t = dCTPK.LayThongTinXN(maXN);

            return t;
        }
    }
}
