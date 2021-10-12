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
    class BUS_QLThuoc
    {
        DAO_QLThuoc dThuoc;

        public BUS_QLThuoc()
        {
            dThuoc = new DAO_QLThuoc();
        }

        public void LayDSThuoc(DataGridView dg)
        {
            dg.DataSource = dThuoc.LayDSThuoc();
        }

        public bool TaoThuoc(Thuoc t)
        {
            try
            {
                dThuoc.ThemThuoc(t);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaThuoc(Thuoc t)
        {
            if (dThuoc.KTThuoc(t))
            {
                try
                {
                    dThuoc.SuaThuoc(t);
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

        public void XoaThuoc(int maThuoc)
        {
            if (dThuoc.XoaThuoc(maThuoc))
            {
                MessageBox.Show("Xóa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Không thấy thuốc để xóa");
            }
        }
    }
}
