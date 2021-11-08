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
using QLPM.Report;

namespace QLPM
{
    public partial class FQLBacSi : Form
    {
        BUS_QLBacSi busBacSi;

        public FQLBacSi()
        {
            InitializeComponent();
            busBacSi = new BUS_QLBacSi();
        }

        public void HienThiDSBacSi()
        {
            gVBS.DataSource = null;
            busBacSi.LayDSBacSi(gVBS);
            gVBS.Columns[0].Width = (int)(gVBS.Width * 0.1);
            gVBS.Columns[1].Width = (int)(gVBS.Width * 0.2);
            gVBS.Columns[2].Width = (int)(gVBS.Width * 0.2);
            gVBS.Columns[3].Width = (int)(gVBS.Width * 0.2);
            gVBS.Columns[4].Width = (int)(gVBS.Width * 0.3);

            gVBS.Columns[0].HeaderText = "Mã bác sĩ";
            gVBS.Columns[1].HeaderText = "Tên bác sĩ";
            gVBS.Columns[2].HeaderText = "Giới tính";
            gVBS.Columns[3].HeaderText = "Ngày sinh";
            gVBS.Columns[4].HeaderText = "Điện thoại";
        }

        public void CapNhatDGBS()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaBS.Text = "";
            txtTenBS.Text = "";
            txtDienThoai.Text = "";
            cbGioiTinh.Text = "";

            //Cập nhật DataGridView
            gVBS.Columns.Clear();
            HienThiDSBacSi();
        }

        private void gVBS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVBS.Rows.Count)
            {
                txtMaBS.Text = gVBS.Rows[e.RowIndex].Cells["MaBS"].Value.ToString();
                txtTenBS.Text = gVBS.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGioiTinh.Text = gVBS.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = gVBS.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = gVBS.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThemBS_Click(object sender, EventArgs e)
        {
            if (txtTenBS.Text == "" || txtDienThoai.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            }
            else
            {
                DateTime d = DateTime.Now;
                if (d.Year - dtpNgaySinh.Value.Year < 18 || d.Year - dtpNgaySinh.Value.Year > 60)
                    MessageBox.Show("Độ tuổi hợp lệ từ 18 đến 60!\n(Tuổi đã nhập " + (d.Year - dtpNgaySinh.Value.Year) + ")");
                else if (txtDienThoai.Text.Trim().Length != 10)
                    MessageBox.Show("Số điện thoại Không hợp lệ");
                else
                {
                    BacSi bs = new BacSi();

                    bs.HoTenBS = txtTenBS.Text.Trim();
                    bs.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    bs.NgaySinh = dtpNgaySinh.Value;
                    bs.DienThoai = txtDienThoai.Text;
                    bs.MaLNV = int.Parse(txtMaLNV.Text);

                    if (busBacSi.TaoBacSi(bs))
                    {
                        MessageBox.Show("Tạo bác sĩ thành công");
                        busBacSi.LayDSBacSi(gVBS);
                        CapNhatDGBS();
                    }
                    else
                    {
                        MessageBox.Show("Tạo bác sĩ thất bại");
                    }
                }
            }
        }

        private void btSuaBS_Click(object sender, EventArgs e)
        {
            if (txtMaBS.Text == "" || txtDienThoai.Text == "")
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
                    BacSi bs = new BacSi();

                    bs.MaBS = int.Parse(txtMaBS.Text);
                    bs.HoTenBS = txtTenBS.Text;
                    bs.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    bs.NgaySinh = dtpNgaySinh.Value;
                    bs.DienThoai = txtDienThoai.Text;
                    bs.MaLNV = int.Parse(txtMaLNV.Text);

                    if (busBacSi.SuaBacSi(bs))
                    {
                        MessageBox.Show("Sửa thành công");
                        busBacSi.SuaBacSi(bs);
                        busBacSi.LayDSBacSi(gVBS);
                        CapNhatDGBS();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }

        private void btXoaBS_Click(object sender, EventArgs e)
        {
            if (txtMaBS.Text != "")
            {
                busBacSi.XoaBacSi(Int32.Parse(txtMaBS.Text));
                busBacSi.LayDSBacSi(gVBS);
                CapNhatDGBS();
            }
            else
            {
                MessageBox.Show("Chưa chọn bác sĩ để xóa");
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

        private void FQLBacSi_Load(object sender, EventArgs e)
        {
            HienThiDSBacSi();
            DoiMauNut();
            string[] gt = { "Nam", "Nữ", "Khác"};
            foreach (string x in gt)
            {
                cbGioiTinh.Items.Add(x);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            busBacSi.TimKiemBacSi(gVBS, txtTimKiem.Text.ToString());
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            ThongKeBacSi t = new ThongKeBacSi();
            FReport f = new FReport();
            t.SetDataSource(busBacSi.LayDSBS().ToList());
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
