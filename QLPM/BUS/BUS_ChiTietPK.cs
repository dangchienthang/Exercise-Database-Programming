using QLPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QLPM.BUS
{
    class BUS_ChiTietPK
    {
        DAO_ChiTietPK dCTPK;

        public BUS_ChiTietPK()
        {
            dCTPK = new DAO_ChiTietPK();
        }

        private DataTable InitDG()
        {
            DataTable dtCTPK = new DataTable();

            dtCTPK.Columns.Add("MaXN");
            dtCTPK.Columns.Add("NgayXN");
            dtCTPK.Columns.Add("NgayHenLayKQ");
            dtCTPK.Columns.Add("YeuCauXN");
            dtCTPK.Columns.Add("KetQuaXN");

            return dtCTPK;
        }

        public void HienThiDSCTPK(DataGridView dg, int maPK)
        {
            var ds = dCTPK.LayDSCTPK(maPK);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDG();
            }
        }

        public void SuaCTPK(XetNghiem_PhieuKham xn)
        {
            if (dCTPK.SuaCTPK(xn))
            {
                MessageBox.Show("Sửa chi tiết xét nghiệm thành công");
            }
            else
            {
                MessageBox.Show("Không thấy chi tiết xét nghiệm để sửa");
            }
        }

        public void XoaCTPK(int maPK, int maXN)
        {
            if (dCTPK.XoaCTPK(maPK, maXN))
            {
                MessageBox.Show("Xóa chi tiết phiếu khám thành công");
            }
            else
            {
                MessageBox.Show("Xóa chi tiết phiếu khám không thành công");
            }
        }

        public void ThemDanhSachCTPK(List<XetNghiem_PhieuKham> list)
        {
            if (dCTPK.ThemDanhSachCTPK(list))
            {
                MessageBox.Show("Thêm chi tiết thành công");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết không thành công");
            }
        }

        public void LayDSXN(ComboBox cb)
        {
            cb.DataSource = dCTPK.LayDSXN();
            cb.DisplayMember = "TenXN";
            cb.ValueMember = "MaXN";
        }

        public XetNghiem HienThiDSXN(int maXN)
        {
            var t = dCTPK.LayThongTinXetNghiem(maXN);

            return t;
        }

        public bool ThemCTPK(int maPK, DataTable dtCTPK)
        {
            bool ketQua = false;
            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in dtCTPK.Rows)
                    {
                        XetNghiem_PhieuKham xn = new XetNghiem_PhieuKham();

                        xn.MaPK = maPK;
                        xn.MaXN = int.Parse(item[0].ToString());
                        xn.NgayXN = DateTime.Parse(item[1].ToString());
                        xn.NgayHenLayKQ = DateTime.Parse(item[2].ToString());
                        xn.YeuCauXN = item[3].ToString();
                        xn.KetQuaXN = item[4].ToString();

                        if (dCTPK.KiemTraXetNghiem(xn))
                        {
                            dCTPK.ThemChiTietPhieuKham(xn);
                        }
                        else
                        {
                            throw new Exception("Xét nghiệm đã tồn tại " + xn.MaXN);
                        }
                    }
                    tran.Complete();
                    ketQua = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ketQua = false;
                }
            }
            return ketQua;
        }
    }
}
