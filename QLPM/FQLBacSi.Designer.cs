namespace QLPM
{
    partial class FQLBacSi
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
            this.txtMaLNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemBS = new System.Windows.Forms.Button();
            this.btSuaBS = new System.Windows.Forms.Button();
            this.btXoaBS = new System.Windows.Forms.Button();
            this.gVBS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gVBS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaLNV
            // 
            this.txtMaLNV.Enabled = false;
            this.txtMaLNV.Location = new System.Drawing.Point(630, 114);
            this.txtMaLNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLNV.Name = "txtMaLNV";
            this.txtMaLNV.Size = new System.Drawing.Size(237, 20);
            this.txtMaLNV.TabIndex = 6;
            this.txtMaLNV.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã loại nhân viên";
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(59, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã bác sĩ:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(134, 111);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(237, 20);
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 10, 13, 0, 0, 0, 0);
            // 
            // txtMaBS
            // 
            this.txtMaBS.Enabled = false;
            this.txtMaBS.Location = new System.Drawing.Point(134, 43);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(237, 20);
            this.txtMaBS.TabIndex = 1;
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Location = new System.Drawing.Point(29, 117);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(57, 13);
            this.ngaySinhLabel.TabIndex = 4;
            this.ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(630, 77);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(237, 20);
            this.txtDienThoai.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên bác sĩ:";
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(134, 77);
            this.txtTenBS.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(237, 20);
            this.txtTenBS.TabIndex = 2;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(630, 43);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(237, 21);
            this.cbGioiTinh.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Điện thoại:";
            // 
            // btThemBS
            // 
            this.btThemBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemBS.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemBS.Location = new System.Drawing.Point(561, 168);
            this.btThemBS.Name = "btThemBS";
            this.btThemBS.Size = new System.Drawing.Size(95, 58);
            this.btThemBS.TabIndex = 7;
            this.btThemBS.Text = "Thêm bác sĩ";
            this.btThemBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemBS.UseVisualStyleBackColor = true;
            this.btThemBS.Click += new System.EventHandler(this.btThemBS_Click);
            // 
            // btSuaBS
            // 
            this.btSuaBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaBS.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaBS.Location = new System.Drawing.Point(792, 168);
            this.btSuaBS.Name = "btSuaBS";
            this.btSuaBS.Size = new System.Drawing.Size(75, 58);
            this.btSuaBS.TabIndex = 9;
            this.btSuaBS.Text = "Sửa";
            this.btSuaBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaBS.UseVisualStyleBackColor = true;
            this.btSuaBS.Click += new System.EventHandler(this.btSuaBS_Click);
            // 
            // btXoaBS
            // 
            this.btXoaBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaBS.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaBS.Location = new System.Drawing.Point(688, 168);
            this.btXoaBS.Name = "btXoaBS";
            this.btXoaBS.Size = new System.Drawing.Size(75, 58);
            this.btXoaBS.TabIndex = 8;
            this.btXoaBS.Text = "Xóa";
            this.btXoaBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaBS.UseVisualStyleBackColor = true;
            this.btXoaBS.Click += new System.EventHandler(this.btXoaBS_Click);
            // 
            // gVBS
            // 
            this.gVBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVBS.Location = new System.Drawing.Point(32, 267);
            this.gVBS.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVBS.Name = "gVBS";
            this.gVBS.RowHeadersWidth = 62;
            this.gVBS.RowTemplate.Height = 28;
            this.gVBS.Size = new System.Drawing.Size(835, 270);
            this.gVBS.TabIndex = 10;
            this.gVBS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVBS_CellClick);
            // 
            // FQLBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.txtMaLNV);
            this.Controls.Add(this.btSuaBS);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.gVBS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXoaBS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btThemBS);
            this.Controls.Add(this.txtMaBS);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ngaySinhLabel);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenBS);
            this.Name = "FQLBacSi";
            this.Text = "QUẢN LÝ BÁC SĨ";
            this.Load += new System.EventHandler(this.FQLBacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaLNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btThemBS;
        private System.Windows.Forms.Button btSuaBS;
        private System.Windows.Forms.Button btXoaBS;
        private System.Windows.Forms.DataGridView gVBS;
    }
}