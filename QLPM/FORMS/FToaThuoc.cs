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
    public partial class FToaThuoc : Form
    {
        BUS_ToaThuoc bToa;

        public FToaThuoc()
        {
            InitializeComponent();
            bToa = new BUS_ToaThuoc();
        }

        public void HienThiDSToaThuoc()
        {
            gVToa.DataSource = null;
            bToa.LayDSToaThuoc(gVToa);
            gVToa.Columns[0].Width = (int)(gVToa.Width * 0.1);
            gVToa.Columns[1].Width = (int)(gVToa.Width * 0.3);
            gVToa.Columns[2].Width = (int)(gVToa.Width * 0.3);
            gVToa.Columns[3].Width = (int)(gVToa.Width * 0.3);
        }

        public void CapNhatDGThuoc()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaToa.Text = "";

            //Cập nhật DataGridView
            gVToa.Columns.Clear();
            HienThiDSToaThuoc();
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

        private void FToaThuoc_Load(object sender, EventArgs e)
        {
            DoiMauNut();
            HienThiDSToaThuoc();
            bToa.LayDSBacSi(cbBS);
            bToa.LayDSBenhNhan(cbBN);
        }

        private void btXoaToa_Click(object sender, EventArgs e)
        {
            if (txtMaToa.Text != "")
            {
                bToa.XoaToa(Int32.Parse(txtMaToa.Text));
                bToa.LayDSToaThuoc(gVToa);
                CapNhatDGThuoc();
            }
            else
                MessageBox.Show("Chưa chọn thuốc để xóa");
        }

        private void btSuaToa_Click(object sender, EventArgs e)
        {
            if (txtMaToa.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                ToaThuoc t = new ToaThuoc();

                t.MaToa = int.Parse(txtMaToa.Text);
                t.NgayKeToa = dtpNgayKeToa.Value;
                t.MaBS = int.Parse(cbBS.SelectedValue.ToString());
                t.MaBN = int.Parse(cbBN.SelectedValue.ToString());

                if (bToa.SuaToa(t))
                {
                    MessageBox.Show("Sửa thành công");
                    bToa.SuaToa(t);
                    bToa.LayDSToaThuoc(gVToa);
                    CapNhatDGThuoc();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        private void gVToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVToa.Rows.Count)
            {
                txtMaToa.Text = gVToa.Rows[e.RowIndex].Cells["MaToa"].Value.ToString();
                dtpNgayKeToa.Text = gVToa.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbBS.Text = gVToa.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbBN.Text = gVToa.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
