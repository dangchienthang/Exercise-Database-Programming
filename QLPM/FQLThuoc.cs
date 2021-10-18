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
    public partial class FQLThuoc : Form
    {
        BUS_QLThuoc busThuoc;
        public FQLThuoc()
        {
            InitializeComponent();
            busThuoc = new BUS_QLThuoc();
        }

        public void HienThiDSThuoc()
        {
            gVThuoc.DataSource = null;
            busThuoc.LayDSThuoc(gVThuoc);
            gVThuoc.Columns[0].Width = (int)(gVThuoc.Width * 0.1);
            gVThuoc.Columns[1].Width = (int)(gVThuoc.Width * 0.2);
            gVThuoc.Columns[2].Width = (int)(gVThuoc.Width * 0.7);
        }

        public void CapNhatDGThuoc()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtMoTa.Text = "";

            //Cập nhật DataGridView
            gVThuoc.Columns.Clear();
            HienThiDSThuoc();
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

        private void FQLThuoc_Load(object sender, EventArgs e)
        {
            HienThiDSThuoc();
            DoiMauNut();
        }

        private void btThemThuoc_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "" || txtMoTa.Text == "" || txtTenThuoc.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                Thuoc t = new Thuoc();

                t.TenThuoc = txtTenThuoc.Text;
                t.MoTa = txtMoTa.Text;

                if (busThuoc.TaoThuoc(t))
                {
                    MessageBox.Show("Thêm thuốc thành công");
                    busThuoc.LayDSThuoc(gVThuoc);
                    CapNhatDGThuoc();
                }
                else
                    MessageBox.Show("Thêm thuốc thất bại");
            }
        }

        private void btXoaThuoc_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text != "")
            {
                busThuoc.XoaThuoc(Int32.Parse(txtMaThuoc.Text));
                busThuoc.LayDSThuoc(gVThuoc);
                CapNhatDGThuoc();
            }
            else
                MessageBox.Show("Chưa chọn thuốc để xóa");
        }

        private void btSuaThuoc_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "" || txtTenThuoc.Text == "" || txtMoTa.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                Thuoc t = new Thuoc();

                t.MaThuoc = int.Parse(txtMaThuoc.Text);
                t.TenThuoc = txtTenThuoc.Text;
                t.MoTa = txtMoTa.Text;

                if (busThuoc.SuaThuoc(t))
                {
                    MessageBox.Show("Sửa thành công");
                    busThuoc.SuaThuoc(t);
                    busThuoc.LayDSThuoc(gVThuoc);
                    CapNhatDGThuoc();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        private void gVThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVThuoc.Rows.Count)
            {
                txtMaThuoc.Text = gVThuoc.Rows[e.RowIndex].Cells["MaThuoc"].Value.ToString();
                txtTenThuoc.Text = gVThuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMoTa.Text = gVThuoc.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
