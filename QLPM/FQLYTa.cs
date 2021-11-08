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
    public partial class FQLYTa : Form
    {
        BUS_QLYTa busYTa;

        public FQLYTa()
        {
            InitializeComponent();
            busYTa = new BUS_QLYTa();
        }

        public void HienThiDSYTa()
        {
            gVYT.DataSource = null;
            busYTa.LayDSYTa(gVYT);
            gVYT.Columns[0].Width = (int)(gVYT.Width * 0.12);
            gVYT.Columns[1].Width = (int)(gVYT.Width * 0.22);
            gVYT.Columns[2].Width = (int)(gVYT.Width * 0.22);
            gVYT.Columns[3].Width = (int)(gVYT.Width * 0.22);
            gVYT.Columns[4].Width = (int)(gVYT.Width * 0.22);

            gVYT.Columns[0].HeaderText = "Mã y tá";
            gVYT.Columns[1].HeaderText = "Tên bác sĩ";
            gVYT.Columns[2].HeaderText = "Giới tính";
            gVYT.Columns[3].HeaderText = "Ngày sinh";
            gVYT.Columns[4].HeaderText = "Điện thoại";
        }

        public void CapNhatDG()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaYT.Text = "";
            txtTenYT.Text = "";
            txtDienThoai.Text = "";
            cbGioiTinh.Text = "";

            //Cập nhật DataGridView
            gVYT.Columns.Clear();
            HienThiDSYTa();
        }

        private void gVYT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVYT.Rows.Count)
            {
                txtMaYT.Text = gVYT.Rows[e.RowIndex].Cells["MaYT"].Value.ToString();
                txtTenYT.Text = gVYT.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGioiTinh.Text = gVYT.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = gVYT.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = gVYT.Rows[e.RowIndex].Cells[4].Value.ToString();
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

        private void FQLYTa_Load(object sender, EventArgs e)
        {
            HienThiDSYTa();
            DoiMauNut();
            string[] gt = { "Nam", "Nữ", "Khác" };
            foreach (string x in gt)
            {
                cbGioiTinh.Items.Add(x);
            }
        }

        private void btThemYT_Click(object sender, EventArgs e)
        {
            if (txtTenYT.Text == "" || txtDienThoai.Text == "" || cbGioiTinh.Text == "")
                MessageBox.Show("Điền đủ thông tin trước khi thêm");
            else
            {
                DateTime d = DateTime.Now;
                if (d.Year - dtpNgaySinh.Value.Year < 18 || d.Year - dtpNgaySinh.Value.Year > 60)
                    MessageBox.Show("Độ tuổi hợp lệ từ 18 đến 60!\n(Tuổi đã nhập " + (d.Year - dtpNgaySinh.Value.Year) + ")");
                else if (txtDienThoai.Text.Trim().Length != 10)
                    MessageBox.Show("Số điện thoại Không hợp lệ");
                else
                {
                    YTa yt = new YTa();

                    yt.HoTenYT = txtTenYT.Text;
                    yt.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    yt.NgaySinh = dtpNgaySinh.Value;
                    yt.DienThoai = txtDienThoai.Text;
                    yt.MaLNV = int.Parse(txtMaLNV.Text);

                    if (busYTa.TaoYTa(yt))
                    {
                        MessageBox.Show("Tạo y tá thành công");
                        busYTa.LayDSYTa(gVYT);
                        CapNhatDG();
                    }
                    else
                        MessageBox.Show("Tạo y tá thất bại");
                }
            }
        }

        private void btXoaYT_Click(object sender, EventArgs e)
        {
            if (txtMaYT.Text != "")
            {
                busYTa.XoaYTa(Int32.Parse(txtMaYT.Text));
                busYTa.LayDSYTa(gVYT);
                CapNhatDG();
            }
            else
                MessageBox.Show("Chưa chọn y tá để xóa");
        }

        private void btSuaYT_Click(object sender, EventArgs e)
        {
            if (txtMaYT.Text == "")
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
                    YTa yt = new YTa();

                    yt.MaYT = int.Parse(txtMaYT.Text);
                    yt.HoTenYT = txtTenYT.Text;
                    yt.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    yt.NgaySinh = dtpNgaySinh.Value;
                    yt.DienThoai = txtDienThoai.Text;
                    yt.MaLNV = int.Parse(txtMaLNV.Text);

                    if (busYTa.SuaYTa(yt))
                    {
                        MessageBox.Show("Sửa thành công");
                        busYTa.SuaYTa(yt);
                        busYTa.LayDSYTa(gVYT);
                        CapNhatDG();
                    }
                    else
                        MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            busYTa.TimKiemYTa(gVYT, txtTimKiem.Text.ToString());
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            ThongKeYTa t = new ThongKeYTa();
            FReport f = new FReport();
            t.SetDataSource(busYTa.LayDSYT().ToList());
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
