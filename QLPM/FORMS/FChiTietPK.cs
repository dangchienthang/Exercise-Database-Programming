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
        bool co = false;

        public FChiTietPK()
        {
            InitializeComponent();
            busCTPK = new BUS_ChiTietPK();

        }
        private void FChiTietPK_Load(object sender, EventArgs e)
        {
            txtMaPK.Text = MaPK.ToString();
            HienThiDSCTPK();

            busCTPK.LayDSXN(cbTenXN);
            co = true;

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
        }

        public void CapNhatDG()
        {
            txtMaPK.Text = "";
            txtMaXN.Text = "";
            txtYC.Text = "";
            txtKQ.Text = "";
            HienThiDSCTPK();
        }

        void HienThiThongTinXN(string maXN)
        {
            int ma = Int32.Parse(maXN);
            XetNghiem x = busCTPK.HienThiDSXN(ma);
            txtMaXN.Text = x.MaXN.ToString();
            txtMoTa.Text = x.MoTa;
        }

        private void gVCTPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTPK.Rows.Count)
            {
                txtMaPK.Text = gVCTPK.Rows[e.RowIndex].Cells["MaPK"].Value.ToString();
                cbTenXN.SelectedIndex = int.Parse(gVCTPK.Rows[e.RowIndex].Cells[1].Value.ToString()) - 1;
                dtpNgayXN.Text = gVCTPK.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayHen.Text = gVCTPK.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtYC.Text = gVCTPK.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtKQ.Text = gVCTPK.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTenXN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                HienThiThongTinXN(cbTenXN.SelectedValue.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == "" || txtMoTa.Text == "" || txtYC.Text == "" || txtKQ.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                XetNghiem_PhieuKham xn = new XetNghiem_PhieuKham();

                xn.MaPK = int.Parse(txtMaPK.Text);
                xn.MaXN = int.Parse(txtMaXN.Text);
                xn.NgayXN = dtpNgayXN.Value;
                xn.YeuCauXN = txtYC.Text;
                xn.KetQuaXN = txtKQ.Text;
                xn.NgayHenLayKQ = dtpNgayHen.Value;

                if (busCTPK.TaoCT(xn))
                {
                    MessageBox.Show("Thêm chi tiết khám bệnh thành công");
                    busCTPK.HienThiDSCTPK(gVCTPK, MaPK);
                    CapNhatDG();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu chi tiết khám bệnh thất bại");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                XetNghiem_PhieuKham xn = new XetNghiem_PhieuKham();

                xn.MaPK = int.Parse(txtMaPK.Text);
                xn.MaXN = int.Parse(txtMaXN.Text);
                xn.NgayXN = dtpNgayXN.Value;
                xn.NgayHenLayKQ = dtpNgayHen.Value;
                xn.YeuCauXN = txtYC.Text;
                xn.KetQuaXN = txtKQ.Text;

                if (busCTPK.SuaCT(xn))
                {
                    MessageBox.Show("Sửa thành công");
                    busCTPK.SuaCT(xn);
                    busCTPK.HienThiDSCTPK(gVCTPK, MaPK);
                    CapNhatDG();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
    }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text != "")
            {
                busCTPK.XoaCT(Int32.Parse(txtMaPK.Text));
                busCTPK.HienThiDSCTPK(gVCTPK, MaPK);
                CapNhatDG();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu để xóa");
            }
        }
    }
}
