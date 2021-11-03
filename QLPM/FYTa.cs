﻿using System;
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
    public partial class FYTa : Form
    {
        int MaTK;
        public FYTa(int ma)
        {
            InitializeComponent();
            random = new Random();
            MaTK = ma;
        }

        private Button nutHienTai;
        private Random random;
        private int s;
        private Form kichHoatForm;

        private Color ChonMau()
        {
            int a = random.Next(Mau.DSMau.Count);
            while (s == a)
            {
                a = random.Next(Mau.DSMau.Count);
            }
            s = a;
            string mau = Mau.DSMau[a];
            return ColorTranslator.FromHtml(mau);
        }

        private void KichHoatButton(object sender)
        {
            if (sender != null)
            {
                if (nutHienTai != (Button)sender)
                {
                    VoHieuButton();
                    Color mau = ChonMau();
                    nutHienTai = (Button)sender;
                    nutHienTai.BackColor = mau;
                    nutHienTai.ForeColor = Color.White;
                    nutHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTieuDe.BackColor = mau;
                    labelTieuDe.BackColor = mau;
                    panelLogo.BackColor = Mau.ChinhDoSangMau(mau, -0.3);
                    Mau.MauChinh = mau;
                    Mau.MauPhu = Mau.ChinhDoSangMau(mau, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        private void VoHieuButton()
        {
            foreach (Control nutTruoc in panelDanhMuc.Controls)
            {
                if (nutTruoc.GetType() == typeof(Button))
                {
                    nutTruoc.BackColor = Color.FromArgb(69, 69, 69);
                    nutTruoc.ForeColor = Color.Gainsboro;
                    nutTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void MoFormCon(Form formCon, object sender)
        {
            if (kichHoatForm != null)
                kichHoatForm.Close();
            KichHoatButton(sender);
            kichHoatForm = formCon;
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            this.panelFormCon.Controls.Add(formCon);
            this.panelFormCon.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
            labelTieuDe.Text = formCon.Text;
        }

        private void bTBN_Click(object sender, EventArgs e)
        {
            MoFormCon(new FQLBenhNhan(), sender);
        }

        private void btLK_Click(object sender, EventArgs e)
        {
            MoFormCon(new FQLLichKham(), sender);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            VoHieuButton();
            labelTieuDe.Text = "Y TÁ";
            panelTieuDe.BackColor = Color.FromArgb(69, 69, 69);
            panelLogo.BackColor = Color.FromArgb(39, 39, 39);
            labelTieuDe.BackColor = Color.FromArgb(69, 69, 69);
            nutHienTai = null;
            btQuayLai.Visible = false;
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            if (kichHoatForm != null)
                kichHoatForm.Close();
            Reset();
        }

        private void FYTa_Load(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.FromArgb(39, 39, 39);
        }

        private void FYTa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }
    }
}
