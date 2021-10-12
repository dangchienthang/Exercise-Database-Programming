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
    public partial class FKeToa : Form
    {
        public int MaToa;

        BUS_ChiTietToa busToa;

        bool co = false;
        DataTable dtToaThuoc;

        public FKeToa()
        {
            InitializeComponent();
            busToa = new BUS_ChiTietToa();
        }

        private void FKeToa_Load(object sender, EventArgs e)
        {
            txtMaToa.Text = MaToa.ToString();

            busToa.LayDSThuoc(cbThuoc);
            co = true;

            dtToaThuoc = new DataTable();

            dtToaThuoc.Columns.Add("MaThuoc");
            dtToaThuoc.Columns.Add("SoLuong");
            dtToaThuoc.Columns.Add("LieuDung");
            dGToa.DataSource = dtToaThuoc;

            dGToa.Columns[0].Width = (int)(0.2 * dGToa.Width);
            dGToa.Columns[1].Width = (int)(0.3 * dGToa.Width);
            dGToa.Columns[2].Width = (int)(0.5 * dGToa.Width);
        }

        void HienThiThongTinThuoc(string maThuoc)
        {
            int ma = int.Parse(maThuoc);
            Thuoc t = busToa.HienThiDSThuoc(ma);
            txtMaThuoc.Text = t.MaThuoc.ToString();
        }

        private void cbThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                HienThiThongTinThuoc(cbThuoc.SelectedValue.ToString());
            }
        }

        private void dGToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGToa.Rows.Count)
            {
                cbThuoc.SelectedIndex = int.Parse(dGToa.Rows[e.RowIndex].Cells["MaThuoc"].Value.ToString()) - 1;
                numSoLuong.Text = dGToa.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                txtLieuDung.Text = dGToa.Rows[e.RowIndex].Cells["LieuDung"].Value.ToString();
            }
        }

        private void btThemTT_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;
            // duyet tung dong trong datatable
            // neu maSP co, tang so luong, chua co
            // them dong moi

            foreach (DataRow item in dtToaThuoc.Rows)
            {
                if (item[0].ToString() == cbThuoc.SelectedValue.ToString()) //co maThuoc hay ko
                {
                    kiemtra = false;
                    // tang so luong
                    item[1] = int.Parse(item[1].ToString()) + int.Parse(numSoLuong.Value.ToString());
                    break;
                }
            }

            if (kiemtra)
            {
                DataRow r = dtToaThuoc.NewRow();

                r[0] = cbThuoc.SelectedValue.ToString();
                r[1] = numSoLuong.Value.ToString();
                r[2] = txtLieuDung.Text;

                dtToaThuoc.Rows.Add(r);
            }
        }

        private void btSuaTT_Click(object sender, EventArgs e)
        {
            int dem = -1;
            foreach (DataRow item in dtToaThuoc.Rows)
            {
                dem++;
                if (dem == dGToa.CurrentCell.RowIndex)
                {
                    item[1] = int.Parse(numSoLuong.Value.ToString()); ;
                    item[2] = txtLieuDung.Text;
                    break;
                }
            }
        }

        private void btXoaTT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dGToa.SelectedCells)
            {
                if (c.Selected)
                    dGToa.Rows.RemoveAt(c.RowIndex);
            }

        }

        private void btTaoToa_Click(object sender, EventArgs e)
        {
            if (busToa.ThemToa(MaToa, dtToaThuoc))
            {
                MessageBox.Show("Đặt hàng thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Đặt hàng thất bại");
            }
        }
    }
}
