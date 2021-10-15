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
    public partial class FLoaiXetNghiem : Form
    {
        BUS_XetNghiem busXN;

        public FLoaiXetNghiem()
        {
            InitializeComponent();
            busXN = new BUS_XetNghiem();
        }

        public void HienThiDSLoaiXetNghiem()
        {
            gVLXN.DataSource = null;
            busXN.LayDSLXN(gVLXN);
            gVLXN.Columns[0].Width = (int)(gVLXN.Width * 0.1);
            gVLXN.Columns[1].Width = (int)(gVLXN.Width * 0.9);
        }

        public void CapNhatDG()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaLXN.Text = "";
            txtTenLXN.Text = "";

            //Cập nhật DataGridView
            gVLXN.Columns.Clear();
            HienThiDSLoaiXetNghiem();
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

        private void FLoaiXetNghiem_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiXetNghiem();
            DoiMauNut();
        }

        private void gVLXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVLXN.Rows.Count)
            {
                txtMaLXN.Text = gVLXN.Rows[e.RowIndex].Cells["MaLXN"].Value.ToString();
                txtTenLXN.Text = gVLXN.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenLXN.Text == "")
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            else
            {
                LoaiXetNghiem lxn = new LoaiXetNghiem();

                lxn.TenLXN = txtTenLXN.Text;

                if (busXN.ThemLXN(lxn))
                {
                    MessageBox.Show("Tạo loại xét nghiệm thành công");
                    busXN.LayDSXN(gVLXN);
                    CapNhatDG();
                }
                else
                {
                    MessageBox.Show("Tạo loại xét nghiệm thất bại");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLXN.Text != "")
            {
                busXN.XoaLXN(Int32.Parse(txtMaLXN.Text));
                busXN.LayDSLXN(gVLXN);
                CapNhatDG();
            }
            else
            {
                MessageBox.Show("Chưa chọn bệnh nhân để xóa");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaLXN.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                LoaiXetNghiem lxn = new LoaiXetNghiem();

                lxn.MaLXN = int.Parse(txtMaLXN.Text);
                lxn.TenLXN = txtTenLXN.Text;

                if (busXN.SuaLXN(lxn))
                {
                    MessageBox.Show("Sửa thành công");
                    busXN.SuaLXN(lxn);
                    busXN.LayDSLXN(gVLXN);
                    CapNhatDG();
                }
                else
                    MessageBox.Show("Sửa thất bại");


            }

        }
    }
}
