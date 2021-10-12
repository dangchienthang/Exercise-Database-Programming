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
    public partial class FBacSi : Form
    {
        int MaTK;

        BUS_LichKham busLK;

        public FBacSi(int ma)
        {
            InitializeComponent();
            MaTK = ma;
            busLK = new BUS_LichKham();
        }

        public void HienThiDSLichKham()
        {
            gVLK.DataSource = null;
            busLK.LayDSLichKham(gVLK);
            gVLK.Columns[0].Width = (int)(gVLK.Width * 0.12);
            gVLK.Columns[1].Width = (int)(gVLK.Width * 0.22);
            gVLK.Columns[2].Width = (int)(gVLK.Width * 0.22);
            gVLK.Columns[3].Width = (int)(gVLK.Width * 0.22);
            gVLK.Columns[4].Width = (int)(gVLK.Width * 0.22);
        }

        private void FBacSi_Load(object sender, EventArgs e)
        {
            HienThiDSLichKham();
            busLK.LayDSTenBenhNhan(cbBN);
            busLK.LayDSTenBacSi(cbBS);
            busLK.LayDSTenYTa(cbYT);
            HienThiDSPXN();
            HienThiDSPhieuKham();
        }

        private void gVLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVLK.Rows.Count)
            {
                txtMaLK.Text = gVLK.Rows[e.RowIndex].Cells["MaLK"].Value.ToString();
                cbBN.Text = gVLK.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();
                cbBS.Text = gVLK.Rows[e.RowIndex].Cells["MaBS"].Value.ToString();
                cbYT.Text = gVLK.Rows[e.RowIndex].Cells["MaYT"].Value.ToString();
                dtpNgayHen.Text = gVLK.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThemLK_Click(object sender, EventArgs e)
        {
            if (txtMaLK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để khám", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int maBN, maBS, maYT;
                maBN = Int32.Parse(gVLK.CurrentRow.Cells["MaBN"].Value.ToString());
                maBS = Int32.Parse(gVLK.CurrentRow.Cells["MaBS"].Value.ToString());
                maYT = Int32.Parse(gVLK.CurrentRow.Cells["MaYT"].Value.ToString());
                FKhamBenh f = new FKhamBenh();
                f.maBenhNhan = maBN;
                f.maBacSi = maBS;
                f.maYTa = maYT;
                f.ShowDialog();
            }
        }

        public void HienThiDSPXN()
        {
            dGPXN.DataSource = null;
            busLK.LayDSPXN(dGPXN);
            dGPXN.Columns[0].Width = (int)(dGPXN.Width * 0.1);
            dGPXN.Columns[1].Width = (int)(dGPXN.Width * 0.2);
            dGPXN.Columns[2].Width = (int)(dGPXN.Width * 0.2);
            dGPXN.Columns[3].Width = (int)(dGPXN.Width * 0.2);
            dGPXN.Columns[4].Width = (int)(dGPXN.Width * 0.3);
        }

        private void dGPXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGPXN.Rows.Count)
            {
                txtMaXN.Text = dGPXN.Rows[e.RowIndex].Cells["MaXN"].Value.ToString();
                txtTenXN.Text = dGPXN.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbTenBacSi.Text = dGPXN.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbHoTenBN.Text = dGPXN.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbLoaiXN.Text = dGPXN.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        public void HienThiDSPhieuKham()
        {
            gVPK.DataSource = null;
            busLK.LayDSPhieuKham(gVPK);
            gVPK.Columns[0].Width = (int)(gVPK.Width * 0.1);
            gVPK.Columns[1].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[2].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[3].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[4].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[5].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[6].Width = (int)(gVPK.Width * 0.15);
        }

        private void gVPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPK.Rows.Count)
            {
                txtMaPK.Text = gVPK.Rows[e.RowIndex].Cells["MaPK"].Value.ToString();
                cbTenBS.Text = gVPK.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbTenBenhNhan.Text = gVPK.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayKham.Text = gVPK.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTrieuChung.Text = gVPK.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtChuanDoan.Text = gVPK.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpNgayTaiKham.Text = gVPK.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
