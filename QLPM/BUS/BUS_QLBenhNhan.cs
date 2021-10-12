using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPM.BUS
{
    class BUS_QLBenhNhan
    {
        DAO_QLBenhNhan dBenhNhan;

        public BUS_QLBenhNhan()
        {
            dBenhNhan = new DAO_QLBenhNhan();
        }

        public void LayDSBenhNhan(DataGridView dg)
        {
            dg.DataSource = dBenhNhan.LayDSBenhNhan();
        }

        public void LayDSLoaiGioiTinh(ComboBox cb)
        {
            cb.DataSource = dBenhNhan.LayDSLoaiGioiTinh();
            cb.DisplayMember = "TenLoaiGT";
            cb.ValueMember = "MaLGT";
        }

        public bool TaoBenhNhan(BenhNhan bn)
        {
            try
            {
                dBenhNhan.ThemBenhNhan(bn);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaBenhNhan(BenhNhan benhnhan)
        {
            if (dBenhNhan.KTBenhNhan(benhnhan))
            {
                try
                {
                    dBenhNhan.SuaBenhNhan(benhnhan);
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

        public void XoaBenhNhan(int maBN)
        {
            if (dBenhNhan.XoaBenhNhan(maBN))
            {
                MessageBox.Show("Xóa bệnh nhân thành công");
            }
            else
            {
                MessageBox.Show("Không thấy bệnh nhân để xóa");
            }
        }
    }
}
