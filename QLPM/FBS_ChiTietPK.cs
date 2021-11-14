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
    public partial class FChiTietPK : Form
    {
        public int MaPK;

        BUS_ChiTietPK busCTPK;

        public FChiTietPK()
        {
            InitializeComponent();
            busCTPK = new BUS_ChiTietPK();

        }
        private void FChiTietPK_Load(object sender, EventArgs e)
        {
            txtMaPK.Text = MaPK.ToString();

            dtpNgayXN.Value = DateTime.Now;
            dtpNgayHen.Value = DateTime.Now;
        }

        private void HienThiDSCTPK()
        {
            gVCTPK.DataSource = null;
            busCTPK.HienThiDSCTPK(gVCTPK, MaPK);
            gVCTPK.Columns[0].Width = (int)(0.1 * gVCTPK.Width);
            gVCTPK.Columns[1].Width = (int)(0.1 * gVCTPK.Width);
            gVCTPK.Columns[2].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[3].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[4].Width = (int)(0.2 * gVCTPK.Width);
            gVCTPK.Columns[5].Width = (int)(0.2 * gVCTPK.Width);

            gVCTPK.Columns[0].HeaderText = "Mã phiếu khám";
            gVCTPK.Columns[1].HeaderText = "Mã xét nghiệm";
            gVCTPK.Columns[2].HeaderText = "Ngày xét nghiệm";
            gVCTPK.Columns[3].HeaderText = "Ngày hẹn lấy kết quả";
            gVCTPK.Columns[4].HeaderText = "Yêu cầu xét nghiệm";
            gVCTPK.Columns[5].HeaderText = "Kết quả xét nghiệm";
        }

        public void CapNhatDG()
        {
            txtMaPK.Text = "";
            txtMaXN.Text = "";
            txtYC.Text = "";
            txtKQ.Text = "";
            HienThiDSCTPK();
        }

        private void gVCTPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTPK.Rows.Count)
            {
                txtMaPK.Text = gVCTPK.Rows[e.RowIndex].Cells["MaPK"].Value.ToString();
                txtMaXN.Text = gVCTPK.Rows[e.RowIndex].Cells["MaXN"].Value.ToString();
                dtpNgayXN.Text = gVCTPK.Rows[e.RowIndex].Cells["NgayXN"].Value.ToString();
                dtpNgayHen.Text = gVCTPK.Rows[e.RowIndex].Cells["NgayHenLayKQ"].Value.ToString();
                txtYC.Text = gVCTPK.Rows[e.RowIndex].Cells["YeuCauXN"].Value.ToString();
                txtKQ.Text = gVCTPK.Rows[e.RowIndex].Cells["KetQuaXN"].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaPK.Text == "" || txtMaXN.Text == "" || txtKQ.Text == "" || txtYC.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                XetNghiem_PhieuKham x = new XetNghiem_PhieuKham();

                x.MaPK = int.Parse(txtMaPK.Text);
                x.MaXN = int.Parse(txtMaXN.Text);
                x.NgayXN = dtpNgayXN.Value;
                x.NgayHenLayKQ = dtpNgayHen.Value;
                x.YeuCauXN = txtYC.Text;
                x.KetQuaXN = txtKQ.Text;

                busCTPK.SuaCTPK(x);
                CapNhatDG();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPK.Text == "" || txtMaXN.Text == "" || txtYC.Text == "" || txtKQ.Text == "")
                MessageBox.Show("Chưa chọn hàng để sửa");
            else
            {
                int maPK = int.Parse(gVCTPK.CurrentRow.Cells["MaPK"].Value.ToString());
                int maXN = int.Parse(gVCTPK.CurrentRow.Cells["MaXN"].Value.ToString());
                busCTPK.XoaCTPK(maPK, maXN);
                // load lại data
                CapNhatDG();
            }
        }

        private void btThemCT_Click(object sender, EventArgs e)
        {
            FBS_XetNghiem f = new FBS_XetNghiem();
            f.MaPK = MaPK;
            f.ShowDialog();
        }

        private void FChiTietPK_Activated(object sender, EventArgs e)
        {
            HienThiDSCTPK();
        }
    }
}
