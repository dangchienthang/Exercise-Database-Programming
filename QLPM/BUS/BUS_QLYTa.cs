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
    class BUS_QLYTa
    {
        DAO_QLYTa dYTa;

        public BUS_QLYTa()
        {
            dYTa = new DAO_QLYTa();
        }

        public void LayDSYTa(DataGridView dg)
        {
            dg.DataSource = dYTa.LayDSYTa();
        }

        public void LayDSLoaiGioiTinh(ComboBox cb)
        {
            cb.DataSource = dYTa.LayDSLoaiGioiTinh();
            cb.DisplayMember = "TenLoaiGT";
            cb.ValueMember = "MaLGT";
        }

        public bool TaoYTa(YTa yt)
        {
            try
            {
                dYTa.ThemYTa(yt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaYTa(YTa yta)
        {
            if (dYTa.KTYTa(yta))
            {
                try
                {
                    dYTa.SuaYTa(yta);
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

        public void XoaYTa(int maYT)
        {
            if (dYTa.XoaYTa(maYT))
            {
                MessageBox.Show("Xóa y tá thành công");
            }
            else
            {
                MessageBox.Show("Không thấy y tá để xóa");
            }
        }
    }
}
