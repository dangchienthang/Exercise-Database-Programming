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
    class BUS_ToaThuoc
    {
        DAO_ToaThuoc dToa;

        public BUS_ToaThuoc()
        {
            dToa = new DAO_ToaThuoc();
        }

        public void LayDSToaThuoc(DataGridView dg)
        {
            dg.DataSource = dToa.LayDSToaThuoc();
        }

        public void LayDSBacSi(ComboBox cb)
        {
            cb.DataSource = dToa.LayDSBacSi();
            cb.DisplayMember = "HoTenBS";
            cb.ValueMember = "MaBS";
        }

        public void LayDSBenhNhan(ComboBox cb)
        {
            cb.DataSource = dToa.LayDSBenhNhan();
            cb.DisplayMember = "HoTenBN";
            cb.ValueMember = "MaBN";
        }

        public bool SuaToa(ToaThuoc toa)
        {
            if (dToa.KTToaThuoc(toa))
            {
                try
                {
                    dToa.SuaToaThuoc(toa);
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
            if (dToa.XoaToaThuoc(maToa))
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
