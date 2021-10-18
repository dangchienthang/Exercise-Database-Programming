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
    public partial class FBS_XetNghiem : Form
    {
        public int MaPK;

        bool co = false;
        DataTable dtCTPK;

        BUS_ChiTietPK busCTPK;

        public FBS_XetNghiem()
        {
            InitializeComponent();
            busCTPK = new BUS_ChiTietPK();
        }

        private void FBS_XetNghiem_Load(object sender, EventArgs e)
        {
            txtMaPK.Text = MaPK.ToString();

            busCTPK.LayDSXN(cbTenXN);
            co = true;

            dtCTPK = new DataTable();

            dtCTPK.Columns.Add("MaXN");
            dtCTPK.Columns.Add("NgayXN");
            dtCTPK.Columns.Add("NgayHenLayKQ");
            dtCTPK.Columns.Add("YeuCauXN");
            dtCTPK.Columns.Add("KetQuaXN");
            gVCTPK.DataSource = dtCTPK;

            gVCTPK.Columns[0].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[1].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[2].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[3].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[4].Width = (int)(0.2 * gVCTPK.Width);
        }

        void HienThiThongTinXetNghiem(string maXN)
        {
            int m = int.Parse(maXN);
            XetNghiem x = busCTPK.HienThiDSXN(m);
            txtMaXN.Text = x.MaXN.ToString();
            txtMoTa.Text = x.MoTa;
        }

        private void cbTenXN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                HienThiThongTinXetNghiem(cbTenXN.SelectedValue.ToString());
            }
        }

        private void gVCTPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTPK.Rows.Count)
            {
                cbTenXN.SelectedIndex = int.Parse(gVCTPK.Rows[e.RowIndex].Cells["MaXN"].Value.ToString()) - 1;
                dtpNgayXN.Text = gVCTPK.Rows[e.RowIndex].Cells["NgayXN"].Value.ToString();
                dtpNgayHen.Text = gVCTPK.Rows[e.RowIndex].Cells["NgayHenLayKQ"].Value.ToString();
                txtYC.Text = gVCTPK.Rows[e.RowIndex].Cells["YeuCauXN"].Value.ToString();
                txtKQ.Text = gVCTPK.Rows[e.RowIndex].Cells["KetQuaXN"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;
            // duyet tung dong trong datatable
            // neu maSP co, bo qua

            foreach (DataRow item in dtCTPK.Rows)
            {
                if (item[0].ToString() == cbTenXN.SelectedValue.ToString()) //co maXN hay ko
                {
                    kiemtra = false;
                    MessageBox.Show("Mã xét nghiệm này đã tồn tại");
                    break;
                }
            }

            if (kiemtra)
            {
                if (txtYC.Text != "" || txtKQ.Text == "")
                {
                    DataRow r = dtCTPK.NewRow();

                    r[0] = cbTenXN.SelectedValue.ToString();
                    r[1] = dtpNgayXN.Value;
                    r[2] = dtpNgayHen.Value;
                    r[3] = txtYC.Text;
                    r[4] = txtKQ.Text;

                    dtCTPK.Rows.Add(r);
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int dem = -1;
            foreach (DataRow item in dtCTPK.Rows)
            {
                dem++;
                if (dem == gVCTPK.CurrentCell.RowIndex)
                {
                    item[1] = dtpNgayXN.Value;
                    item[2] = dtpNgayHen.Value;
                    item[3] = txtYC.Text;
                    item[4] = txtKQ.Text;
                    break;
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in gVCTPK.SelectedCells)
            {
                if (c.Selected)
                    gVCTPK.Rows.RemoveAt(c.RowIndex);
            }
        }

        private void btThemChiTiet_Click(object sender, EventArgs e)
        {
            if (busCTPK.ThemCTPK(MaPK, dtCTPK))
            {
                MessageBox.Show("Thêm chi tiết thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Thêm chi tiết thất bại");
            }
        }

    }
}
