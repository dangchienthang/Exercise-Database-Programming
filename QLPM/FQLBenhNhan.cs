using QLPM.BUS;
using QLPM.Report;
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
    public partial class FQLBenhNhan : Form
    {
        BUS_QLBenhNhan busBN;

        public FQLBenhNhan()
        {
            InitializeComponent();
            busBN = new BUS_QLBenhNhan();
        }

        public void HienThiDSBenhNhan()
        {
            gVBN.DataSource = null;
            busBN.LayDSBenhNhan(gVBN);
            gVBN.Columns[0].Width = (int)(gVBN.Width * 0.1);
            gVBN.Columns[1].Width = (int)(gVBN.Width * 0.15);
            gVBN.Columns[2].Width = (int)(gVBN.Width * 0.1);
            gVBN.Columns[3].Width = (int)(gVBN.Width * 0.1);
            gVBN.Columns[4].Width = (int)(gVBN.Width * 0.15);
            gVBN.Columns[5].Width = (int)(gVBN.Width * 0.4);

            gVBN.Columns[0].HeaderText = "Mã bệnh nhân";
            gVBN.Columns[1].HeaderText = "Tên bác sĩ";
            gVBN.Columns[2].HeaderText = "Giới tính";
            gVBN.Columns[3].HeaderText = "Ngày sinh";
            gVBN.Columns[4].HeaderText = "Điện thoại";
            gVBN.Columns[5].HeaderText = "Địa chỉ";

        }

        public void CapNhatDG()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaBN.Text = "";
            txtTenBN.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.Text = "";

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
                cbGioiTinh.Text = gVBN.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = gVBN.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = gVBN.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = gVBN.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void DoiMauNut()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Mau.MauChinh;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Mau.MauPhu;
                }
            }
        }

        private void FQLBenhNhan_Load(object sender, EventArgs e)
        {
            HienThiDSBenhNhan();
            DoiMauNut();
            string[] gt = { "Nam", "Nữ", "Khác" };
            foreach (string x in gt)
            {
                cbGioiTinh.Items.Add(x);
            }
        }

        private void btThemBN_Click(object sender, EventArgs e)
        {
            if (txtTenBN.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                DateTime d = DateTime.Now;
                if (d.Year - dtpNgaySinh.Value.Year < 18 || d.Year - dtpNgaySinh.Value.Year > 60)
                    MessageBox.Show("Độ tuổi hợp lệ từ 18 đến 60!\n(Tuổi đã nhập " + (d.Year - dtpNgaySinh.Value.Year) + ")");
                else if (txtDienThoai.Text.Trim().Length != 10)
                    MessageBox.Show("Số điện thoại Không hợp lệ");
                else
                {
                    BenhNhan bn = new BenhNhan();

                    bn.HoTenBN = txtTenBN.Text;
                    bn.NgaySinh = dtpNgaySinh.Value;
                    bn.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    bn.DienThoai = txtDienThoai.Text;
                    bn.DiaChi = txtDiaChi.Text;

                    if (busBN.TaoBenhNhan(bn))
                    {
                        MessageBox.Show("Tạo bệnh nhân thành công");
                        busBN.LayDSBenhNhan(gVBN);
                        CapNhatDG();
                    }
                    else
                    {
                        MessageBox.Show("Tạo bệnh nhân thất bại");
                    }
                }
            }
        }

        private void btSuaBN_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                DateTime d = DateTime.Now;
                if (d.Year - dtpNgaySinh.Value.Year < 18 || d.Year - dtpNgaySinh.Value.Year > 60)
                    MessageBox.Show("Độ tuổi hợp lệ từ 18 đến 60!\n(Tuổi đã nhập " + (d.Year - dtpNgaySinh.Value.Year) + ")");
                else if (txtDienThoai.Text.Trim().Length != 10)
                    MessageBox.Show("Số điện thoại Không hợp lệ");
                else
                {
                    BenhNhan bn = new BenhNhan();

                    bn.MaBN = int.Parse(txtMaBN.Text);
                    bn.HoTenBN = txtTenBN.Text;
                    bn.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    bn.NgaySinh = dtpNgaySinh.Value;
                    bn.DienThoai = txtDienThoai.Text;
                    bn.DiaChi = txtDiaChi.Text;

                    if (busBN.SuaBenhNhan(bn))
                    {
                        MessageBox.Show("Sửa thành công");
                        busBN.SuaBenhNhan(bn);
                        busBN.LayDSBenhNhan(gVBN);
                        CapNhatDG();
                    }
                    else
                        MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btXoaBN_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text != "")
            {
                busBN.XoaBenhNhan(Int32.Parse(txtMaBN.Text));
                busBN.LayDSBenhNhan(gVBN);
                CapNhatDG();
            }
            else
            {
                MessageBox.Show("Chưa chọn bệnh nhân để xóa");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            busBN.TimKiemBenhNhan(gVBN, txtTimKiem.Text.ToString());
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            ThongKeBenhNhan t = new ThongKeBenhNhan();
            FReport f = new FReport();
            t.SetDataSource(busBN.LayDSBN().ToList());
            f.Report.ReportSource = t;
            f.Show();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
