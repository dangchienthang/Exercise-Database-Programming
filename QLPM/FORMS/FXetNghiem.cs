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
    public partial class FXetNghiem : Form
    {
        BUS_XetNghiem busXN;

        public FXetNghiem()
        {
            InitializeComponent();
            busXN = new BUS_XetNghiem();
        }

        public void HienThiDSXetNghiem()
        {
            gVXN.DataSource = null;
            busXN.LayDSXN(gVXN);
            gVXN.Columns[0].Width = (int)(gVXN.Width * 0.1);
            gVXN.Columns[1].Width = (int)(gVXN.Width * 0.2);
            gVXN.Columns[2].Width = (int)(gVXN.Width * 0.3);
            gVXN.Columns[3].Width = (int)(gVXN.Width * 0.4);
        }

        public void CapNhatDG()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaXN.Text = "";
            txtMoTa.Text = "";

            //Cập nhật DataGridView
            gVXN.Columns.Clear();
            HienThiDSXetNghiem();
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

        private void FXetNghiem_Load(object sender, EventArgs e)
        {
            HienThiDSXetNghiem();
            DoiMauNut();
            busXN.LayDSLoaiXN(cbLXN);
        }

        private void gVXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVXN.Rows.Count)
            {
                txtMaXN.Text = gVXN.Rows[e.RowIndex].Cells["MaXN"].Value.ToString();
                txtTenXN.Text = gVXN.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLXN.Text = gVXN.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMoTa.Text = gVXN.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btThemXN_Click(object sender, EventArgs e)
        {
            if (txtTenXN.Text == "" || txtMoTa.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                XetNghiem xn = new XetNghiem();

                xn.TenXN = txtTenXN.Text;
                xn.MaLXN = int.Parse(cbLXN.SelectedValue.ToString());
                xn.MoTa = txtMoTa.Text;

                if (busXN.ThemXN(xn))
                {
                    MessageBox.Show("Tạo xét nghiệm thành công");
                    busXN.LayDSXN(gVXN);
                    CapNhatDG();
                }
                else
                {
                    MessageBox.Show("Tạo xét nghiệm thất bại");
                }
            }
        }

        private void btXoaXN_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text != "")
            {
                busXN.XoaXN(Int32.Parse(txtMaXN.Text));
                busXN.LayDSXN(gVXN);
                CapNhatDG();
            }
            else
            {
                MessageBox.Show("Chưa chọn bệnh nhân để xóa");
            }
        }

        private void btSuaXN_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                XetNghiem xn = new XetNghiem();

                xn.MaXN = int.Parse(txtMaXN.Text);
                xn.TenXN = txtTenXN.Text;
                xn.MaLXN = int.Parse(cbLXN.SelectedValue.ToString());
                xn.MoTa = txtMoTa.Text;

                if (busXN.SuaXN(xn))
                {
                    MessageBox.Show("Sửa thành công");
                    busXN.SuaXN(xn);
                    busXN.LayDSXN(gVXN);
                    CapNhatDG();
                }
                else
                    MessageBox.Show("Sửa thất bại");


            }

        }
    }
}
