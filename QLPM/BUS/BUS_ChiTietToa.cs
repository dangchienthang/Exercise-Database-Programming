using QLPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QLPM.BUS
{
    class BUS_ChiTietToa
    {
        DAO_ChiTIetToa dToa;

        public BUS_ChiTietToa()
        {
            dToa = new DAO_ChiTIetToa();
        }

        private DataTable InitDG()
        {
            DataTable dtCTT = new DataTable();

            dtCTT.Columns.Add("MaToa");
            dtCTT.Columns.Add("MaThuoc");
            dtCTT.Columns.Add("SoLuong");
            dtCTT.Columns.Add("LieuDung");

            return dtCTT;
        }

        public void HienThiDSCTDH(DataGridView dg, int maToa)
        {
            var ds = dToa.LayDSCTT(maToa);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDG();
            }
        }

        public void SuaCTT(ChiTietToaThuoc c)
        {
            if (dToa.SuaCTT(c))
            {
                MessageBox.Show("Sửa chi tiết toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Không thấy chi tiết toa thuốc để sửa");
            }
        }

        public void XoaCTT(int maToa, int maThuoc)
        {
            if (dToa.XoaCTT(maToa, maThuoc))
            {
                MessageBox.Show("Xóa chi tiết toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Xóa chi tiết toa thuốc không thành công");
            }
        }

        public void ThemDanhSachCTT(List<ChiTietToaThuoc> list)
        {
            if (dToa.ThemDanhSachCTT(list))
            {
                MessageBox.Show("Kê toa thuốc thành công");
            }
            else
            {
                MessageBox.Show("Kê toa thuốc không thành công");
            }
        }

        public void LayDSThuoc(ComboBox cb)
        {
            cb.DataSource = dToa.LayDSThuoc();
            cb.DisplayMember = "TenThuoc";
            cb.ValueMember = "MaThuoc";
        }

        public Thuoc HienThiDSThuoc(int maThuoc)
        {
            var t = dToa.LayThongTinThuoc(maThuoc);

            return t;
        }

        public bool ThemToa(int maToa, DataTable dtToaThuoc)
        {
            bool ketQua = false;
            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in dtToaThuoc.Rows)
                    {
                        ChiTietToaThuoc ct = new ChiTietToaThuoc();
                        ct.MaToa = maToa;
                        ct.MaThuoc = int.Parse(item[0].ToString());
                        ct.SoLuong = int.Parse(item[1].ToString());
                        ct.LieuDung = item[2].ToString();
                        if (dToa.KiemTraThuoc(ct))
                        {
                            dToa.ThemToa(ct);
                        }
                        else
                        {
                            throw new Exception("Thuốc đã tồn tại " + ct.MaThuoc);
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
