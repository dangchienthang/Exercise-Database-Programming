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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string connectionString = QLPM.Properties.Resources.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT MaND FROM NguoiDung WHERE TenDangNhap=@username AND MatKhau=@password";
            command.Parameters.AddWithValue("@username", txtTenDN.Text);
            command.Parameters.AddWithValue("@password", txtMK.Text);
            con.Open();
            var result = command.ExecuteScalar();
            con.Close();

            if (result != null)
            {
                con.Open();
                command.CommandText = "SELECT MaTK, MaLNV FROM TaiKhoan WHERE MaND=@user_id";
                command.Parameters.AddWithValue("@user_id", result.ToString());
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int MaTK = reader.GetInt32(0);
                    int MaLNV = reader.GetInt32(1);

                    con.Close();

                    if (MaLNV == 1)
                    {
                        //Form quản trị
                        Hide();
                        FQuanTri f = new FQuanTri();
                        f.ShowDialog();
                        Show();
                    }
                    if (MaLNV == 2)
                    {
                        //Form bác sĩ
                        Hide();
                        FBacSi f = new FBacSi(MaTK);
                        f.ShowDialog();
                        Show();
                    }
                    else if (MaLNV == 3)
                    {
                        //Form y tá
                        Hide();
                        FYTa f = new FYTa(MaTK);
                        f.ShowDialog();
                        Show();
                    }
                }
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void FDangNhap_Activated(object sender, EventArgs e)
        {
            txtMK.Text = "";
            checkBox.Checked = false;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                txtMK.PasswordChar = default(char);
            else
                txtMK.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thông quản lý phòng mạch tư Datha\n\nHọ tên: Đặng Chiến Thắng\nMSSV: 1851050133\nGVHD: Ths.Hồ Quang Khải");
        }
    }
}
