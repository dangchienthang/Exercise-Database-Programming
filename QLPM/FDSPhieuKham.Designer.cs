
namespace QLPM
{
    partial class FDSPhieuKham
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
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSuaPK = new System.Windows.Forms.Button();
            this.btXoaPK = new System.Windows.Forms.Button();
            this.gVPK = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.cbBN = new System.Windows.Forms.ComboBox();
            this.dtpNgayTaiKham = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gVPK)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(55, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã thuốc:";
            // 
            // txtMaPK
            // 
            this.txtMaPK.Enabled = false;
            this.txtMaPK.Location = new System.Drawing.Point(134, 43);
            this.txtMaPK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.Size = new System.Drawing.Size(237, 20);
            this.txtMaPK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên bác sĩ:";
            // 
            // btSuaPK
            // 
            this.btSuaPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaPK.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaPK.Location = new System.Drawing.Point(792, 191);
            this.btSuaPK.Name = "btSuaPK";
            this.btSuaPK.Size = new System.Drawing.Size(75, 58);
            this.btSuaPK.TabIndex = 9;
            this.btSuaPK.Text = "Sửa";
            this.btSuaPK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaPK.UseVisualStyleBackColor = true;
            this.btSuaPK.Click += new System.EventHandler(this.btSuaPK_Click);
            // 
            // btXoaPK
            // 
            this.btXoaPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaPK.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaPK.Location = new System.Drawing.Point(688, 191);
            this.btXoaPK.Name = "btXoaPK";
            this.btXoaPK.Size = new System.Drawing.Size(75, 58);
            this.btXoaPK.TabIndex = 8;
            this.btXoaPK.Text = "Xóa";
            this.btXoaPK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaPK.UseVisualStyleBackColor = true;
            this.btXoaPK.Click += new System.EventHandler(this.btXoaPK_Click);
            // 
            // gVPK
            // 
            this.gVPK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVPK.Location = new System.Drawing.Point(32, 267);
            this.gVPK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVPK.Name = "gVPK";
            this.gVPK.RowHeadersWidth = 62;
            this.gVPK.RowTemplate.Height = 28;
            this.gVPK.Size = new System.Drawing.Size(835, 270);
            this.gVPK.TabIndex = 10;
            this.gVPK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVPK_CellClick);
            this.gVPK.DoubleClick += new System.EventHandler(this.gVPK_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên bệnh nhân:";
            // 
            // cbBS
            // 
            this.cbBS.FormattingEnabled = true;
            this.cbBS.Location = new System.Drawing.Point(134, 78);
            this.cbBS.Margin = new System.Windows.Forms.Padding(2);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(237, 21);
            this.cbBS.TabIndex = 2;
            // 
            // cbBN
            // 
            this.cbBN.FormattingEnabled = true;
            this.cbBN.Location = new System.Drawing.Point(134, 114);
            this.cbBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbBN.Name = "cbBN";
            this.cbBN.Size = new System.Drawing.Size(237, 21);
            this.cbBN.TabIndex = 3;
            // 
            // dtpNgayTaiKham
            // 
            this.dtpNgayTaiKham.CustomFormat = "";
            this.dtpNgayTaiKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTaiKham.Location = new System.Drawing.Point(630, 149);
            this.dtpNgayTaiKham.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayTaiKham.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTaiKham.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTaiKham.Name = "dtpNgayTaiKham";
            this.dtpNgayTaiKham.Size = new System.Drawing.Size(237, 20);
            this.dtpNgayTaiKham.TabIndex = 7;
            this.dtpNgayTaiKham.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ngày tái khám:";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Location = new System.Drawing.Point(630, 114);
            this.txtChuanDoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(237, 20);
            this.txtChuanDoan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chuẩn đoán:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(630, 78);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(237, 20);
            this.txtTrieuChung.TabIndex = 5;
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "";
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKham.Location = new System.Drawing.Point(630, 40);
            this.dtpNgayKham.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKham.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKham.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(237, 20);
            this.dtpNgayKham.TabIndex = 4;
            this.dtpNgayKham.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày khám:";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Location = new System.Drawing.Point(525, 81);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(64, 13);
            this.diaChiLabel.TabIndex = 21;
            this.diaChiLabel.Text = "Triệu chứng";
            // 
            // FDSPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.dtpNgayTaiKham);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtChuanDoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.diaChiLabel);
            this.Controls.Add(this.cbBN);
            this.Controls.Add(this.cbBS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSuaPK);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVPK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaPK);
            this.Controls.Add(this.txtMaPK);
            this.Name = "FDSPhieuKham";
            this.Text = "DANH SÁCH PHIẾU KHÁM";
            this.Load += new System.EventHandler(this.FDSPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuaPK;
        private System.Windows.Forms.Button btXoaPK;
        private System.Windows.Forms.DataGridView gVPK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBS;
        private System.Windows.Forms.ComboBox cbBN;
        private System.Windows.Forms.DateTimePicker dtpNgayTaiKham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label diaChiLabel;
    }
}