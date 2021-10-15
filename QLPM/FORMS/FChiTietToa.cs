using QLPM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPM
{
    public partial class FChiTietToa : Form
    {
        public int MaToa;

        BUS_ChiTietToa busToa;

        public FChiTietToa()
        {
            InitializeComponent();
            busToa = new BUS_ChiTietToa();
        }

        private void HienThiDSToa()
        {
            gVToa.DataSource = null;
            busToa.HienThiDSCTDH(gVToa, MaToa);
            gVToa.Columns[0].Width = (int)(0.2 * gVToa.Width);
            gVToa.Columns[1].Width = (int)(0.2 * gVToa.Width);
            gVToa.Columns[2].Width = (int)(0.3 * gVToa.Width);
            gVToa.Columns[3].Width = (int)(0.3 * gVToa.Width);
        }

        public void CapNhatDG()
        {
            txtMaToa.Text = "";
            txtMaThuoc.Text = "";
            txtSL.Text = "";
            txtLD.Text = "";
            HienThiDSToa();
        }

        private void FCTToaThuoc_Load(object sender, EventArgs e)
        {
            txtMaToa.Text = MaToa.ToString();
        }

        private void btSuaTT_Click(object sender, EventArgs e)
        {
            if (txtMaToa.Text == "" || txtMaThuoc.Text == "" || txtSL.Text == "" || txtLD.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                ChiTietToaThuoc c = new ChiTietToaThuoc();

                c.MaToa = int.Parse(txtMaToa.Text);
                c.MaThuoc = int.Parse(txtMaThuoc.Text);
                c.SoLuong = short.Parse(txtSL.Text);
                c.LieuDung = txtLD.Text;

                busToa.SuaCTT(c);
                CapNhatDG();
            }
        }

        private void btXoaTT_Click(object sender, EventArgs e)
        {
            if (txtMaToa.Text == "" || txtMaThuoc.Text == "" || txtSL.Text == "" || txtLD.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                int maToa = int.Parse(gVToa.CurrentRow.Cells["MaToa"].Value.ToString());
                int maThuoc = int.Parse(gVToa.CurrentRow.Cells["MaThuoc"].Value.ToString());
                busToa.XoaCTT(maToa, maThuoc);
                // load lại data
                CapNhatDG();
            }
        }

        private void btThemTT_Click(object sender, EventArgs e)
        {
            FKeToa f = new FKeToa();
            f.MaToa = MaToa;
            f.ShowDialog();
        }

        private void gVToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVToa.Rows.Count)
            {
                txtMaToa.Text = gVToa.Rows[e.RowIndex].Cells["MaToa"].Value.ToString();
                txtMaThuoc.Text = gVToa.Rows[e.RowIndex].Cells["MaThuoc"].Value.ToString();
                txtSL.Text = gVToa.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                txtLD.Text = gVToa.Rows[e.RowIndex].Cells["LieuDung"].Value.ToString();
            }
        }

        private void FCTToaThuoc_Activated(object sender, EventArgs e)
        {
            HienThiDSToa();
        }
    }   
}
