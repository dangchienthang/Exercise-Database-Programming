using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPM.DAO;

namespace QLPM.BUS
{
    class BUS_QLBacSi
    {
        DAO_QLBacSi dBacSi;

        public BUS_QLBacSi()
        {
            dBacSi = new DAO_QLBacSi();
        }

        public void LayDSBacSi(DataGridView dg)
        {
            dg.DataSource = dBacSi.LayDSBacSi();
        }

        public void LayDSLoaiGioiTinh(ComboBox cb)
        {
            cb.DataSource = dBacSi.LayDSLoaiGioiTinh();
            cb.DisplayMember = "TenLoaiGT";
            cb.ValueMember = "MaLGT";
        }

        public bool TaoBacSi(BacSi bs)
        {
            try
            {
                dBacSi.ThemBacSi(bs);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaBacSi(BacSi bacsi)
        {
            if (dBacSi.KTBacSi(bacsi))
            {
                try
                {
                    dBacSi.SuaBacSi(bacsi);
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

        public void XoaBacSi(int maBS)
        {
            if (dBacSi.XoaBacSi(maBS))
            {
                MessageBox.Show("Xóa bác sĩ thành công");
            }
            else
            {
                MessageBox.Show("Không thấy bác sĩ để xóa");
            }
        }
    }
}
