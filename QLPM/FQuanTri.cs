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
    public partial class FQuanTri : Form
    {
        BUS_QLBacSi busBacSi;
        BUS_QLYTa busYTa;
        BUS_QLBenhNhan busBenhNhan;
        BUS_QLThuoc busThuoc;

        public FQuanTri()
        {
            InitializeComponent();
            busBacSi = new BUS_QLBacSi();
            busYTa = new BUS_QLYTa();
            busBenhNhan = new BUS_QLBenhNhan();
            busThuoc = new BUS_QLThuoc();
        }

        private void FQuanTri_Load(object sender, EventArgs e)
        {
            HienThiDSBacSi();
            busBacSi.LayDSLoaiGioiTinh(cbGioiTinh);
            HienThiDSYTa();
            busYTa.LayDSLoaiGioiTinh(cbGT);
            HienThiDSBenhNhan();
            busBenhNhan.LayDSLoaiGioiTinh(cbGTinh);
            HienThiDSThuoc();
        }

        //Tab bác sĩ
        public void HienThiDSBacSi()
        {
            gVBS.DataSource = null;
            busBacSi.LayDSBacSi(gVBS);
            gVBS.Columns[0].Width = (int)(gVBS.Width * 0.1);
            gVBS.Columns[1].Width = (int)(gVBS.Width * 0.3);
            gVBS.Columns[2].Width = (int)(gVBS.Width * 0.2);
            gVBS.Columns[3].Width = (int)(gVBS.Width * 0.2);
            gVBS.Columns[4].Width = (int)(gVBS.Width * 0.2);
        }

        public void CapNhatDGBS()
        {
            //Cập nhật lại textbox sau khi thực hiện hành động thêm, sửa hoặc xóa
            txtMaBS.Text = "";

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
                dtpNgaySinh.Text = gVBS.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGioiTinh.Text = gVBS.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = gVBS.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThemBS_Click(object sender, EventArgs e)
        {
            if (txtTenBS.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm");
            }
            else
            {
                BacSi bs = new BacSi();

                bs.HoTenBS = txtTenBS.Text;
                bs.NgaySinh = dtpNgaySinh.Value;
                bs.MaLGT = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
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

        private void btSuaBS_Click(object sender, EventArgs e)
        {
            if (txtMaBS.Text == "")
                MessageBox.Show("Vui lòng chọn hàng dữ liệu cần sửa!");
            else
            {
                BacSi bs = new BacSi();

                bs.MaBS = int.Parse(txtMaBS.Text);
                bs.HoTenBS = txtTenBS.Text;
                bs.NgaySinh = dtpNgaySinh.Value;
                bs.MaLGT = int.Parse(cbGioiTinh.SelectedValue.ToString());
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


        //Tab y tá
        public void HienThiDSYTa()
        {
            gVYT.DataSource = null;
            busYTa.LayDSYTa(gVYT);
            gVYT.Columns[0].Width = (int)(gVYT.Width * 0.1);
            gVYT.Columns[1].Width = (int)(gVYT.Width * 0.2);
            gVYT.Columns[2].Width = (int)(gVYT.Width * 0.2);
            gVYT.Columns[3].Width = (int)(gVYT.Width * 0.2);
            gVYT.Columns[4].Width = (int)(gVYT.Width * 0.2);
        }

        public void CapNhatDGYT()
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
                dtpNS.Text = gVYT.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGT.Text = gVYT.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDT.Text = gVYT.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThemYT_Click(object sender, EventArgs e)
        {
            if (txtTenYT.Text == "")
                MessageBox.Show("Điền đủ thông tin trước khi thêm");
            else
            {
                YTa yt = new YTa();

                yt.HoTenYT = txtTenYT.Text;
                yt.NgaySinh = dtpNS.Value;
                yt.MaLGT = Int32.Parse(cbGT.SelectedValue.ToString());
                yt.DienThoai = txtDT.Text;
                yt.MaLNV = int.Parse(txtLNV.Text);

                if (busYTa.TaoYTa(yt))
                {
                    MessageBox.Show("Tạo y tá thành công");
                    busYTa.LayDSYTa(gVYT);
                    CapNhatDGYT();
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
                CapNhatDGYT();
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
                yt.MaLNV = int.Parse(txtLNV.Text);

                if (busYTa.SuaYTa(yt))
                {
                    MessageBox.Show("Sửa thành công");
                    busYTa.SuaYTa(yt);
                    busYTa.LayDSYTa(gVYT);
                    CapNhatDGYT();
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
        }

        //Tab bệnh nhân
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
                dtpNSinh.Text = gVBN.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGTinh.Text = gVBN.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDThoai.Text = gVBN.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                bn.NgaySinh = dtpNSinh.Value;
                bn.MaLGT = Int32.Parse(cbGTinh.SelectedValue.ToString());
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
                bn.NgaySinh = dtpNSinh.Value;
                bn.MaLGT = int.Parse(cbGTinh.SelectedValue.ToString());
                bn.DienThoai = txtDThoai.Text;
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

        //Tab quản lí thuốc
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
            txtMoTa.Text = "";
            txtTenThuoc.Text = "";

            //Cập nhật DataGridView
            gVThuoc.Columns.Clear();
            HienThiDSThuoc();
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
            if (txtMaThuoc.Text == "")
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
    }
}
