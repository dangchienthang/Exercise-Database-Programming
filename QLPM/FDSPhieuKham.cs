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
    public partial class FDSPhieuKham : Form
    {
        BUS_KhamBenh busKB;

        public FDSPhieuKham()
        {
            busKB = new BUS_KhamBenh();
            InitializeComponent();
        }

        public void HienThiDSPhieuKham()
        {
            gVPK.DataSource = null;
            busKB.LayDSPK(gVPK);
            gVPK.Columns[0].Width = (int)(gVPK.Width * 0.1);
            gVPK.Columns[1].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[2].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[3].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[4].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[5].Width = (int)(gVPK.Width * 0.15);
            gVPK.Columns[6].Width = (int)(gVPK.Width * 0.15);

            gVPK.Columns[0].HeaderText = "Mã phiếu khám";
            gVPK.Columns[1].HeaderText = "Tên bác sĩ";
            gVPK.Columns[2].HeaderText = "Tên bệnh nhân";
            gVPK.Columns[3].HeaderText = "Ngày khám";
            gVPK.Columns[4].HeaderText = "Triệu chứng";
            gVPK.Columns[5].HeaderText = "Chuẩn đoán";
            gVPK.Columns[6].HeaderText = "Ngày tái khám";
        }

        public void CapNhatDG()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaPK.Text = "";
            txtTrieuChung.Text = "";
            txtChuanDoan.Text = "";

            //Cập nhật DataGridView
            gVPK.Columns.Clear();
            HienThiDSPhieuKham();
        }

        private void FDSPhieuKham_Load(object sender, EventArgs e)
        {
            HienThiDSPhieuKham();
            busKB.LayDSBS(cbBS);
            busKB.LayDSBN(cbBN);
            dtpNgayKham.Value = DateTime.Now;
            dtpNgayTaiKham.Value = DateTime.Now;
        }

        private void gVPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPK.Rows.Count)
            {
                txtMaPK.Text = gVPK.Rows[e.RowIndex].Cells["MaPK"].Value.ToString();
                cbBS.Text = gVPK.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbBN.Text = gVPK.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayKham.Text = gVPK.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTrieuChung.Text = gVPK.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtChuanDoan.Text = gVPK.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpNgayTaiKham.Text = gVPK.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btXoaPK_Click(object sender, EventArgs e)
        {
            if (txtMaPK.Text != "")
            {
                busKB.XoaPhieuKham(Int32.Parse(txtMaPK.Text));
                busKB.LayDSPK(gVPK);
                CapNhatDG();
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu để xóa");
            }
        }

        private void btSuaPK_Click(object sender, EventArgs e)
        {
            if (txtMaPK.Text == "" | txtTrieuChung.Text == "" || txtChuanDoan.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                PhieuKham pk = new PhieuKham();

                pk.MaPK = int.Parse(txtMaPK.Text);
                pk.MaBS = int.Parse(cbBS.SelectedValue.ToString());
                pk.MaBN = int.Parse(cbBN.SelectedValue.ToString());
                pk.NgayKham = dtpNgayKham.Value;
                pk.TrieuChung = txtTrieuChung.Text;
                pk.ChuanDoan = txtChuanDoan.Text;
                pk.NgayTaiKham = dtpNgayTaiKham.Value;

                if (busKB.SuaPhieuKham(pk))
                {
                    MessageBox.Show("Sửa thành công");
                    busKB.SuaPhieuKham(pk);
                    busKB.LayDSPK(gVPK);
                    CapNhatDG();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
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
