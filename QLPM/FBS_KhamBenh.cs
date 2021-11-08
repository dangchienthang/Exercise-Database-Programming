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
        BUS_KhamBenh busKB;

        public int maBenhNhan;
        public int maBacSi;
        public int maYTa;

        public FKhamBenh()
        {
            InitializeComponent();
            //MaTK = ma;
            busKB = new BUS_KhamBenh();
        }

        private void FKhamBenh_Load(object sender, EventArgs e)
        {
            HienThiDSPhieuKham();
            HienThiDSToa();

            txtTenBN.Text = maBenhNhan.ToString();
            txtTenBS.Text = maBacSi.ToString();

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

            gVPK.Columns[0].HeaderText = "Mã phiếu khám";
            gVPK.Columns[1].HeaderText = "Mã bác sĩ";
            gVPK.Columns[2].HeaderText = "Mã bệnh nhân";
            gVPK.Columns[3].HeaderText = "Ngày khám";
            gVPK.Columns[4].HeaderText = "Triệu chứng";
            gVPK.Columns[5].HeaderText = "Chuẩn đoán";
            gVPK.Columns[6].HeaderText = "Ngày tái khám";
        }

        public void HienThiDSToa()
        {
            gVToa.DataSource = null;
            busKB.LayDSToa(gVToa, maBenhNhan, maBacSi);
            gVToa.Columns[0].Width = (int)(gVToa.Width * 0.25);
            gVToa.Columns[1].Width = (int)(gVToa.Width * 0.25);
            gVToa.Columns[2].Width = (int)(gVToa.Width * 0.25);
            gVToa.Columns[3].Width = (int)(gVToa.Width * 0.25);

            gVToa.Columns[0].HeaderText = "Mã toa thuốc";
            gVToa.Columns[1].HeaderText = "Ngày kê toa";
            gVToa.Columns[2].HeaderText = "Mã bác sĩ";
            gVToa.Columns[3].HeaderText = "Mã bệnh nhân";
        }

        public void CapNhatDGPK()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaPK.Text = "";

            //Cập nhật DataGridView
            gVPK.Columns.Clear();
            HienThiDSPhieuKham();
        }

        public void CapNhatDGTT()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaToa.Text = "";

            //Cập nhật DataGridView
            gVToa.Columns.Clear();
            HienThiDSToa();
        }


        private void gVPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPK.Rows.Count)
            {
                txtMaPK.Text = gVPK.Rows[e.RowIndex].Cells["MaPK"].Value.ToString();
                txtTenBS.Text = gVPK.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenBN.Text = gVPK.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayKham.Text = gVPK.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTrieuChung.Text = gVPK.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtChuanDoan.Text = gVPK.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpNgayTaiKham.Text = gVPK.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btThemPK_Click(object sender, EventArgs e)
        {
            PhieuKham pk = new PhieuKham();

            pk.MaBS = Int32.Parse(txtTenBS.Text);
            pk.MaBN = Int32.Parse(txtTenBN.Text);
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
                pk.MaBS = int.Parse(txtTenBS.Text);
                pk.MaBN = int.Parse(txtTenBN.Text);
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
            FChiTietToa f = new FChiTietToa();
            //truyen bien
            f.maToa = maToa;
            f.ShowDialog();
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gVPK_DoubleClick(object sender, EventArgs e)
        {
            int maPK;
            maPK = int.Parse(gVPK.CurrentRow.Cells["MaPK"].Value.ToString());
            //goi Form
            FChiTietPK f = new FChiTietPK();
            //truyen bien
            f.MaPK = maPK;
            f.ShowDialog();
        }
    }
}
