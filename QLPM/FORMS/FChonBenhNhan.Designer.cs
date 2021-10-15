
namespace QLPM.FORMS
{
    partial class FChonBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.txtMaLK = new System.Windows.Forms.TextBox();
            this.btKham = new System.Windows.Forms.Button();
            this.gVLK = new System.Windows.Forms.DataGridView();
            this.cbBN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gVLK)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(73, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã lịch khám:";
            // 
            // txtMaLK
            // 
            this.txtMaLK.Enabled = false;
            this.txtMaLK.Location = new System.Drawing.Point(146, 43);
            this.txtMaLK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLK.Name = "txtMaLK";
            this.txtMaLK.Size = new System.Drawing.Size(237, 20);
            this.txtMaLK.TabIndex = 1;
            // 
            // btKham
            // 
            this.btKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKham.Image = global::QLPM.Properties.Resources.Start_icon;
            this.btKham.Location = new System.Drawing.Point(750, 191);
            this.btKham.Name = "btKham";
            this.btKham.Size = new System.Drawing.Size(117, 58);
            this.btKham.TabIndex = 9;
            this.btKham.Text = "Bắt đầu khám";
            this.btKham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKham.UseVisualStyleBackColor = true;
            this.btKham.Click += new System.EventHandler(this.btKham_Click);
            // 
            // gVLK
            // 
            this.gVLK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVLK.Location = new System.Drawing.Point(32, 267);
            this.gVLK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVLK.Name = "gVLK";
            this.gVLK.RowHeadersWidth = 62;
            this.gVLK.RowTemplate.Height = 28;
            this.gVLK.Size = new System.Drawing.Size(835, 270);
            this.gVLK.TabIndex = 10;
            this.gVLK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVLK_CellClick);
            // 
            // cbBN
            // 
            this.cbBN.FormattingEnabled = true;
            this.cbBN.Location = new System.Drawing.Point(146, 77);
            this.cbBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbBN.Name = "cbBN";
            this.cbBN.Size = new System.Drawing.Size(237, 21);
            this.cbBN.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên bệnh nhân:";
            // 
            // cbYT
            // 
            this.cbYT.FormattingEnabled = true;
            this.cbYT.Location = new System.Drawing.Point(146, 113);
            this.cbYT.Margin = new System.Windows.Forms.Padding(2);
            this.cbYT.Name = "cbYT";
            this.cbYT.Size = new System.Drawing.Size(237, 21);
            this.cbYT.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên y tá:";
            // 
            // cbBS
            // 
            this.cbBS.FormattingEnabled = true;
            this.cbBS.Location = new System.Drawing.Point(146, 151);
            this.cbBS.Margin = new System.Windows.Forms.Padding(2);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(237, 21);
            this.cbBS.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên bác sĩ chỉ định:";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.CustomFormat = "";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHen.Location = new System.Drawing.Point(146, 191);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayHen.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHen.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(237, 20);
            this.dtpNgayHen.TabIndex = 21;
            this.dtpNgayHen.Value = new System.DateTime(2021, 9, 14, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày hẹn:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.AutoSize = true;
            this.txtMaBN.Location = new System.Drawing.Point(405, 81);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(79, 13);
            this.txtMaBN.TabIndex = 25;
            this.txtMaBN.Text = "Mã bệnh nhân:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(522, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã y tá:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(522, 113);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mã bác sĩ:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(522, 151);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 28;
            // 
            // FChonBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbYT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btKham);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVLK);
            this.Controls.Add(this.txtMaLK);
            this.Name = "FChonBenhNhan";
            this.Text = "QUẢN LÝ LỊCH KHÁM";
            this.Load += new System.EventHandler(this.FChonBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVLK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaLK;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Button btKham;
        private System.Windows.Forms.DataGridView gVLK;
        private System.Windows.Forms.ComboBox cbBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbYT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtMaBN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}