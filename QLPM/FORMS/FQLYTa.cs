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

namespace QLPM.FORMS
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
        }

        public void CapNhatDG()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaYT.Text = "";

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
                dtpNgaySinh.Text = gVYT.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGioiTinh.Text = gVYT.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            busYTa.LayDSLoaiGioiTinh(cbGioiTinh);
            DoiMauNut();
        }

        private void btThemYT_Click(object sender, EventArgs e)
        {
            if (txtTenYT.Text == "")
                MessageBox.Show("Điền đủ thông tin trước khi thêm");
            else
            {
                YTa yt = new YTa();

                yt.HoTenYT = txtTenYT.Text;
                yt.NgaySinh = dtpNgaySinh.Value;
                yt.MaLGT = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
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
                YTa yt = new YTa();

                yt.MaYT = int.Parse(txtMaYT.Text);
                yt.HoTenYT = txtTenYT.Text;
                yt.NgaySinh = dtpNgaySinh.Value;
                yt.MaLGT = int.Parse(cbGioiTinh.SelectedValue.ToString());
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
}
