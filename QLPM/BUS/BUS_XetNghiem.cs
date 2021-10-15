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
    class BUS_XetNghiem
    {
        DAO_XetNghiem dXN;

        public BUS_XetNghiem()
        {
            dXN = new DAO_XetNghiem();
        }

        public void LayDSXN(DataGridView dg)
        {
            dg.DataSource = dXN.LayDSXetNghiem();
        }

        public void LayDSLoaiXN(ComboBox cb)
        {
            cb.DataSource = dXN.LayDSLoaiXN();
            cb.DisplayMember = "TenLXN";
            cb.ValueMember = "MaLXN";
        }

        public bool ThemXN(XetNghiem x)
        {
            try
            {
                dXN.ThemXN(x);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaXN(XetNghiem x)
        {
            if (dXN.KTXetNghiem(x))
            {
                try
                {
                    dXN.SuaXN(x);
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

        public void XoaXN(int maXN)
        {
            if (dXN.XoaXN(maXN))
            {
                MessageBox.Show("Xóa xét nghiệm thành công");
            }
            else
            {
                MessageBox.Show("Không thấy xét nghiệm để xóa");
            }
        }

        public void LayDSLXN(DataGridView dg)
        {
            dg.DataSource = dXN.LayDSLoaiXetNghiem();
        }

        public bool ThemLXN(LoaiXetNghiem x)
        {
            try
            {
                dXN.ThemLXN(x);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaLXN(LoaiXetNghiem x)
        {
            if (dXN.KTLoaiXetNghiem(x))
            {
                try
                {
                    dXN.SuaLXN(x);
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

        public void XoaLXN(int maLXN)
        {
            if (dXN.XoaLXN(maLXN))
            {
                MessageBox.Show("Xóa loại xét nghiệm thành công");
            }
            else
            {
                MessageBox.Show("Không thấy loại xét nghiệm để xóa");
            }
        }
    }
}
