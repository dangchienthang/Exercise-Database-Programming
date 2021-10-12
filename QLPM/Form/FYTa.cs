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
    public partial class FYTa : Form
    {
        BUS_QLBenhNhan busBenhNhan;
        BUS_LichKham busLK;
        int MaTK;
        public FYTa(int ma)
        {
            InitializeComponent();
            MaTK = ma;
            busBenhNhan = new BUS_QLBenhNhan();
            busLK = new BUS_LichKham();
        }

        private void FYTa_Load(object sender, EventArgs e)
        {
            HienThiDSBenhNhan();
            busBenhNhan.LayDSLoaiGioiTinh(cbGioiTinh);
            HienThiDSLichKham();
            busLK.LayDSTenBenhNhan(cbBN);
            busLK.LayDSTenBacSi(cbBS);
            busLK.LayDSTenYTa(cbYT);
        }


        //Tab thêm bệnh nhân
        public void HienThiDSBenhNhan()
        {
            gVBN.DataSource = null;
            busBenhNhan.LayDSBenhNhan(gVBN);
            gVBN.Columns[0].Width = (int)(gVBN.Width * 0.1);
            gVBN.Columns[1].Width = (int)(gVBN.Width * 0.15);
            gVBN.Columns[2].Width = (int)(gVBN.Width * 0.1);
            gVBN.Columns[3].Width = (int)(gVBN.Width * 0.1);
            gVBN.Columns[4].Width = (int)(gVBN.Width * 0.15);
            gVBN.Columns[5].Width = (int)(gVBN.Width * 0.4);
        }

        public void CapNhatDGBN()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaBN.Text = "";

            //Cập nhật DataGridView
            gVBN.Columns.Clear();
            HienThiDSBenhNhan();
        }

        private void gVBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVBN.Rows.Count)
            {
                txtMaBN.Text = gVBN.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();
                txtTenBN.Text = gVBN.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Text = gVBN.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGioiTinh.Text = gVBN.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = gVBN.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = gVBN.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btThemBN_Click(object sender, EventArgs e)
        {
            if (txtTenBN.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                BenhNhan bn = new BenhNhan();

                bn.HoTenBN = txtTenBN.Text;
                bn.NgaySinh = dtpNgaySinh.Value;
                bn.MaLGT = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
                bn.DienThoai = txtDienThoai.Text;
                bn.DiaChi = txtDiaChi.Text;

                if (busBenhNhan.TaoBenhNhan(bn))
                {
                    MessageBox.Show("Tạo bệnh nhân thành công");
                    busBenhNhan.LayDSBenhNhan(gVBN);
                    CapNhatDGBN();
                }
                else
                {
                    MessageBox.Show("Tạo bệnh nhân thất bại");
                }
            }
        }

        private void btXoaBN_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text != "")
            {
                busBenhNhan.XoaBenhNhan(Int32.Parse(txtMaBN.Text));
                busBenhNhan.LayDSBenhNhan(gVBN);
                CapNhatDGBN();
            }
            else
            {
                MessageBox.Show("Chưa chọn bệnh nhân để xóa");
            }
        }

        private void btSuaBN_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                BenhNhan bn = new BenhNhan();

                bn.MaBN = int.Parse(txtMaBN.Text);
                bn.HoTenBN = txtTenBN.Text;
                bn.NgaySinh = dtpNgaySinh.Value;
                bn.MaLGT = int.Parse(cbGioiTinh.SelectedValue.ToString());
                bn.DienThoai = txtDienThoai.Text;
                bn.DiaChi = txtDiaChi.Text;

                if (busBenhNhan.SuaBenhNhan(bn))
                {
                    MessageBox.Show("Sửa thành công");
                    busBenhNhan.SuaBenhNhan(bn);
                    busBenhNhan.LayDSBenhNhan(gVBN);
                    CapNhatDGBN();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        //Tab thêm lịch

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

        public void CapNhatDGLK()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaLK.Text = "";

            //Cập nhật DataGridView
            gVLK.Columns.Clear();
            HienThiDSLichKham();
        }

        private void gVLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVLK.Rows.Count)
            {
                txtMaLK.Text = gVLK.Rows[e.RowIndex].Cells["MaLK"].Value.ToString();
                cbBN.Text = gVLK.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbBS.Text = gVLK.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbYT.Text = gVLK.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgayHen.Text = gVLK.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThemLK_Click(object sender, EventArgs e)
        {
            LichKham lk = new LichKham();

            lk.MaBN = Int32.Parse(cbBN.SelectedValue.ToString());
            lk.MaBS = Int32.Parse(cbBS.SelectedValue.ToString());
            lk.MaYT = Int32.Parse(cbYT.SelectedValue.ToString());
            lk.NgayHen = dtpNgayHen.Value;

            if (busLK.TaoLichKham(lk))
            {
                MessageBox.Show("Tạo lịch khám thành công");
                busLK.LayDSLichKham(gVLK);
                CapNhatDGLK();
            }
            else
            {
                MessageBox.Show("Tạo lịch khám thất bại");
            }
        }

        private void btXoaLK_Click(object sender, EventArgs e)
        {
            if (txtMaLK.Text != "")
            {
                busLK.XoaLichKham(Int32.Parse(txtMaLK.Text));
                busLK.LayDSLichKham(gVLK);
                CapNhatDGLK();
            }
            else
            {
                MessageBox.Show("Chưa chọn lịch để xóa");
            }
        }

        private void btSuaLK_Click(object sender, EventArgs e)
        {
            if (txtMaLK.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                LichKham lk = new LichKham();

                lk.MaLK = int.Parse(txtMaLK.Text);
                lk.MaBN = int.Parse(cbBN.SelectedValue.ToString());
                lk.MaBS = int.Parse(cbBS.SelectedValue.ToString());
                lk.MaYT = int.Parse(cbYT.SelectedValue.ToString());
                lk.NgayHen = dtpNgayHen.Value;

                if (busLK.SuaLichKham(lk))
                {
                    MessageBox.Show("Sửa thành công");
                    busLK.SuaLichKham(lk);
                    busLK.LayDSLichKham(gVLK);
                    CapNhatDGLK();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
