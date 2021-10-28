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
        }

        public void CapNhatDG()
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
            busBN.LayDSLoaiGioiTinh(cbGioiTinh);
            DoiMauNut();
        }

        private void btThemBN_Click(object sender, EventArgs e)
        {
            if (txtTenBN.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                BenhNhan bn = new BenhNhan();

                bn.HoTenBN = txtTenBN.Text;
                bn.NgaySinh = dtpNgaySinh.Value;
                bn.MaLGT = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
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

    }
}
