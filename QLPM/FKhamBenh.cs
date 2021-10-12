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
    public partial class FKhamBenh : Form
    {
        BUS_LichKham busLK;
        BUS_KhamBenh busKB;

        public int maBenhNhan;
        public int maBacSi;
        public int maYTa;

        public FKhamBenh()
        {
            InitializeComponent();
            //MaTK = ma;
            busLK = new BUS_LichKham();
            busKB = new BUS_KhamBenh();
        }

        private void FKhamBenh_Load(object sender, EventArgs e)
        {
            HienThiDSPhieuXetNghiem();
            busKB.LayDSLoaiXN(cbLoaiXN);

            HienThiDSPhieuKham();
            HienThiDSToa();

            cbHoTenBN.Text = maBenhNhan.ToString();
            cbTenBacSi.Text = maBacSi.ToString();

            cbTenBenhNhan.Text = maBenhNhan.ToString();
            cbTenBS.Text = maBacSi.ToString();

            txtBN.Text = maBenhNhan.ToString();
            txtBS.Text = maBacSi.ToString();

            dtpNgayKham.Value = DateTime.Now;
            dtpNgayTaiKham.Value = DateTime.Now;
            dtpNgayKeToa.Value = DateTime.Now;

            if (gVPK.RowCount >= 1)
                btThemPK.Enabled = false;

            if (gVToa.RowCount >= 1)
                btThemTT.Enabled = false;
        }

        public void HienThiDSPhieuKham()
        {
            gVPK.DataSource = null;
            busKB.LayDSPhieuKham(gVPK, maBenhNhan, maBacSi);
            gVPK.Columns[0].Width = (int)(gVPK.Width * 0.1);
            gVPK.Columns[1].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[2].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[3].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[4].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[5].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[6].Width = (int)(gVPK.Width * 0.15);
        }

        public void HienThiDSPhieuXetNghiem()
        {
            gVXN.DataSource = null;
            busKB.LayDSPhieuXetNghiem(gVXN, maBenhNhan, maBacSi);
            gVXN.Columns[0].Width = (int)(gVXN.Width * 0.1);
            gVXN.Columns[1].Width = (int)(gVXN.Width * 0.2);
            gVXN.Columns[2].Width = (int)(gVXN.Width * 0.2);
            gVXN.Columns[3].Width = (int)(gVXN.Width * 0.2);
            gVXN.Columns[4].Width = (int)(gVXN.Width * 0.3);
        }

        public void HienThiDSToa()
        {
            gVToa.DataSource = null;
            busKB.LayDSToa(gVToa, maBenhNhan, maBacSi);
            gVToa.Columns[0].Width = (int)(gVToa.Width * 0.25);
            gVToa.Columns[1].Width = (int)(gVToa.Width * 0.25);
            gVToa.Columns[2].Width = (int)(gVToa.Width * 0.25);
            gVToa.Columns[3].Width = (int)(gVToa.Width * 0.25);
        }

        public void CapNhatDGPK()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaPK.Text = "";

            //Cập nhật DataGridView
            gVPK.Columns.Clear();
            HienThiDSPhieuKham();
        }

        public void CapNhatDGPXN()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaXN.Text = "";

            //Cập nhật DataGridView
            gVXN.Columns.Clear();
            HienThiDSPhieuXetNghiem();
        }

        public void CapNhatDGTT()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaToa.Text = "";

            //Cập nhật DataGridView
            gVToa.Columns.Clear();
            HienThiDSToa();
        }

        private void gVXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVXN.Rows.Count)
            {
                txtMaXN.Text = gVXN.Rows[e.RowIndex].Cells["MaXN"].Value.ToString();
                txtTenXN.Text = gVXN.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbTenBacSi.Text = gVXN.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbHoTenBN.Text = gVXN.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbLoaiXN.Text = gVXN.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThemPXN_Click(object sender, EventArgs e)
        {
            if (txtTenXN.Text == "")
                MessageBox.Show("Điền đủ thông tin trước khi thêm!");
            else
            {
                XetNghiem xn = new XetNghiem();

                xn.TenXN = txtTenXN.Text;
                xn.MaBS = Int32.Parse(cbTenBacSi.SelectedValue.ToString());
                xn.MaBN = Int32.Parse(cbHoTenBN.SelectedValue.ToString());
                xn.MaLXN = Int32.Parse(cbLoaiXN.SelectedValue.ToString());

                if (busKB.TaoPhieuXetNghiem(xn))
                {
                    MessageBox.Show("Tạo phiếu xét nghiệm thành công");
                    busKB.LayDSPhieuXetNghiem(gVXN, maBenhNhan, maBacSi);
                    CapNhatDGPXN();
                }
                else
                {
                    MessageBox.Show("Tạo phiếu khám thất bại");
                }
            }
        }

        private void btXoaPXN_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text != "")
            {
                busKB.XoaPhieuXetNghiem(Int32.Parse(txtMaXN.Text));
                busKB.LayDSPhieuXetNghiem(gVXN, maBenhNhan, maBacSi);
                CapNhatDGPXN();
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu để xóa");
            }
        }

        private void btSuaPXN_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                XetNghiem xn = new XetNghiem();

                xn.MaXN = int.Parse(txtMaXN.Text);
                xn.TenXN = txtTenXN.Text;
                xn.MaBS = int.Parse(cbTenBacSi.SelectedValue.ToString());
                xn.MaBN = int.Parse(cbHoTenBN.SelectedValue.ToString());
                xn.MaLXN = int.Parse(cbLoaiXN.SelectedValue.ToString());

                if (busKB.SuaPhieuXetNghiem(xn))
                {
                    MessageBox.Show("Sửa thành công");
                    busKB.SuaPhieuXetNghiem(xn);
                    busKB.LayDSPhieuXetNghiem(gVXN, maBenhNhan, maBacSi);
                    CapNhatDGPXN();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
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

        private void btThemPK_Click(object sender, EventArgs e)
        {
            PhieuKham pk = new PhieuKham();

            pk.MaBS = Int32.Parse(cbTenBS.SelectedValue.ToString());
            pk.MaBN = Int32.Parse(cbTenBenhNhan.SelectedValue.ToString());
            pk.NgayKham = dtpNgayKham.Value;
            pk.TrieuChung = txtTrieuChung.Text;
            pk.ChuanDoan = txtChuanDoan.Text;
            pk.NgayTaiKham = dtpNgayTaiKham.Value;

            if (busKB.TaoPhieuKham(pk))
            {
                MessageBox.Show("Tạo phiếu khám thành công");
                busKB.LayDSPhieuKham(gVPK, maBenhNhan, maBacSi);
                CapNhatDGPK();
                if (gVPK.RowCount >= 1)
                    btThemPK.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tạo phiếu khám thất bại");
            }
        }

        private void btXoaPK_Click(object sender, EventArgs e)
        {
            if (txtMaPK.Text != "")
            {
                busKB.XoaPhieuKham(Int32.Parse(txtMaPK.Text));
                busKB.LayDSPhieuKham(gVPK, maBenhNhan, maBacSi);
                CapNhatDGPK();
                if (gVPK.RowCount < 2)
                    btThemPK.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu để xóa");
            }
        }

        private void btSuaPK_Click(object sender, EventArgs e)
        {
            if (txtMaPK.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                PhieuKham pk = new PhieuKham();

                pk.MaPK = int.Parse(txtMaPK.Text);
                pk.MaBS = int.Parse(cbTenBS.SelectedValue.ToString());
                pk.MaBN = int.Parse(cbTenBenhNhan.SelectedValue.ToString());
                pk.NgayKham = dtpNgayKham.Value;
                pk.TrieuChung = txtTrieuChung.Text;
                pk.ChuanDoan = txtChuanDoan.Text;
                pk.NgayTaiKham = dtpNgayTaiKham.Value;

                if (busKB.SuaPhieuKham(pk))
                {
                    MessageBox.Show("Sửa thành công");
                    busKB.SuaPhieuKham(pk);
                    busKB.LayDSPhieuKham(gVPK, maBenhNhan, maBacSi);
                    CapNhatDGPK();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btThemTT_Click(object sender, EventArgs e)
        {
            ToaThuoc t = new ToaThuoc();

            t.NgayKeToa = dtpNgayKeToa.Value;
            t.MaBS = Int32.Parse(txtBS.Text);
            t.MaBN = Int32.Parse(txtBN.Text);

            if (busKB.TaoToa(t))
            {
                MessageBox.Show("Tạo toa thuốc thành công");
                busKB.LayDSToa(gVToa, maBenhNhan, maBacSi);
                CapNhatDGTT();
                if (gVToa.RowCount >= 1)
                    btThemTT.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tạo toa thuốc thất bại");
            }
        }

        private void btSuaTT_Click(object sender, EventArgs e)
        {
            if (txtMaToa.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                ToaThuoc t = new ToaThuoc();

                t.MaToa = int.Parse(txtMaToa.Text);
                t.NgayKeToa = dtpNgayKeToa.Value;
                t.MaBS = int.Parse(txtBS.Text);
                t.MaBN = int.Parse(txtBN.Text);

                if (busKB.SuaToa(t))
                {
                    MessageBox.Show("Sửa thành công");
                    busKB.SuaToa(t);
                    busKB.LayDSToa(gVToa, maBenhNhan, maBacSi);
                    CapNhatDGTT();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btXoaTT_Click(object sender, EventArgs e)
        {
            if (txtMaToa.Text != "")
            {
                busKB.XoaToa(Int32.Parse(txtMaToa.Text));
                busKB.LayDSToa(gVToa, maBenhNhan, maBacSi);
                CapNhatDGTT();
                if (gVToa.RowCount < 2)
                    btThemTT.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu để xóa");
            }
        }

        private void gVToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVToa.Rows.Count)
            {
                txtMaToa.Text = gVToa.Rows[e.RowIndex].Cells["MaToa"].Value.ToString();
                dtpNgayKeToa.Text = gVToa.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBS.Text = gVToa.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBN.Text = gVToa.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void gVToa_DoubleClick(object sender, EventArgs e)
        {
            int maToa;
            maToa = int.Parse(gVToa.CurrentRow.Cells["MaToa"].Value.ToString());
            //goi Form
            FCTToaThuoc f = new FCTToaThuoc();
            //truyen bien
            f.MaToa = maToa;
            f.ShowDialog();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
