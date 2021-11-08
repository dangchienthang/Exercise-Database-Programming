using QLPM.BUS;
using QLPM.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPM
{
    public partial class FThongKe : Form
    {
        BUS_KhamBenh busKB;
        private DateTime mocBD;
        private DateTime mocKT;

        public FThongKe()
        {
            InitializeComponent();
            busKB = new BUS_KhamBenh();
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

        private void FThongKe_Load(object sender, EventArgs e)
        {
            DoiMauNut();
            dtpMocKetThuc.Value = DateTime.Now;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            mocBD = dtpMocBatDau.Value;
            mocKT = dtpMocKetThuc.Value;
            if (mocKT < mocBD)
                MessageBox.Show("Mốc kết thúc phải lớn hơn mốc bắt đầu");
            else
            {
                busKB.ThongKePK(gVPK, mocBD, mocKT);

                gVPK.Columns[0].Width = (int)(gVPK.Width * 0.1);
                gVPK.Columns[1].Width = (int)(gVPK.Width * 0.15);
                gVPK.Columns[2].Width = (int)(gVPK.Width * 0.15);
                gVPK.Columns[3].Width = (int)(gVPK.Width * 0.15);
                gVPK.Columns[4].Width = (int)(gVPK.Width * 0.15);
                gVPK.Columns[5].Width = (int)(gVPK.Width * 0.15);
                gVPK.Columns[6].Width = (int)(gVPK.Width * 0.15);

                gVPK.Columns[0].HeaderText = "Mã phiếu khám";
                gVPK.Columns[1].HeaderText = "Tên bác sĩ";
                gVPK.Columns[2].HeaderText = "Tên bệnh nhân";
                gVPK.Columns[3].HeaderText = "Ngày khám";
                gVPK.Columns[4].HeaderText = "Triệu chứng";
                gVPK.Columns[5].HeaderText = "Chuẩn đoán";
                gVPK.Columns[6].HeaderText = "Ngày tái khám";
            }
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string connectionString = QLPM.Properties.Resources.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThongKeLichSuKham";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NgayBatDau", dtpMocBatDau.Value);
            command.Parameters.AddWithValue("@NgayKetThuc", dtpMocKetThuc.Value);
            con.Open();
            DataTable dt = new DataTable();

            da.SelectCommand = command;
            da.Fill(dt);

            ThongKeLichKham t = new ThongKeLichKham();
            t.SetDataSource(dt);

            FReport f = new FReport();
            f.Report.ReportSource = t;
            f.Show();

            con.Close();
        }
    }
}
